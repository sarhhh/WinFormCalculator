using System;
using System.Collections.Generic;

namespace WinFormCalculator
{
    // 用于存储单次计算结果和硬件标志位
    public class ALUResult
    {
        public int[] Result { get; set; } = Array.Empty<int>();
        public int CarryOut { get; set; }  // 进位标志 (CF)
        public int Overflow { get; set; }  // 溢出标志 (OF)
        public int Zero { get; set; }      // 零标志 (ZF)
        public int Sign { get; set; }      // 符号标志 (SF)
        public List<string> Logs { get; set; } = new List<string>();
    }

    public class CLA_Result
    {
        public int[] S { get; set; } = new int[4];
        public int P_group { get; set; }
        public int G_group { get; set; }
        public int Cout { get; set; }
    }

    /// <summary>
    /// 纯硬件逻辑模拟层，无任何UI依赖
    /// </summary>
    public static class HardwareALU
    {
        // --- 基础逻辑门模拟 ---
        public static int AND(int a, int b) => a & b;
        public static int OR(int a, int b) => a | b;
        public static int XOR(int a, int b) => a ^ b;
        public static int NOT(int a) => a == 0 ? 1 : 0;

        // --- 4位超前进位加法器核心逻辑 ---
        private static CLA_Result CLA4_Block(int[] A, int[] B, int Cin)
        {
            int[] P = new int[4];
            int[] G = new int[4];
            int[] C = new int[5];
            int[] S = new int[4];

            // 计算生成因子和传递因子
            for (int i = 0; i < 4; ++i)
            {
                P[i] = OR(A[i], B[i]);
                G[i] = AND(A[i], B[i]);
            }

            // 超前进位逻辑
            C[4] = Cin;
            C[3] = OR(G[3], AND(P[3], C[4]));
            C[2] = OR(G[2], OR(AND(P[2], G[3]), AND(P[2], AND(P[3], C[4]))));
            C[1] = OR(G[1], OR(AND(P[1], G[2]), OR(AND(P[1], AND(P[2], G[3])), AND(P[1], AND(P[2], AND(P[3], C[4]))))));
            C[0] = OR(G[0], OR(AND(P[0], G[1]), OR(AND(P[0], AND(P[1], G[2])), OR(AND(P[0], AND(P[1], AND(P[2], G[3]))), AND(P[0], AND(P[1], AND(P[2], AND(P[3], C[4]))))))));

            // 本位和
            for (int i = 0; i < 4; ++i)
            {
                int not_G = NOT(G[i]);
                int prop = AND(not_G, P[i]); 
                S[i] = XOR(prop, C[i + 1]);
            }

            int P_group = AND(P[0], AND(P[1], AND(P[2], P[3])));
            int G_group = OR(G[0], OR(AND(P[0], G[1]), OR(AND(P[0], AND(P[1], G[2])), AND(P[0], AND(P[1], AND(P[2], G[3]))))));

            return new CLA_Result { S = S, P_group = P_group, G_group = G_group, Cout = C[0] };
        }

        // --- 串行连接多个4位CLA模块 ---
        private static int[] Simple_CLA_Main(int[] A, int[] B, int C_in, out int C_out)
        {
            int n = A.Length;
            int blocks = n / 4;
            int[] final_S = new int[n];
            int current_C = C_in;

            for (int i = blocks - 1; i >= 0; --i)
            {
                int[] subA = new int[4];
                int[] subB = new int[4];
                Array.Copy(A, i * 4, subA, 0, 4);
                Array.Copy(B, i * 4, subB, 0, 4);

                CLA_Result res = CLA4_Block(subA, subB, current_C);

                for (int j = 0; j < 4; ++j)
                {
                    final_S[i * 4 + j] = res.S[j];
                }
                current_C = res.Cout;
            }
            
            C_out = current_C;
            return final_S;
        }

        /// <summary>
        /// 8 功能运算器核心调度入口
        /// </summary>
        /// <param name="A">操作数A（数组，大端序）</param>
        /// <param name="B">操作数B（数组，大端序）</param>
        /// <param name="OP">3位控制信号：长度为3的数组</param>
        public static ALUResult Execute(int[] A, int[] B, int[] OP)
        {
            int n = A.Length; // 确保传入的是 8 的倍数（如 8位、16位）
            ALUResult result = new ALUResult { Result = new int[n] };
            result.Logs.Add($"[系统控制] 运算器获取操作指令，位宽={n}位");
            result.Logs.Add($"[获取数据] A={string.Join("", A)} | B={string.Join("", B)} | OP={string.Join("", OP)}");

            // 解码3位控制指令 (0 ~ 7)
            int opCode = (OP[0] << 2) | (OP[1] << 1) | OP[2]; 
            int[] workB = new int[n];
            int Cin = 0;
            
            bool isLogicOp = false;

            switch (opCode)
            {
                case 0: // 000: A + B
                    Array.Copy(B, workB, n);
                    Cin = 0;
                    result.Logs.Add("-> 解析操作: 算术加法 (A + B)");
                    break;
                case 1: // 001: A - B (即 A + ~B + 1)
                    for(int i=0; i<n; i++) workB[i] = NOT(B[i]);
                    Cin = 1;
                    result.Logs.Add("-> 解析操作: 算术减法 (A - B)");
                    break;
                case 2: // 010: A AND B
                    for(int i=0; i<n; i++) result.Result[i] = AND(A[i], B[i]);
                    isLogicOp = true;
                    result.Logs.Add("-> 解析操作: 逻辑与 (A & B)");
                    break;
                case 3: // 011: A OR B
                    for(int i=0; i<n; i++) result.Result[i] = OR(A[i], B[i]);
                    isLogicOp = true;
                    result.Logs.Add("-> 解析操作: 逻辑或 (A | B)");
                    break;
                case 4: // 100: NOT A
                    for(int i=0; i<n; i++) result.Result[i] = NOT(A[i]);
                    isLogicOp = true;
                    result.Logs.Add("-> 解析操作: 逻辑非 (~A)");
                    break;
                case 5: // 101: A XOR B
                    for(int i=0; i<n; i++) result.Result[i] = XOR(A[i], B[i]);
                    isLogicOp = true;
                    result.Logs.Add("-> 解析操作: 逻辑异或 (A ^ B)");
                    break;
                case 6: // 110: A + 1
                    for(int i=0; i<n; i++) workB[i] = 0;
                    Cin = 1;
                    result.Logs.Add("-> 解析操作: 自增 (A + 1)");
                    break;
                case 7: // 111: A - 1 (原码全1即为补码-1，A + (-1) + 0)
                    for(int i=0; i<n; i++) workB[i] = 1; 
                    Cin = 0;
                    result.Logs.Add("-> 解析操作: 自减 (A - 1)");
                    break;
            }

            // 如果不是逻辑运算，则走硬件加法器数据通路
            if (!isLogicOp)
            {
                result.Logs.Add($"[ALU运算] 数据送入底层CLA加法器计算:");
                result.Logs.Add($"   -> 实际输入A = {string.Join("", A)}");
                result.Logs.Add($"   -> 实际输入B'= {string.Join("", workB)}, Cin = {Cin}");

                int cout;
                result.Result = Simple_CLA_Main(A, workB, Cin, out cout);
                result.CarryOut = cout;

                // 标志位逻辑：硬件溢出判断 S_MSB ^ A_MSB ^ B_MSB
                int msb = 0;
                int C_in_MSB = XOR(result.Result[msb], XOR(A[msb], workB[msb]));

                int P_MSB = OR(A[msb], workB[msb]);
                int G_MSB = AND(A[msb], workB[msb]);
                int C_out_MSB = OR(G_MSB, AND(P_MSB, C_in_MSB));

                // 溢出标志 OF
                result.Overflow = C_in_MSB != C_out_MSB ? 1 : 0;
                if (result.Overflow == 1) result.Logs.Add("[Hardware OF 警告] 检测到硬件溢出 (Overflow)！");
            }
            else
            {
                result.Logs.Add($"[ALU运算] 执行逻辑位运算。");
            }

            // 零标志 ZF
            bool zero = true;
            foreach(int bit in result.Result) { if(bit == 1) { zero = false; break; } }
            result.Zero = zero ? 1 : 0;

            // 符号标志 SF (最高位)
            result.Sign = result.Result[0];

            result.Logs.Add($"[输出总线] 结果 R = {string.Join("", result.Result)}");
            result.Logs.Add($"[状态寄存器] CF={result.CarryOut}, OF={result.Overflow}, ZF={result.Zero}, SF={result.Sign}");
            result.Logs.Add("-> 运算完成，标志位抓取完毕。");
            return result;
        }
    }
}
