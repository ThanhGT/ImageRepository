using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ImageRepository
{
    class Database
    {
        //create sqlconnection object
        private SqlConnection con = new SqlConnection();

        public Database()
        {
            //setup connection string
            con.ConnectionString = @"Data Source=MSI; Initial Catalog=CredentialsDB;Integrated Security=True";

        }

        //return connection object
        public SqlConnection getConObj()
        {
            return con;
        }
    }
}
