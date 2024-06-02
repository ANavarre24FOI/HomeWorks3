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

namespace Project
{
    public partial class FrmLogin : Form
    {
        public static Users LoggedUser { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Label_LoginTextBox_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_PasswordTextBox_Click(object sender, EventArgs e)
        {

        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string username = Login_TextBox.Text;
            string password = Password_TextBox.Text;

            LoggedUser = UsersRepository.GetUsers(username, password);

            if (LoggedUser != null && LoggedUser.CheckPassword(password))
            {
                MessageBox.Show("User Logged Successfully!");
                DashBoard menu = new DashBoard(LoggedUser);
                Hide();
                menu.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong credetials!");
            }
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            Register frmrg = new Register();
            Hide();
            frmrg.ShowDialog();
        }

        private void CheckBox_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Password.Checked)
            {
                Password_TextBox.PasswordChar = '\0';
            }
            else
            {
                Password_TextBox.PasswordChar = '*';
            }
        }
    }
}
