# WinFormCalculator — 8 位 ALU 硬件仿真
简要说明  
一个基于 .NET 10 的 WinForms 程序，用于可视化并模拟 8 位算术逻辑单元（ALU）。
项目以硬件逻辑门和 4 位超前进位加法器（CLA）为核心，实现了常见算术与逻辑操作并输出硬件标志位与运行日志

主要特性
- 支持 8 种操作（由 3 位控制信号 `OP` 指定）：
  - `000`: A + B
  - `001`: A - B（A + ~B + 1）
  - `010`: A AND B
  - `011`: A OR B
  - `100`: NOT A
  - `101`: A XOR B
  - `110`: A + 1
  - `111`: A - 1
- 纯硬件仿真层 `HardwareALU`（位于 `ALU.cs`），无 UI 依赖，便于单元测试与复用。
- 4 位 CLA 模块串联实现多位加法，带进位/溢出/零/符号标志计算。
- 可视化 UI（`Form1.cs`）：二进制开关控制 A/B/OP，结果与标志以标签高亮显示，并提供运行日志（RichTextBox）。

快速开始（在 Windows 上）
前提
- 安装 .NET 10 SDK 或 使用 Visual Studio Community 2026（推荐）。

使用 Visual Studio
1. 在 Visual Studio 中打开解决方案（`C:\Users\Admin\source\repos\WinFormCalculator`）。  
2. 设为启动项目并运行（按 __F5__ 或 使用 __Debug > Start Debugging__）。

使用命令行
1. 打开项目目录：
   - `cd C:\Users\Admin\source\repos\WinFormCalculator`
2. 构建并运行：
   - `dotnet build`
   - `dotnet run --project .`

界面与用法
- 输入：通过界面上的 `CheckBox` 控制 A7..A0、B7..B0 与 OP2..OP0（每个复选框表示一位 0/1）。  
- 执行：点击 `Execute` 或勾选自动触发以在改动时实时计算。  
- 输出：R7..R0 显示结果位；右侧显示标志位 CF、OF、ZF、SF；下方日志展示 CLA 计算过程与状态信息。

代码结构（关键文件）
- `ALU.cs` — 硬件仿真核心（`HardwareALU`, `ALUResult`, `CLA_Result`）。  
- `Form1.cs` / `Form1.Designer.cs` — WinForms 前端与界面布局。  
- `Program.cs` — 应用入口。  


贡献与反馈
欢迎通过 issues 或 pull requests 参与改进。

(应付作业写的，勿喷)
