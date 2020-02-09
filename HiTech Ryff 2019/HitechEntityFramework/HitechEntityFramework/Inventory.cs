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
    
    public partial class Inventory : Form
    {
        HiTechEntities dbEntities = new HiTechEntities();
         
        public Inventory()
        {
            InitializeComponent();
        }

        private void SaveInventoryBtn_Click(object sender, EventArgs e)
        {
            Book newBook = new Book();
            //Check duplicate Emloyee ID
            string searchId = comboBoxISBN.Text.Trim();
            Book book = dbEntities.Books.Find(searchId);
            if (book != null)

            {
                MessageBox.Show("Duplicate ISBN!", "Error");

                return;
            }
            else
            {
                newBook.ISBN = comboBoxISBN.Text.Trim();
            }

            //newBook.ISBN = comboBoxISBN.Text.Trim();
            newBook.Title = textBoxTitle.Text.Trim();
            newBook.Price = Convert.ToDouble(TextBoxPrice.Text.Trim());
            newBook.QoH = Convert.ToInt32(textBoxQOH.Text.Trim());
            newBook.Year = Convert.ToInt32(textBoxYear.Text.Trim());
            newBook.PId = Convert.ToInt32(comboBoxPublisher.Text.Trim());
            newBook.SId = Convert.ToInt32(comboBoxSupplier.Text.Trim());
            newBook.AuthorId = Convert.ToInt32(comboBoxAuthorID.Text.Trim());
            
            dbEntities.Books.Add(newBook);
            dbEntities.SaveChanges();
            MessageBox.Show("Book saved successfully", "Confirmation");
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            IQueryable<Book> listBook = from book in dbEntities.Books select book;
            
            foreach (var book in listBook)
            {
                comboBoxISBN.Items.Add(book.ISBN);
            }
            var listAuthor = from aut in dbEntities.Authors select aut;
            foreach (var aut in listAuthor)
            {
                comboBoxAuthorID.Items.Add(aut.AuthorId);
            }

            var listSupllier = from sup in dbEntities.Suppliers select sup;
            foreach (var sup in listSupllier)
            {
                comboBoxSupplier.Items.Add(sup.SId);
            }

            var listPublisher = from pub in dbEntities.Publishers select pub;
            foreach (var pub in listPublisher)
            {
                comboBoxPublisher.Items.Add(pub.PId);
            }

            
        }

        private void ListInventoryBtn_Click(object sender, EventArgs e)
        {
            var BookList = from book in dbEntities.Books select book;
            ListViewProduct.Items.Clear();
            foreach (var book in BookList)
            {
                ListViewItem item = new ListViewItem(book.ISBN);
                item.SubItems.Add(book.Title);
                item.SubItems.Add(book.Price.ToString());
                item.SubItems.Add(book.QoH.ToString());
                item.SubItems.Add(book.Year.ToString());
                item.SubItems.Add(book.PId.ToString());
                item.SubItems.Add(book.SId.ToString());
                item.SubItems.Add(book.AuthorId.ToString());
                ListViewProduct.Items.Add(item);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to Close this form?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void UpdateInventoryBtn_Click(object sender, EventArgs e)
        {
            string searchId = comboBoxISBN.Text.Trim();
            Book newBook = dbEntities.Books.Find(searchId);
            //newBook.ISBN = comboBoxISBN.Text.Trim();
            newBook.Title = textBoxTitle.Text.Trim();
            newBook.Price = Convert.ToDouble(TextBoxPrice.Text.Trim());
            newBook.QoH = Convert.ToInt32(textBoxQOH.Text.Trim());
            newBook.Year = Convert.ToInt32(textBoxYear.Text.Trim());
            newBook.PId = Convert.ToInt32(comboBoxPublisher.Text.Trim());
            newBook.SId = Convert.ToInt32(comboBoxSupplier.Text.Trim());
            newBook.AuthorId = Convert.ToInt32(comboBoxAuthorID.Text.Trim());
            dbEntities.SaveChanges();
            MessageBox.Show("Book updated successfully.", "Confirmation");
        }

        private void DelInventoryBtn_Click(object sender, EventArgs e)
        {
           

            string searchId = comboBoxISBN.Text.Trim();
            Book newBook = dbEntities.Books.Find(searchId);
            DialogResult Result = MessageBox.Show("Do you want to delete the record?",
        "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {

                newBook.ISBN = comboBoxISBN.Text.Trim();
                newBook.Title = textBoxTitle.Text.Trim();
                newBook.Price = Convert.ToDouble(TextBoxPrice.Text.Trim());
                newBook.QoH = Convert.ToInt32(textBoxQOH.Text.Trim());
                newBook.Year = Convert.ToInt32(textBoxYear.Text.Trim());
                newBook.PId = Convert.ToInt32(comboBoxPublisher.Text.Trim());
                newBook.SId = Convert.ToInt32(comboBoxSupplier.Text.Trim());
                newBook.AuthorId = Convert.ToInt32(comboBoxAuthorID.Text.Trim());

                dbEntities.Books.Remove(newBook);
                dbEntities.SaveChanges();
                MessageBox.Show("Book deleted successfully", "Confirmation");
                
            }

        }

        private void SearchInventoryBtn_Click(object sender, EventArgs e)
        {
            
            

                    string searchId = textBoxSearch.Text.Trim();
                    Book book = dbEntities.Books.Find(searchId);
                    if (book != null)
                    {
                        comboBoxISBN.Text = book.ISBN;
                        textBoxTitle.Text=book.Title;
                        TextBoxPrice.Text = book.Price.ToString();
                        textBoxQOH.Text = book.QoH.ToString();
                        textBoxYear.Text = book.Year.ToString();
                        comboBoxPublisher.Text = book.PId.ToString();
                        comboBoxSupplier.Text = book.SId.ToString();
                        comboBoxAuthorID.Text = book.AuthorId.ToString();
                                                                                                      

                    }
                    else
                    {
                var listBook = dbEntities.Books.Where(tl => tl.Title == textBoxSearch.Text).ToList<Book>();
                // if (listEmp != null) :Problem
                if (listBook.Count != 0)
                {
                    foreach (var bk in listBook)
                    {
                        //MessageBox.Show( bk.ISBN.ToString()+ ", " + bk.Title.ToString()
                        //                    + ", " + bk.Price.ToString());
                        ListViewProduct.Items.Clear();
                        comboBoxISBN.ResetText();
                        textBoxTitle.Clear();
                        TextBoxPrice.Clear();
                        textBoxQOH.Clear();
                        textBoxYear.Clear();
                        comboBoxPublisher.ResetText();
                        comboBoxSupplier.ResetText();
                        comboBoxAuthorID.ResetText();

                                               
                        ListViewItem item = new ListViewItem(bk.ISBN);
                        item.SubItems.Add(bk.Title);
                        item.SubItems.Add(bk.Price.ToString());
                        item.SubItems.Add(bk.QoH.ToString());
                        item.SubItems.Add(bk.Year.ToString());
                        item.SubItems.Add(bk.PId.ToString());
                        item.SubItems.Add(bk.SId.ToString());
                        item.SubItems.Add(bk.AuthorId.ToString());
                        ListViewProduct.Items.Add(item);
                                                                                                              }

                }

                else
                {

                    MessageBox.Show("ISBN or Title not exist in the DB", "Warning");

                }
                    }
                  
                         
                  
            

        }

        private void comboBoxISBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bookid = comboBoxISBN.Text;
            Book book = dbEntities.Books.Find(bookid);
            var listBook = from bok in dbEntities.Books select bok;
            foreach (var bok in listBook)
            {
                textBoxTitle.Text = book.Title;
                TextBoxPrice.Text = book.Price.ToString();
                textBoxQOH.Text = book.QoH.ToString();
                textBoxYear.Text = book.Year.ToString();
                comboBoxPublisher.Text = book.PId.ToString();
                comboBoxSupplier.Text = book.SId.ToString();
                comboBoxAuthorID.Text = book.AuthorId.ToString();
                
            }

        }

        private void comboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            int supid = Convert.ToInt32(comboBoxSupplier.Text);
            Supplier supp = dbEntities.Suppliers.Find(supid);
            var listSupllier = from sup in dbEntities.Suppliers select sup;
                foreach (var sup in listSupllier)
                {
                    labelSupplier.Text = supp.SName;
                labelSupplier.Visible = true;
            }
            

        }

        private void comboBoxPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pubid = Convert.ToInt32(comboBoxPublisher.Text);
           Publisher publ = dbEntities.Publishers.Find(pubid);
            var listPublisher = from pub in dbEntities.Publishers select pub;
                foreach (var pub in listPublisher)
                {
                    labelPublisher.Text = publ.PName;
                labelPublisher.Visible = true;
            }
                
            
        }

        private void comboBoxAuthorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int autid = Convert.ToInt32(comboBoxAuthorID.Text);
            Author auth = dbEntities.Authors.Find(autid);
            var listAuthor = from aut in dbEntities.Authors select aut;
                foreach (var aut in listAuthor)
                {
                    labelAuthor.Text = auth.FirstName +" "+auth.LastName;
                labelAuthor.Visible = true;
            }
               
           
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AuthorForm myForm = new AuthorForm();

            myForm.ShowDialog();
        }

        private void labelNewSup_Click(object sender, EventArgs e)
        {
            SupplierForm myForm = new SupplierForm();

            myForm.ShowDialog();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            PublisherForm myForm = new PublisherForm();

            myForm.ShowDialog();
        }

        //private void labelSupplier_Click(object sender, EventArgs e)
        //{

        //}
    }
}
