namespace BankSystem
{
    partial class Dashboard
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
            this.txtBalanceValue = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Welcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtLogout = new System.Windows.Forms.LinkLabel();
            this.txtCreateAccount = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.transaction = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAccountNumber = new System.Windows.Forms.ComboBox();
            this.Description = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deposit_remark_txt = new System.Windows.Forms.RichTextBox();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAccountNumber2 = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.withdrawal_remak_txt = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReciever = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTransfer = new System.Windows.Forms.ComboBox();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.transf_btn = new System.Windows.Forms.Button();
            this.tranfs_rmk_txt = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnShowBalance = new System.Windows.Forms.Button();
            this.txtAccountNumber3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtShowBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.transaction.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.txtBalanceValue);
            this.panel1.Controls.Add(this.txtBalance);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Welcome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 59);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtBalanceValue
            // 
            this.txtBalanceValue.AutoSize = true;
            this.txtBalanceValue.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBalanceValue.ForeColor = System.Drawing.Color.White;
            this.txtBalanceValue.Location = new System.Drawing.Point(638, 11);
            this.txtBalanceValue.Name = "txtBalanceValue";
            this.txtBalanceValue.Size = new System.Drawing.Size(0, 25);
            this.txtBalanceValue.TabIndex = 7;
            // 
            // txtBalance
            // 
            this.txtBalance.AutoSize = true;
            this.txtBalance.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBalance.ForeColor = System.Drawing.Color.White;
            this.txtBalance.Location = new System.Drawing.Point(499, 15);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(154, 21);
            this.txtBalance.TabIndex = 6;
            this.txtBalance.Text = "Account Number :";
            // 
            // txtFullName
            // 
            this.txtFullName.AutoSize = true;
            this.txtFullName.BackColor = System.Drawing.Color.Transparent;
            this.txtFullName.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFullName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtFullName.Location = new System.Drawing.Point(303, 9);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(0, 25);
            this.txtFullName.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 392);
            this.panel2.TabIndex = 1;
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Welcome.ForeColor = System.Drawing.Color.White;
            this.Welcome.Location = new System.Drawing.Point(209, 11);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(88, 24);
            this.Welcome.TabIndex = 4;
            this.Welcome.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(103, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "...bank with us";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "UGBANKS";
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.txtLogout);
            this.panel3.Controls.Add(this.txtCreateAccount);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 690);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtLogout
            // 
            this.txtLogout.AutoSize = true;
            this.txtLogout.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLogout.ForeColor = System.Drawing.Color.Red;
            this.txtLogout.LinkColor = System.Drawing.Color.Red;
            this.txtLogout.Location = new System.Drawing.Point(3, 585);
            this.txtLogout.Name = "txtLogout";
            this.txtLogout.Size = new System.Drawing.Size(64, 21);
            this.txtLogout.TabIndex = 2;
            this.txtLogout.TabStop = true;
            this.txtLogout.Text = "Logout";
            this.txtLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtLogout_LinkClicked);
            // 
            // txtCreateAccount
            // 
            this.txtCreateAccount.AutoSize = true;
            this.txtCreateAccount.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCreateAccount.LinkVisited = true;
            this.txtCreateAccount.Location = new System.Drawing.Point(0, 553);
            this.txtCreateAccount.Name = "txtCreateAccount";
            this.txtCreateAccount.Size = new System.Drawing.Size(172, 21);
            this.txtCreateAccount.TabIndex = 1;
            this.txtCreateAccount.TabStop = true;
            this.txtCreateAccount.Text = "Create new account";
            this.txtCreateAccount.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.txtCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtCreateAccount_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Accounts ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // transaction
            // 
            this.transaction.Controls.Add(this.tabPage1);
            this.transaction.Controls.Add(this.tabPage2);
            this.transaction.Controls.Add(this.tabPage3);
            this.transaction.Controls.Add(this.tabPage4);
            this.transaction.Controls.Add(this.tabPage5);
            this.transaction.Dock = System.Windows.Forms.DockStyle.Right;
            this.transaction.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transaction.ItemSize = new System.Drawing.Size(110, 25);
            this.transaction.Location = new System.Drawing.Point(209, 59);
            this.transaction.Margin = new System.Windows.Forms.Padding(2);
            this.transaction.Name = "transaction";
            this.transaction.SelectedIndex = 0;
            this.transaction.Size = new System.Drawing.Size(875, 690);
            this.transaction.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.transaction.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtAccountNumber);
            this.tabPage1.Controls.Add(this.Description);
            this.tabPage1.Controls.Add(this.btnDeposit);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.deposit_remark_txt);
            this.tabPage1.Controls.Add(this.txtDepositAmount);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(867, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Deposit";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAccountNumber.FormattingEnabled = true;
            this.txtAccountNumber.Location = new System.Drawing.Point(281, 60);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(312, 28);
            this.txtAccountNumber.TabIndex = 18;
            this.txtAccountNumber.SelectedIndexChanged += new System.EventHandler(this.txtAccountNumber_SelectedIndexChanged);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.BackColor = System.Drawing.Color.Transparent;
            this.Description.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Description.ForeColor = System.Drawing.Color.White;
            this.Description.Location = new System.Drawing.Point(11, 111);
            this.Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(118, 21);
            this.Description.TabIndex = 17;
            this.Description.Text = "Description ";
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.White;
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.btnDeposit.Location = new System.Drawing.Point(281, 224);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(114, 33);
            this.btnDeposit.TabIndex = 12;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Deposit Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Select Account Number";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // deposit_remark_txt
            // 
            this.deposit_remark_txt.Location = new System.Drawing.Point(282, 111);
            this.deposit_remark_txt.Margin = new System.Windows.Forms.Padding(2);
            this.deposit_remark_txt.Name = "deposit_remark_txt";
            this.deposit_remark_txt.Size = new System.Drawing.Size(311, 88);
            this.deposit_remark_txt.TabIndex = 13;
            this.deposit_remark_txt.Text = "";
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.BackColor = System.Drawing.Color.White;
            this.txtDepositAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepositAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDepositAmount.Location = new System.Drawing.Point(282, 22);
            this.txtDepositAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(311, 25);
            this.txtDepositAmount.TabIndex = 11;
            this.txtDepositAmount.TextChanged += new System.EventHandler(this.txtDepositAmount_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtAccountNumber2);
            this.tabPage2.Controls.Add(this.txtAmount);
            this.tabPage2.Controls.Add(this.btnWithdraw);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.withdrawal_remak_txt);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(867, 657);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Withdraw";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "Select Account Number";
            // 
            // txtAccountNumber2
            // 
            this.txtAccountNumber2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAccountNumber2.FormattingEnabled = true;
            this.txtAccountNumber2.Location = new System.Drawing.Point(240, 32);
            this.txtAccountNumber2.Name = "txtAccountNumber2";
            this.txtAccountNumber2.Size = new System.Drawing.Size(325, 28);
            this.txtAccountNumber2.TabIndex = 26;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(240, 80);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(325, 25);
            this.txtAmount.TabIndex = 25;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.btnWithdraw.Location = new System.Drawing.Point(240, 213);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(114, 33);
            this.btnWithdraw.TabIndex = 23;
            this.btnWithdraw.Text = "withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Enter Amount";
            // 
            // withdrawal_remak_txt
            // 
            this.withdrawal_remak_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.withdrawal_remak_txt.Location = new System.Drawing.Point(240, 128);
            this.withdrawal_remak_txt.Margin = new System.Windows.Forms.Padding(2);
            this.withdrawal_remak_txt.Name = "withdrawal_remak_txt";
            this.withdrawal_remak_txt.Size = new System.Drawing.Size(325, 62);
            this.withdrawal_remak_txt.TabIndex = 17;
            this.withdrawal_remak_txt.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtReciever);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtTransfer);
            this.tabPage3.Controls.Add(this.txtTransferAmount);
            this.tabPage3.Controls.Add(this.transf_btn);
            this.tabPage3.Controls.Add(this.tranfs_rmk_txt);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(867, 657);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transfer";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(31, 232);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Description";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(31, 83);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Choose account";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(31, 143);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Reciever\'s Account";
            // 
            // txtReciever
            // 
            this.txtReciever.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReciever.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReciever.Location = new System.Drawing.Point(234, 138);
            this.txtReciever.Margin = new System.Windows.Forms.Padding(2);
            this.txtReciever.Name = "txtReciever";
            this.txtReciever.Size = new System.Drawing.Size(302, 25);
            this.txtReciever.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(31, 189);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Enter Amount";
            // 
            // txtTransfer
            // 
            this.txtTransfer.FormattingEnabled = true;
            this.txtTransfer.Items.AddRange(new object[] {
            "Saving Account",
            "Current Account"});
            this.txtTransfer.Location = new System.Drawing.Point(234, 83);
            this.txtTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransfer.Name = "txtTransfer";
            this.txtTransfer.Size = new System.Drawing.Size(302, 28);
            this.txtTransfer.TabIndex = 25;
            this.txtTransfer.SelectedIndexChanged += new System.EventHandler(this.txtTransfer_SelectedIndexChanged);
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransferAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTransferAmount.Location = new System.Drawing.Point(234, 184);
            this.txtTransferAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(302, 25);
            this.txtTransferAmount.TabIndex = 24;
            // 
            // transf_btn
            // 
            this.transf_btn.BackColor = System.Drawing.Color.White;
            this.transf_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transf_btn.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transf_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transf_btn.Location = new System.Drawing.Point(234, 305);
            this.transf_btn.Margin = new System.Windows.Forms.Padding(2);
            this.transf_btn.Name = "transf_btn";
            this.transf_btn.Size = new System.Drawing.Size(112, 28);
            this.transf_btn.TabIndex = 22;
            this.transf_btn.Text = "Transfer";
            this.transf_btn.UseVisualStyleBackColor = false;
            this.transf_btn.Click += new System.EventHandler(this.transf_btn_Click);
            // 
            // tranfs_rmk_txt
            // 
            this.tranfs_rmk_txt.Location = new System.Drawing.Point(234, 232);
            this.tranfs_rmk_txt.Margin = new System.Windows.Forms.Padding(2);
            this.tranfs_rmk_txt.Name = "tranfs_rmk_txt";
            this.tranfs_rmk_txt.Size = new System.Drawing.Size(302, 54);
            this.tranfs_rmk_txt.TabIndex = 21;
            this.tranfs_rmk_txt.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.tabPage4.Controls.Add(this.btnShowBalance);
            this.tabPage4.Controls.Add(this.txtAccountNumber3);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.txtShowBalance);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(867, 657);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Balance";
            // 
            // btnShowBalance
            // 
            this.btnShowBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.btnShowBalance.Location = new System.Drawing.Point(34, 167);
            this.btnShowBalance.Name = "btnShowBalance";
            this.btnShowBalance.Size = new System.Drawing.Size(170, 38);
            this.btnShowBalance.TabIndex = 4;
            this.btnShowBalance.Text = "show balance";
            this.btnShowBalance.UseVisualStyleBackColor = true;
            this.btnShowBalance.Click += new System.EventHandler(this.btnShowBalance_Click);
            // 
            // txtAccountNumber3
            // 
            this.txtAccountNumber3.FormattingEnabled = true;
            this.txtAccountNumber3.Location = new System.Drawing.Point(269, 44);
            this.txtAccountNumber3.Name = "txtAccountNumber3";
            this.txtAccountNumber3.Size = new System.Drawing.Size(264, 28);
            this.txtAccountNumber3.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Select Account Number :";
            // 
            // txtShowBalance
            // 
            this.txtShowBalance.AutoSize = true;
            this.txtShowBalance.Location = new System.Drawing.Point(203, 102);
            this.txtShowBalance.Name = "txtShowBalance";
            this.txtShowBalance.Size = new System.Drawing.Size(0, 20);
            this.txtShowBalance.TabIndex = 1;
            this.txtShowBalance.Click += new System.EventHandler(this.txtShowBalance_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Show balance :";
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(867, 657);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Transactions";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 749);
            this.Controls.Add(this.transaction);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.transaction.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label Welcome;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private TabControl transaction;
        private TabPage tabPage1;
        private Button btnDeposit;
        private Label label4;
        private Label label6;
        private RichTextBox deposit_remark_txt;
        private TextBox txtDepositAmount;
        private TabPage tabPage2;
        private Label label8;
        private Label label7;
        private RichTextBox withdrawal_remak_txt;
        private TabPage tabPage3;
        private Label label14;
        private Label label13;
        private Label label12;
        private TextBox txtReciever;
        private Label label11;
        private ComboBox txtTransfer;
        private TextBox txtTransferAmount;
        private Button transf_btn;
        private RichTextBox tranfs_rmk_txt;
        private Label Description;
        private Button btnWithdraw;
        private TextBox txtAmount;
        private Label txtBalanceValue;
        private Label txtBalance;
        private Label txtFullName;
        private ComboBox txtAccountNumber;
        private ComboBox txtAccountNumber2;
        private Label label9;
        private LinkLabel txtCreateAccount;
        private LinkLabel txtLogout;
        private TabPage tabPage4;
        private Label txtShowBalance;
        private Label label5;
        private Button btnShowBalance;
        private ComboBox txtAccountNumber3;
        private Label label10;
        private TabPage tabPage5;
    }
}