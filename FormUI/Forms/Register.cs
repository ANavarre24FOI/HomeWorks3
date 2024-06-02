using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Repositories;
using Project.Forms;
using Project.Models;

namespace Project.Forms
{
    public partial class Register : Form
    {
        public static Users LoggedUser { get; private set; }
        public Register()
        {
            InitializeComponent();
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            if (!TextBox_Login.Text.Equals("") && !TextBox_Password.Text.Equals("")  && !TextBox_Name.Text.Equals("") && !TextBox_LastName.Text.Equals(""))
            {
                UsersRepository.AddUser(TextBox_Login.Text, TextBox_Password.Text, TextBox_Name.Text, TextBox_LastName.Text);
                MessageBox.Show("User Registered!");


                string username = TextBox_Login.Text;
                string password = TextBox_Password.Text;

                LoggedUser = UsersRepository.GetUsers(username, password);

                if (LoggedUser != null && LoggedUser.CheckPassword(password))
                {
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
        }

        private void CheckBox_Password_CheckedChanged(object sender, EventArgs e)
        {
            if ( CheckBox_Password.Checked )
            {
                TextBox_Password.PasswordChar = '\0';
            }
            else
            {
                TextBox_Password.PasswordChar = '*';
            }
        }
    }
}
