using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Project.Forms;
using Project.Models;
using Project.Repositories;

namespace Project.Forms
{
    public partial class Review : Form
    {
        private Order madeOrder;
        public Review(Order order)
        {
            InitializeComponent();
            madeOrder = order;
            Review_Load(madeOrder);
        }

        private void Review_Load(Order order)
        {
            Button_Review_MainDish.Text = GetDishName(order.Main_Dish);
            Button_Review_SecondaryDish.Text = GetDishName(order.Secondary_Dish);
            Button_Review_Dessert.Text = GetDishName(order.Dessert);
        }

        private string GetDishName(int? dishId)
        {
            if (dishId == null)
            {
                return "None";
            }

            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var query = "SELECT Name FROM Dishes WHERE Dish_id = @DishId";
                var parameters = new { DishId = dishId };
                var dishName = connection.QuerySingleOrDefault<string>(query, parameters);
                return dishName ?? "Unknown";
            }
        }

        private void Button_Review_MainDish_Click(object sender, EventArgs e)
        {
            string dishName = GetDishName(madeOrder.Main_Dish);
            int userId = madeOrder.User_id; // Assuming madeOrder contains User_id

            MakeReview frmMakeReview = new MakeReview(dishName, madeOrder.Main_Dish, userId);
            Hide();
            frmMakeReview.ShowDialog();
            Close();
        }

        private void Button_Review_SecondaryDish_Click(object sender, EventArgs e)
        {
            string dishName = GetDishName(madeOrder.Secondary_Dish);
            int userId = madeOrder.User_id; // Assuming madeOrder contains User_id

            MakeReview frmMakeReview = new MakeReview(dishName, madeOrder.Secondary_Dish, userId);
            Hide();
            frmMakeReview.ShowDialog();
            Close();
        }

        private void Button_Review_Dessert_Click(object sender, EventArgs e)
        {
            string dishName = GetDishName(madeOrder.Dessert);
            int userId = madeOrder.User_id; // Assuming madeOrder contains User_id

            MakeReview frmMakeReview = new MakeReview(dishName, madeOrder.Dessert, userId);
            Hide();
            frmMakeReview.ShowDialog();
            Close();
        }

        private void Button_NoReview_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
