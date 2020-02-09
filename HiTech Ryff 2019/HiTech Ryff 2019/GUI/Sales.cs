using HiTech_Ryff_2019.Business;
using HiTech_Ryff_2019.DataAcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiTech_Ryff_2019.GUI
{
    public partial class Sales : Form
    {
        SqlDataAdapter da;
        DataSet dsHiTech;
        DataTable dtClients;
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            dsHiTech = UtilityDB.InitializeDataSet();
            dtClients = dsHiTech.Tables["Clients"];

           
            //dataGridViewSales.DataSource = dsHiTech.Tables["Clients"];
        }

        private void salesButtonAdd_Click(object sender, EventArgs e)
        {
            if (Validator.Validator.IsValidEmail(salesTextBoxEmail.Text, "E-mail") )
            {

                Client aClient = new Client

                {
                    CId = Convert.ToInt32(salesTextBoxClientId.Text.Trim()),
                    CName = salesTextBoxClientName.Text.Trim(),
                    Street = salesTextBoxStreet.Text.Trim(),
                    City = salesTextBoxCity.Text.Trim(),
                    PostalCode = salesMaskedTextBoxPCode.Text.Trim(),
                    Phone = salesMaskedTextBoxPhone.Text.Trim(),
                    FaxNumber = salesMaskedTextBoxFax.Text.Trim(),
                    Credit = Convert.ToInt64(salesTextBoxCreditLimit.Text.Trim()),
                    Cemail = salesTextBoxEmail.Text.Trim()
                };



                //Add Student Object data to the DataTable students
                dtClients.Rows.Add(aClient.CId, aClient.CName, aClient.Street, aClient.City, aClient.PostalCode, aClient.Phone,
                    aClient.FaxNumber, aClient.Credit, aClient.Cemail);
            }

            else
            {
                MessageBox.Show("E-mail not valid");
            }

            dataGridViewSales.DataSource = dsHiTech.Tables["Clients"];
            labelDSInfo.Visible = true;
            LabelDBinfo.Visible = false;
        }

        private void salesButtonList_Click(object sender, EventArgs e)
        {
            labelDSInfo.Visible = false;
            LabelDBinfo.Visible = true;
            da = new SqlDataAdapter("SELECT * FROM Clients", UtilityDB.ConnectDB());
            da.Fill(dsHiTech.Tables["Clients"]);
            dataGridViewSales.DataSource = dsHiTech.Tables["Clients"];
        }

        private void salesButtonUpdate_Click(object sender, EventArgs e)
        {
            UtilityDB.UpdateDBTable("Clients");
            MessageBox.Show("Database has been updated successfully", "Update Database", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void salesButtonModify_Click(object sender, EventArgs e)
        {
            labelDSInfo.Visible = true;
            LabelDBinfo.Visible = false;
            int searchId = Convert.ToInt32(salesTextBoxClientId.Text);

            DataRow drClient = dtClients.Rows.Find(searchId);
            if (drClient != null)
            {
                drClient["CId"] = Convert.ToInt32(salesTextBoxClientId.Text.Trim());
                drClient["CName"] = salesTextBoxClientName.Text.Trim();
                drClient["Street"] = salesTextBoxStreet.Text.Trim();
                drClient["City"] = salesTextBoxCity.Text.Trim();
                drClient["PostalCode"] = salesMaskedTextBoxPCode.Text.Trim();
                drClient["Phone"] = salesMaskedTextBoxPhone.Text.Trim();
                drClient["FaxNumber"] = salesMaskedTextBoxFax.Text.Trim();
                drClient["Credit"] = Convert.ToInt64(salesTextBoxCreditLimit.Text.Trim());
                drClient["CEmail"] = salesTextBoxEmail.Text.Trim();
                                             
                MessageBox.Show(drClient.RowState.ToString());

            }
            else
            {
                MessageBox.Show("Student not found", "Wrong student ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salesButtonSearch_Click(object sender, EventArgs e)
        {
            if (salesTextBoxSearch.Text == "") { return; }

            int searchId = Convert.ToInt32(salesTextBoxSearch.Text);

            DataRow drClient = dtClients.Rows.Find(searchId);
            if (drClient != null)
            {
                salesTextBoxClientId.Text= drClient["CId"].ToString();
                salesTextBoxClientName.Text = drClient["CName"].ToString();
                salesTextBoxStreet.Text = drClient["Street"].ToString();
                salesTextBoxCity.Text = drClient["City"].ToString();
                salesMaskedTextBoxPCode.Text = drClient["PostalCode"].ToString();
                salesMaskedTextBoxPhone.Text = drClient["Phone"].ToString();
                salesMaskedTextBoxFax.Text = drClient["FaxNumber"].ToString();
                salesTextBoxCreditLimit.Text = drClient["Credit"].ToString();
                salesTextBoxEmail.Text = drClient["CEmail"].ToString();
            }

            else
            {
                MessageBox.Show("Client not found", "Wrong ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                salesTextBoxClientId.Clear();
                salesTextBoxClientName.Clear();
                salesTextBoxStreet.Clear();
                salesTextBoxCity.Clear();
                salesMaskedTextBoxPCode.Clear();
                salesMaskedTextBoxPhone.Clear();
                salesMaskedTextBoxFax.Clear();
                salesTextBoxCreditLimit.Clear();
                salesTextBoxEmail.Clear();
            }

        }

        private void salesButtonDelete_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you really want to delete this Client?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                int searchId = Convert.ToInt32(salesTextBoxClientId.Text);
                DataRow drClient = dtClients.Rows.Find(searchId);
               drClient.Delete();
                MessageBox.Show("Client deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to Close this form?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonListDS_Click(object sender, EventArgs e)
        {
            dataGridViewSales.Refresh();
            dataGridViewSales.DataSource = dsHiTech.Tables["Clients"];
        }

        private void dataGridViewSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void buttonListDS_Click(object sender, EventArgs e)
        //{
        //    dataGridViewSales.Refresh();
        //    dataGridViewSales.DataSource = dsHiTech.Tables["Clients"];
        //}
    }
}
