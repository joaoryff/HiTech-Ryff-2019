using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace HiTech_Ryff_2019.DataAcess
{
    public static class UtilityDB
    { /// <summary>
      /// This method return an active database connection
      /// </summary>
      /// <returns>an object of type SqlConnection</returns>
      /// 

        static DataSet dsHithecDB;
        static DataTable dtClients;
        static SqlDataAdapter da;
        public static SqlConnection ConnectDB()
        {
            SqlConnection connDB = new SqlConnection();
            //connDB.ConnectionString = "server=LAPTOP-1C5J0JNG;database=HiTech;user=sa;password=wikxn3";
            connDB.ConnectionString = ConfigurationManager.ConnectionStrings["connectionHiTech"].ConnectionString;
            connDB.Open();
            return connDB;

        }


        public static DataSet InitializeDataSet()
        {
            dsHithecDB = new DataSet("HitechDS");

            dtClients = new DataTable("Clients");
            dtClients.Columns.Add("CId", typeof(Int32));
            dtClients.Columns.Add("CName", typeof(string));
            dtClients.Columns.Add("Street", typeof(string));
            dtClients.Columns.Add("City", typeof(string));
            dtClients.Columns.Add("PostalCode", typeof(string));
            dtClients.Columns.Add("Phone", typeof(string));
            dtClients.Columns.Add("FaxNumber", typeof(string));
            dtClients.Columns.Add("Credit", typeof(float));
            dtClients.Columns.Add("CEmail", typeof(string));
            dtClients.PrimaryKey = new DataColumn[] { dtClients.Columns["CId"] };
            dsHithecDB.Tables.Add(dtClients);

           


            da = new SqlDataAdapter("SELECT * FROM Clients", UtilityDB.ConnectDB());
            SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(da);
            da.Fill(dsHithecDB.Tables["Clients"]);


            return dsHithecDB;

        }

        public static void UpdateDBTable(string tableName)
        {
            SqlCommandBuilder swlBuilder = new SqlCommandBuilder(da);
            da.Update(dsHithecDB.Tables[tableName]);
        }

    }
}