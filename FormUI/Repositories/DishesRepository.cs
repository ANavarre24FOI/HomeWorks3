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
    public static class DishesRepository
    {
        public static List<Dish> GetAllDishes()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var output = connection.Query<Dish>("SELECT * FROM Dishes").ToList();
                return output;
            }
        }

        public static List<Dish> GetDishesByType(string type)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var output = connection.Query<Dish>($"SELECT * FROM Dishes where Type = '{type}'").ToList();
                return output;
            }
        }
    }
}
