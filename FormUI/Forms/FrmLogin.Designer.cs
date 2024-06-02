namespace Project
{
    partial class FrmLogin
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
            this.Login_TextBox = new System.Windows.Forms.TextBox();
            this.Label_LoginTextBox = new System.Windows.Forms.Label();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.Label_PasswordTextBox = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Button_Register = new System.Windows.Forms.Button();
            this.CheckBox_Password = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Login_TextBox
            // 
            this.Login_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Login_TextBox.Location = new System.Drawing.Point(108, 86);
            this.Login_TextBox.Name = "Login_TextBox";
            this.Login_TextBox.Size = new System.Drawing.Size(202, 31);
            this.Login_TextBox.TabIndex = 0;
            // 
            // Label_LoginTextBox
            // 
            this.Label_LoginTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_LoginTextBox.AutoSize = true;
            this.Label_LoginTextBox.Location = new System.Drawing.Point(103, 58);
            this.Label_LoginTextBox.Name = "Label_LoginTextBox";
            this.Label_LoginTextBox.Size = new System.Drawing.Size(65, 25);
            this.Label_LoginTextBox.TabIndex = 1;
            this.Label_LoginTextBox.Text = "Login";
            this.Label_LoginTextBox.Click += new System.EventHandler(this.Label_LoginTextBox_Click);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Password_TextBox.Location = new System.Drawing.Point(108, 156);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(202, 31);
            this.Password_TextBox.TabIndex = 2;
            this.Password_TextBox.TextChanged += new System.EventHandler(this.Password_TextBox_TextChanged);
            // 
            // Label_PasswordTextBox
            // 
            this.Label_PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_PasswordTextBox.AutoSize = true;
            this.Label_PasswordTextBox.Location = new System.Drawing.Point(103, 128);
            this.Label_PasswordTextBox.Name = "Label_PasswordTextBox";
            this.Label_PasswordTextBox.Size = new System.Drawing.Size(106, 25);
            this.Label_PasswordTextBox.TabIndex = 3;
            this.Label_PasswordTextBox.Text = "Password";
            this.Label_PasswordTextBox.Click += new System.EventHandler(this.Label_PasswordTextBox_Click);
            // 
            // Login_Button
            // 
            this.Login_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_Button.Location = new System.Drawing.Point(142, 228);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(126, 46);
            this.Login_Button.TabIndex = 4;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Button_Register
            // 
            this.Button_Register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Register.Location = new System.Drawing.Point(142, 280);
            this.Button_Register.Name = "Button_Register";
            this.Button_Register.Size = new System.Drawing.Size(126, 46);
            this.Button_Register.TabIndex = 5;
            this.Button_Register.Text = "Register";
            this.Button_Register.UseVisualStyleBackColor = true;
            this.Button_Register.Click += new System.EventHandler(this.Button_Register_Click);
            // 
            // CheckBox_Password
            // 
            this.CheckBox_Password.AutoSize = true;
            this.CheckBox_Password.Location = new System.Drawing.Point(108, 193);
            this.CheckBox_Password.Name = "CheckBox_Password";
            this.CheckBox_Password.Size = new System.Drawing.Size(184, 29);
            this.CheckBox_Password.TabIndex = 6;
            this.CheckBox_Password.Text = "Show Password";
            this.CheckBox_Password.UseVisualStyleBackColor = true;
            this.CheckBox_Password.CheckedChanged += new System.EventHandler(this.CheckBox_Password_CheckedChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(428, 338);
            this.Controls.Add(this.CheckBox_Password);
            this.Controls.Add(this.Button_Register);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Label_PasswordTextBox);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Label_LoginTextBox);
            this.Controls.Add(this.Login_TextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login_TextBox;
        private System.Windows.Forms.Label Label_LoginTextBox;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label Label_PasswordTextBox;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Button_Register;
        private System.Windows.Forms.CheckBox CheckBox_Password;
    }
}

