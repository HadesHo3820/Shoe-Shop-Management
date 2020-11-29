using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ShoeShopManager
{
    public partial class fmBill : Form
    {
        DTO_Employee emp = new DTO_Employee();
        public fmBill()
        {
            InitializeComponent();
            
        }

       public fmBill(DTO_Employee emp, List<DTO_Product> list, DTO_Customer cus, string totalPrice)
        {
            InitializeComponent();
            txtcashier.Text = "Cashier: " +  emp.Fullname;
            txtCus.Text = "Customer: " + cus.cusName;
            String bill = String.Format("{0,-4} {1,-60} {2,-40} {3,-40} {4,-40}\n\n\n", "No.", "Product", "Quantity", "Price", "Amount");
            for(int i = 0; i < list.Count; i++)
            {
                bill += String.Format("{0,-4} {1,-60} {2,-40} {3,-40} {4,-40}\n {5,-1000}\n", (i+1),list[i].proName,list[i].proQuantity.ToString().Trim(),(list[i].proPrice/list[i].proQuantity),list[i].proPrice,"-" + list[i].discount + "%");
            }
            lblInfoBill.Text = bill;
            lblTotal.Text = totalPrice;
            lblDate.Text ="Date: " + DateTime.Today.ToString("d");
        }
    }
}
