namespace BankSystem
{
    partial class CreateNewAccount
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
            this.Savings2 = new System.Windows.Forms.RadioButton();
            this.Current2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Savings2
            // 
            this.Savings2.AutoSize = true;
            this.Savings2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Savings2.Location = new System.Drawing.Point(72, 59);
            this.Savings2.Name = "Savings2";
            this.Savings2.Size = new System.Drawing.Size(90, 24);
            this.Savings2.TabIndex = 0;
            this.Savings2.TabStop = true;
            this.Savings2.Text = "Savings";
            this.Savings2.UseVisualStyleBackColor = true;
            // 
            // Current2
            // 
            this.Current2.AutoSize = true;
            this.Current2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Current2.Location = new System.Drawing.Point(163, 59);
            this.Current2.Name = "Current2";
            this.Current2.Size = new System.Drawing.Size(90, 24);
            this.Current2.TabIndex = 1;
            this.Current2.TabStop = true;
            this.Current2.Text = "Current";
            this.Current2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select account type";
            // 
            // txtEnter
            // 
            this.txtEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.txtEnter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEnter.ForeColor = System.Drawing.Color.White;
            this.txtEnter.Location = new System.Drawing.Point(100, 89);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(112, 32);
            this.txtEnter.TabIndex = 3;
            this.txtEnter.Text = "Enter";
            this.txtEnter.UseVisualStyleBackColor = false;
            this.txtEnter.Click += new System.EventHandler(this.txtEnter_Click);
            // 
            // CreateNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 143);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Current2);
            this.Controls.Add(this.Savings2);
            this.Name = "CreateNewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton Savings2;
        private RadioButton Current2;
        private Label label1;
        private Button txtEnter;
    }
}