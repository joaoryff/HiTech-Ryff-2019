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
    public partial class OrderForm : Form
    {
       HiTechEntities dbEntities = new HiTechEntities();
        public OrderForm()
        {
            InitializeComponent();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {  
            Order newOrd = new Order();
           
            

                var nextval = dbEntities.Orders.Max(oid => oid.OId);
               ComboBoxOid.Text = Convert.ToString(nextval + 1);
                newOrd.OId = Convert.ToInt32(ComboBoxOid.Text.Trim());
            

            
            newOrd.OrderDate = Convert.ToDateTime(dateTimePickerOrder.Text);
            newOrd.ReqDate = Convert.ToDateTime(dateTimePickerReq.Text);
            newOrd.ShipDate = Convert.ToDateTime(dateTimePickerShip.Text);
            newOrd.CId = Convert.ToInt32(ComboBoxClientIdO.Text);
            newOrd.QoO = Convert.ToInt32(TextBoxQOrder.Text);
            newOrd.ISBN = ComboBoxBookO.Text;

            Book newBook = new Book();
            string searchISBN = ComboBoxBookO.Text.Trim();
            Book book = dbEntities.Books.Find(searchISBN);
            book.QoH = book.QoH - Convert.ToInt32(newOrd.QoO);

            newOrd.Total = Convert.ToDouble(book.Price)*Convert.ToInt64(newOrd.QoO);


            Client cli = new Client();
            int searchClient = Convert.ToInt32(ComboBoxClientIdO.Text.Trim());
            Client cl = dbEntities.Clients.Find(searchClient);
            cl.Credit = Convert.ToDouble(cl.Credit - newOrd.Total);
                              

            

            dbEntities.Orders.Add(newOrd);
            dbEntities.SaveChanges();
            MessageBox.Show("Order saved successfully", "Confirmation");


            ComboBoxOid.Items.Clear();
            var listOrder = from orde in dbEntities.Orders select orde;
            foreach (var orde in listOrder)
            {
                
                ComboBoxOid.Items.Add(orde.OId);
            }




        }

        private void OrderForm_Load(object sender, EventArgs e)

        {
            dateTimePickerOrder.Value = DateTime.Now;
            dateTimePickerReq.MinDate = DateTime.Now.AddDays(1);
            dateTimePickerShip.Value = dateTimePickerReq.Value.AddDays(-1);
           
            var listBook = from book in dbEntities.Books select book;
            foreach (var book in listBook)
            {
                ComboBoxBookO.Items.Add(book.ISBN);
                //labelUnPrice.Text = book.Price.ToString();
            }

            var listClient = from cli in dbEntities.Clients select cli;
            foreach (var cli in listClient)
            {
                ComboBoxClientIdO.Items.Add(cli.CId);
            }

            var listOrder = from ord in dbEntities.Orders select ord;
            foreach (var ord in listOrder)
            {
                ComboBoxOid.Items.Add(ord.OId);
            }

           

           
        }

        private void buttonUpdateO_Click(object sender, EventArgs e)
        {
            int searchId = Convert.ToInt32(ComboBoxOid.Text.Trim());
            Order newOrd = dbEntities.Orders.Find(searchId);

            
            newOrd.ReqDate = Convert.ToDateTime(dateTimePickerReq.Text);
            newOrd.ShipDate = Convert.ToDateTime(dateTimePickerShip.Text);
            newOrd.CId = Convert.ToInt32(ComboBoxClientIdO.Text);
            

            string searchISBN = ComboBoxBookO.Text.Trim();
            Book book = dbEntities.Books.Find(searchISBN);
            
             book.QoH = book.QoH + newOrd.QoO-Convert.ToInt32(TextBoxQOrder.Text);
            //MessageBox.Show((newOrd.QoO - Convert.ToInt32(TextBoxQOrder.Text)).ToString());

            newOrd.QoO = Convert.ToInt32(TextBoxQOrder.Text);
            newOrd.Total = Convert.ToDouble(book.Price) * Convert.ToInt64(newOrd.QoO);
                      
            newOrd.ISBN = ComboBoxBookO.Text;

            Client cli = new Client();
            int searchClient = Convert.ToInt32(ComboBoxClientIdO.Text.Trim());
            Client cl = dbEntities.Clients.Find(searchClient);
            cl.Credit =Convert.ToDouble( cl.Credit-newOrd.Total);


            dbEntities.SaveChanges();
            MessageBox.Show("Order updated successfully.", "Confirmation");



           
        }

        private void dateTimePickerShip_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePickerReq_ValueChanged(object sender, EventArgs e)
        {
           
                //dateTimePickerReq.Value = DateTime.Now.AddDays(1);
            dateTimePickerShip.Value = dateTimePickerReq.Value.AddDays(-1);
           
            
        }

        private void buttonAllO_Click(object sender, EventArgs e)
        {
            var OrderList = from ord in dbEntities.Orders select ord;
            listViewOrder.Items.Clear();
            foreach (var ord  in OrderList)
            {
                ListViewItem item = new ListViewItem(ord.OId.ToString());
                item.SubItems.Add(ord.OrderDate.ToString());
                item.SubItems.Add(ord.ReqDate.ToString());
                item.SubItems.Add(ord.ShipDate.ToString());
                item.SubItems.Add(ord.CId.ToString());
                item.SubItems.Add(ord.QoO.ToString());
                item.SubItems.Add(ord.ISBN.ToString());
                item.SubItems.Add(ord.Total.ToString());
                listViewOrder.Items.Add(item);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            int searchId = Convert.ToInt32(ComboBoxOid.Text.Trim());
            Order newOrder = dbEntities.Orders.Find(searchId);
            DialogResult Result = MessageBox.Show("Do you want to delete the record?",
        "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                newOrder.OId = Convert.ToInt32(ComboBoxOid.Text.Trim());
                newOrder.OrderDate = Convert.ToDateTime(dateTimePickerOrder.Text);
                newOrder.ReqDate = Convert.ToDateTime(dateTimePickerReq.Text);
                newOrder.ShipDate = Convert.ToDateTime(dateTimePickerReq.Text);
                newOrder.CId = Convert.ToInt32(ComboBoxClientIdO.Text.Trim());


                Book newBook = new Book();                
                string searchISBN = ComboBoxBookO.Text.Trim();
                Book book = dbEntities.Books.Find(searchISBN);
                book.QoH = book.QoH + newOrder.QoO;

                newOrder.QoO = Convert.ToInt32(TextBoxQOrder.Text.Trim());

                Client cli = new Client();
                int searchClient = Convert.ToInt32(ComboBoxClientIdO.Text.Trim());
                Client cl = dbEntities.Clients.Find(searchClient);
                cl.Credit = Convert.ToDouble(cl.Credit + newOrder.Total);


                newOrder.Total = Convert.ToDouble(labelTotal.Text);
                newOrder.ISBN = ComboBoxBookO.Text.Trim();

                dbEntities.Orders.Remove(newOrder);
                dbEntities.SaveChanges();
                MessageBox.Show("Order canceled successfully", "Confirmation");
                          
                 }

            ComboBoxOid.Items.Clear();
            var listOrder = from orde in dbEntities.Orders select orde;
            foreach (var orde in listOrder)
            {
                
                ComboBoxOid.Items.Add(orde.OId);
            }

        }

        private void ComboBoxOid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Orderid = Convert.ToInt32(ComboBoxOid.Text);
            Order ord = dbEntities.Orders.Find(Orderid);
            var listOrder = from orde in dbEntities.Orders select orde;
            foreach (var orde in listOrder)
            {
                ComboBoxOid.Text = ord.OId.ToString();
                dateTimePickerOrder.Text = ord.OrderDate.ToString();
                //dateTimePickerReq.Text = ord.ReqDate.ToString();
                //dateTimePickerShip.Text = ord.ShipDate.ToString();
                ComboBoxClientIdO.Text = ord.CId.ToString();
                TextBoxQOrder.Text = ord.QoO.ToString();
                labelTotal.Text = ord.Total.ToString();
                ComboBoxBookO.Text = ord.ISBN.ToString();
            }
           
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to Close this form?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonSearchO_Click(object sender, EventArgs e)
        {
            int searchId = Convert.ToInt32(textSearchO.Text.Trim());
            Order ord = dbEntities.Orders.Find(searchId);
            if (ord != null)
            {
                ComboBoxOid.Text = ord.OId.ToString();
                dateTimePickerOrder.Text = ord.OrderDate.ToString();
                //dateTimePickerReq.Text = ord.ReqDate.ToString();
                dateTimePickerShip.Text = ord.ShipDate.ToString();
                ComboBoxClientIdO.Text = ord.CId.ToString();
                TextBoxQOrder.Text = ord.QoO.ToString();
                TextBoxQOrder.Text = ord.Total.ToString();
                ComboBoxBookO.Text = ord.ISBN.ToString();


            }
            else
            {
                MessageBox.Show("Order not exist in the DB", "Warning");

            }

               
            }

        private void dateTimePickerOrder_ValueChanged(object sender, EventArgs e)
        {
            
            //dateTimePickerOrder.Value = DateTime.Now;
        }

        private void ComboBoxClientIdO_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Clientid = Convert.ToInt32(ComboBoxClientIdO.Text);
            Client cli = dbEntities.Clients.Find(Clientid);
            var listClient = from clie in dbEntities.Clients select clie;
            foreach (var clie in listClient)
            {

               labelCredit.Text = cli.Credit.ToString();
                
            }
        }

        private void ComboBoxBookO_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Bookid = ComboBoxBookO.Text;
            Book bok = dbEntities.Books.Find(Bookid);
            var listBook = from book in dbEntities.Books select book;
            foreach (var book in listBook)
            {

                labelUnPrice.Text = bok.Price.ToString();
                labelQdisp.Text = bok.QoH.ToString();
            }

        }

        private void TextBoxQOrder_TextChanged(object sender, EventArgs e)
        {


            //if (!string.IsNullOrEmpty(this.TextBoxQOrder.Text))
            //{

            //    string searchISBN = ComboBoxBookO.Text.Trim();
            //Book book = dbEntities.Books.Find(searchISBN);
            //var listBook = from bok in dbEntities.Books select bok;
            //foreach (var bok in listBook)
            //{
              

            //        labelTotal.Text = Convert.ToString(bok.Price * Convert.ToInt64(TextBoxQOrder.Text));
            //        labelQdisp.Text = Convert.ToString(bok.QoH - Convert.ToInt32(TextBoxQOrder.Text));
            //    }
            //}

           



        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelQdisp_Click(object sender, EventArgs e)
        {

        }

        private void buttonForPay_Click(object sender, EventArgs e)
        {
            Order newOrd = new Order();
            Invoice newInvoice = new Invoice();


            
            Invoice inv = dbEntities.Invoices.Find(Convert.ToInt32(ComboBoxOid.Text.Trim()));
            if (inv != null)

            {
                MessageBox.Show("Duplicate Order!", "Error");

                return;
            }
            else
            {
                newInvoice.Oid = Convert.ToInt32(ComboBoxOid.Text);

            }
                                                         

            newInvoice.Oid = Convert.ToInt32(ComboBoxOid.Text);
                newInvoice.Cid = Convert.ToInt32(ComboBoxClientIdO.Text); 

                Client cli = dbEntities.Clients.Find(newInvoice.Cid);
                newInvoice.ClientName = cli.CName;

                newInvoice.IssueDate = DateTime.Now;
                newInvoice.DueDate = newInvoice.IssueDate.Value.AddDays(30);
                newInvoice.ISBN = ComboBoxBookO.Text;


            Book book = dbEntities.Books.Find(newInvoice.ISBN.ToString());
                newInvoice.BookName = book.Title;
                newInvoice.UnitPrice = book.Price;

                newInvoice.Quantity = Convert.ToInt32(TextBoxQOrder.Text);

            newInvoice.Total = newInvoice.Quantity * newInvoice.UnitPrice;

               
                dbEntities.Invoices.Add(newInvoice);  
                                   
                dbEntities.SaveChanges();

                MessageBox.Show("Invoice saved successfully", "Confirmation");                      
          
        }
    }
}
