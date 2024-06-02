using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;

namespace Project.Forms
{
    public partial class MakeReview : Form
    {
        private int userId;
        private int dishId;

        public MakeReview(string dishName, int dishId, int userId)
        {
            InitializeComponent();
            this.dishId = dishId;
            this.userId = userId;
            TextBox_DishName.Text = dishName;
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
            comboBox1.Items.Add(4);
            comboBox1.Items.Add(5);
            comboBox1.SelectedIndex = 0;
        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            int rating = (int)comboBox1.SelectedItem;
            string comment = TextBox_Comment.Text;

            AddReview(userId, dishId, rating, comment);

            MessageBox.Show("Review submitted successfully!");
            Close();
        }

        private void AddReview(int userId, int dishId, int rating, string comment)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("SampleDB")))
            {
                string query = "INSERT INTO Ratings (User_id, Dish_id, Rating, Comment) " +
                               "VALUES (@UserId, @DishId, @Rating, @Comment)";

                var parameters = new
                {
                    UserId = userId,
                    DishId = dishId,
                    Rating = rating,
                    Comment = comment
                };

                connection.Execute(query, parameters);
            }
        }
    }
}

