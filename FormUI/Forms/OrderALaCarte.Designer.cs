
namespace Project.Forms
{
    partial class OrderALaCarte
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
            this.ComboBox_MainDish = new System.Windows.Forms.ComboBox();
            this.ComboBox_SecondaryDish = new System.Windows.Forms.ComboBox();
            this.ComboBox_Dessert = new System.Windows.Forms.ComboBox();
            this.Label_MainDish = new System.Windows.Forms.Label();
            this.Label_SecondaryDish = new System.Windows.Forms.Label();
            this.Label_Dessert = new System.Windows.Forms.Label();
            this.OrderButton = new System.Windows.Forms.Button();
            this.Label_Points = new System.Windows.Forms.Label();
            this.Label_nbrOfPoints = new System.Windows.Forms.Label();
            this.Label_CostPhrase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBox_MainDish
            // 
            this.ComboBox_MainDish.FormattingEnabled = true;
            this.ComboBox_MainDish.Location = new System.Drawing.Point(44, 127);
            this.ComboBox_MainDish.Name = "ComboBox_MainDish";
            this.ComboBox_MainDish.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_MainDish.TabIndex = 0;
            this.ComboBox_MainDish.SelectedIndexChanged += new System.EventHandler(this.ComboBox_MainDish_SelectedIndexChanged);
            // 
            // ComboBox_SecondaryDish
            // 
            this.ComboBox_SecondaryDish.FormattingEnabled = true;
            this.ComboBox_SecondaryDish.Location = new System.Drawing.Point(205, 127);
            this.ComboBox_SecondaryDish.Name = "ComboBox_SecondaryDish";
            this.ComboBox_SecondaryDish.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_SecondaryDish.TabIndex = 1;
            this.ComboBox_SecondaryDish.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SecondaryDish_SelectedIndexChanged);
            // 
            // ComboBox_Dessert
            // 
            this.ComboBox_Dessert.FormattingEnabled = true;
            this.ComboBox_Dessert.Location = new System.Drawing.Point(360, 127);
            this.ComboBox_Dessert.Name = "ComboBox_Dessert";
            this.ComboBox_Dessert.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Dessert.TabIndex = 2;
            this.ComboBox_Dessert.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Dessert_SelectedIndexChanged);
            // 
            // Label_MainDish
            // 
            this.Label_MainDish.AutoSize = true;
            this.Label_MainDish.Location = new System.Drawing.Point(41, 111);
            this.Label_MainDish.Name = "Label_MainDish";
            this.Label_MainDish.Size = new System.Drawing.Size(51, 13);
            this.Label_MainDish.TabIndex = 3;
            this.Label_MainDish.Text = "MainDish";
            // 
            // Label_SecondaryDish
            // 
            this.Label_SecondaryDish.AutoSize = true;
            this.Label_SecondaryDish.Location = new System.Drawing.Point(202, 111);
            this.Label_SecondaryDish.Name = "Label_SecondaryDish";
            this.Label_SecondaryDish.Size = new System.Drawing.Size(82, 13);
            this.Label_SecondaryDish.TabIndex = 4;
            this.Label_SecondaryDish.Text = "Secondary Dish";
            // 
            // Label_Dessert
            // 
            this.Label_Dessert.AutoSize = true;
            this.Label_Dessert.Location = new System.Drawing.Point(357, 111);
            this.Label_Dessert.Name = "Label_Dessert";
            this.Label_Dessert.Size = new System.Drawing.Size(43, 13);
            this.Label_Dessert.TabIndex = 5;
            this.Label_Dessert.Text = "Dessert";
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(170, 201);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(230, 69);
            this.OrderButton.TabIndex = 6;
            this.OrderButton.Text = "Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // Label_Points
            // 
            this.Label_Points.AutoSize = true;
            this.Label_Points.Location = new System.Drawing.Point(192, 176);
            this.Label_Points.Name = "Label_Points";
            this.Label_Points.Size = new System.Drawing.Size(92, 13);
            this.Label_Points.TabIndex = 7;
            this.Label_Points.Text = "You have actually";
            // 
            // Label_nbrOfPoints
            // 
            this.Label_nbrOfPoints.AutoSize = true;
            this.Label_nbrOfPoints.Location = new System.Drawing.Point(290, 176);
            this.Label_nbrOfPoints.Name = "Label_nbrOfPoints";
            this.Label_nbrOfPoints.Size = new System.Drawing.Size(35, 13);
            this.Label_nbrOfPoints.TabIndex = 8;
            this.Label_nbrOfPoints.Text = "label1";
            // 
            // Label_CostPhrase
            // 
            this.Label_CostPhrase.AutoSize = true;
            this.Label_CostPhrase.Location = new System.Drawing.Point(203, 273);
            this.Label_CostPhrase.Name = "Label_CostPhrase";
            this.Label_CostPhrase.Size = new System.Drawing.Size(144, 13);
            this.Label_CostPhrase.TabIndex = 9;
            this.Label_CostPhrase.Text = "Your Order cost 10 GiftPoints";
            // 
            // OrderALaCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 383);
            this.Controls.Add(this.Label_CostPhrase);
            this.Controls.Add(this.Label_nbrOfPoints);
            this.Controls.Add(this.Label_Points);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.Label_Dessert);
            this.Controls.Add(this.Label_SecondaryDish);
            this.Controls.Add(this.Label_MainDish);
            this.Controls.Add(this.ComboBox_Dessert);
            this.Controls.Add(this.ComboBox_SecondaryDish);
            this.Controls.Add(this.ComboBox_MainDish);
            this.Name = "OrderALaCarte";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OrderALaCarte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_MainDish;
        private System.Windows.Forms.ComboBox ComboBox_SecondaryDish;
        private System.Windows.Forms.ComboBox ComboBox_Dessert;
        private System.Windows.Forms.Label Label_MainDish;
        private System.Windows.Forms.Label Label_SecondaryDish;
        private System.Windows.Forms.Label Label_Dessert;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Label Label_Points;
        private System.Windows.Forms.Label Label_nbrOfPoints;
        private System.Windows.Forms.Label Label_CostPhrase;
    }
}