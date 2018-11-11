using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPARQLDemo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            if (UsrTextBox.Text == "admin" && pwdTextBox.Text == "admin")
            {
                SPARQLDemo SPARQLDemo2 = new SPARQLDemo();
                SPARQLDemo2.flag = 1;
                SPARQLDemo2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("UserName or Password error, plese try it again\n you also can browser as Guest");

            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            SPARQLDemo sPARQLDemo = new SPARQLDemo();
            sPARQLDemo.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You has cancelled login");
            SPARQLDemo SPARQLDemo3 = new SPARQLDemo();
            SPARQLDemo3.flag = 0;
            SPARQLDemo3.Show();
            this.Hide();
        }
    }
}
