using HiTech_Ryff_2019.DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTech_Ryff_2019.Business
{
    public class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
       
        private string jobTitle;
        

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
       
        public string JobTitle { get => jobTitle; set => jobTitle = value; }

        public void SaveEmployee(Employee emp)
        {
            EmployeeDB.SaveRecord(emp);
        }

        public List<Employee> ListEmployees()
        {
            return EmployeeDB.GetEmployeeList();
        }

        public void UpdateEmployee(Employee emp)
        {
            EmployeeDB.UpdateRecord(emp);
        }

        public Employee SearchEmployee(int id)
        {
            return EmployeeDB.SearchRecord(id);
        }

        public void DeleteEmployee(int id)
        {
            EmployeeDB.DeleteRecord(id);
        }

        public int CreateId()
        {
            return EmployeeDB.GetEmployeeId();
        }

       
    }
}
 