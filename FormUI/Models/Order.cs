using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Order
    {
        public int Order_id { get; set; }
        public int User_id { get; set; }
        public int Main_Dish { get; set; }
        public int Secondary_Dish { get; set; }
        public int Dessert { get; set; }
    }
}
