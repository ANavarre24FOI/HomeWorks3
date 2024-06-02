using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using Project.Models;
using System.Data.SqlClient;

namespace Project.Repositories
{
    public class OrderRepository
    {
        public static void AddOrder(int userId, int mainDishId, int secondaryDishId, int dessertId)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("SampleDB")))
            {
                string query = "INSERT INTO Orders (User_id, Main_Dish, Secondary_Dish, Dessert, OrderDate) " +
                               "VALUES (@UserId, @MainDishId, @SecondaryDishId, @DessertId, GETDATE())";

                var parameters = new
                {
                    UserId = userId,
                    MainDishId = mainDishId == 0 ? (int?)null : mainDishId,
                    SecondaryDishId = secondaryDishId == 0 ? (int?)null : secondaryDishId,
                    DessertId = dessertId == 0 ? (int?)null : dessertId
                };

                connection.Execute(query, parameters);
            }
        }
    }
}
