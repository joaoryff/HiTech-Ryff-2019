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
   
    public partial class SupplierForm : Form
    {
        HiTechEntities dbEntities = new HiTechEntities();
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void comboBoxAuthorIDsave_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBoxSId.Text);
            Supplier sup = dbEntities.Suppliers.Find(id);
            var listSup = from supe in dbEntities.Suppliers select supe;
            foreach (var supe in listSup)
            {
                comboBoxSName.Text = sup.SName.ToString();
               
            }

        }

        private void SaveSupBtn_Click(object sender, EventArgs e)
        {
            Supplier newsup = new Supplier();


            var nextval = dbEntities.Suppliers.Max(supId => supId.SId);
            comboBoxSId.Text = Convert.ToString(nextval + 1);
            newsup.SId = Convert.ToInt32(comboBoxSId.Text);


            newsup.SName = comboBoxSName.Text.Trim();
           


            dbEntities.Suppliers.Add(newsup);
            dbEntities.SaveChanges();
            MessageBox.Show("Supplier saved successfully", "Confirmation");

        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            int searchId = Convert.ToInt32(comboBoxSId.Text.Trim());
            Supplier newsup = dbEntities.Suppliers.Find(searchId);
            DialogResult Result = MessageBox.Show("Do you want to delete the record?",
        "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                newsup.SId = Convert.ToInt32(comboBoxSId.Text.Trim());
                newsup.SName = comboBoxSName.Text.Trim();
               

                dbEntities.Suppliers.Remove(newsup);
                dbEntities.SaveChanges();
                MessageBox.Show("Supplier deleted successfully", "Confirmation");

            }
            comboBoxSId.Items.Clear();
            var listSup = from sup in dbEntities.Suppliers select sup;
            foreach (var sup in listSup)
            {

              comboBoxSId.Items.Add(sup.SId);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBoxSId.Text);
            Supplier sup = dbEntities.Suppliers.Find(id);


            sup.SName = comboBoxSName.Text.Trim();
           
            
            dbEntities.SaveChanges();
            MessageBox.Show("Supplier updated successfully.", "Confirmation");
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            var listSup = from sup in dbEntities.Suppliers select sup;
            foreach (var sup in listSup)
            {
                comboBoxSId.Items.Add(sup.SId);
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
