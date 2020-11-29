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

namespace Project_ShoeShopManager
{
    public partial class fmLogin : Form
    {
        private DTO_Employee emp = new DTO_Employee();
        public fmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BUS_Employee busEmp = new BUS_Employee();
            string username = txtLogin.Text;
            string pass = txtPass.Text;
            string check = chekcLoginForm();
            if(check.Equals(""))
            {         
                emp = busEmp.Login(username, pass);
                if(emp != null)
                {
                    if (emp.role.Equals("Cashier"))
                    {
                        this.Hide();
                        Thread t = new Thread(new ThreadStart(showfmEmployee));
                        t.Start();
                        this.Close();

                    }
                    if (emp.role.Equals("Manager"))
                    {
                        this.Hide();
                        Thread t = new Thread(new ThreadStart(showfmManager));
                        t.Start();
                        this.Close();
                    }
                    if (emp.role.Equals("Admin"))
                    {
                        this.Hide();
                        Thread t = new Thread(new ThreadStart(showfmAdmin));
                        t.Start();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid account");
                }
            }
            else
            {
                MessageBox.Show(check);
            }
        }
        private void showfmEmployee()
        {
            fmCashier f = new fmCashier(emp);
            Application.Run(f);
        }

        private void showfmManager()
        {
            fmManager f = new fmManager(emp);
            Application.Run(f);
        }

        private void showfmAdmin()
        {
            fmAdmin f = new fmAdmin(emp);
            Application.Run(f);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtPass.Text = "";
        }

        private string chekcLoginForm()
        {
            string valid = "";
            if (txtLogin.Text.Length == 0 || txtLogin.Text.Trim().Equals(""))
            {
                valid += "Username cannot empty";
            }
            if (txtPass.Text.Length == 0 || txtPass.Text.Trim().Equals(""))
            {
                valid += "\nPassword cannot empty";
            }
            return valid;
        }
    }
         
}

     
    

