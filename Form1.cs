using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormCalculator
{
    public partial class Form1 : Form
    {
        private CheckBox[] chkA;
        private CheckBox[] chkB;
        private CheckBox[] chkOp;
        private Label[] lblRes;

        public Form1()
        {
            InitializeComponent();
            
            // 绑定设计师控件到数组以复用逻辑
            chkOp = new CheckBox[] { chkOp2, chkOp1, chkOp0 };
            chkA = new CheckBox[] { chkA7, chkA6, chkA5, chkA4, chkA3, chkA2, chkA1, chkA0 };
            chkB = new CheckBox[] { chkB7, chkB6, chkB5, chkB4, chkB3, chkB2, chkB1, chkB0 };
            lblRes = new Label[] { lblRes7, lblRes6, lblRes5, lblRes4, lblRes3, lblRes2, lblRes1, lblRes0 };

            this.SuspendLayout();

            // 注意：所有的全局与背景配置、控件位置和样式已被迁移至 Form1.Designer.cs
            // 使得设计器可以直接进行可视化编辑与拖拽。

            // 动态添加按钮下方的文本标识
            Font idxFont = new Font("Consolas", 8, FontStyle.Regular);
            Color idxColor = Color.Gray;

            for (int i = 0; i < 3; i++)
            {
                Label l = new Label { Text = $"OP{2-i}", Font = idxFont, ForeColor = idxColor, AutoSize = true };
                l.Location = new Point(chkOp[i].Location.X + 8, chkOp[i].Location.Y + chkOp[i].Height + 2);
                this.Controls.Add(l);
            }
            for (int i = 0; i < 8; i++)
            {
                Label l = new Label { Text = $"A{7-i}", Font = idxFont, ForeColor = idxColor, AutoSize = true };
                l.Location = new Point(chkA[i].Location.X + 12, chkA[i].Location.Y + chkA[i].Height + 2);
                this.Controls.Add(l);
            }
            for (int i = 0; i < 8; i++)
            {
                Label l = new Label { Text = $"B{7-i}", Font = idxFont, ForeColor = idxColor, AutoSize = true };
                l.Location = new Point(chkB[i].Location.X + 12, chkB[i].Location.Y + chkB[i].Height + 2);
                this.Controls.Add(l);
            }
            for (int i = 0; i < 8; i++)
            {
                Label l = new Label { Text = $"R{7-i}", Font = idxFont, ForeColor = idxColor, AutoSize = true };
                l.Location = new Point(lblRes[i].Location.X + 12, lblRes[i].Location.Y + lblRes[i].Height + 2);
                this.Controls.Add(l);
            }

            // 右上角添加 OP CMD 指示说明图例
            Label lblOpHint = new Label();
            lblOpHint.Text = "【OP CMD 说明】\n000: A+B\n001: A-B\n010: A AND B\n011: A OR B\n100: NOT A\n101: A XOR B\n110: A+1\n111: A-1";
            lblOpHint.Location = new Point(580, 20);
            lblOpHint.AutoSize = true;
            lblOpHint.Font = new Font("Consolas", 10, FontStyle.Regular);
            lblOpHint.ForeColor = Color.MediumSeaGreen;
            this.Controls.Add(lblOpHint);

            // 绑定事件
            for (int i = 0; i < 3; i++) chkOp[i].CheckedChanged += Switch_CheckedChanged;
            for (int i = 0; i < 8; i++) chkA[i].CheckedChanged += Switch_CheckedChanged;
            for (int i = 0; i < 8; i++) chkB[i].CheckedChanged += Switch_CheckedChanged;
            btnExec.Click += BtnExecute_Click;

            this.ResumeLayout(false);

            // 首次初始计算
            ExecuteALU(true);
        }

        private void Switch_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox chk && chk != chkAutoTrigger)
            {
                chk.BackColor = chk.Checked ? Color.MediumSeaGreen : Color.FromArgb(60, 60, 65);
                chk.ForeColor = Color.White;
                chk.Text = chk.Checked ? "1" : "0";
            }
            if (chkAutoTrigger != null && chkAutoTrigger.Checked)
            {
                ExecuteALU();
            }
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            ExecuteALU();
        }

        private void ExecuteALU(bool isInit = false)
        {
            if (rtbLogs == null) return;
            rtbLogs.Clear();

            if (isInit)
            {
                rtbLogs.AppendText($"[{DateTime.Now:HH:mm:ss}] 系统上电初始化...\n");
                rtbLogs.AppendText("加载 8 位 ALU 运算模块...\n");
                rtbLogs.AppendText("初始化数据总线 A, B 与 控制总线 OP...\n");
                rtbLogs.AppendText("等待首个硬件时钟脉冲信号执行...\n");
            }
            else
            {
                rtbLogs.AppendText($"[{DateTime.Now:HH:mm:ss}] 收到硬件时钟脉冲，开始采样数据总线信号...\n");
            }

            int[] OP = new int[3];
            for (int i = 0; i < 3; i++) OP[i] = chkOp[i].Checked ? 1 : 0;

            int[] A = new int[8];
            for (int i = 0; i < 8; i++) A[i] = chkA[i].Checked ? 1 : 0;

            int[] B = new int[8];
            for (int i = 0; i < 8; i++) B[i] = chkB[i].Checked ? 1 : 0;

            var result = HardwareALU.Execute(A, B, OP);

            if (!isInit)
            {
                foreach (var log in result.Logs)
                {
                    rtbLogs.AppendText(log + "\n");
                }
            }

            for (int i = 0; i < 8; i++)
            {
                lblRes[i].BackColor = result.Result[i] == 1 ? Color.Red : Color.FromArgb(60, 20, 20);
                lblRes[i].Text = result.Result[i].ToString();
                lblRes[i].ForeColor = result.Result[i] == 1 ? Color.White : Color.Gray;
            }

            lblCarry.BackColor = result.CarryOut == 1 ? Color.Crimson : Color.FromArgb(60, 20, 20);
            lblOverflow.BackColor = result.Overflow == 1 ? Color.Crimson : Color.FromArgb(60, 20, 20);
            lblZero.BackColor = result.Zero == 1 ? Color.Crimson : Color.FromArgb(60, 20, 20);
            lblSign.BackColor = result.Sign == 1 ? Color.Crimson : Color.FromArgb(60, 20, 20);

            if (!isInit)
            {
                rtbLogs.AppendText("状态寄存器刷新完毕。\n");
            }
            rtbLogs.ScrollToCaret();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 已在构造函数中初始化UI
        }
    }
}
