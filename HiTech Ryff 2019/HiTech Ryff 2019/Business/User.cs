using HiTech_Ryff_2019.DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTech_Ryff_2019.Business
{
    class User
    {
        private int empId;
        private string password;

        public int EmpId { get => empId; set => empId = value; }
        public string Password { get => password; set => password = value; }



        public void SaveUser(User use)
        {
            UserDA.SaveRecordU(use);
        }

        public List<User> ListUsers()
        {
            return UserDA.GetUserList();
        }

    }
}
