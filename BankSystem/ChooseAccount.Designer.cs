namespace BankSystem
{
    partial class ChooseAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.Savings = new System.Windows.Forms.RadioButton();
            this.Current = new System.Windows.Forms.RadioButton();
            this.btnChooseAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(235, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Savings
            // 
            this.Savings.AutoSize = true;
            this.Savings.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Savings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.Savings.Location = new System.Drawing.Point(275, 113);
            this.Savings.Name = "Savings";
            this.Savings.Size = new System.Drawing.Size(107, 29);
            this.Savings.TabIndex = 1;
            this.Savings.TabStop = true;
            this.Savings.Text = "Savings";
            this.Savings.UseVisualStyleBackColor = true;
            // 
            // Current
            // 
            this.Current.AutoSize = true;
            this.Current.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Current.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.Current.Location = new System.Drawing.Point(388, 113);
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(107, 29);
            this.Current.TabIndex = 2;
            this.Current.TabStop = true;
            this.Current.Text = "Current";
            this.Current.UseVisualStyleBackColor = true;
            // 
            // btnChooseAccount
            // 
            this.btnChooseAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.btnChooseAccount.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChooseAccount.ForeColor = System.Drawing.Color.White;
            this.btnChooseAccount.Location = new System.Drawing.Point(258, 163);
            this.btnChooseAccount.Name = "btnChooseAccount";
            this.btnChooseAccount.Size = new System.Drawing.Size(258, 46);
            this.btnChooseAccount.TabIndex = 3;
            this.btnChooseAccount.Text = "Create Account";
            this.btnChooseAccount.UseVisualStyleBackColor = false;
            this.btnChooseAccount.Click += new System.EventHandler(this.btnChooseAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(299, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Terms and condition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(664, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor in" +
    "cididunt ut labore et dolore magna aliqua.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(516, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu f" +
    "ugiat nulla pariatur.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(629, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehe" +
    "nderit in voluptate velit esse pariatur.";
            // 
            // ChooseAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChooseAccount);
            this.Controls.Add(this.Current);
            this.Controls.Add(this.Savings);
            this.Controls.Add(this.label1);
            this.Name = "ChooseAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton Savings;
        private RadioButton Current;
        private Button btnChooseAccount;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}