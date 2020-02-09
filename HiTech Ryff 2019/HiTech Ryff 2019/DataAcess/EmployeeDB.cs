using HiTech_Ryff_2019.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiTech_Ryff_2019.DataAcess
{
    public static class EmployeeDB
    {
        public static List<Employee> GetEmployeeList()
        {
            List<Employee> listEmp = new List<Employee>();
            // Connect and open database
            SqlConnection connDB = UtilityDB.ConnectDB();
            // Perform insert statement
            //create an object of type SqlCommand
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "SELECT * FROM Employees";
            SqlDataReader sqlReader = cmd.ExecuteReader();
            Employee emp;
            while (sqlReader.Read())
            {
                emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmpId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();
               

                listEmp.Add(emp);
            }
            // close database
            connDB.Close();
            return listEmp;
        }
        public static void UpdateRecord(Employee emp)
        {
            //Connect and open the database : SqlConnection
            SqlConnection connDb = UtilityDB.ConnectDB();

            // Perform the Update operation : SqlCommand
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = connDb;
            sqlCmd.CommandText = "Update Employees " +
                                 "SET EmpId = " + emp.EmployeeId + "," +
                                 "    FirstName = '" + emp.FirstName + "'," +
                                 "    LastName = '" + emp.LastName + "'," +
                                 "    JobTitle = '" + emp.JobTitle +
                                  "'" + " WHERE EmpId =" + emp.EmployeeId;

            sqlCmd.ExecuteNonQuery();

            //Close the database
            connDb.Close();
            MessageBox.Show("Employee record has been updated successully..", "Confirmation");
        }

        public static Employee SearchRecord(int empId)
        {
            Employee emp = new Employee();

            // Connect Database
            SqlConnection connDB = UtilityDB.ConnectDB();

            // Create SQl command
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connDB;

            // Create the Select Statement
            cmd.CommandText = "SELECT * FROM Employees" +
                              " WHERE EmpId = " + empId;

            SqlDataReader sqlReader = cmd.ExecuteReader();

            if (sqlReader.Read())
            {
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmpId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();
               
            }
            else
            {
                emp = null;
            }
            return emp;
        }
        public static void DeleteRecord(int empId)
        {
            SqlConnection conndb = UtilityDB.ConnectDB();
            try
            {

                string sqlDelete = "DELETE from Employees " +
                               " WHERE EmpId = " + empId;

                string sqlDeleteUser = "DELETE from Users " +
                               " WHERE EmpId = " + empId;

                SqlCommand cmd = new SqlCommand(sqlDelete, conndb);
                SqlCommand cmdu = new SqlCommand(sqlDeleteUser, conndb);
                cmdu.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted Successfully.");

            }
            catch (FormatException)
            {
                throw;
            }
            finally
            {
                conndb.Close();
            }
        }

        public static void SaveRecord(Employee emp)
        {
            // Connect and open database
            SqlConnection connDB = UtilityDB.ConnectDB();
            // Perform insert statement
            //create an object of type SqlCommand
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            string sqlInsert = "INSERT INTO Employees " +
                               "(EmpId,FirstName,LastName,JobTitle)" +
                               " VALUES (@EmpId,@FirstName,@LastName,@JobTitle)";
            cmd.Parameters.AddWithValue("@EmpId", emp.EmployeeId);
            cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmd.Parameters.AddWithValue("@LastName", emp.LastName);
            cmd.Parameters.AddWithValue("@JobTitle", emp.JobTitle);
           
            cmd.CommandText = sqlInsert;
            cmd.ExecuteNonQuery();

            connDB.Close();
            MessageBox.Show("Employee record has been saved successfully", "Confirmation");
        }
        public static int GetEmployeeId()
        {
            int nextId = 1112;
            // connect and open the database
            SqlConnection connDB = UtilityDB.ConnectDB();
            // create and customize the SqlCommand object
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT max(EmpId) as TempId " +
                              " FROM Employees";
            cmd.Connection = connDB;
            SqlDataReader sqlReader = cmd.ExecuteReader();
            if (sqlReader.Read())
            {
                if (!sqlReader.IsDBNull(0))
                {
                    nextId = Convert.ToInt32(sqlReader["TempId"]) + 1;
                }

            }
            // close the database
            connDB.Close();
            //return the nextId
            return nextId;
        }
        


        
    }
}
