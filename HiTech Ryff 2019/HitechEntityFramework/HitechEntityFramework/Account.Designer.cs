namespace HitechEntityFramework
{
    partial class Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewInvoice = new System.Windows.Forms.ListView();
            this.Oid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IssueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Q = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewInvoice
            // 
            this.listViewInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listViewInvoice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Oid,
            this.Cid,
            this.IssueDate,
            this.DueDate,
            this.ISBN,
            this.PName,
            this.Q,
            this.UnitP,
            this.Total});
            this.listViewInvoice.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewInvoice.GridLines = true;
            this.listViewInvoice.Location = new System.Drawing.Point(28, 67);
            this.listViewInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.listViewInvoice.Name = "listViewInvoice";
            this.listViewInvoice.Size = new System.Drawing.Size(715, 280);
            this.listViewInvoice.TabIndex = 113;
            this.listViewInvoice.UseCompatibleStateImageBehavior = false;
            this.listViewInvoice.View = System.Windows.Forms.View.Details;
            // 
            // Oid
            // 
            this.Oid.Text = "Order Id";
            this.Oid.Width = 67;
            // 
            // Cid
            // 
            this.Cid.Text = "Client Id";
            this.Cid.Width = 84;
            // 
            // IssueDate
            // 
            this.IssueDate.Text = "Issue Date";
            this.IssueDate.Width = 98;
            // 
            // DueDate
            // 
            this.DueDate.Text = "Due Date";
            this.DueDate.Width = 92;
            // 
            // ISBN
            // 
            this.ISBN.Text = "ISBN";
            this.ISBN.Width = 65;
            // 
            // PName
            // 
            this.PName.Text = "Book Name";
            this.PName.Width = 82;
            // 
            // Q
            // 
            this.Q.Text = "Quantity";
            this.Q.Width = 83;
            // 
            // UnitP
            // 
            this.UnitP.Text = "Unit Price";
            this.UnitP.Width = 76;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            // 
            // buttonInvoice
            // 
            this.buttonInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonInvoice.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInvoice.Location = new System.Drawing.Point(312, 384);
            this.buttonInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInvoice.Name = "buttonInvoice";
            this.buttonInvoice.Size = new System.Drawing.Size(70, 28);
            this.buttonInvoice.TabIndex = 114;
            this.buttonInvoice.Text = "&Invoice";
            this.buttonInvoice.UseVisualStyleBackColor = false;
            this.buttonInvoice.Click += new System.EventHandler(this.buttonAllO_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInvoice);
            this.Controls.Add(this.listViewInvoice);
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewInvoice;
        private System.Windows.Forms.ColumnHeader Oid;
        private System.Windows.Forms.ColumnHeader Cid;
        private System.Windows.Forms.ColumnHeader IssueDate;
        private System.Windows.Forms.ColumnHeader DueDate;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.ColumnHeader PName;
        private System.Windows.Forms.ColumnHeader Q;
        private System.Windows.Forms.ColumnHeader UnitP;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Button buttonInvoice;
    }
}