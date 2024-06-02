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
    public partial class DashBoard : Form
    {
        public static Users LoggedUser;
        public DashBoard(Users user)
        {
            InitializeComponent();
            LoggedUser = user;
        }

        private void Button_ALaCarte_Click(object sender, EventArgs e)
        {

            OrderALaCarte frmOrderALaCarte = new OrderALaCarte(LoggedUser);
            frmOrderALaCarte.ShowDialog();
        }

        private void Button_LogOut_Click(object sender, EventArgs e)
        {
            LoggedUser = null;
            FrmLogin frmLogin = new FrmLogin();
            Hide();
            frmLogin.ShowDialog();
            Close();
        }

        private void Button_Profile_Click(object sender, EventArgs e)
        {
            Profile frmProfile = new Profile(LoggedUser);
            frmProfile.ShowDialog();
        }
    }
}
