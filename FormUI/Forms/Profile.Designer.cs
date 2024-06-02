
namespace Project.Forms
{
    partial class Profile
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
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.Label_LastName = new System.Windows.Forms.Label();
            this.TextBox_LastName = new System.Windows.Forms.TextBox();
            this.Label_GiftPointsnbr = new System.Windows.Forms.Label();
            this.TextBox_GiftPoint = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(24, 49);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 13);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Name";
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(27, 65);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.ReadOnly = true;
            this.TextBox_Name.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Name.TabIndex = 1;
            // 
            // Label_LastName
            // 
            this.Label_LastName.AutoSize = true;
            this.Label_LastName.Location = new System.Drawing.Point(24, 102);
            this.Label_LastName.Name = "Label_LastName";
            this.Label_LastName.Size = new System.Drawing.Size(55, 13);
            this.Label_LastName.TabIndex = 2;
            this.Label_LastName.Text = "LastName";
            // 
            // TextBox_LastName
            // 
            this.TextBox_LastName.Location = new System.Drawing.Point(27, 118);
            this.TextBox_LastName.Name = "TextBox_LastName";
            this.TextBox_LastName.ReadOnly = true;
            this.TextBox_LastName.Size = new System.Drawing.Size(100, 20);
            this.TextBox_LastName.TabIndex = 3;
            // 
            // Label_GiftPointsnbr
            // 
            this.Label_GiftPointsnbr.AutoSize = true;
            this.Label_GiftPointsnbr.Location = new System.Drawing.Point(278, 49);
            this.Label_GiftPointsnbr.Name = "Label_GiftPointsnbr";
            this.Label_GiftPointsnbr.Size = new System.Drawing.Size(99, 13);
            this.Label_GiftPointsnbr.TabIndex = 4;
            this.Label_GiftPointsnbr.Text = "GiftPoints\'s Number";
            // 
            // TextBox_GiftPoint
            // 
            this.TextBox_GiftPoint.Location = new System.Drawing.Point(277, 65);
            this.TextBox_GiftPoint.Name = "TextBox_GiftPoint";
            this.TextBox_GiftPoint.ReadOnly = true;
            this.TextBox_GiftPoint.Size = new System.Drawing.Size(100, 20);
            this.TextBox_GiftPoint.TabIndex = 5;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 181);
            this.Controls.Add(this.TextBox_GiftPoint);
            this.Controls.Add(this.Label_GiftPointsnbr);
            this.Controls.Add(this.TextBox_LastName);
            this.Controls.Add(this.Label_LastName);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.LabelName);
            this.Name = "Profile";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Label Label_LastName;
        private System.Windows.Forms.TextBox TextBox_LastName;
        private System.Windows.Forms.Label Label_GiftPointsnbr;
        private System.Windows.Forms.TextBox TextBox_GiftPoint;
    }
}