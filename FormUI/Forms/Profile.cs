using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Forms;
using Project.Models;
using Project.Repositories;

namespace Project.Forms
{
    public partial class Profile : Form
    {
        public Profile(Users loggedUser)
        {
            InitializeComponent();
            TextBox_Name.Text = loggedUser.Name;
            TextBox_LastName.Text = loggedUser.LastName;
            TextBox_GiftPoint.Text = Convert.ToString(loggedUser.GiftPoints);
        }
    }
}
