using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ImageRepository
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            passBox.UseSystemPasswordChar = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            NewAccount account = new NewAccount();
            account.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User creds = null;
            string uname = userBox.Text;
            string pwd = passBox.Text;

            //if user do not enter value and click on login button show message
            if (String.IsNullOrEmpty(uname) || String.IsNullOrEmpty(pwd))
                msgLabel.Text = "Credentials cannot be empty";
            else if (uname.Equals(" ") || pwd.Equals(" "))
                msgLabel.Text = "Invalid Credentials. Please check username and password";
            else
            {
                User user = new User();
                user.checkLogin(uname, pwd);
                
                this.Hide();
                Repository imgRep = new Repository();
                imgRep.Show();
            }            
        }
    }
}
