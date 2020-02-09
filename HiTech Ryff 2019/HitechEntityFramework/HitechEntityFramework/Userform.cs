using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitechEntityFramework
{
    public partial class Userform : Form
    {
        int count;
        HiTechEntities dbEntities = new HiTechEntities();
        public Userform()
        {
            InitializeComponent();
        }

        public Userform(string us)
        {
            InitializeComponent();
            EmpidtxtU.Text = us; //O label está recebendo o valor que foi recebido por parâmetro
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            
            
           
            int searchId = Convert.ToInt32(EmpidtxtU.Text.Trim());
            User us = dbEntities.Users.Find(searchId);

            if (textBoxOldpassword.Text == us.Password)
            {
                us.Password = textBoxNewPassword.Text.Trim();

                dbEntities.SaveChanges();

                MessageBox.Show("Password saved successfully", "Confirmation");
            }
            else
            {
                count++;
                if (count >= 3)
                {
                    MessageBox.Show("Please contact the system administator.", "Error");
                    this.Hide();

                }
                MessageBox.Show("Old Password is invalid!", "Denied! -rest " + (3 - count) + " attempt(s)");
              
               
            }

        }

        private void EmpidtxtU_TextChanged(object sender, EventArgs e)
        {
            int Empid = Convert.ToInt32(EmpidtxtU.Text);
            Employee emp = dbEntities.Employees.Find(Empid);
            if (emp != null)
            {
                var listEmp = from em in dbEntities.Employees select em;

                foreach (var em in listEmp)
                {

                    TextBoxEmpfnameU.Text = emp.FirstName;
                    TextBoxEmplnameU.Text = emp.LastName;
                    TextBoxJobU.Text = emp.JobTitle;

                }


            }
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to Close this form?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
