
namespace Project.Forms
{
    partial class Register
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
            this.TextBox_Login = new System.Windows.Forms.TextBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.TextBox_LastName = new System.Windows.Forms.TextBox();
            this.Label_Login = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_LastName = new System.Windows.Forms.Label();
            this.Button_Register = new System.Windows.Forms.Button();
            this.CheckBox_Password = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TextBox_Login
            // 
            this.TextBox_Login.Location = new System.Drawing.Point(58, 56);
            this.TextBox_Login.Name = "TextBox_Login";
            this.TextBox_Login.Size = new System.Drawing.Size(156, 20);
            this.TextBox_Login.TabIndex = 0;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(58, 112);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '*';
            this.TextBox_Password.Size = new System.Drawing.Size(156, 20);
            this.TextBox_Password.TabIndex = 1;
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(58, 170);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(156, 20);
            this.TextBox_Name.TabIndex = 2;
            // 
            // TextBox_LastName
            // 
            this.TextBox_LastName.Location = new System.Drawing.Point(58, 223);
            this.TextBox_LastName.Name = "TextBox_LastName";
            this.TextBox_LastName.Size = new System.Drawing.Size(156, 20);
            this.TextBox_LastName.TabIndex = 3;
            // 
            // Label_Login
            // 
            this.Label_Login.AutoSize = true;
            this.Label_Login.Location = new System.Drawing.Point(55, 40);
            this.Label_Login.Name = "Label_Login";
            this.Label_Login.Size = new System.Drawing.Size(33, 13);
            this.Label_Login.TabIndex = 4;
            this.Label_Login.Text = "Login";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(55, 96);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(53, 13);
            this.Label_Password.TabIndex = 5;
            this.Label_Password.Text = "Password";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(55, 154);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(35, 13);
            this.Label_Name.TabIndex = 6;
            this.Label_Name.Text = "Name";
            // 
            // Label_LastName
            // 
            this.Label_LastName.AutoSize = true;
            this.Label_LastName.Location = new System.Drawing.Point(55, 207);
            this.Label_LastName.Name = "Label_LastName";
            this.Label_LastName.Size = new System.Drawing.Size(55, 13);
            this.Label_LastName.TabIndex = 7;
            this.Label_LastName.Text = "LastName";
            // 
            // Button_Register
            // 
            this.Button_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Button_Register.Location = new System.Drawing.Point(77, 259);
            this.Button_Register.Name = "Button_Register";
            this.Button_Register.Size = new System.Drawing.Size(118, 47);
            this.Button_Register.TabIndex = 8;
            this.Button_Register.Text = "Register";
            this.Button_Register.UseVisualStyleBackColor = true;
            this.Button_Register.Click += new System.EventHandler(this.Button_Register_Click);
            // 
            // CheckBox_Password
            // 
            this.CheckBox_Password.AutoSize = true;
            this.CheckBox_Password.Location = new System.Drawing.Point(77, 134);
            this.CheckBox_Password.Name = "CheckBox_Password";
            this.CheckBox_Password.Size = new System.Drawing.Size(99, 17);
            this.CheckBox_Password.TabIndex = 9;
            this.CheckBox_Password.Text = "ShowPassword";
            this.CheckBox_Password.UseVisualStyleBackColor = true;
            this.CheckBox_Password.CheckedChanged += new System.EventHandler(this.CheckBox_Password_CheckedChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 370);
            this.Controls.Add(this.CheckBox_Password);
            this.Controls.Add(this.Button_Register);
            this.Controls.Add(this.Label_LastName);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Label_Login);
            this.Controls.Add(this.TextBox_LastName);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.TextBox_Login);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Login;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.TextBox TextBox_LastName;
        private System.Windows.Forms.Label Label_Login;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_LastName;
        private System.Windows.Forms.Button Button_Register;
        private System.Windows.Forms.CheckBox CheckBox_Password;
    }
}