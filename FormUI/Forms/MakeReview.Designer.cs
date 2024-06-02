
namespace Project.Forms
{
    partial class MakeReview
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
            this.TextBox_DishName = new System.Windows.Forms.TextBox();
            this.Label_ReviewDish = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Label_StarRatings = new System.Windows.Forms.Label();
            this.TextBox_Comment = new System.Windows.Forms.TextBox();
            this.Label_Comment = new System.Windows.Forms.Label();
            this.Button_Submit = new System.Windows.Forms.Button();
            this.Label_GiftPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_DishName
            // 
            this.TextBox_DishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox_DishName.Location = new System.Drawing.Point(43, 55);
            this.TextBox_DishName.Name = "TextBox_DishName";
            this.TextBox_DishName.Size = new System.Drawing.Size(146, 23);
            this.TextBox_DishName.TabIndex = 0;
            // 
            // Label_ReviewDish
            // 
            this.Label_ReviewDish.AutoSize = true;
            this.Label_ReviewDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Label_ReviewDish.Location = new System.Drawing.Point(38, 27);
            this.Label_ReviewDish.Name = "Label_ReviewDish";
            this.Label_ReviewDish.Size = new System.Drawing.Size(151, 25);
            this.Label_ReviewDish.TabIndex = 1;
            this.Label_ReviewDish.Text = "Dish to Review :";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "1,2,3,4,5";
            this.comboBox1.Location = new System.Drawing.Point(43, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "1,2,3,4,5";
            // 
            // Label_StarRatings
            // 
            this.Label_StarRatings.AutoSize = true;
            this.Label_StarRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Label_StarRatings.Location = new System.Drawing.Point(38, 108);
            this.Label_StarRatings.Name = "Label_StarRatings";
            this.Label_StarRatings.Size = new System.Drawing.Size(78, 25);
            this.Label_StarRatings.TabIndex = 2;
            this.Label_StarRatings.Text = "Rating :";
            // 
            // TextBox_Comment
            // 
            this.TextBox_Comment.Location = new System.Drawing.Point(43, 206);
            this.TextBox_Comment.MaxLength = 250;
            this.TextBox_Comment.Multiline = true;
            this.TextBox_Comment.Name = "TextBox_Comment";
            this.TextBox_Comment.Size = new System.Drawing.Size(315, 107);
            this.TextBox_Comment.TabIndex = 3;
            // 
            // Label_Comment
            // 
            this.Label_Comment.AutoSize = true;
            this.Label_Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Label_Comment.Location = new System.Drawing.Point(41, 178);
            this.Label_Comment.Name = "Label_Comment";
            this.Label_Comment.Size = new System.Drawing.Size(108, 25);
            this.Label_Comment.TabIndex = 4;
            this.Label_Comment.Text = "Comment :";
            // 
            // Button_Submit
            // 
            this.Button_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Button_Submit.Location = new System.Drawing.Point(77, 337);
            this.Button_Submit.Name = "Button_Submit";
            this.Button_Submit.Size = new System.Drawing.Size(235, 54);
            this.Button_Submit.TabIndex = 5;
            this.Button_Submit.Text = "Submit Review";
            this.Button_Submit.UseVisualStyleBackColor = true;
            this.Button_Submit.Click += new System.EventHandler(this.Button_Submit_Click);
            // 
            // Label_GiftPoints
            // 
            this.Label_GiftPoints.AutoSize = true;
            this.Label_GiftPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_GiftPoints.Location = new System.Drawing.Point(74, 394);
            this.Label_GiftPoints.Name = "Label_GiftPoints";
            this.Label_GiftPoints.Size = new System.Drawing.Size(238, 20);
            this.Label_GiftPoints.TabIndex = 6;
            this.Label_GiftPoints.Text = "This Review will give you 3 points";
            // 
            // MakeReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.Label_GiftPoints);
            this.Controls.Add(this.Button_Submit);
            this.Controls.Add(this.Label_Comment);
            this.Controls.Add(this.TextBox_Comment);
            this.Controls.Add(this.Label_StarRatings);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Label_ReviewDish);
            this.Controls.Add(this.TextBox_DishName);
            this.Name = "MakeReview";
            this.Text = "MakeReview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_DishName;
        private System.Windows.Forms.Label Label_ReviewDish;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Label_StarRatings;
        private System.Windows.Forms.TextBox TextBox_Comment;
        private System.Windows.Forms.Label Label_Comment;
        private System.Windows.Forms.Button Button_Submit;
        private System.Windows.Forms.Label Label_GiftPoints;
    }
}