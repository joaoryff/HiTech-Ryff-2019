namespace HitechEntityFramework
{
    partial class OrderForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReqDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAllO = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerReq = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCredit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelQdisp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelUnPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerShip = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerOrder = new System.Windows.Forms.DateTimePicker();
            this.labelTotal = new System.Windows.Forms.Label();
            this.ComboBoxOid = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.ComboBoxBookO = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.ComboBoxClientIdO = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.TextBoxQOrder = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textSearchO = new System.Windows.Forms.TextBox();
            this.buttonSearchO = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonUpdateO = new System.Windows.Forms.Button();
            this.buttonForPay = new System.Windows.Forms.Button();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ExitButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(705, 385);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(87, 54);
            this.ExitButton.TabIndex = 115;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // listViewOrder
            // 
            this.listViewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader26,
            this.columnHeader34,
            this.ReqDate,
            this.columnHeader35,
            this.columnHeader31,
            this.columnHeader28,
            this.columnHeader27,
            this.columnHeader1});
            this.listViewOrder.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewOrder.GridLines = true;
            this.listViewOrder.Location = new System.Drawing.Point(16, 238);
            this.listViewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(576, 168);
            this.listViewOrder.TabIndex = 112;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Order Id";
            this.columnHeader26.Width = 53;
            // 
            // columnHeader34
            // 
            this.columnHeader34.Text = "Order Date";
            this.columnHeader34.Width = 84;
            // 
            // ReqDate
            // 
            this.ReqDate.Text = "ReqDate";
            // 
            // columnHeader35
            // 
            this.columnHeader35.Text = "Shiping Date";
            this.columnHeader35.Width = 87;
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "Client Id";
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Quantity";
            this.columnHeader28.Width = 82;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Product";
            this.columnHeader27.Width = 83;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Total";
            // 
            // buttonAllO
            // 
            this.buttonAllO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAllO.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllO.Location = new System.Drawing.Point(705, 192);
            this.buttonAllO.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAllO.Name = "buttonAllO";
            this.buttonAllO.Size = new System.Drawing.Size(70, 28);
            this.buttonAllO.TabIndex = 111;
            this.buttonAllO.Text = "&List";
            this.buttonAllO.UseVisualStyleBackColor = false;
            this.buttonAllO.Click += new System.EventHandler(this.buttonAllO_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonCancel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(703, 135);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(72, 28);
            this.buttonCancel.TabIndex = 110;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox9.Controls.Add(this.buttonForPay);
            this.groupBox9.Controls.Add(this.dateTimePickerReq);
            this.groupBox9.Controls.Add(this.label1);
            this.groupBox9.Controls.Add(this.labelCredit);
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Controls.Add(this.labelQdisp);
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Controls.Add(this.labelUnPrice);
            this.groupBox9.Controls.Add(this.label3);
            this.groupBox9.Controls.Add(this.dateTimePickerShip);
            this.groupBox9.Controls.Add(this.label2);
            this.groupBox9.Controls.Add(this.dateTimePickerOrder);
            this.groupBox9.Controls.Add(this.labelTotal);
            this.groupBox9.Controls.Add(this.ComboBoxOid);
            this.groupBox9.Controls.Add(this.label34);
            this.groupBox9.Controls.Add(this.ComboBoxBookO);
            this.groupBox9.Controls.Add(this.label26);
            this.groupBox9.Controls.Add(this.ComboBoxClientIdO);
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.TextBoxQOrder);
            this.groupBox9.Controls.Add(this.label33);
            this.groupBox9.Controls.Add(this.label35);
            this.groupBox9.Controls.Add(this.label37);
            this.groupBox9.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(9, 12);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox9.Size = new System.Drawing.Size(688, 133);
            this.groupBox9.TabIndex = 108;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Create a new Order";
            // 
            // dateTimePickerReq
            // 
            this.dateTimePickerReq.Location = new System.Drawing.Point(547, 67);
            this.dateTimePickerReq.Name = "dateTimePickerReq";
            this.dateTimePickerReq.Size = new System.Drawing.Size(136, 20);
            this.dateTimePickerReq.TabIndex = 74;
            this.dateTimePickerReq.ValueChanged += new System.EventHandler(this.dateTimePickerReq_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Request date:";
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredit.Location = new System.Drawing.Point(280, 71);
            this.labelCredit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(20, 16);
            this.labelCredit.TabIndex = 122;
            this.labelCredit.Text = "-.-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 121;
            this.label6.Text = "Credit Disp:";
            // 
            // labelQdisp
            // 
            this.labelQdisp.AutoSize = true;
            this.labelQdisp.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQdisp.Location = new System.Drawing.Point(432, 69);
            this.labelQdisp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQdisp.Name = "labelQdisp";
            this.labelQdisp.Size = new System.Drawing.Size(20, 16);
            this.labelQdisp.TabIndex = 120;
            this.labelQdisp.Text = "-.-";
            this.labelQdisp.Click += new System.EventHandler(this.labelQdisp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 119;
            this.label5.Text = "Qnt Disp:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelUnPrice
            // 
            this.labelUnPrice.AutoSize = true;
            this.labelUnPrice.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnPrice.Location = new System.Drawing.Point(432, 90);
            this.labelUnPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUnPrice.Name = "labelUnPrice";
            this.labelUnPrice.Size = new System.Drawing.Size(20, 16);
            this.labelUnPrice.TabIndex = 118;
            this.labelUnPrice.Text = "-.-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 117;
            this.label3.Text = "Unit Price:";
            // 
            // dateTimePickerShip
            // 
            this.dateTimePickerShip.Location = new System.Drawing.Point(547, 90);
            this.dateTimePickerShip.Name = "dateTimePickerShip";
            this.dateTimePickerShip.Size = new System.Drawing.Size(136, 20);
            this.dateTimePickerShip.TabIndex = 71;
            this.dateTimePickerShip.ValueChanged += new System.EventHandler(this.dateTimePickerShip_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 116;
            this.label2.Text = "Order Total:";
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Enabled = false;
            this.dateTimePickerOrder.Location = new System.Drawing.Point(547, 38);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(136, 20);
            this.dateTimePickerOrder.TabIndex = 72;
            this.dateTimePickerOrder.ValueChanged += new System.EventHandler(this.dateTimePickerOrder_ValueChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(432, 115);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(20, 16);
            this.labelTotal.TabIndex = 74;
            this.labelTotal.Text = "-.-";
            // 
            // ComboBoxOid
            // 
            this.ComboBoxOid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ComboBoxOid.FormattingEnabled = true;
            this.ComboBoxOid.Location = new System.Drawing.Point(0, 41);
            this.ComboBoxOid.Name = "ComboBoxOid";
            this.ComboBoxOid.Size = new System.Drawing.Size(97, 24);
            this.ComboBoxOid.TabIndex = 73;
            this.ComboBoxOid.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOid_SelectedIndexChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(213, 20);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(61, 16);
            this.label34.TabIndex = 32;
            this.label34.Text = "Client Id :";
            // 
            // ComboBoxBookO
            // 
            this.ComboBoxBookO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ComboBoxBookO.FormattingEnabled = true;
            this.ComboBoxBookO.Location = new System.Drawing.Point(346, 42);
            this.ComboBoxBookO.Name = "ComboBoxBookO";
            this.ComboBoxBookO.Size = new System.Drawing.Size(115, 24);
            this.ComboBoxBookO.TabIndex = 23;
            this.ComboBoxBookO.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBookO_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(474, 44);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 16);
            this.label26.TabIndex = 24;
            this.label26.Text = "Order date:";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // ComboBoxClientIdO
            // 
            this.ComboBoxClientIdO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ComboBoxClientIdO.FormattingEnabled = true;
            this.ComboBoxClientIdO.Location = new System.Drawing.Point(216, 42);
            this.ComboBoxClientIdO.Name = "ComboBoxClientIdO";
            this.ComboBoxClientIdO.Size = new System.Drawing.Size(115, 24);
            this.ComboBoxClientIdO.TabIndex = 33;
            this.ComboBoxClientIdO.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClientIdO_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(474, 90);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(64, 16);
            this.label27.TabIndex = 26;
            this.label27.Text = "Ship date:";
            // 
            // TextBoxQOrder
            // 
            this.TextBoxQOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TextBoxQOrder.Location = new System.Drawing.Point(114, 42);
            this.TextBoxQOrder.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxQOrder.Name = "TextBoxQOrder";
            this.TextBoxQOrder.Size = new System.Drawing.Size(97, 20);
            this.TextBoxQOrder.TabIndex = 17;
            this.TextBoxQOrder.Tag = " Name should be less than 32-digits alphabet! ";
            this.TextBoxQOrder.Text = "1";
            this.TextBoxQOrder.TextChanged += new System.EventHandler(this.TextBoxQOrder_TextChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(111, 20);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(60, 16);
            this.label33.TabIndex = 16;
            this.label33.Text = "Quantity:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(2, 19);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(57, 16);
            this.label35.TabIndex = 0;
            this.label35.Text = "Order ID:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(343, 20);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(66, 16);
            this.label37.TabIndex = 3;
            this.label37.Text = "Product ID:";
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox10.Controls.Add(this.textSearchO);
            this.groupBox10.Controls.Add(this.buttonSearchO);
            this.groupBox10.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(14, 149);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox10.Size = new System.Drawing.Size(279, 71);
            this.groupBox10.TabIndex = 109;
            this.groupBox10.TabStop = false;
            this.groupBox10.Tag = "Email should be like xxx@abc.com!";
            this.groupBox10.Text = "Search an Order";
            // 
            // textSearchO
            // 
            this.textSearchO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textSearchO.Location = new System.Drawing.Point(11, 30);
            this.textSearchO.Margin = new System.Windows.Forms.Padding(2);
            this.textSearchO.Name = "textSearchO";
            this.textSearchO.Size = new System.Drawing.Size(131, 20);
            this.textSearchO.TabIndex = 13;
            // 
            // buttonSearchO
            // 
            this.buttonSearchO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSearchO.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchO.Location = new System.Drawing.Point(179, 26);
            this.buttonSearchO.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchO.Name = "buttonSearchO";
            this.buttonSearchO.Size = new System.Drawing.Size(70, 27);
            this.buttonSearchO.TabIndex = 14;
            this.buttonSearchO.Text = "Sear&ch";
            this.buttonSearchO.UseVisualStyleBackColor = false;
            this.buttonSearchO.Click += new System.EventHandler(this.buttonSearchO_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonOrder.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.Location = new System.Drawing.Point(701, 31);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(72, 27);
            this.buttonOrder.TabIndex = 106;
            this.buttonOrder.Text = "&Order";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonUpdateO
            // 
            this.buttonUpdateO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonUpdateO.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateO.Location = new System.Drawing.Point(703, 83);
            this.buttonUpdateO.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateO.Name = "buttonUpdateO";
            this.buttonUpdateO.Size = new System.Drawing.Size(70, 27);
            this.buttonUpdateO.TabIndex = 107;
            this.buttonUpdateO.Text = "&Update";
            this.buttonUpdateO.UseVisualStyleBackColor = false;
            this.buttonUpdateO.Click += new System.EventHandler(this.buttonUpdateO_Click);
            // 
            // buttonForPay
            // 
            this.buttonForPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonForPay.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForPay.Location = new System.Drawing.Point(50, 93);
            this.buttonForPay.Margin = new System.Windows.Forms.Padding(2);
            this.buttonForPay.Name = "buttonForPay";
            this.buttonForPay.Size = new System.Drawing.Size(140, 34);
            this.buttonForPay.TabIndex = 116;
            this.buttonForPay.Text = "&Send to Account";
            this.buttonForPay.UseVisualStyleBackColor = false;
            this.buttonForPay.Click += new System.EventHandler(this.buttonForPay_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HitechEntityFramework.Properties.Resources.Capture;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.buttonAllO);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonUpdateO);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader34;
        private System.Windows.Forms.ColumnHeader columnHeader35;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.Button buttonAllO;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox ComboBoxOid;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrder;
        private System.Windows.Forms.DateTimePicker dateTimePickerShip;
        private System.Windows.Forms.ComboBox ComboBoxClientIdO;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox ComboBoxBookO;
        private System.Windows.Forms.TextBox TextBoxQOrder;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textSearchO;
        private System.Windows.Forms.Button buttonSearchO;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonUpdateO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerReq;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ColumnHeader ReqDate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label labelUnPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelQdisp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCredit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonForPay;
    }
}