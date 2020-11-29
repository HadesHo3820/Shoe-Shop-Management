namespace Project_ShoeShopManager
{
    partial class fmAdmin
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
            this.lblEmp = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.txtProDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbProType = new System.Windows.Forms.ComboBox();
            this.txtProQuantity = new System.Windows.Forms.TextBox();
            this.txtProPrice = new System.Windows.Forms.TextBox();
            this.txtProSize = new System.Windows.Forms.TextBox();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabType = new System.Windows.Forms.TabPage();
            this.cbMnProLine = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMnQuantityType = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMnNametype = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMnIDProType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabEmp = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdOff = new System.Windows.Forms.RadioButton();
            this.rdOn = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cbEmpRole = new System.Windows.Forms.ComboBox();
            this.txtEmpSupervisor = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbEmpShop = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEmpPass = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmpAddress = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.tabProduct.SuspendLayout();
            this.tabType.SuspendLayout();
            this.tabEmp.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmp.Location = new System.Drawing.Point(35, 18);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(72, 29);
            this.lblEmp.TabIndex = 6;
            this.lblEmp.Text = "Hello";
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl2.Controls.Add(this.tabProduct);
            this.tabControl2.Controls.Add(this.tabType);
            this.tabControl2.Controls.Add(this.tabEmp);
            this.tabControl2.Location = new System.Drawing.Point(12, 62);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(628, 613);
            this.tabControl2.TabIndex = 5;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.txtProDiscount);
            this.tabProduct.Controls.Add(this.label7);
            this.tabProduct.Controls.Add(this.label12);
            this.tabProduct.Controls.Add(this.cbProType);
            this.tabProduct.Controls.Add(this.txtProQuantity);
            this.tabProduct.Controls.Add(this.txtProPrice);
            this.tabProduct.Controls.Add(this.txtProSize);
            this.tabProduct.Controls.Add(this.txtProName);
            this.tabProduct.Controls.Add(this.txtProID);
            this.tabProduct.Controls.Add(this.label6);
            this.tabProduct.Controls.Add(this.label5);
            this.tabProduct.Controls.Add(this.label4);
            this.tabProduct.Controls.Add(this.label3);
            this.tabProduct.Controls.Add(this.label2);
            this.tabProduct.Controls.Add(this.label1);
            this.tabProduct.Location = new System.Drawing.Point(28, 4);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(596, 605);
            this.tabProduct.TabIndex = 0;
            this.tabProduct.Text = "Product";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // txtProDiscount
            // 
            this.txtProDiscount.Location = new System.Drawing.Point(225, 510);
            this.txtProDiscount.Name = "txtProDiscount";
            this.txtProDiscount.ReadOnly = true;
            this.txtProDiscount.Size = new System.Drawing.Size(220, 26);
            this.txtProDiscount.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Discount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(220, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 26);
            this.label12.TabIndex = 16;
            this.label12.Text = "Manage product";
            // 
            // cbProType
            // 
            this.cbProType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProType.FormattingEnabled = true;
            this.cbProType.Location = new System.Drawing.Point(225, 174);
            this.cbProType.Name = "cbProType";
            this.cbProType.Size = new System.Drawing.Size(220, 28);
            this.cbProType.TabIndex = 13;
            // 
            // txtProQuantity
            // 
            this.txtProQuantity.Location = new System.Drawing.Point(225, 443);
            this.txtProQuantity.Name = "txtProQuantity";
            this.txtProQuantity.ReadOnly = true;
            this.txtProQuantity.Size = new System.Drawing.Size(220, 26);
            this.txtProQuantity.TabIndex = 12;
            // 
            // txtProPrice
            // 
            this.txtProPrice.Location = new System.Drawing.Point(225, 375);
            this.txtProPrice.Name = "txtProPrice";
            this.txtProPrice.ReadOnly = true;
            this.txtProPrice.Size = new System.Drawing.Size(220, 26);
            this.txtProPrice.TabIndex = 11;
            // 
            // txtProSize
            // 
            this.txtProSize.Location = new System.Drawing.Point(225, 311);
            this.txtProSize.Name = "txtProSize";
            this.txtProSize.ReadOnly = true;
            this.txtProSize.Size = new System.Drawing.Size(220, 26);
            this.txtProSize.TabIndex = 10;
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(225, 242);
            this.txtProName.Name = "txtProName";
            this.txtProName.ReadOnly = true;
            this.txtProName.Size = new System.Drawing.Size(220, 26);
            this.txtProName.TabIndex = 9;
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(225, 112);
            this.txtProID.Name = "txtProID";
            this.txtProID.ReadOnly = true;
            this.txtProID.Size = new System.Drawing.Size(220, 26);
            this.txtProID.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID product";
            // 
            // tabType
            // 
            this.tabType.Controls.Add(this.cbMnProLine);
            this.tabType.Controls.Add(this.label13);
            this.tabType.Controls.Add(this.txtMnQuantityType);
            this.tabType.Controls.Add(this.label11);
            this.tabType.Controls.Add(this.txtMnNametype);
            this.tabType.Controls.Add(this.label10);
            this.tabType.Controls.Add(this.label9);
            this.tabType.Controls.Add(this.txtMnIDProType);
            this.tabType.Controls.Add(this.label8);
            this.tabType.Location = new System.Drawing.Point(28, 4);
            this.tabType.Name = "tabType";
            this.tabType.Padding = new System.Windows.Forms.Padding(3);
            this.tabType.Size = new System.Drawing.Size(596, 605);
            this.tabType.TabIndex = 1;
            this.tabType.Text = "Type product";
            this.tabType.UseVisualStyleBackColor = true;
            // 
            // cbMnProLine
            // 
            this.cbMnProLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMnProLine.FormattingEnabled = true;
            this.cbMnProLine.Location = new System.Drawing.Point(205, 325);
            this.cbMnProLine.Name = "cbMnProLine";
            this.cbMnProLine.Size = new System.Drawing.Size(220, 28);
            this.cbMnProLine.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(200, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(234, 26);
            this.label13.TabIndex = 17;
            this.label13.Text = "Manage product type";
            // 
            // txtMnQuantityType
            // 
            this.txtMnQuantityType.Location = new System.Drawing.Point(205, 421);
            this.txtMnQuantityType.Name = "txtMnQuantityType";
            this.txtMnQuantityType.ReadOnly = true;
            this.txtMnQuantityType.Size = new System.Drawing.Size(220, 26);
            this.txtMnQuantityType.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Total quantity";
            // 
            // txtMnNametype
            // 
            this.txtMnNametype.Location = new System.Drawing.Point(205, 242);
            this.txtMnNametype.Name = "txtMnNametype";
            this.txtMnNametype.ReadOnly = true;
            this.txtMnNametype.Size = new System.Drawing.Size(220, 26);
            this.txtMnNametype.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Name type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "ID productline";
            // 
            // txtMnIDProType
            // 
            this.txtMnIDProType.Location = new System.Drawing.Point(205, 165);
            this.txtMnIDProType.Name = "txtMnIDProType";
            this.txtMnIDProType.ReadOnly = true;
            this.txtMnIDProType.Size = new System.Drawing.Size(220, 26);
            this.txtMnIDProType.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "ID product type";
            // 
            // tabEmp
            // 
            this.tabEmp.Controls.Add(this.panel2);
            this.tabEmp.Controls.Add(this.panel1);
            this.tabEmp.Controls.Add(this.label14);
            this.tabEmp.Location = new System.Drawing.Point(28, 4);
            this.tabEmp.Name = "tabEmp";
            this.tabEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmp.Size = new System.Drawing.Size(596, 605);
            this.tabEmp.TabIndex = 2;
            this.tabEmp.Text = "Employees";
            this.tabEmp.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rdOff);
            this.panel2.Controls.Add(this.rdOn);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.cbEmpRole);
            this.panel2.Controls.Add(this.txtEmpSupervisor);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.cbEmpShop);
            this.panel2.Location = new System.Drawing.Point(23, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 213);
            this.panel2.TabIndex = 32;
            // 
            // rdOff
            // 
            this.rdOff.AutoSize = true;
            this.rdOff.Location = new System.Drawing.Point(273, 177);
            this.rdOff.Name = "rdOff";
            this.rdOff.Size = new System.Drawing.Size(56, 24);
            this.rdOff.TabIndex = 36;
            this.rdOff.Text = "Off";
            this.rdOff.UseVisualStyleBackColor = true;
            // 
            // rdOn
            // 
            this.rdOn.AutoSize = true;
            this.rdOn.Checked = true;
            this.rdOn.Location = new System.Drawing.Point(181, 177);
            this.rdOn.Name = "rdOn";
            this.rdOn.Size = new System.Drawing.Size(55, 24);
            this.rdOn.TabIndex = 35;
            this.rdOn.TabStop = true;
            this.rdOn.Text = "On";
            this.rdOn.UseVisualStyleBackColor = true;
            this.rdOn.CheckedChanged += new System.EventHandler(this.rdOn_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(40, 179);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 20);
            this.label23.TabIndex = 34;
            this.label23.Text = "Status";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(35, 129);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 20);
            this.label22.TabIndex = 33;
            this.label22.Text = "Role";
            // 
            // cbEmpRole
            // 
            this.cbEmpRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpRole.FormattingEnabled = true;
            this.cbEmpRole.Location = new System.Drawing.Point(181, 126);
            this.cbEmpRole.Name = "cbEmpRole";
            this.cbEmpRole.Size = new System.Drawing.Size(220, 28);
            this.cbEmpRole.TabIndex = 32;
            // 
            // txtEmpSupervisor
            // 
            this.txtEmpSupervisor.Location = new System.Drawing.Point(181, 68);
            this.txtEmpSupervisor.Name = "txtEmpSupervisor";
            this.txtEmpSupervisor.ReadOnly = true;
            this.txtEmpSupervisor.Size = new System.Drawing.Size(220, 26);
            this.txtEmpSupervisor.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(35, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 20);
            this.label21.TabIndex = 30;
            this.label21.Text = "Supervisor";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(35, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 20);
            this.label20.TabIndex = 29;
            this.label20.Text = "Shop";
            // 
            // cbEmpShop
            // 
            this.cbEmpShop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpShop.FormattingEnabled = true;
            this.cbEmpShop.Location = new System.Drawing.Point(181, 13);
            this.cbEmpShop.Name = "cbEmpShop";
            this.cbEmpShop.Size = new System.Drawing.Size(220, 28);
            this.cbEmpShop.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbShowPass);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtEmpPass);
            this.panel1.Controls.Add(this.txtEmpID);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtEmpAddress);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtEmpName);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtEmpPhone);
            this.panel1.Location = new System.Drawing.Point(23, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 286);
            this.panel1.TabIndex = 31;
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Location = new System.Drawing.Point(419, 66);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(113, 24);
            this.cbShowPass.TabIndex = 31;
            this.cbShowPass.Text = "Show pass";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(35, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 20);
            this.label18.TabIndex = 19;
            this.label18.Text = "ID employee";
            // 
            // txtEmpPass
            // 
            this.txtEmpPass.Location = new System.Drawing.Point(181, 64);
            this.txtEmpPass.Name = "txtEmpPass";
            this.txtEmpPass.PasswordChar = '*';
            this.txtEmpPass.ReadOnly = true;
            this.txtEmpPass.Size = new System.Drawing.Size(220, 26);
            this.txtEmpPass.TabIndex = 30;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(181, 13);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(220, 26);
            this.txtEmpID.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(35, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "Password";
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.Location = new System.Drawing.Point(181, 235);
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.ReadOnly = true;
            this.txtEmpAddress.Size = new System.Drawing.Size(220, 26);
            this.txtEmpAddress.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Fullname";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(35, 235);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 20);
            this.label19.TabIndex = 27;
            this.label19.Text = "Address";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(181, 124);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.ReadOnly = true;
            this.txtEmpName.Size = new System.Drawing.Size(220, 26);
            this.txtEmpName.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Phonenumber";
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.Location = new System.Drawing.Point(181, 177);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.ReadOnly = true;
            this.txtEmpPhone.Size = new System.Drawing.Size(220, 26);
            this.txtEmpPhone.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(199, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(218, 26);
            this.label14.TabIndex = 18;
            this.label14.Text = "Manage employees";
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToAddRows = false;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(668, 53);
            this.dgvView.MultiSelect = false;
            this.dgvView.Name = "dgvView";
            this.dgvView.ReadOnly = true;
            this.dgvView.RowHeadersWidth = 62;
            this.dgvView.RowTemplate.Height = 28;
            this.dgvView.Size = new System.Drawing.Size(907, 656);
            this.dgvView.TabIndex = 4;
            this.dgvView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 689);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD NEW";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(204, 689);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 35);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "EDIT";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(386, 689);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1486, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(89, 35);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(546, 689);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 35);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // fmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 759);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.dgvView);
            this.Name = "fmAdmin";
            this.Text = "2";
            this.tabControl2.ResumeLayout(false);
            this.tabProduct.ResumeLayout(false);
            this.tabProduct.PerformLayout();
            this.tabType.ResumeLayout(false);
            this.tabType.PerformLayout();
            this.tabEmp.ResumeLayout(false);
            this.tabEmp.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.TextBox txtProSize;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabType;
        private System.Windows.Forms.TabPage tabEmp;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbProType;
        private System.Windows.Forms.TextBox txtProQuantity;
        private System.Windows.Forms.TextBox txtProPrice;
        private System.Windows.Forms.ComboBox cbMnProLine;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMnQuantityType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMnNametype;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMnIDProType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmpAddress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.ComboBox cbEmpShop;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.TextBox txtEmpPass;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbEmpRole;
        private System.Windows.Forms.TextBox txtEmpSupervisor;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rdOff;
        private System.Windows.Forms.RadioButton rdOn;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtProDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbShowPass;
    }
}