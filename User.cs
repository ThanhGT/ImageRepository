using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ImageRepository
{
    class User
    {
        string userId { get; set; }
        string password { get; set; }

        //create objet of database class object
        Database db = new Database();

        public User()
        {

        }

        //user object with arguments
        public User(string aUserId, string aPassword)
        {

            userId = aUserId;
            password = aPassword;

        }

        public User checkLogin(string checkUserId, string checkPass)
        {
            Database db = new Database();
            SqlConnection con = db.getConObj();
            User user = null;

            DataTable dtbl = new DataTable();

            if (dtbl.Rows.Count > 0)
            {

                DataRow row = dtbl.Rows[0];
                //check if password matches
                row["username"].ToString().Equals(checkUserId);
                row["password"].ToString().Equals(checkPass);
                user = new User(checkUserId, checkPass);

            }

            return user;
        }
    }
}
