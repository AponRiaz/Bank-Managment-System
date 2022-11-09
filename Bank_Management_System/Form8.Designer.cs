namespace Bank_Management_System
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BalanceLb1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBalanceBtn = new System.Windows.Forms.Button();
            this.CheckBALTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WdBtn = new System.Windows.Forms.Label();
            this.WdAmtTb = new System.Windows.Forms.TextBox();
            this.WdAccountTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DepAmtTb = new System.Windows.Forms.TextBox();
            this.DepAccountTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DepositBtn = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.BalanceLb1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CheckBalanceBtn);
            this.panel1.Controls.Add(this.CheckBALTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(51, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 119);
            this.panel1.TabIndex = 0;
            // 
            // BalanceLb1
            // 
            this.BalanceLb1.AutoSize = true;
            this.BalanceLb1.Location = new System.Drawing.Point(661, 37);
            this.BalanceLb1.Name = "BalanceLb1";
            this.BalanceLb1.Size = new System.Drawing.Size(90, 20);
            this.BalanceLb1.TabIndex = 5;
            this.BalanceLb1.Text = "YourBalance";
            this.BalanceLb1.Click += new System.EventHandler(this.BalanceLb1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(661, 84);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(491, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 3;
            // 
            // CheckBalanceBtn
            // 
            this.CheckBalanceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CheckBalanceBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBalanceBtn.Location = new System.Drawing.Point(368, 56);
            this.CheckBalanceBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBalanceBtn.Name = "CheckBalanceBtn";
            this.CheckBalanceBtn.Size = new System.Drawing.Size(86, 31);
            this.CheckBalanceBtn.TabIndex = 2;
            this.CheckBalanceBtn.Text = "Check";
            this.CheckBalanceBtn.UseVisualStyleBackColor = false;
            this.CheckBalanceBtn.Click += new System.EventHandler(this.CheckBalance_Click);
            // 
            // CheckBALTb
            // 
            this.CheckBALTb.Location = new System.Drawing.Point(162, 64);
            this.CheckBALTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBALTb.Name = "CheckBALTb";
            this.CheckBALTb.Size = new System.Drawing.Size(175, 27);
            this.CheckBALTb.TabIndex = 1;
            this.CheckBALTb.TextChanged += new System.EventHandler(this.CheckBALTb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(162, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Check Your Balance ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transactions";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.WdBtn);
            this.panel2.Controls.Add(this.WdAmtTb);
            this.panel2.Controls.Add(this.WdAccountTb);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(51, 384);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 174);
            this.panel2.TabIndex = 2;
            // 
            // WdBtn
            // 
            this.WdBtn.AutoSize = true;
            this.WdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.WdBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WdBtn.Location = new System.Drawing.Point(491, 97);
            this.WdBtn.Name = "WdBtn";
            this.WdBtn.Size = new System.Drawing.Size(105, 28);
            this.WdBtn.TabIndex = 5;
            this.WdBtn.Text = "Withdraw";
            this.WdBtn.Click += new System.EventHandler(this.label7_Click);
            // 
            // WdAmtTb
            // 
            this.WdAmtTb.Location = new System.Drawing.Point(162, 135);
            this.WdAmtTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WdAmtTb.Name = "WdAmtTb";
            this.WdAmtTb.Size = new System.Drawing.Size(251, 27);
            this.WdAmtTb.TabIndex = 4;
            this.WdAmtTb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // WdAccountTb
            // 
            this.WdAccountTb.Location = new System.Drawing.Point(162, 61);
            this.WdAccountTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WdAccountTb.Name = "WdAccountTb";
            this.WdAccountTb.Size = new System.Drawing.Size(251, 27);
            this.WdAccountTb.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(49, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Amount";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Account Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(175, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Withdraw Money";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DepAmtTb);
            this.panel3.Controls.Add(this.DepAccountTb);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.DepositBtn);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(51, 186);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(851, 191);
            this.panel3.TabIndex = 3;
            // 
            // DepAmtTb
            // 
            this.DepAmtTb.Location = new System.Drawing.Point(158, 135);
            this.DepAmtTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepAmtTb.Name = "DepAmtTb";
            this.DepAmtTb.Size = new System.Drawing.Size(251, 27);
            this.DepAmtTb.TabIndex = 5;
            // 
            // DepAccountTb
            // 
            this.DepAccountTb.Location = new System.Drawing.Point(158, 72);
            this.DepAccountTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepAccountTb.Name = "DepAccountTb";
            this.DepAccountTb.Size = new System.Drawing.Size(251, 27);
            this.DepAccountTb.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Yellow;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(48, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "Amount";
            // 
            // DepositBtn
            // 
            this.DepositBtn.AutoSize = true;
            this.DepositBtn.BackColor = System.Drawing.Color.Gray;
            this.DepositBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DepositBtn.Location = new System.Drawing.Point(478, 105);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(85, 28);
            this.DepositBtn.TabIndex = 2;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gold;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(11, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Account Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(204, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Deposit Money";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkSalmon;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(801, 556);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 44);
            this.button7.TabIndex = 20;
            this.button7.Text = "BACK";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(809, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gold;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Account Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gold;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(622, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "Current Balance";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(934, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CheckBalanceBtn;
        private System.Windows.Forms.TextBox CheckBALTb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label WdBtn;
        private System.Windows.Forms.TextBox WdAmtTb;
        private System.Windows.Forms.TextBox WdAccountTb;
        private System.Windows.Forms.TextBox DepAmtTb;
        private System.Windows.Forms.TextBox DepAccountTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label DepositBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label BalanceLb1;
        private System.Windows.Forms.Button CheckBalance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
    }
}