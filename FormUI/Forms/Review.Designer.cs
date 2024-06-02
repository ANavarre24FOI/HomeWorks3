
namespace Project.Forms
{
    partial class Review
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
            this.WannaMakeReview = new System.Windows.Forms.Label();
            this.Button_Review_MainDish = new System.Windows.Forms.Button();
            this.Button_Review_SecondaryDish = new System.Windows.Forms.Button();
            this.Button_Review_Dessert = new System.Windows.Forms.Button();
            this.Button_NoReview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WannaMakeReview
            // 
            this.WannaMakeReview.AutoSize = true;
            this.WannaMakeReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WannaMakeReview.Location = new System.Drawing.Point(145, 23);
            this.WannaMakeReview.Name = "WannaMakeReview";
            this.WannaMakeReview.Size = new System.Drawing.Size(230, 25);
            this.WannaMakeReview.TabIndex = 0;
            this.WannaMakeReview.Text = "Wanna Make a Review ?";
            // 
            // Button_Review_MainDish
            // 
            this.Button_Review_MainDish.Location = new System.Drawing.Point(42, 95);
            this.Button_Review_MainDish.Name = "Button_Review_MainDish";
            this.Button_Review_MainDish.Size = new System.Drawing.Size(75, 23);
            this.Button_Review_MainDish.TabIndex = 1;
            this.Button_Review_MainDish.Text = "Button_Review_MainDish";
            this.Button_Review_MainDish.UseVisualStyleBackColor = true;
            this.Button_Review_MainDish.Click += new System.EventHandler(this.Button_Review_MainDish_Click);
            // 
            // Button_Review_SecondaryDish
            // 
            this.Button_Review_SecondaryDish.Location = new System.Drawing.Point(216, 95);
            this.Button_Review_SecondaryDish.Name = "Button_Review_SecondaryDish";
            this.Button_Review_SecondaryDish.Size = new System.Drawing.Size(75, 23);
            this.Button_Review_SecondaryDish.TabIndex = 2;
            this.Button_Review_SecondaryDish.Text = "Button_Review_SecondaryDish";
            this.Button_Review_SecondaryDish.UseVisualStyleBackColor = true;
            this.Button_Review_SecondaryDish.Click += new System.EventHandler(this.Button_Review_SecondaryDish_Click);
            // 
            // Button_Review_Dessert
            // 
            this.Button_Review_Dessert.Location = new System.Drawing.Point(402, 95);
            this.Button_Review_Dessert.Name = "Button_Review_Dessert";
            this.Button_Review_Dessert.Size = new System.Drawing.Size(75, 23);
            this.Button_Review_Dessert.TabIndex = 3;
            this.Button_Review_Dessert.Text = "Button_Review_Dessert";
            this.Button_Review_Dessert.UseVisualStyleBackColor = true;
            this.Button_Review_Dessert.Click += new System.EventHandler(this.Button_Review_Dessert_Click);
            // 
            // Button_NoReview
            // 
            this.Button_NoReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Button_NoReview.Location = new System.Drawing.Point(197, 156);
            this.Button_NoReview.Name = "Button_NoReview";
            this.Button_NoReview.Size = new System.Drawing.Size(114, 48);
            this.Button_NoReview.TabIndex = 4;
            this.Button_NoReview.Text = "No, Thanks";
            this.Button_NoReview.UseVisualStyleBackColor = true;
            this.Button_NoReview.Click += new System.EventHandler(this.Button_NoReview_Click);
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 216);
            this.Controls.Add(this.Button_NoReview);
            this.Controls.Add(this.Button_Review_Dessert);
            this.Controls.Add(this.Button_Review_SecondaryDish);
            this.Controls.Add(this.Button_Review_MainDish);
            this.Controls.Add(this.WannaMakeReview);
            this.Name = "Review";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WannaMakeReview;
        private System.Windows.Forms.Button Button_Review_MainDish;
        private System.Windows.Forms.Button Button_Review_SecondaryDish;
        private System.Windows.Forms.Button Button_Review_Dessert;
        private System.Windows.Forms.Button Button_NoReview;
    }
}