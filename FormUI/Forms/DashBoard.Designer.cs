
namespace Project.Forms
{
    partial class DashBoard
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
            this.Button_ALaCarte = new System.Windows.Forms.Button();
            this.Button_Profile = new System.Windows.Forms.Button();
            this.Button_LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_ALaCarte
            // 
            this.Button_ALaCarte.Location = new System.Drawing.Point(99, 102);
            this.Button_ALaCarte.Name = "Button_ALaCarte";
            this.Button_ALaCarte.Size = new System.Drawing.Size(223, 73);
            this.Button_ALaCarte.TabIndex = 0;
            this.Button_ALaCarte.Text = "Order A La Carte";
            this.Button_ALaCarte.UseVisualStyleBackColor = true;
            this.Button_ALaCarte.Click += new System.EventHandler(this.Button_ALaCarte_Click);
            // 
            // Button_Profile
            // 
            this.Button_Profile.Location = new System.Drawing.Point(99, 222);
            this.Button_Profile.Name = "Button_Profile";
            this.Button_Profile.Size = new System.Drawing.Size(223, 73);
            this.Button_Profile.TabIndex = 1;
            this.Button_Profile.Text = "Profile";
            this.Button_Profile.UseVisualStyleBackColor = true;
            this.Button_Profile.Click += new System.EventHandler(this.Button_Profile_Click);
            // 
            // Button_LogOut
            // 
            this.Button_LogOut.Location = new System.Drawing.Point(99, 343);
            this.Button_LogOut.Name = "Button_LogOut";
            this.Button_LogOut.Size = new System.Drawing.Size(223, 73);
            this.Button_LogOut.TabIndex = 2;
            this.Button_LogOut.Text = "LogOut";
            this.Button_LogOut.UseVisualStyleBackColor = true;
            this.Button_LogOut.Click += new System.EventHandler(this.Button_LogOut_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 484);
            this.Controls.Add(this.Button_LogOut);
            this.Controls.Add(this.Button_Profile);
            this.Controls.Add(this.Button_ALaCarte);
            this.Name = "DashBoard";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_ALaCarte;
        private System.Windows.Forms.Button Button_Profile;
        private System.Windows.Forms.Button Button_LogOut;
    }
}