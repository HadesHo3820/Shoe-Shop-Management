using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_ShoeShopManager
{

    public partial class fmCashier : Form
    {
        private DTO_Employee employee = new DTO_Employee();
        private DTO_Customer cus = new DTO_Customer();
        private BindingList<DTO_Product> listCart = new BindingList<DTO_Product>();
        private int indexPro;
        private int indexCart;

        public fmCashier()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public fmCashier(DTO_Employee emp) : this()
        {
            employee = emp;
            lblFullname.Text = "Hello " + emp.Fullname;
            loadProduct();
        }

        public void loadProduct()
        {

            BUS_Product bus = new BUS_Product();
            dgvProduct.DataSource = bus.loadProduct();

            binding();

            QuantityUpDown.Value = 1;

            cbSearch1.Items.Clear();
            cbSearch1.Items.Add("Load all");
            cbSearch1.Items.Add("Product's Name");
            cbSearch1.Items.Add("Prodcut's type");
            cbSearch1.SelectedItem = "Load all";

            cbSearch2.Items.Clear();
            cbSearch2.Items.Add("ID order");
            cbSearch2.Items.Add("Phonenumber");
            cbSearch2.SelectedItem = "ID order";


        }

        private void binding()
        {
            txtProID.DataBindings.Clear();
            txtProName.DataBindings.Clear();
            txtProPrice.DataBindings.Clear();
            txtSize.DataBindings.Clear();
            txtDiscount.DataBindings.Clear();

            txtProID.DataBindings.Add("Text", dgvProduct.DataSource, "IDProduct");
            txtProName.DataBindings.Add("Text", dgvProduct.DataSource, "NameProduct");
            txtProPrice.DataBindings.Add("Text", dgvProduct.DataSource, "Price", false, DataSourceUpdateMode.Never);
            txtSize.DataBindings.Add("Text", dgvProduct.DataSource, "Size");
            txtDiscount.DataBindings.Add("Text", dgvProduct.DataSource, "Discount");
        }
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            QuantityUpDown.Value = 1;
            indexPro = e.RowIndex;

        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexCart = e.RowIndex;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            string id = txtProID.Text;
            string proIdtype = dgvProduct.Rows[indexPro].Cells[2].Value.ToString();
            string name = txtProName.Text;
            float size = float.Parse(txtSize.Text);
            int price = int.Parse(txtProPrice.Text);
            int quantity = int.Parse(QuantityUpDown.Value.ToString());
            string discount = txtDiscount.Text;
            DTO_Product product = findProductByID(id, listCart);
                dgvCart.DataSource = null;
                if (product != null)
                {
                    product.proQuantity += quantity;
                    product.proPrice += price;
                    dgvCart.DataSource = listCart;
                    QuantityUpDown.Value = 1;

                    dgvCart.Columns["proIdType"].Visible = false;
                    dgvCart.Columns["proStatus"].Visible = false;
                }
                else
                {
                    DTO_Product x = new DTO_Product(id, proIdtype, name, size, price, quantity, discount);
                    listCart.Add(x);
                    dgvCart.DataSource = listCart;

                    dgvCart.Columns["proIdType"].Visible = false;
                    dgvCart.Columns["proStatus"].Visible = false;
                    QuantityUpDown.Value = 1;
                }
                loadTotal();
        }


        public DTO_Product findProductByID(string productID, BindingList<DTO_Product> listCart)
        {
            DTO_Product product = listCart.FirstOrDefault(x => x.proID == productID);
            return product;
        }

        private void loadTotal()
        {
            long totalPrice = 0;
            int totalQuantity = 0;
            if (listCart != null)
            {

                foreach (DTO_Product pro in listCart)
                {
                    totalPrice += (Convert.ToInt64(pro.proPrice) * Convert.ToInt64(pro.discount) / 100);
                    totalQuantity += pro.proQuantity;
                }
            }
            lblTotalPrice.Text = totalPrice.ToString();
            lblQuantity.Text = totalQuantity.ToString();
        }

        private void QuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDiscount.Text.Equals(""))
                {
                    txtDiscount.Text = "0";
                }
                DataGridViewRow selectedRow = dgvProduct.Rows[indexPro];
                string oldPriceStr = selectedRow.Cells[5].Value.ToString();
                int oldPrice = int.Parse(oldPriceStr);
                int quantiy = int.Parse(QuantityUpDown.Value.ToString());
                int Price = oldPrice * quantiy;
                txtProPrice.Text = Price.ToString();
            }
            catch
            {

            }
            
        }

        private void txtCusNumber_TextChanged(object sender, EventArgs e)
        {
            BUS_Customer busCus = new BUS_Customer();
            try
            {
                cus = busCus.searchPhone(txtCusPhone1.Text);
                if (cus != null)
                {
                    txtCusName.Text = cus.cusName;
                    txtCusAdress.Text = cus.cusAddress;
                }
                else
                {
                    txtCusName.Text = "";
                    txtCusAdress.Text = "";
                }
            }
            catch
            {
                txtCusName.Text = "";
                txtCusAdress.Text = "";
                txtCusPhone1.Clear();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            int count = 0;
            BUS_Order bus = new BUS_Order();
            BUS_Orderdetail busOderDetail = new BUS_Orderdetail();
            BUS_Customer busCus = new BUS_Customer();
            string valid = checkConfirm();
            if (valid.Equals(""))
            {
                if (cus != null)
                {
                    string cusphone = cus.cusPhonenumber;
                    string idEmp = employee.Username;
                    long totalPrice = int.Parse(lblTotalPrice.Text);
                    int totalQuantity = int.Parse(lblQuantity.Text);
                    DTO_Order order = new DTO_Order(cusphone, idEmp, totalPrice, totalQuantity);
                    int IDOrder = bus.createOrder(order);

                    foreach (DTO_Product pro in listCart)
                    {
                        DTO_OrderDetail detail = new DTO_OrderDetail(IDOrder, pro.proID, pro.proPrice, pro.discount, pro.proQuantity);
                        int counts = busOderDetail.createOrderDetail(detail);
                        count += counts;
                    }
                    showBill();
                    MessageBox.Show(count.ToString());
                }
                else
                {
                    string newCus = txtCusName.Text;
                    string newPhone = txtCusPhone1.Text;
                    string newAdd = txtCusAdress.Text;
                    cus = new DTO_Customer(newPhone, newCus, newAdd);
                    busCus.creatCustomer(cus);
                    string idEmp = employee.Username;
                    int totalQuantity = int.Parse(lblQuantity.Text);
                    long totalPrice = int.Parse(lblTotalPrice.Text);

                    DTO_Order order = new DTO_Order(cus.cusPhonenumber, idEmp, totalPrice, totalQuantity);
                    int IDOrder = bus.createOrder(order);

                    foreach (DTO_Product pro in listCart)
                    {
                        DTO_OrderDetail detail = new DTO_OrderDetail(IDOrder, pro.proID, pro.proPrice, pro.discount, pro.proQuantity);
                        int counts = busOderDetail.createOrderDetail(detail);
                        count += counts;
                    }
                    MessageBox.Show(count.ToString());
                    showBill();
                }
                clear1();
                loadProduct();
            }
            else
            {
                MessageBox.Show(valid);
            }
        }


        public void clear1()
        {
            txtCusPhone1.Clear();
            txtCusAdress.Clear();
            txtCusName.Clear();
            txtSearch1.Clear();
            listCart.Clear();
            dgvCart.Columns.Clear();
        }

        private string checkConfirm()
        {
            string valid = "";
            if (txtCusPhone1.Text.Equals("") || txtCusPhone1.Text.Length < 9)
            {
                valid += " 'Numberphone' isn't valid\n";
            }
            if (txtCusName.Text.Equals(""))
            {
                valid += "\n 'Customer name' is empty\n";
            }
            if (txtCusAdress.Text.Equals(""))
            {
                valid += "\n 'Address' is empty\n";
            }
            if (listCart.Count <= 0)
            {
                valid += "\n 'Cart' is empty, cannot confirm";
            }
            return valid;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvCart.Rows[indexCart];
                string id = selectedRow.Cells[0].Value.ToString();
                DTO_Product product = findProductByID(id, listCart);
                listCart.Remove(product);
                dgvCart.DataSource = listCart;
                loadTotal();
                if (listCart.Count == 0)
                {
                    dgvCart.Columns.Clear();
                }
            }
            catch (Exception)
            {
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            BUS_Product bus = new BUS_Product();
            if (cbSearch1.SelectedIndex == 0)
            {
                txtSearch1.Clear();
                loadProduct();
            }
            else if (cbSearch1.SelectedIndex == 1)
            {
                string name = txtSearch1.Text;
                dgvProduct.DataSource = bus.loadProByName(name);
                binding();
                
            }
            else
            {
                string type = txtSearch1.Text;
                dgvProduct.DataSource = bus.loadProByType(type);
                binding();
            }
        }

        // TAB INFOVIEW


        public void loadOrder()
        {
            txtProID2.DataBindings.Clear();
            txtProName2.DataBindings.Clear();
            txtProPrice2.DataBindings.Clear();
            txtProSize2.DataBindings.Clear();
            txtProQuantity2.DataBindings.Clear();
            txtTotal2.DataBindings.Clear();
            txtCusName2.DataBindings.Clear();
            txtCusPhone2.DataBindings.Clear();


            txtProID2.DataBindings.Add("Text", dgvOrderDetail.DataSource, "IDProduct");
            txtProName2.DataBindings.Add("Text", dgvOrderDetail.DataSource, "NameProduct");
            txtProPrice2.DataBindings.Add("Text", dgvOrderDetail.DataSource, "Price");
            txtProSize2.DataBindings.Add("Text", dgvOrderDetail.DataSource, "Size");
            txtProQuantity2.DataBindings.Add("Text", dgvOrderDetail.DataSource, "Quantity");

            txtCusName2.DataBindings.Add("Text", dgvOrder.DataSource, "FullName");
            txtCusPhone2.DataBindings.Add("Text", dgvOrder.DataSource, "CusPhone");
            txtTotal2.DataBindings.Add("Text", dgvOrder.DataSource, "PriceFinal");
        }
        private void clear2()
        {

            dgvOrder.DataSource = null;
            dgvOrderDetail.DataSource = null;

            txtSearch2.Clear();
            txtCusPhone2.Clear();
            txtCusName2.Clear();
            txtIdOrder2.Clear();
            txtProID2.Clear();
            txtProName2.Clear();
            txtProSize2.Clear();
            txtProPrice2.Clear();
            txtProQuantity2.Clear();
            txtTotal2.Clear();
            lblTotalPrice.Text = "0";
            lblQuantity.Text = "0";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BUS_Order busOrder = new BUS_Order();
            BUS_Orderdetail busDetail = new BUS_Orderdetail();
            if (cbSearch2.SelectedIndex == 0)
            {
                string id = txtSearch2.Text;
                dgvOrder.DataSource = busOrder.searchOrderByIdOrder(id);
            }
            else
            {
                string phone = txtSearch2.Text;
                dgvOrder.DataSource = busOrder.searchOrderByPhone(phone);
            }
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BUS_Orderdetail busDetail = new BUS_Orderdetail();
            DataGridViewRow selectedRow = dgvOrder.CurrentRow;
            string id = selectedRow.Cells[0].Value.ToString();
            txtIdOrder2.Text = id;
            dgvOrderDetail.DataSource = busDetail.searchDetailByIdOrder(id);
            loadOrder();

        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            clear2();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            showBill();
        }

        private void showBill()
        {
            fmBill f = new fmBill(employee, listCart.ToList(), cus, lblTotalPrice.Text);
            f.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
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

    }
}
