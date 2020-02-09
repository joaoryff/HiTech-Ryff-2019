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
    public partial class PublisherForm : Form
    {
        HiTechEntities dbEntities = new HiTechEntities();
        public PublisherForm()
        {
            InitializeComponent();
        }

        private void PublisherForm_Load(object sender, EventArgs e)
        {
            var listpub = from pub in dbEntities.Publishers select pub ;
            foreach (var pub in listpub)
            {
                comboBoxPId.Items.Add(pub.PId);
            }
        }

        private void SaveInventoryBtn_Click(object sender, EventArgs e)
        {
           Publisher newpub = new Publisher();


            var nextval = dbEntities.Publishers.Max(pId => pId.PId);
            comboBoxPId.Text = Convert.ToString(nextval + 1);
            newpub.PId = Convert.ToInt32(comboBoxPId.Text);


           newpub.PName = comboBoxPname.Text.Trim();
            newpub.WebSite = comboBoxPWeb.Text.Trim();



            dbEntities.Publishers.Add(newpub);
            dbEntities.SaveChanges();
            MessageBox.Show("Publisher saved successfully", "Confirmation");
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {

            int searchId = Convert.ToInt32(comboBoxPId.Text.Trim());
           Publisher newpub = dbEntities.Publishers.Find(searchId);
            DialogResult Result = MessageBox.Show("Do you want to delete the record?",
        "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                newpub.PId = Convert.ToInt32(comboBoxPId.Text.Trim());
                newpub.PName = comboBoxPname.Text.Trim();
                newpub.WebSite = comboBoxPWeb.Text.Trim();

                dbEntities.Publishers.Remove(newpub);
                dbEntities.SaveChanges();
                MessageBox.Show("Publisher deleted successfully", "Confirmation");

            }
            comboBoxPId.Items.Clear();
            var listpub = from pub in dbEntities.Publishers select pub;
            foreach (var pub in listpub)
            {

                comboBoxPId.Items.Add(pub.PId);
            }
        }

        private void comboBoxPId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBoxPId.Text);
            Publisher pub = dbEntities.Publishers.Find(id);
            var listpub = from pube in dbEntities.Publishers select pube;
            foreach (var pube in listpub)
            {
                //comboBoxAuthorIDsave.Text = aut.AuthorId.ToString();
                comboBoxPname.Text = pub.PName.ToString();
                comboBoxPWeb.Text = pub.WebSite.ToString();
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
            int id = Convert.ToInt32(comboBoxPId.Text);
            Publisher pub = dbEntities.Publishers.Find(id);


           pub.PName= comboBoxPname.Text.Trim();
           pub.WebSite = comboBoxPWeb.Text.Trim();


            dbEntities.SaveChanges();
            MessageBox.Show("Publisher updated successfully.", "Confirmation");
        }
    }
}
