namespace Project_ShoeShopManager
{
    partial class fmCashier
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
            System.Windows.Forms.Label label23;
            this.lblFullname = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.cbSearch1 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCusAdress = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCusPhone1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.txtProPrice = new System.Windows.Forms.TextBox();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.cbSearch2 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTotal2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtProQuantity2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProID2 = new System.Windows.Forms.TextBox();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.txtProName2 = new System.Windows.Forms.TextBox();
            this.txtProSize2 = new System.Windows.Forms.TextBox();
            this.txtProPrice2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCusPhone2 = new System.Windows.Forms.TextBox();
            this.txtCusName2 = new System.Windows.Forms.TextBox();
            this.txtIdOrder2 = new System.Windows.Forms.TextBox();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            label23 = new System.Windows.Forms.Label();
            this.Order.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label23.ForeColor = System.Drawing.Color.CornflowerBlue;
            label23.Location = new System.Drawing.Point(690, 13);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(159, 43);
            label23.TabIndex = 12;
            label23.Text = "ORDER ";
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.ForeColor = System.Drawing.Color.Maroon;
            this.lblFullname.Location = new System.Drawing.Point(12, 9);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(56, 22);
            this.lblFullname.TabIndex = 3;
            this.lblFullname.Text = "Hello";
            // 
            // Order
            // 
            this.Order.Controls.Add(this.tabPage1);
            this.Order.Controls.Add(this.tabPage2);
            this.Order.Location = new System.Drawing.Point(12, 48);
            this.Order.Name = "Order";
            this.Order.SelectedIndex = 0;
            this.Order.Size = new System.Drawing.Size(1688, 905);
            this.Order.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lblQuantity);
            this.tabPage1.Controls.Add(this.dgvCart);
            this.tabPage1.Controls.Add(this.cbSearch1);
            this.tabPage1.Controls.Add(label23);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.txtCusAdress);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.txtCusPhone1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtCusName);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.txtSearch1);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.lblTotalPrice);
            this.tabPage1.Controls.Add(this.dgvProduct);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1680, 872);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create order";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1443, 839);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1230, 839);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total quantity:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(1344, 839);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(21, 20);
            this.lblQuantity.TabIndex = 15;
            this.lblQuantity.Text = "...";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(23, 552);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 62;
            this.dgvCart.RowTemplate.Height = 28;
            this.dgvCart.Size = new System.Drawing.Size(1631, 269);
            this.dgvCart.TabIndex = 14;
            this.dgvCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellClick);
            // 
            // cbSearch1
            // 
            this.cbSearch1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbSearch1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch1.FormattingEnabled = true;
            this.cbSearch1.Location = new System.Drawing.Point(698, 76);
            this.cbSearch1.Name = "cbSearch1";
            this.cbSearch1.Size = new System.Drawing.Size(161, 28);
            this.cbSearch1.TabIndex = 13;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(33, 193);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 20);
            this.label21.TabIndex = 11;
            this.label21.Text = "Address";
            // 
            // txtCusAdress
            // 
            this.txtCusAdress.Location = new System.Drawing.Point(167, 193);
            this.txtCusAdress.Name = "txtCusAdress";
            this.txtCusAdress.Size = new System.Drawing.Size(494, 26);
            this.txtCusAdress.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(33, 84);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 20);
            this.label20.TabIndex = 2;
            this.label20.Text = "PhoneNumber";
            // 
            // txtCusPhone1
            // 
            this.txtCusPhone1.Location = new System.Drawing.Point(167, 78);
            this.txtCusPhone1.Name = "txtCusPhone1";
            this.txtCusPhone1.Size = new System.Drawing.Size(236, 26);
            this.txtCusPhone1.TabIndex = 5;
            this.txtCusPhone1.TextChanged += new System.EventHandler(this.txtCusNumber_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 517);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Cart";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(167, 136);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(236, 26);
            this.txtCusName.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1557, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 33);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch1
            // 
            this.txtSearch1.Location = new System.Drawing.Point(878, 76);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.Size = new System.Drawing.Size(319, 26);
            this.txtSearch1.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(33, 139);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 20);
            this.label19.TabIndex = 1;
            this.label19.Text = "Customer name";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(1535, 839);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(21, 20);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "...";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(698, 136);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.RowTemplate.Height = 28;
            this.dgvProduct.Size = new System.Drawing.Size(956, 368);
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.QuantityUpDown);
            this.panel1.Controls.Add(this.txtSize);
            this.panel1.Controls.Add(this.btnAddToCart);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtProName);
            this.panel1.Controls.Add(this.txtProPrice);
            this.panel1.Controls.Add(this.txtProID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 253);
            this.panel1.TabIndex = 0;
            // 
            // QuantityUpDown
            // 
            this.QuantityUpDown.Location = new System.Drawing.Point(462, 13);
            this.QuantityUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.QuantityUpDown.Name = "QuantityUpDown";
            this.QuantityUpDown.Size = new System.Drawing.Size(169, 26);
            this.QuantityUpDown.TabIndex = 16;
            this.QuantityUpDown.ValueChanged += new System.EventHandler(this.QuantityUpDown_ValueChanged);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(143, 143);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(169, 26);
            this.txtSize.TabIndex = 15;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(19, 207);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(107, 29);
            this.btnAddToCart.TabIndex = 14;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(531, 207);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(106, 29);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(205, 207);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(107, 29);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(462, 140);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(169, 26);
            this.txtDiscount.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Discount (%)";
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(143, 74);
            this.txtProName.Name = "txtProName";
            this.txtProName.ReadOnly = true;
            this.txtProName.Size = new System.Drawing.Size(169, 26);
            this.txtProName.TabIndex = 5;
            // 
            // txtProPrice
            // 
            this.txtProPrice.Location = new System.Drawing.Point(462, 74);
            this.txtProPrice.Name = "txtProPrice";
            this.txtProPrice.ReadOnly = true;
            this.txtProPrice.Size = new System.Drawing.Size(169, 26);
            this.txtProPrice.TabIndex = 4;
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(143, 15);
            this.txtProID.Name = "txtProID";
            this.txtProID.ReadOnly = true;
            this.txtProID.Size = new System.Drawing.Size(169, 26);
            this.txtProID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID product";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSearch2);
            this.tabPage2.Controls.Add(this.btnClear2);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.cbSearch2);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.dgvOrder);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.dgvOrderDetail);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1680, 872);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Info bill";
            // 
            // txtSearch2
            // 
            this.txtSearch2.Location = new System.Drawing.Point(1032, 26);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(358, 26);
            this.txtSearch2.TabIndex = 28;
            this.txtSearch2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(1396, 22);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(111, 34);
            this.btnClear2.TabIndex = 30;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font(".VnArial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label24.Location = new System.Drawing.Point(164, 15);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(242, 34);
            this.label24.TabIndex = 25;
            this.label24.Text = "SEARCH ORDER";
            // 
            // cbSearch2
            // 
            this.cbSearch2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch2.FormattingEnabled = true;
            this.cbSearch2.Items.AddRange(new object[] {
            "ID order",
            "Phonenumber",
            "Date"});
            this.cbSearch2.Location = new System.Drawing.Point(863, 26);
            this.cbSearch2.Name = "cbSearch2";
            this.cbSearch2.Size = new System.Drawing.Size(146, 28);
            this.cbSearch2.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtTotal2);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.txtProQuantity2);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtProID2);
            this.panel4.Controls.Add(this.lblTotal2);
            this.panel4.Controls.Add(this.txtProName2);
            this.panel4.Controls.Add(this.txtProSize2);
            this.panel4.Controls.Add(this.txtProPrice2);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(19, 435);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(518, 416);
            this.panel4.TabIndex = 29;
            // 
            // txtTotal2
            // 
            this.txtTotal2.Location = new System.Drawing.Point(266, 342);
            this.txtTotal2.Name = "txtTotal2";
            this.txtTotal2.ReadOnly = true;
            this.txtTotal2.Size = new System.Drawing.Size(169, 26);
            this.txtTotal2.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(57, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "ID product";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(59, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Product";
            // 
            // txtProQuantity2
            // 
            this.txtProQuantity2.Location = new System.Drawing.Point(266, 221);
            this.txtProQuantity2.Name = "txtProQuantity2";
            this.txtProQuantity2.ReadOnly = true;
            this.txtProQuantity2.Size = new System.Drawing.Size(169, 26);
            this.txtProQuantity2.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(59, 289);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Quantity";
            // 
            // txtProID2
            // 
            this.txtProID2.Location = new System.Drawing.Point(266, 32);
            this.txtProID2.Name = "txtProID2";
            this.txtProID2.ReadOnly = true;
            this.txtProID2.Size = new System.Drawing.Size(169, 26);
            this.txtProID2.TabIndex = 3;
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Location = new System.Drawing.Point(57, 345);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(44, 20);
            this.lblTotal2.TabIndex = 5;
            this.lblTotal2.Text = "Total";
            // 
            // txtProName2
            // 
            this.txtProName2.Location = new System.Drawing.Point(266, 93);
            this.txtProName2.Name = "txtProName2";
            this.txtProName2.ReadOnly = true;
            this.txtProName2.Size = new System.Drawing.Size(169, 26);
            this.txtProName2.TabIndex = 5;
            // 
            // txtProSize2
            // 
            this.txtProSize2.Location = new System.Drawing.Point(266, 155);
            this.txtProSize2.Name = "txtProSize2";
            this.txtProSize2.ReadOnly = true;
            this.txtProSize2.Size = new System.Drawing.Size(169, 26);
            this.txtProSize2.TabIndex = 8;
            // 
            // txtProPrice2
            // 
            this.txtProPrice2.Location = new System.Drawing.Point(264, 286);
            this.txtProPrice2.Name = "txtProPrice2";
            this.txtProPrice2.ReadOnly = true;
            this.txtProPrice2.Size = new System.Drawing.Size(169, 26);
            this.txtProPrice2.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Size";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(774, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Find by";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(568, 86);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 62;
            this.dgvOrder.RowTemplate.Height = 28;
            this.dgvOrder.Size = new System.Drawing.Size(1093, 322);
            this.dgvOrder.TabIndex = 6;
            this.dgvOrder.Tag = "";
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.txtCusPhone2);
            this.panel3.Controls.Add(this.txtCusName2);
            this.panel3.Controls.Add(this.txtIdOrder2);
            this.panel3.Location = new System.Drawing.Point(19, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(518, 322);
            this.panel3.TabIndex = 28;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(59, 146);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 20);
            this.label22.TabIndex = 20;
            this.label22.Text = "PhoneNumber";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(59, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 20);
            this.label17.TabIndex = 15;
            this.label17.Text = "ID Order";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(59, 226);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 20);
            this.label18.TabIndex = 18;
            this.label18.Text = "Customer";
            // 
            // txtCusPhone2
            // 
            this.txtCusPhone2.Location = new System.Drawing.Point(270, 140);
            this.txtCusPhone2.Name = "txtCusPhone2";
            this.txtCusPhone2.ReadOnly = true;
            this.txtCusPhone2.Size = new System.Drawing.Size(169, 26);
            this.txtCusPhone2.TabIndex = 19;
            // 
            // txtCusName2
            // 
            this.txtCusName2.Location = new System.Drawing.Point(270, 223);
            this.txtCusName2.Name = "txtCusName2";
            this.txtCusName2.ReadOnly = true;
            this.txtCusName2.Size = new System.Drawing.Size(169, 26);
            this.txtCusName2.TabIndex = 21;
            // 
            // txtIdOrder2
            // 
            this.txtIdOrder2.Location = new System.Drawing.Point(270, 61);
            this.txtIdOrder2.Name = "txtIdOrder2";
            this.txtIdOrder2.ReadOnly = true;
            this.txtIdOrder2.Size = new System.Drawing.Size(169, 26);
            this.txtIdOrder2.TabIndex = 4;
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AllowUserToAddRows = false;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(568, 435);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersWidth = 62;
            this.dgvOrderDetail.RowTemplate.Height = 28;
            this.dgvOrderDetail.Size = new System.Drawing.Size(1093, 416);
            this.dgvOrderDetail.TabIndex = 4;
            this.dgvOrderDetail.Tag = "";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1573, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(97, 33);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // fmCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 964);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.lblFullname);
            this.Name = "fmCashier";
            this.Text = "fmEmployee";
            this.Order.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.TabControl Order;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.TextBox txtCusPhone2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtProPrice2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProSize2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProName2;
        private System.Windows.Forms.TextBox txtIdOrder2;
        private System.Windows.Forms.TextBox txtProID2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtCusAdress;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCusPhone1;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCusName2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbSearch2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtProQuantity2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.NumericUpDown QuantityUpDown;
        private System.Windows.Forms.TextBox txtProPrice;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.ComboBox cbSearch1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTotal2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch2;
    }
}