using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTech_Ryff_2019.Business;

namespace HiTech_Ryff_2019.DataAcess
{
    class UserDA
    {
        public static List<User> GetUserList()
        {
            List<User> listUser = new List<User>();
            // Connect and open database
            SqlConnection connDB = UtilityDB.ConnectDB();
            // Perform insert statement
            //create an object of type SqlCommand
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "SELECT * FROM Users";
            SqlDataReader sqlReader = cmd.ExecuteReader();
            User use;
            while (sqlReader.Read())
            {
               use = new User();
               use.EmpId = Convert.ToInt32(sqlReader["EmpId"]);
                use.Password = sqlReader["Password"].ToString();

                listUser.Add(use);
            }
            // close database
            connDB.Close();
            return listUser;
        }


        public static void SaveRecordU(User use)
        {
            // Connect and open database
            SqlConnection connDB = UtilityDB.ConnectDB();
            // Perform insert statement
            //create an object of type SqlCommand
            SqlCommand cmdu = new SqlCommand();
            cmdu.Connection = connDB;
            string sqlInsertu = "INSERT INTO Users " +
                               "(EmpId,Password)" +
                               " VALUES (@EmpId,@Password)";
            cmdu.Parameters.AddWithValue("@EmpId", use.EmpId);
            cmdu.Parameters.AddWithValue("@Password", use.Password);
            
            cmdu.CommandText = sqlInsertu;
            cmdu.ExecuteNonQuery();

            connDB.Close();
            
        }



    }
}
