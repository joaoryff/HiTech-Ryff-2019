using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTech_Ryff_2019;

namespace HitechEntityFramework
{
    public partial class LogIn : Form
    {
        HiTechEntities dbEntities = new HiTechEntities();
        private int count = 0;
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            //Check duplicate Emloyee ID
            int searchUs = Convert.ToInt32(textBoxUserName.Text.Trim());
            User user = dbEntities.Users.Find(searchUs);


            Employee newEmp = new Employee();
            //Check duplicate Emloyee ID
            int searchEmp = Convert.ToInt32(textBoxUserName.Text.Trim());
            Employee emp = dbEntities.Employees.Find(searchEmp);

            if (emp != null || user != null)
            {

                if (emp.JobTitle == "Sales Manager" && user.EmpId.ToString() == textBoxUserName.Text && user.Password == textBoxPassword.Text)
                {

                    HiTech_Ryff_2019.GUI.Sales myForm = new HiTech_Ryff_2019.GUI.Sales();

                    myForm.ShowDialog();

                    this.Close();
                }

                else if (emp.JobTitle == "MIS Manager" && user.EmpId.ToString() == textBoxUserName.Text && user.Password == textBoxPassword.Text)
                {

                    HiTech_Ryff_2019.MIS myForm = new HiTech_Ryff_2019.MIS();

                    myForm.ShowDialog();
                    this.Close();
                }
                else if (emp.JobTitle == "Order Clerk" && user.EmpId.ToString() == textBoxUserName.Text && user.Password == textBoxPassword.Text)
                {


                    HitechEntityFramework.OrderForm myForm = new HitechEntityFramework.OrderForm();

                    myForm.ShowDialog();
                    this.Close();
                }

                else if (emp.JobTitle == "Accountant" && user.EmpId.ToString() == textBoxUserName.Text && user.Password == textBoxPassword.Text)
                {


                    HitechEntityFramework.Account myForm = new HitechEntityFramework.Account();

                    myForm.ShowDialog();
                    this.Close();

                }

                else if (emp.JobTitle == "Inventory Controller" && user.EmpId.ToString() == textBoxUserName.Text && user.Password == textBoxPassword.Text)
                {


                    HitechEntityFramework.Inventory myForm = new HitechEntityFramework.Inventory();

                    myForm.ShowDialog();
                    this.Close();
                  
                }

                else if (user.EmpId.ToString() == textBoxUserName.Text && user.Password != textBoxPassword.Text)
                {


                    count++;
                    if (count >= 3)
                    {
                        MessageBox.Show("Please contact the system administator.", "Error");
                        this.Hide();

                    }
                    MessageBox.Show("Password is invalid!", "Denied! -rest " + (3 - count) + " attempt(s)");


                }

                
            }


            else/* if (emp == null || user == null)*/
            {
                count++;
                if (count >= 3)
                {
                    MessageBox.Show("Please contact the system administator.", "Error");
                    this.Hide();

                }
                MessageBox.Show("Password is invalid!", "Denied! -rest " + (3 - count) + " attempt(s)");

            }
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to Close this form?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void labelChangepassword_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            //Check duplicate Emloyee ID
            int searchUs = Convert.ToInt32(textBoxUserName.Text.Trim());
            User user = dbEntities.Users.Find(searchUs);
            

            if (user != null)
            {

                if (user.EmpId.ToString() == textBoxUserName.Text && user.Password == textBoxPassword.Text)
                {
                    string us = textBoxUserName.Text.Trim();


                    Userform myForm = new Userform(us);

                    myForm.ShowDialog();
                    this.Close();                  
                }

                else/* if (emp == null || user == null)*/
                {
                    count++;
                    if (count >= 3)
                    {
                        MessageBox.Show("Please contact the system administator.", "Error");
                        this.Hide();

                    }
                    MessageBox.Show("Password is invalid!", "Denied! -rest " + (3 - count) + " attempt(s)");

                }


            }

            else/* if (emp == null || user == null)*/
            {
                count++;
                if (count >= 3)
                {
                    MessageBox.Show("Please contact the system administator.", "Error");
                    this.Hide();

                }
                MessageBox.Show("Id is invalid!", "Denied! -rest " + (3 - count) + " attempt(s)");

            }

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
        //    if (textBoxUserName.Text != "")
        //    {
        //        int Empid = Convert.ToInt32(textBoxUserName.Text);
        //        Employee emp = dbEntities.Employees.Find(Empid);
        //        if (emp != null)
        //        {
        //            var listEmp = from em in dbEntities.Employees select em;

        //            foreach (var em in listEmp)
        //            {

        //                labelUsName.Text = emp.FirstName + ' ' + emp.LastName;
        //                labelJobTitle.Text = emp.JobTitle;

        //            }


        //        }
        //        else
        //        {
        //            labelUsName.Text = "-----";
        //            labelJobTitle.Text = "-----";
        //        }
        //    }
        }
    }
}
    

