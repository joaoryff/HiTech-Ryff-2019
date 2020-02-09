using Microsoft.Office.Interop.Excel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HitechEntityFramework
{
    public partial class Account : Form
    {
        //public static string Path = Application.StartupPath + @"\invoice.xlsx";
        //public static string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + ";Extended Properties=Excel 12.0;";

        HiTechEntities dbEntities = new HiTechEntities();
        public Account()
        {
            InitializeComponent();
        }

        private void buttonInvoice_Click(object sender, EventArgs e)
        {
           

        }

        private void Account_Load(object sender, EventArgs e)
        {
            var InvList = from inv in dbEntities.Invoices select inv;
            listViewInvoice.Items.Clear();
            foreach (var inv in InvList)
            {
                ListViewItem item = new ListViewItem(inv.Oid.ToString());
                item.SubItems.Add(inv.Cid.ToString());
                item.SubItems.Add(inv.IssueDate.ToString());
                item.SubItems.Add(inv.DueDate.ToString());
                item.SubItems.Add(inv.ISBN.ToString());
                item.SubItems.Add(inv.BookName.ToString());
                item.SubItems.Add(inv.Quantity.ToString());
                item.SubItems.Add(inv.UnitPrice.ToString());
                item.SubItems.Add(inv.Total.ToString());
                listViewInvoice.Items.Add(item);
            }
        }

        private void buttonAllO_Click(object sender, EventArgs e)
        {
           

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
            int i = 1;
            int i2 = 2;
            ws.Cells[1, 1] = "Order id";
            ws.Cells[1, 2] = "Client id";
            ws.Cells[1, 3] = "Issue Date";
            ws.Cells[1, 4] = "Due Date";
            ws.Cells[1, 5] = "ISBN";
            ws.Cells[1, 6] = "Book Name";
            ws.Cells[1, 7] = "Quantity Order";
            ws.Cells[1, 8] = "Unit Price";
            ws.Cells[1, 9] = "Total";
               



            foreach (ListViewItem lvi in listViewInvoice.Items)
            {
                i = 1;
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    ws.Cells[i2, i] = lvs.Text;
                    i++;
                }
                i2++;
            }

            ws.Columns.AutoFit();

            this.Close();

        }
    }
}
