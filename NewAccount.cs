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
using System.Data.Sql;

namespace ImageRepository
{
    public partial class NewAccount : Form
    {

        public NewAccount()
        {
            InitializeComponent();
        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {
            passBox.UseSystemPasswordChar = true;
        }

        private void passBox2_TextChanged(object sender, EventArgs e)
        {
            passBox2.UseSystemPasswordChar = true;
        }

        // establish database connection
        SqlConnection con = new SqlConnection();

        private void submitButton_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            SqlConnection con = db.getConObj();

            //create an instance of SqlDataAdapter to read data
            SqlDataAdapter da = new SqlDataAdapter("spGetCreds", con);

            // execute stored procedure
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            // define parameters of a stored procedure based on user input
            da.SelectCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = userBox.Text;
            da.SelectCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = passBox.Text;

            //store the username and password typed by user into database 
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);

            MessageBox.Show("Account has been successfully created ");

            this.Hide();

        }

    }
}
