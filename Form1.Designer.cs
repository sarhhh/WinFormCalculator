namespace WinFormCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            chkOp2 = new CheckBox();
            chkOp1 = new CheckBox();
            chkOp0 = new CheckBox();
            chkA7 = new CheckBox();
            chkA6 = new CheckBox();
            chkA5 = new CheckBox();
            chkA4 = new CheckBox();
            chkA3 = new CheckBox();
            chkA2 = new CheckBox();
            chkA1 = new CheckBox();
            chkA0 = new CheckBox();
            chkB7 = new CheckBox();
            chkB6 = new CheckBox();
            chkB5 = new CheckBox();
            chkB4 = new CheckBox();
            chkB3 = new CheckBox();
            chkB2 = new CheckBox();
            chkB1 = new CheckBox();
            chkB0 = new CheckBox();
            lblRes7 = new Label();
            lblRes6 = new Label();
            lblRes5 = new Label();
            lblRes4 = new Label();
            lblRes3 = new Label();
            lblRes2 = new Label();
            lblRes1 = new Label();
            lblRes0 = new Label();
            chkAutoTrigger = new CheckBox();
            rtbLogs = new RichTextBox();
            lblCarry = new Label();
            lblOverflow = new Label();
            lblZero = new Label();
            lblSign = new Label();
            lblOpTitle = new Label();
            lblATitle = new Label();
            lblBTitle = new Label();
            lblResTitle = new Label();
            btnExec = new Button();
            SuspendLayout();
            // 
            // chkOp2
            // 
            chkOp2.Appearance = Appearance.Button;
            chkOp2.BackColor = Color.FromArgb(60, 60, 65);
            chkOp2.Cursor = Cursors.Hand;
            chkOp2.FlatAppearance.BorderSize = 0;
            chkOp2.FlatStyle = FlatStyle.Flat;
            chkOp2.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkOp2.ForeColor = Color.White;
            chkOp2.Location = new Point(122, 15);
            chkOp2.Name = "chkOp2";
            chkOp2.Size = new Size(40, 35);
            chkOp2.TabIndex = 0;
            chkOp2.Text = "0";
            chkOp2.TextAlign = ContentAlignment.MiddleCenter;
            chkOp2.UseVisualStyleBackColor = false;
            // 
            // chkOp1
            // 
            chkOp1.Appearance = Appearance.Button;
            chkOp1.BackColor = Color.FromArgb(60, 60, 65);
            chkOp1.Cursor = Cursors.Hand;
            chkOp1.FlatAppearance.BorderSize = 0;
            chkOp1.FlatStyle = FlatStyle.Flat;
            chkOp1.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkOp1.ForeColor = Color.White;
            chkOp1.Location = new Point(172, 15);
            chkOp1.Name = "chkOp1";
            chkOp1.Size = new Size(40, 35);
            chkOp1.TabIndex = 1;
            chkOp1.Text = "0";
            chkOp1.TextAlign = ContentAlignment.MiddleCenter;
            chkOp1.UseVisualStyleBackColor = false;
            // 
            // chkOp0
            // 
            chkOp0.Appearance = Appearance.Button;
            chkOp0.BackColor = Color.FromArgb(60, 60, 65);
            chkOp0.Cursor = Cursors.Hand;
            chkOp0.FlatAppearance.BorderSize = 0;
            chkOp0.FlatStyle = FlatStyle.Flat;
            chkOp0.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkOp0.ForeColor = Color.White;
            chkOp0.Location = new Point(222, 15);
            chkOp0.Name = "chkOp0";
            chkOp0.Size = new Size(40, 35);
            chkOp0.TabIndex = 2;
            chkOp0.Text = "0";
            chkOp0.TextAlign = ContentAlignment.MiddleCenter;
            chkOp0.UseVisualStyleBackColor = false;
            // 
            // chkA7
            // 
            chkA7.Appearance = Appearance.Button;
            chkA7.BackColor = Color.FromArgb(60, 60, 65);
            chkA7.Cursor = Cursors.Hand;
            chkA7.FlatAppearance.BorderSize = 0;
            chkA7.FlatStyle = FlatStyle.Flat;
            chkA7.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkA7.ForeColor = Color.White;
            chkA7.Location = new Point(122, 69);
            chkA7.Name = "chkA7";
            chkA7.Size = new Size(40, 35);
            chkA7.TabIndex = 3;
            chkA7.Text = "0";
            chkA7.TextAlign = ContentAlignment.MiddleCenter;
            chkA7.UseVisualStyleBackColor = false;
            // 
            // chkA6
            // 
            chkA6.Appearance = Appearance.Button;
            chkA6.BackColor = Color.FromArgb(60, 60, 65);
            chkA6.Cursor = Cursors.Hand;
            chkA6.FlatAppearance.BorderSize = 0;
            chkA6.FlatStyle = FlatStyle.Flat;
            chkA6.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkA6.ForeColor = Color.White;
            chkA6.Location = new Point(172, 69);
            chkA6.Name = "chkA6";
            chkA6.Size = new Size(40, 35);
            chkA6.TabIndex = 4;
            chkA6.Text = "0";
            chkA6.TextAlign = ContentAlignment.MiddleCenter;
            chkA6.UseVisualStyleBackColor = false;
            // 
            // chkA5
            // 
            chkA5.Appearance = Appearance.Button;
            chkA5.BackColor = Color.FromArgb(60, 60, 65);
            chkA5.Cursor = Cursors.Hand;
            chkA5.FlatAppearance.BorderSize = 0;
            chkA5.FlatStyle = FlatStyle.Flat;
            chkA5.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkA5.ForeColor = Color.White;
            chkA5.Location = new Point(222, 69);
            chkA5.Name = "chkA5";
            chkA5.Size = new Size(40, 35);
            chkA5.TabIndex = 5;
            chkA5.Text = "0";
            chkA5.TextAlign = ContentAlignment.MiddleCenter;
            chkA5.UseVisualStyleBackColor = false;
            // 
            // chkA4
            // 
            chkA4.Appearance = Appearance.Button;
            chkA4.BackColor = Color.FromArgb(60, 60, 65);
            chkA4.Cursor = Cursors.Hand;
            chkA4.FlatAppearance.BorderSize = 0;
            chkA4.FlatStyle = FlatStyle.Flat;
            chkA4.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkA4.ForeColor = Color.White;
            chkA4.Location = new Point(272, 69);
            chkA4.Name = "chkA4";
            chkA4.Size = new Size(40, 35);
            chkA4.TabIndex = 6;
            chkA4.Text = "0";
            chkA4.TextAlign = ContentAlignment.MiddleCenter;
            chkA4.UseVisualStyleBackColor = false;
            // 
            // chkA3
            // 
            chkA3.Appearance = Appearance.Button;
            chkA3.BackColor = Color.FromArgb(60, 60, 65);
            chkA3.Cursor = Cursors.Hand;
            chkA3.FlatAppearance.BorderSize = 0;
            chkA3.FlatStyle = FlatStyle.Flat;
            chkA3.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkA3.ForeColor = Color.White;
            chkA3.Location = new Point(322, 69);
            chkA3.Name = "chkA3";
            chkA3.Size = new Size(40, 35);
            chkA3.TabIndex = 7;
            chkA3.Text = "0";
            chkA3.TextAlign = ContentAlignment.MiddleCenter;
            chkA3.UseVisualStyleBackColor = false;
            // 
            // chkA2
            // 
            chkA2.Appearance = Appearance.Button;
            chkA2.BackColor = Color.FromArgb(60, 60, 65);
            chkA2.Cursor = Cursors.Hand;
            chkA2.FlatAppearance.BorderSize = 0;
            chkA2.FlatStyle = FlatStyle.Flat;
            chkA2.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkA2.ForeColor = Color.White;
            chkA2.Location = new Point(372, 69);
            chkA2.Name = "chkA2";
            chkA2.Size = new Size(40, 35);
            chkA2.TabIndex = 8;
            chkA2.Text = "0";
            chkA2.TextAlign = ContentAlignment.MiddleCenter;
            chkA2.UseVisualStyleBackColor = false;
            // 
            // chkA1
            // 
            chkA1.Appearance = Appearance.Button;
            chkA1.BackColor = Color.FromArgb(60, 60, 65);
            chkA1.Cursor = Cursors.Hand;
            chkA1.FlatAppearance.BorderSize = 0;
            chkA1.FlatStyle = FlatStyle.Flat;
            chkA1.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkA1.ForeColor = Color.White;
            chkA1.Location = new Point(422, 69);
            chkA1.Name = "chkA1";
            chkA1.Size = new Size(40, 35);
            chkA1.TabIndex = 9;
            chkA1.Text = "0";
            chkA1.TextAlign = ContentAlignment.MiddleCenter;
            chkA1.UseVisualStyleBackColor = false;
            // 
            // chkA0
            // 
            chkA0.Appearance = Appearance.Button;
            chkA0.BackColor = Color.FromArgb(60, 60, 65);
            chkA0.Cursor = Cursors.Hand;
            chkA0.FlatAppearance.BorderSize = 0;
            chkA0.FlatStyle = FlatStyle.Flat;
            chkA0.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkA0.ForeColor = Color.White;
            chkA0.Location = new Point(472, 69);
            chkA0.Name = "chkA0";
            chkA0.Size = new Size(40, 35);
            chkA0.TabIndex = 10;
            chkA0.Text = "0";
            chkA0.TextAlign = ContentAlignment.MiddleCenter;
            chkA0.UseVisualStyleBackColor = false;
            // 
            // chkB7
            // 
            chkB7.Appearance = Appearance.Button;
            chkB7.BackColor = Color.FromArgb(60, 60, 65);
            chkB7.Cursor = Cursors.Hand;
            chkB7.FlatAppearance.BorderSize = 0;
            chkB7.FlatStyle = FlatStyle.Flat;
            chkB7.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkB7.ForeColor = Color.White;
            chkB7.Location = new Point(122, 128);
            chkB7.Name = "chkB7";
            chkB7.Size = new Size(40, 35);
            chkB7.TabIndex = 11;
            chkB7.Text = "0";
            chkB7.TextAlign = ContentAlignment.MiddleCenter;
            chkB7.UseVisualStyleBackColor = false;
            // 
            // chkB6
            // 
            chkB6.Appearance = Appearance.Button;
            chkB6.BackColor = Color.FromArgb(60, 60, 65);
            chkB6.Cursor = Cursors.Hand;
            chkB6.FlatAppearance.BorderSize = 0;
            chkB6.FlatStyle = FlatStyle.Flat;
            chkB6.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkB6.ForeColor = Color.White;
            chkB6.Location = new Point(172, 128);
            chkB6.Name = "chkB6";
            chkB6.Size = new Size(40, 35);
            chkB6.TabIndex = 12;
            chkB6.Text = "0";
            chkB6.TextAlign = ContentAlignment.MiddleCenter;
            chkB6.UseVisualStyleBackColor = false;
            // 
            // chkB5
            // 
            chkB5.Appearance = Appearance.Button;
            chkB5.BackColor = Color.FromArgb(60, 60, 65);
            chkB5.Cursor = Cursors.Hand;
            chkB5.FlatAppearance.BorderSize = 0;
            chkB5.FlatStyle = FlatStyle.Flat;
            chkB5.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkB5.ForeColor = Color.White;
            chkB5.Location = new Point(222, 128);
            chkB5.Name = "chkB5";
            chkB5.Size = new Size(40, 35);
            chkB5.TabIndex = 13;
            chkB5.Text = "0";
            chkB5.TextAlign = ContentAlignment.MiddleCenter;
            chkB5.UseVisualStyleBackColor = false;
            // 
            // chkB4
            // 
            chkB4.Appearance = Appearance.Button;
            chkB4.BackColor = Color.FromArgb(60, 60, 65);
            chkB4.Cursor = Cursors.Hand;
            chkB4.FlatAppearance.BorderSize = 0;
            chkB4.FlatStyle = FlatStyle.Flat;
            chkB4.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkB4.ForeColor = Color.White;
            chkB4.Location = new Point(272, 128);
            chkB4.Name = "chkB4";
            chkB4.Size = new Size(40, 35);
            chkB4.TabIndex = 14;
            chkB4.Text = "0";
            chkB4.TextAlign = ContentAlignment.MiddleCenter;
            chkB4.UseVisualStyleBackColor = false;
            // 
            // chkB3
            // 
            chkB3.Appearance = Appearance.Button;
            chkB3.BackColor = Color.FromArgb(60, 60, 65);
            chkB3.Cursor = Cursors.Hand;
            chkB3.FlatAppearance.BorderSize = 0;
            chkB3.FlatStyle = FlatStyle.Flat;
            chkB3.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkB3.ForeColor = Color.White;
            chkB3.Location = new Point(322, 128);
            chkB3.Name = "chkB3";
            chkB3.Size = new Size(40, 35);
            chkB3.TabIndex = 15;
            chkB3.Text = "0";
            chkB3.TextAlign = ContentAlignment.MiddleCenter;
            chkB3.UseVisualStyleBackColor = false;
            // 
            // chkB2
            // 
            chkB2.Appearance = Appearance.Button;
            chkB2.BackColor = Color.FromArgb(60, 60, 65);
            chkB2.Cursor = Cursors.Hand;
            chkB2.FlatAppearance.BorderSize = 0;
            chkB2.FlatStyle = FlatStyle.Flat;
            chkB2.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkB2.ForeColor = Color.White;
            chkB2.Location = new Point(372, 128);
            chkB2.Name = "chkB2";
            chkB2.Size = new Size(40, 35);
            chkB2.TabIndex = 16;
            chkB2.Text = "0";
            chkB2.TextAlign = ContentAlignment.MiddleCenter;
            chkB2.UseVisualStyleBackColor = false;
            // 
            // chkB1
            // 
            chkB1.Appearance = Appearance.Button;
            chkB1.BackColor = Color.FromArgb(60, 60, 65);
            chkB1.Cursor = Cursors.Hand;
            chkB1.FlatAppearance.BorderSize = 0;
            chkB1.FlatStyle = FlatStyle.Flat;
            chkB1.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkB1.ForeColor = Color.White;
            chkB1.Location = new Point(422, 128);
            chkB1.Name = "chkB1";
            chkB1.Size = new Size(40, 35);
            chkB1.TabIndex = 17;
            chkB1.Text = "0";
            chkB1.TextAlign = ContentAlignment.MiddleCenter;
            chkB1.UseVisualStyleBackColor = false;
            // 
            // chkB0
            // 
            chkB0.Appearance = Appearance.Button;
            chkB0.BackColor = Color.FromArgb(60, 60, 65);
            chkB0.Cursor = Cursors.Hand;
            chkB0.FlatAppearance.BorderSize = 0;
            chkB0.FlatStyle = FlatStyle.Flat;
            chkB0.Font = new Font("Consolas", 14F, FontStyle.Bold);
            chkB0.ForeColor = Color.White;
            chkB0.Location = new Point(472, 128);
            chkB0.Name = "chkB0";
            chkB0.Size = new Size(40, 35);
            chkB0.TabIndex = 18;
            chkB0.Text = "0";
            chkB0.TextAlign = ContentAlignment.MiddleCenter;
            chkB0.UseVisualStyleBackColor = false;
            // 
            // lblRes7
            // 
            lblRes7.BackColor = Color.FromArgb(60, 20, 20);
            lblRes7.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblRes7.ForeColor = Color.White;
            lblRes7.Location = new Point(122, 188);
            lblRes7.Name = "lblRes7";
            lblRes7.Size = new Size(40, 35);
            lblRes7.TabIndex = 19;
            lblRes7.Text = "0";
            lblRes7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRes6
            // 
            lblRes6.BackColor = Color.FromArgb(60, 20, 20);
            lblRes6.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblRes6.ForeColor = Color.White;
            lblRes6.Location = new Point(172, 188);
            lblRes6.Name = "lblRes6";
            lblRes6.Size = new Size(40, 35);
            lblRes6.TabIndex = 20;
            lblRes6.Text = "0";
            lblRes6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRes5
            // 
            lblRes5.BackColor = Color.FromArgb(60, 20, 20);
            lblRes5.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblRes5.ForeColor = Color.White;
            lblRes5.Location = new Point(222, 188);
            lblRes5.Name = "lblRes5";
            lblRes5.Size = new Size(40, 35);
            lblRes5.TabIndex = 21;
            lblRes5.Text = "0";
            lblRes5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRes4
            // 
            lblRes4.BackColor = Color.FromArgb(60, 20, 20);
            lblRes4.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblRes4.ForeColor = Color.White;
            lblRes4.Location = new Point(272, 188);
            lblRes4.Name = "lblRes4";
            lblRes4.Size = new Size(40, 35);
            lblRes4.TabIndex = 22;
            lblRes4.Text = "0";
            lblRes4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRes3
            // 
            lblRes3.BackColor = Color.FromArgb(60, 20, 20);
            lblRes3.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblRes3.ForeColor = Color.White;
            lblRes3.Location = new Point(322, 188);
            lblRes3.Name = "lblRes3";
            lblRes3.Size = new Size(40, 35);
            lblRes3.TabIndex = 23;
            lblRes3.Text = "0";
            lblRes3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRes2
            // 
            lblRes2.BackColor = Color.FromArgb(60, 20, 20);
            lblRes2.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblRes2.ForeColor = Color.White;
            lblRes2.Location = new Point(372, 188);
            lblRes2.Name = "lblRes2";
            lblRes2.Size = new Size(40, 35);
            lblRes2.TabIndex = 24;
            lblRes2.Text = "0";
            lblRes2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRes1
            // 
            lblRes1.BackColor = Color.FromArgb(60, 20, 20);
            lblRes1.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblRes1.ForeColor = Color.White;
            lblRes1.Location = new Point(422, 188);
            lblRes1.Name = "lblRes1";
            lblRes1.Size = new Size(40, 35);
            lblRes1.TabIndex = 25;
            lblRes1.Text = "0";
            lblRes1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRes0
            // 
            lblRes0.BackColor = Color.FromArgb(60, 20, 20);
            lblRes0.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblRes0.ForeColor = Color.White;
            lblRes0.Location = new Point(472, 188);
            lblRes0.Name = "lblRes0";
            lblRes0.Size = new Size(40, 35);
            lblRes0.TabIndex = 26;
            lblRes0.Text = "0";
            lblRes0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkAutoTrigger
            // 
            chkAutoTrigger.Font = new Font("Segoe UI Semibold", 10F);
            chkAutoTrigger.Location = new Point(441, 255);
            chkAutoTrigger.Name = "chkAutoTrigger";
            chkAutoTrigger.Size = new Size(120, 30);
            chkAutoTrigger.TabIndex = 31;
            chkAutoTrigger.Text = "⚙ Auto Trigger";
            // 
            // rtbLogs
            // 
            rtbLogs.BackColor = Color.FromArgb(15, 15, 15);
            rtbLogs.BorderStyle = BorderStyle.None;
            rtbLogs.Font = new Font("Consolas", 10F);
            rtbLogs.ForeColor = Color.LimeGreen;
            rtbLogs.Location = new Point(10, 298);
            rtbLogs.Name = "rtbLogs";
            rtbLogs.ReadOnly = true;
            rtbLogs.Size = new Size(740, 495);
            rtbLogs.TabIndex = 33;
            rtbLogs.Text = "";
            // 
            // lblCarry
            // 
            lblCarry.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblCarry.Location = new Point(46, 259);
            lblCarry.Name = "lblCarry";
            lblCarry.Size = new Size(80, 25);
            lblCarry.TabIndex = 27;
            lblCarry.Text = "Carry (C)";
            lblCarry.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOverflow
            // 
            lblOverflow.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblOverflow.Location = new Point(136, 259);
            lblOverflow.Name = "lblOverflow";
            lblOverflow.Size = new Size(100, 25);
            lblOverflow.TabIndex = 28;
            lblOverflow.Text = "Overflow (V)";
            lblOverflow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblZero
            // 
            lblZero.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblZero.Location = new Point(246, 259);
            lblZero.Name = "lblZero";
            lblZero.Size = new Size(80, 25);
            lblZero.TabIndex = 29;
            lblZero.Text = "Zero (Z)";
            lblZero.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSign
            // 
            lblSign.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblSign.Location = new Point(336, 259);
            lblSign.Name = "lblSign";
            lblSign.Size = new Size(80, 25);
            lblSign.TabIndex = 30;
            lblSign.Text = "Sign (S)";
            lblSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOpTitle
            // 
            lblOpTitle.AutoSize = true;
            lblOpTitle.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lblOpTitle.ForeColor = Color.DarkOrange;
            lblOpTitle.Location = new Point(10, 20);
            lblOpTitle.Name = "lblOpTitle";
            lblOpTitle.Size = new Size(72, 19);
            lblOpTitle.TabIndex = 34;
            lblOpTitle.Text = "OP CMD:";
            // 
            // lblATitle
            // 
            lblATitle.AutoSize = true;
            lblATitle.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lblATitle.ForeColor = Color.LightSkyBlue;
            lblATitle.Location = new Point(10, 74);
            lblATitle.Name = "lblATitle";
            lblATitle.Size = new Size(72, 19);
            lblATitle.TabIndex = 35;
            lblATitle.Text = "DATA A:";
            // 
            // lblBTitle
            // 
            lblBTitle.AutoSize = true;
            lblBTitle.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lblBTitle.ForeColor = Color.LightSkyBlue;
            lblBTitle.Location = new Point(10, 133);
            lblBTitle.Name = "lblBTitle";
            lblBTitle.Size = new Size(72, 19);
            lblBTitle.TabIndex = 36;
            lblBTitle.Text = "DATA B:";
            // 
            // lblResTitle
            // 
            lblResTitle.AutoSize = true;
            lblResTitle.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lblResTitle.ForeColor = Color.Gold;
            lblResTitle.Location = new Point(10, 188);
            lblResTitle.Name = "lblResTitle";
            lblResTitle.Size = new Size(72, 19);
            lblResTitle.TabIndex = 37;
            lblResTitle.Text = "OUTPUT:";
            // 
            // btnExec
            // 
            btnExec.BackColor = Color.DodgerBlue;
            btnExec.Cursor = Cursors.Hand;
            btnExec.FlatStyle = FlatStyle.Flat;
            btnExec.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExec.ForeColor = Color.White;
            btnExec.Location = new Point(577, 252);
            btnExec.Name = "btnExec";
            btnExec.Size = new Size(130, 35);
            btnExec.TabIndex = 32;
            btnExec.Text = "⚡ Send CLK Pulse";
            btnExec.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(30, 30, 32);
            ClientSize = new Size(761, 805);
            Controls.Add(chkOp2);
            Controls.Add(chkOp1);
            Controls.Add(chkOp0);
            Controls.Add(chkA7);
            Controls.Add(chkA6);
            Controls.Add(chkA5);
            Controls.Add(chkA4);
            Controls.Add(chkA3);
            Controls.Add(chkA2);
            Controls.Add(chkA1);
            Controls.Add(chkA0);
            Controls.Add(chkB7);
            Controls.Add(chkB6);
            Controls.Add(chkB5);
            Controls.Add(chkB4);
            Controls.Add(chkB3);
            Controls.Add(chkB2);
            Controls.Add(chkB1);
            Controls.Add(chkB0);
            Controls.Add(lblRes7);
            Controls.Add(lblRes6);
            Controls.Add(lblRes5);
            Controls.Add(lblRes4);
            Controls.Add(lblRes3);
            Controls.Add(lblRes2);
            Controls.Add(lblRes1);
            Controls.Add(lblRes0);
            Controls.Add(lblCarry);
            Controls.Add(lblOverflow);
            Controls.Add(lblZero);
            Controls.Add(lblSign);
            Controls.Add(chkAutoTrigger);
            Controls.Add(btnExec);
            Controls.Add(rtbLogs);
            Controls.Add(lblOpTitle);
            Controls.Add(lblATitle);
            Controls.Add(lblBTitle);
            Controls.Add(lblResTitle);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.WhiteSmoke;
            Name = "Form1";
            Text = "8位运算器 (ALU) 硬件模拟仿真";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.CheckBox chkOp2;
        private System.Windows.Forms.CheckBox chkOp1;
        private System.Windows.Forms.CheckBox chkOp0;

        private System.Windows.Forms.CheckBox chkA7;
        private System.Windows.Forms.CheckBox chkA6;
        private System.Windows.Forms.CheckBox chkA5;
        private System.Windows.Forms.CheckBox chkA4;
        private System.Windows.Forms.CheckBox chkA3;
        private System.Windows.Forms.CheckBox chkA2;
        private System.Windows.Forms.CheckBox chkA1;
        private System.Windows.Forms.CheckBox chkA0;

        private System.Windows.Forms.CheckBox chkB7;
        private System.Windows.Forms.CheckBox chkB6;
        private System.Windows.Forms.CheckBox chkB5;
        private System.Windows.Forms.CheckBox chkB4;
        private System.Windows.Forms.CheckBox chkB3;
        private System.Windows.Forms.CheckBox chkB2;
        private System.Windows.Forms.CheckBox chkB1;
        private System.Windows.Forms.CheckBox chkB0;

        private System.Windows.Forms.Label lblRes7;
        private System.Windows.Forms.Label lblRes6;
        private System.Windows.Forms.Label lblRes5;
        private System.Windows.Forms.Label lblRes4;
        private System.Windows.Forms.Label lblRes3;
        private System.Windows.Forms.Label lblRes2;
        private System.Windows.Forms.Label lblRes1;
        private System.Windows.Forms.Label lblRes0;

        private System.Windows.Forms.CheckBox chkAutoTrigger;
        private System.Windows.Forms.RichTextBox rtbLogs;

        private System.Windows.Forms.Label lblCarry;
        private System.Windows.Forms.Label lblOverflow;
        private System.Windows.Forms.Label lblZero;
        private System.Windows.Forms.Label lblSign;

        private System.Windows.Forms.Label lblOpTitle;
        private System.Windows.Forms.Label lblATitle;
        private System.Windows.Forms.Label lblBTitle;
        private System.Windows.Forms.Label lblResTitle;
        private System.Windows.Forms.Button btnExec;
    }
}
