using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Users
    {
        public int User_id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int GiftPoints { get; set; }

        public string FullInfo
        {
            get
            {
                // "Tim Corey (test@test.com)"
                return $"{User_id}, {Login}, {Password}, { Name }, {LastName}, {GiftPoints})";
            }
        }

        public bool CheckPassword(string password)
        {
            return Password == password;
        }

    }
}
