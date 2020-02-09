using HiTech_Ryff_2019.Business;
using HiTech_Ryff_2019.DataAcess;
using HiTech_Ryff_2019.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HiTech_Ryff_2019
{
    public partial class MIS : Form
    {
        List<Employee> listEmp;
        public MIS()
        {
            InitializeComponent();
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
                      
            dataGridViewEmployees.DataSource = emp.ListEmployees();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Emplist.Items.Clear();
            if (  Validator.Validator.IsValidName(textBoxFirstName.Text, "Name") &&
                Validator.Validator.IsValidName(textBoxLastName.Text, "Name"))
            { 
                Employee emp = new Employee();
                User use = new User();
                
            int nextEmpId = emp.CreateId();
                comboBoxEmployeeId.Text = nextEmpId.ToString();
            emp.EmployeeId = nextEmpId; 
            emp.FirstName = textBoxFirstName.Text.Trim();
            emp.LastName = textBoxLastName.Text.Trim();
            emp.JobTitle = comboBoxJobTitle.Text.Trim();
                               emp.SaveEmployee(emp);
                use.EmpId = Convert.ToInt32(comboBoxEmployeeId.Text);
                use.Password = comboBoxEmployeeId.Text;

                
                use.SaveUser(use);
                Emplist.Items.Clear();
            }

            else
            {
                MessageBox.Show("Not Save");
            }




        }

        private void UpdateButton_Click(object sender, EventArgs e)
        { Emplist.Items.Clear();
            if (Validator.Validator.IsValidName(textBoxFirstName.Text, "Name") &&
                Validator.Validator.IsValidName(textBoxLastName.Text, "Name"))
            {
                Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(comboBoxEmployeeId.Text.Trim());
            emp.FirstName = textBoxFirstName.Text.Trim();
            emp.LastName = textBoxLastName.Text.Trim();
            emp.JobTitle = comboBoxJobTitle.Text.Trim();
           
            emp.UpdateEmployee(emp);
            }

            else
            {
                MessageBox.Show("Not Save");
            }


        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            int id;
            id = Convert.ToInt32(textBoxSearchEmp.Text.Trim());

            emp = emp.SearchEmployee(id);
            if (emp != null)
            {
                comboBoxEmployeeId.Text = emp.EmployeeId.ToString();
                textBoxFirstName.Text = emp.FirstName;
                textBoxLastName.Text = emp.LastName;
                comboBoxJobTitle.Text = emp.JobTitle;
                
            }
            else
            {
                MessageBox.Show("Employee not found", "Information");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            int id = Convert.ToInt32(comboBoxEmployeeId.Text);
            emp.DeleteEmployee(id);
            Emplist.Items.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to Close this form?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                
            }

           
        }

        private void MIS_Load(object sender, EventArgs e)
        {
            Employee aEmp = new Employee();
           
            listEmp = aEmp.ListEmployees();
            foreach (Employee emp in listEmp)
            {
                comboBoxJobTitle.Items.Add(emp.JobTitle);
            }
        }

        private void comboBoxJobTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
