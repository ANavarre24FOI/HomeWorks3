using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Models;
using Project.Repositories;
using Project.Forms;

namespace Project.Forms
{
    public partial class OrderALaCarte : Form
    {
        private Users loggedUser;
        public OrderALaCarte(Users user)
        {
            InitializeComponent();
            loggedUser = user;
        }

        private void OrderALaCarte_Load(object sender, EventArgs e)
        {
            LoadDishes();
        }

        private void LoadDishes()
        {
            List<Dish> mainDishes = DishesRepository.GetDishesByType("Main");
            List<Dish> secondaryDishes = DishesRepository.GetDishesByType("Secondary");
            List<Dish> desserts = DishesRepository.GetDishesByType("Dessert");

            mainDishes.Insert(0, new Dish { Dish_id = 0, Name = "None" });
            secondaryDishes.Insert(0, new Dish { Dish_id = 0, Name = "None" });
            desserts.Insert(0, new Dish { Dish_id = 0, Name = "None" });

            ComboBox_MainDish.DataSource = mainDishes;
            ComboBox_MainDish.DisplayMember = "Name";
            ComboBox_MainDish.ValueMember = "Dish_id";

            ComboBox_SecondaryDish.DataSource = secondaryDishes;
            ComboBox_SecondaryDish.DisplayMember = "Name";
            ComboBox_SecondaryDish.ValueMember = "Dish_id";

            ComboBox_Dessert.DataSource = desserts;
            ComboBox_Dessert.DisplayMember = "Name";
            ComboBox_Dessert.ValueMember = "Dish_id";
        }

        private void ComboBox_MainDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle main dish selection changed
        }

        private void ComboBox_SecondaryDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle secondary dish selection changed
        }

        private void ComboBox_Dessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle dessert selection changed
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            int mainDishId = (int)ComboBox_MainDish.SelectedValue;
            int secondaryDishId = (int)ComboBox_SecondaryDish.SelectedValue;
            int dessertId = (int)ComboBox_Dessert.SelectedValue;
            int userId = loggedUser.User_id;

            OrderRepository.AddOrder(userId, mainDishId, secondaryDishId, dessertId);

            Order CurrentOrder = new Order();
            CurrentOrder.User_id = userId;
            CurrentOrder.Main_Dish = mainDishId;
            CurrentOrder.Secondary_Dish = secondaryDishId;
            CurrentOrder.Dessert = dessertId;

            Review frmreview = new Review(CurrentOrder);
            Hide();
            frmreview.ShowDialog();
            Close();
        }
            
    }
}