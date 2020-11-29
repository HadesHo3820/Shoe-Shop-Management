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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ShoeShopManager
{
    public partial class fmAddQuanity : Form
    {
        private int quantity;
        private string ID;
        public fmAddQuanity()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public fmAddQuanity(string idPro) : this()
        {
            ID = idPro;
            lblIdPro.Text = "ID product: " + ID;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            BUS_Product bus = new BUS_Product();
            
            if (!Regex.Match(txtQuantity.Text, "^[0-9]{1,10}$").Success)
            {
                lblSuccess.Text = "Please input number!!!";
                txtQuantity.Text = "";
            }
            else
            {
                quantity = Convert.ToInt32(txtQuantity.Text);
                bool check =  bus.updateQuantityPro(quantity, ID);
                if (check)
                {
                    this.Close();
                }
            }  
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
