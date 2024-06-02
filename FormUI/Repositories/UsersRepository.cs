using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Project.Models;

namespace Project.Repositories
{
    class UsersRepository
    {
        public static Users GetUsers(string login, string password)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var query = "SELECT User_id, Login, Password, Name, LastName FROM Users WHERE Login = @Login AND Password = @Password";
                var parameters = new { Login = login, Password = password };
                var output = connection.Query<Users>(query, parameters).FirstOrDefault();

                if (output != null)
                {
                    return output;
                }
                else
                {
                    // Optionally, handle the case where no user is found.
                    return null;
                }
            }
        }

        public static void AddUser(string login, string password, string name, string lastName)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("SampleDB")))
            {
                string query = "INSERT INTO Users (Login, Password, Name, LastName) " +
                               "VALUES (@Login, @Password, @Name, @LastName)";

                var parameters = new
                {
                    Login = login,
                    Password = password,
                    Name = name,
                    LastName = lastName
                };

                connection.Execute(query, parameters);
            }
        }

    }
}
