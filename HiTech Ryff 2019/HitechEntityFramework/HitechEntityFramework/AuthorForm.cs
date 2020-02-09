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
    public partial class AuthorForm : Form
    {
        HiTechEntities dbEntities = new HiTechEntities();
        public AuthorForm()
        {
            InitializeComponent();
        }

        private void SaveInventoryBtn_Click(object sender, EventArgs e)
        {
            Author newAut = new Author();


            var nextval = dbEntities.Authors.Max(autId => autId.AuthorId);
            comboBoxAuthorIDsave.Text = Convert.ToString(nextval + 1);
            newAut.AuthorId = Convert.ToInt32(comboBoxAuthorIDsave.Text);
            

            newAut.FirstName = comboBoxAuthorFname.Text.Trim();
            newAut.LastName = comboBoxAuthorFname.Text.Trim();
           


            dbEntities.Authors.Add(newAut);
            dbEntities.SaveChanges();
            MessageBox.Show("Author saved successfully", "Confirmation");

            

        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            int searchId = Convert.ToInt32(comboBoxAuthorIDsave.Text.Trim());
           Author newAut = dbEntities.Authors.Find(searchId);
            DialogResult Result = MessageBox.Show("Do you want to delete the record?",
        "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
               newAut.AuthorId = Convert.ToInt32(comboBoxAuthorIDsave.Text.Trim());
               newAut.FirstName = comboBoxAuthorFname.Text.Trim();
               newAut.FirstName = comboBoxAuthorFname.Text.Trim();
                  
                 dbEntities.Authors.Remove(newAut);
                dbEntities.SaveChanges();
                MessageBox.Show("Author deleted successfully", "Confirmation");

            }
           comboBoxAuthorIDsave.Items.Clear();
            var listAut = from aut in dbEntities.Authors select aut;
            foreach (var aut in listAut)
            {

                comboBoxAuthorIDsave.Items.Add(aut.AuthorId);
            }

        }

        private void comboBoxAuthorIDsave_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBoxAuthorIDsave.Text);
            Author aut = dbEntities.Authors.Find(id);
            var listAut = from aute in dbEntities.Authors select aute;
            foreach (var aute in listAut)
            {
               //comboBoxAuthorIDsave.Text = aut.AuthorId.ToString();
                comboBoxAuthorFname.Text = aut.FirstName.ToString();
               comboBoxAuthorLName.Text = aut.LastName.ToString();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to Close this form?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBoxAuthorIDsave.Text);
            Author aut = dbEntities.Authors.Find(id);


            aut.FirstName = comboBoxAuthorFname.Text.Trim();
            aut.LastName = comboBoxAuthorLName.Text.Trim();
                                      

            dbEntities.SaveChanges();
            MessageBox.Show("Author updated successfully.", "Confirmation");
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            var listAut = from aut in dbEntities.Authors select aut;
            foreach (var aut in listAut)
            {
                comboBoxAuthorIDsave.Items.Add(aut.AuthorId);
            }
        }
    }
}
