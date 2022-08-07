namespace BankSystem
{
    partial class Welcome
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Panel();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gotoLogin = new System.Windows.Forms.LinkLabel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.Password = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.FName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Register.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 450);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(117, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "...bank with us";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(50, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "UGBANKS";
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.White;
            this.Register.Controls.Add(this.txtPhoneNumber);
            this.Register.Controls.Add(this.label3);
            this.Register.Controls.Add(this.gotoLogin);
            this.Register.Controls.Add(this.btnRegister);
            this.Register.Controls.Add(this.txtPassword);
            this.Register.Controls.Add(this.Password);
            this.Register.Controls.Add(this.PhoneNumber);
            this.Register.Controls.Add(this.txtEmail);
            this.Register.Controls.Add(this.txtLastName);
            this.Register.Controls.Add(this.Email);
            this.Register.Controls.Add(this.txtFirstName);
            this.Register.Controls.Add(this.LName);
            this.Register.Controls.Add(this.FName);
            this.Register.Dock = System.Windows.Forms.DockStyle.Right;
            this.Register.Location = new System.Drawing.Point(306, 0);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(494, 450);
            this.Register.TabIndex = 1;
            this.Register.Paint += new System.Windows.Forms.PaintEventHandler(this.Register_Paint);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Location = new System.Drawing.Point(168, 249);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(303, 23);
            this.txtPhoneNumber.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.label3.Location = new System.Drawing.Point(186, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Register";
            // 
            // gotoLogin
            // 
            this.gotoLogin.ActiveLinkColor = System.Drawing.Color.Maroon;
            this.gotoLogin.AutoSize = true;
            this.gotoLogin.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gotoLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.gotoLogin.Location = new System.Drawing.Point(28, 403);
            this.gotoLogin.Name = "gotoLogin";
            this.gotoLogin.Size = new System.Drawing.Size(175, 19);
            this.gotoLogin.TabIndex = 10;
            this.gotoLogin.TabStop = true;
            this.gotoLogin.Text = "I Already have an account";
            this.gotoLogin.VisitedLinkColor = System.Drawing.Color.LightSkyBlue;
            this.gotoLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gotoLogin_LinkClicked);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.btnRegister.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(28, 361);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(445, 39);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register ";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleName = "txtPassword";
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(169, 285);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(304, 23);
            this.txtPassword.TabIndex = 8;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.Password.Location = new System.Drawing.Point(28, 286);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(74, 22);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.PhoneNumber.Location = new System.Drawing.Point(28, 249);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(107, 22);
            this.PhoneNumber.TabIndex = 5;
            this.PhoneNumber.Text = "Phone Number";
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleName = "txtEmail";
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEmail.Location = new System.Drawing.Point(168, 205);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(303, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.Emailinput_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.AccessibleName = "txtLastName";
            this.txtLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtLastName.Location = new System.Drawing.Point(168, 165);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(303, 23);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.TextChanged += new System.EventHandler(this.LNinput_TextChanged);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.Email.Location = new System.Drawing.Point(28, 206);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(46, 22);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email";
            // 
            // txtFirstName
            // 
            this.txtFirstName.AccessibleName = "txtFirstName";
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtFirstName.Location = new System.Drawing.Point(168, 125);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(303, 23);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.FNinput_TextChanged);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.LName.Location = new System.Drawing.Point(28, 166);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(80, 22);
            this.LName.TabIndex = 2;
            this.LName.Text = "Last Name";
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.FName.Location = new System.Drawing.Point(28, 126);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(82, 22);
            this.FName.TabIndex = 0;
            this.FName.Text = "First Name";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.panel1);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Register.ResumeLayout(false);
            this.Register.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel Register;
        private TextBox txtFirstName;
        private Label FName;
        private TextBox txtLastName;
        private Label LName;
        private TextBox txtEmail;
        private Label Email;
        private Label PhoneNumber;
        private Label Password;
        private LinkLabel gotoLogin;
        private Button btnRegister;
        private MaskedTextBox txtPassword;
        private Label label3;
        private TextBox txtPhoneNumber;
    }
}