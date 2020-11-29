using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ShoeShopManager
{
    public partial class fmAdmin : Form
    {   
        DTO_Employee employee = new DTO_Employee();
        private int index;
        public fmAdmin()
        {
            InitializeComponent();
            dgvView.ReadOnly = true;
            this.AutoSize = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public fmAdmin(DTO_Employee emp) : this()
        {
            employee = emp;
            lblEmp.Text = "Hello " + emp.Fullname;
            loadAllData();
        }


        
        private void loadAllData()
        {
            try
            {
                if (tabControl2.SelectedIndex == 0)
                {
                    BUS_Product bus = new BUS_Product();
                    BUS_ProductType busProType = new BUS_ProductType();

                    dgvView.DataSource = bus.loadProduct();

                    txtProID.DataBindings.Clear();
                    txtProName.DataBindings.Clear();
                    txtProSize.DataBindings.Clear();
                    cbProType.DataBindings.Clear();
                    txtProPrice.DataBindings.Clear();
                    txtProQuantity.DataBindings.Clear();
                    txtProDiscount.DataBindings.Clear();

                    txtProID.DataBindings.Add("Text", dgvView.DataSource, "IDProduct").DataSourceUpdateMode = DataSourceUpdateMode.Never;
                    txtProName.DataBindings.Add("Text", dgvView.DataSource, "NameProduct").DataSourceUpdateMode = DataSourceUpdateMode.Never;
                    txtProSize.DataBindings.Add("Text", dgvView.DataSource, "Size").DataSourceUpdateMode = DataSourceUpdateMode.Never;
                    cbProType.DataBindings.Add("Text", dgvView.DataSource, "NameProductType").DataSourceUpdateMode = DataSourceUpdateMode.Never;
                    txtProPrice.DataBindings.Add("Text", dgvView.DataSource, "Price").DataSourceUpdateMode = DataSourceUpdateMode.Never;
                    txtProQuantity.DataBindings.Add("Text", dgvView.DataSource, "Quantity").DataSourceUpdateMode = DataSourceUpdateMode.Never;
                    txtProDiscount.DataBindings.Add("Text", dgvView.DataSource, "Discount").DataSourceUpdateMode = DataSourceUpdateMode.Never;



                    cbProType.DataSource = busProType.loadProType();
                    cbProType.DisplayMember = "NameProductType";

                }
                else if (tabControl2.SelectedIndex == 1)
                {
                    BUS_ProductType busProType = new BUS_ProductType();
                    dgvView.DataSource = busProType.loadProType();

                    txtMnNametype.DataBindings.Clear();
                    txtMnIDProType.DataBindings.Clear();
                    txtMnQuantityType.DataBindings.Clear();
                    cbMnProLine.DataBindings.Clear();

                    txtMnIDProType.DataBindings.Add("Text", dgvView.DataSource, "IDProductType").DataSourceUpdateMode = DataSourceUpdateMode.Never;
                    txtMnNametype.DataBindings.Add("Text", dgvView.DataSource, "NameProductType").DataSourceUpdateMode = DataSourceUpdateMode.Never;
                    txtMnQuantityType.DataBindings.Add("Text", dgvView.DataSource, "Quantity").DataSourceUpdateMode = DataSourceUpdateMode.Never;
                    cbMnProLine.DataBindings.Add("Text", dgvView.DataSource, "NameProductlines").DataSourceUpdateMode = DataSourceUpdateMode.Never;

                    
                    cbMnProLine.Items.Clear();
                    cbMnProLine.Items.Add("Male");
                    cbMnProLine.Items.Add("FeMale");

                    cbMnProLine.SelectedItem = "Male";
                }
                else
                {

                    BUS_Employee busEmp = new BUS_Employee();
                    dgvView.DataSource = busEmp.loadEmployee();

                    BUS_Shop busShop = new BUS_Shop();
                    cbEmpShop.DataSource = busShop.loadShop();
                    cbEmpShop.DisplayMember = "Address";

                    cbEmpRole.Items.Clear();
                    cbEmpRole.Items.Add("Cashier");
                    cbEmpRole.Items.Add("Manager");
                    cbEmpRole.SelectedItem = "Cashier";
                    rdOn.Checked = true;
                }
            }
            catch
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string check = checkAdd();
            if (btnAdd.Text.Equals("ADD NEW"))
            {
                btnAdd.Text = "ADD";
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                EditText();
                txtProID.Text = "ID product is added automatic";
            }
            else
            {
                if (check.Equals(""))
                {
                    if (tabControl2.SelectedIndex == 0)//Add product
                    {
 
                            BUS_Product bus = new BUS_Product();
                            string idPro = txtProID.Text;
                            bool checkIDProduct = bus.checkID(idPro);
                            if (checkIDProduct)
                            {
                                var rs = MessageBox.Show("Do you want to update quantity of product ?", "",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                                if (rs == DialogResult.Yes)
                                {

                                fmAddQuanity f = new fmAddQuanity(idPro);
                                f.ShowDialog();
                                Clear();
                                } 
                            }
                            else
                            {
                                string idProType = cbProType.Text;
                                MessageBox.Show(idProType);
                                float size = float.Parse(txtProSize.Text);
                                string name = txtProName.Text;
                                int price = int.Parse(txtProPrice.Text);
                                int quantity = int.Parse(txtProQuantity.Text);
                                string discount = txtProDiscount.Text;
                                DTO_Product x = new DTO_Product(idProType,name,size,price,quantity,discount);
                                bus.addProduct(x);
                                MessageBox.Show("Add new product succesfully");
                                loadAllData();
                                Clear();
                        }
                    }
                    else if (tabControl2.SelectedIndex == 1)//Add Type
                    {
                        EditText();
                        try
                        {
                            BUS_ProductType bus = new BUS_ProductType();

                            string idProtype = txtMnIDProType.Text;
                            string idProLine = cbMnProLine.Text;
                            string nameProType = txtMnIDProType.Text;
                            int quantity = 0;
                            DTO_ProductType x = new DTO_ProductType(idProtype, idProLine, nameProType, quantity);
                            bus.addProType(x);
                            MessageBox.Show("Create product type succesfully");
                            loadAllData();
                            Clear();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("ID product type is duplicate!!!");
                        }
                    }
                    else //Add Employee
                    {
                        EditText();
                        try
                        {
                            BUS_Employee bus = new BUS_Employee();

                            string id = txtEmpID.Text;
                            string pass = txtEmpPass.Text;
                            string name = txtEmpName.Text;
                            string idShop = cbEmpShop.Text.ToString();
                            string address = txtEmpAddress.Text;
                            string supervisor = txtEmpSupervisor.Text;
                            string phone = txtEmpPhone.Text;
                            string role = cbEmpRole.Text;
                            DTO_Employee x = new DTO_Employee(id, pass, name, phone, address, idShop, supervisor, role, "On");
                            bus.addEmployee(x);
                            MessageBox.Show("Create succesfully");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("ID employee is duplicate!!!");
                        }
                        loadAllData();
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show(check);
                }
            }
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text.Equals("EDIT"))
            {
                btnUpdate.Text = "UPDATE";
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;

                Action<Control.ControlCollection> blockTextBox = null;

                blockTextBox = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                            (control as TextBox).ReadOnly = false;
                        else
                            blockTextBox(control.Controls);
                };

                blockTextBox(Controls);

                txtProID.ReadOnly = true;
            }
            else
            {
                var rs = MessageBox.Show("Do you want to update ???", "",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    if (tabControl2.SelectedIndex == 0)//Update product
                    {
                        
                        BUS_Product bus = new BUS_Product();
                        string check = checkUpdate();
                        if (check.Equals(""))
                        {
                            
                            string idPro = txtProID.Text;
                            string idProType = cbProType.Text;
                            float size = float.Parse(txtProSize.Text);
                            string name = txtProName.Text;
                            int price = int.Parse(txtProPrice.Text);
                            int quantity = int.Parse(txtProQuantity.Text);
                            string discount = txtProDiscount.Text;
                            DTO_Product x = new DTO_Product(idPro,idProType,name,size,price,quantity,discount);
                            bool update = bus.updateProduct(x);
                            if (update)
                            {
                                MessageBox.Show("Update succesfully");
                                Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show(check);
                        }
                    }
                    else if (tabControl2.SelectedIndex == 1)//Update Type
                    {
                        BUS_ProductType bus = new BUS_ProductType();
                        string check = checkUpdate();
                        if (check.Equals(""))
                        {
                            txtMnIDProType.ReadOnly = true;
                            string idProtype = txtMnIDProType.Text;
                            string idProLine = cbMnProLine.SelectedItem.ToString();
                            string nameProType = txtMnNametype.Text;
                            int quantity = int.Parse(txtMnQuantityType.Text);
                            DTO_ProductType x = new DTO_ProductType(idProtype, idProLine, nameProType, quantity);
                            bool update = bus.updateProType(x);
                            if (update)
                            {
                                MessageBox.Show("Update succesfully");
                                Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show(check);
                        }
                    }
                    else //Update Employee
                    {
                        BUS_Employee bus = new BUS_Employee();
                        string check = checkUpdate();
                        if (check.Equals(""))
                        {
                            txtEmpID.ReadOnly = true;
                            string id = txtEmpID.Text;
                            string pass = txtEmpPass.Text;
                            string name = txtEmpName.Text;
                            string idShop = cbEmpShop.Text.ToString();
                            string address = txtEmpAddress.Text;
                            string supervisor = txtEmpSupervisor.Text;
                            string phone = txtEmpPhone.Text;
                            string role = cbEmpRole.SelectedItem.ToString();
                            string status = "On";
                            if (rdOff.Checked == true)
                            {
                                status = "Off";
                            }
                            if (txtEmpSupervisor.Text.Equals(""))
                            {
                                txtEmpSupervisor.Text = "null";
                            }
                            DTO_Employee x = new DTO_Employee(id, pass, name, phone, address, idShop, supervisor, role, status);
                            bool update = bus.updateEmployee(x);
                            if (update)
                            {
                                MessageBox.Show("Update succesfully");
                                Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show(check);
                        }
                    }
                    btnUpdate.Text = "EDIT";
                }
                Clear();
            }
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Do you want to delete ???", "",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                    if (tabControl2.SelectedIndex == 0)// Delete product
                    {
                         BUS_Product bus = new BUS_Product();
                         bus.deleteProduct(txtProID.Text);
                        MessageBox.Show("Delete succesfull");
                    Clear();
                }
                    else if (tabControl2.SelectedIndex == 1)//Delete Type
                    {
                        BUS_ProductType bus = new BUS_ProductType();
                        bus.deleteProType(txtMnIDProType.Text);
                        MessageBox.Show("Delete succesfull");
                        Clear();
                    }
                    else //Delete Employee
                    {
                        BUS_Employee bus = new BUS_Employee();
                        bus.deleteEmployee(txtEmpID.Text);
                        MessageBox.Show("Delete succesfull !!!");
                        Clear();
                    }
            }
        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadAllData();
            Clear();
        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            try
            {
                if (tabControl2.SelectedIndex == 0)
                {
                    DataGridViewRow selectedRow = dgvView.Rows[index];

                }
                if (tabControl2.SelectedIndex == 1)
                {
                    txtMnQuantityType.ReadOnly = true;
                    DataGridViewRow selectedRow = dgvView.Rows[index];
                    string quantity = selectedRow.Cells[3].Value.ToString();
                    txtMnQuantityType.Text = quantity;
                }
                if (tabControl2.SelectedIndex == 2)
                {
                    BUS_Employee busEmp = new BUS_Employee();
                    DataGridViewRow selectedRow = dgvView.Rows[index];
                    string idEmp = selectedRow.Cells[0].Value.ToString();
                    employee = busEmp.getDetail(idEmp);

                    txtEmpID.Text = idEmp;
                    txtEmpPass.Text = employee.Password;
                    txtEmpName.Text = employee.Fullname;
                    txtEmpPhone.Text = employee.Phone;
                    txtEmpAddress.Text = employee.Address;
                    cbEmpShop.Text = employee.IDShop;
                    txtEmpSupervisor.Text = employee.Supervisor;
                    cbEmpRole.Text = employee.role;
                    if (employee.Status.Equals("Off"))
                    {
                        rdOn.Checked = false;
                    }
                    else
                    {
                        rdOn.Checked = true;
                    }
                }
            }
            catch
            {
                Clear();
            }

        }

        private void rdOn_CheckedChanged(object sender, EventArgs e)
        {
            if (rdOn.Checked == true)
            {
                rdOff.Checked = false;
            }
            else
            {
                rdOff.Checked = true;
            }
        }

        private string checkAdd()
        {
            
            string valid = "";
            
            if (tabControl2.SelectedIndex == 0)
            {
                if (txtProName.Text.Length == 0)
                {
                    valid += "Name cannot be empty\n\n";
                }
                if (!Regex.Match(txtProSize.Text, "^[1-9]{1,3}.[0-9]{1}$").Success)
                {
                    valid += "Size  is wrong format x.x \n\n";
                }
                if (!Regex.Match(txtProPrice.Text, "^[0-9]{1,50}$").Success)
                {
                    valid += "Price  is wrong format\n\n";
                }
                if (!Regex.Match(txtProQuantity.Text, "^[0-9]{1,10}$").Success)
                {
                    valid += "Quantity is wrong format\n\n";
                }
                if (!Regex.Match(txtProDiscount.Text, "^[0-9]{1,9}$").Success)
                {
                    valid += "Discount  is wrong format";
                }
            }
            else if (tabControl2.SelectedIndex == 1)
            {
                BUS_ProductType bus = new BUS_ProductType();
                bool check = bus.checkProType(txtMnIDProType.Text);
                if (check)
                {
                    valid += "ID product type already  exits\n";
                }
                if (txtMnIDProType.TextLength == 0)
                {
                    valid += "\nID product type cannot be empty\n";
                }
                if (txtMnNametype.TextLength == 0)
                {
                    valid += "\nName product type cannot be empty";
                }
                return valid;
            }
            else
            {
                BUS_Employee bus = new BUS_Employee();
                bool check = bus.checkEmployee(txtEmpID.Text);
                if (check)
                {
                    valid += "\nThis ID is already exits!!!\n";
                }
                if (txtEmpID.TextLength == 0)
                {
                    valid += "\nID cannot be empty\n";
                }
                if (txtEmpPass.TextLength == 0)
                {
                    valid += "\nPassword cannot empty\n";
                }
                if (txtEmpName.TextLength == 0)
                {
                    valid += "\nName cannot empty\n";
                }
                if (txtEmpPhone.TextLength == 0)
                {
                    valid += "\nPhone cannot empty\n";
                }
                if (txtEmpAddress.TextLength == 0)
                {
                    valid += "\nAddress cannot empty";
                }
                return valid;
            }
            return valid;
        }

        private string checkUpdate()
        {
            string valid = "";
            if (tabControl2.SelectedIndex == 0)
            {
                if (txtProID.Text.Length == 0)
                {
                    valid += "ID product cannot be empty\n";
                }
                if (txtProName.Text.Length == 0)
                {
                    valid += "Name cannot be empty\n\n";
                }
                if (!Regex.Match(txtProSize.Text, "^[1-9]{1,3}.[0-9]{1}$").Success)
                {
                    valid += "Size  is wrong format x.x \n\n";
                }
                if (!Regex.Match(txtProPrice.Text, "^[0-9]{1,50}$").Success)
                {
                    valid += "Price  is wrong format\n\n";
                }
                if (!Regex.Match(txtProQuantity.Text, "^[0-9]{1,9}$").Success)
                {
                    valid += "Quantity is wrong format\n\n";
                }
                if (!Regex.Match(txtProDiscount.Text, "^[0-9]{1,9}$").Success)
                {
                    valid += "Discount  is wrong format\n\n";
                }
            }
            else if(tabControl2.SelectedIndex == 1)
            {
                BUS_ProductType bus = new BUS_ProductType();
                bool check = bus.checkProType(txtMnIDProType.Text);
                if (!check)
                {
                    valid += "ID product type is not exits\n\n";
                }
                if (txtMnIDProType.TextLength == 0)
                {
                    valid += "ID product type cannot be empty\n\n";
                }
                if (txtMnNametype.TextLength == 0)
                {
                    valid += "Name product type cannot be empty";
                }
                return valid;
            }
            else
            {
                BUS_Employee bus = new BUS_Employee();
                bool check = bus.checkEmployee(txtEmpID.Text);
                if (!check)
                {
                    valid += "\nThis ID is not exits!!!\n";
                }
                if (txtEmpPass.TextLength == 0)
                {
                    valid += "\nPassword cannot empty\n";
                }
                if (txtEmpName.TextLength == 0)
                {
                    valid += "\nName cannot empty\n";
                }
                if (txtEmpPhone.TextLength == 0)
                {
                    valid += "\nPhone cannot empty\n";
                }
                if (txtEmpAddress.TextLength == 0)
                {
                    valid += "\nAddress cannot empty";
                }
                return valid;
            }
            return valid;
        }

        //Open edit textbox
        private void EditText()
        {
            Action<Control.ControlCollection> clearTextBox = null;

            clearTextBox = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        clearTextBox(control.Controls);
            };
            clearTextBox(Controls);

            Action<Control.ControlCollection> blockTextBox = null;

            blockTextBox = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).ReadOnly = false;
                    else
                        blockTextBox(control.Controls);
            };

            blockTextBox(Controls);

            txtProID.ReadOnly = true;
        }

        //ClearAll control
        private void Clear()
        {
            //Clear textbox
            Action<Control.ControlCollection> clearTextBox = null;

            clearTextBox = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        clearTextBox(control.Controls);
            };
            clearTextBox(Controls);

            Action<Control.ControlCollection> blockTextBox = null;

            blockTextBox = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).ReadOnly = true;
                    else
                        blockTextBox(control.Controls);
            };

            blockTextBox(Controls);
            loadAllData();

            btnAdd.Text = "ADD NEW";
            btnUpdate.Text = "EDIT";

            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread t = new Thread(new ThreadStart(showLoginform));
            t.Start();
            this.Close();
        }

        private void showLoginform()
        {
            fmLogin f = new fmLogin();
            Application.Run(f);
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtEmpPass.PasswordChar = '\0';
            }else
            {
                txtEmpPass.PasswordChar = '*';
            }
        }

       
    }
}
