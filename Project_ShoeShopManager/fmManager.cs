using BUS;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_ShoeShopManager
{
    public partial class fmManager : Form
    {
        DTO_Employee employee = new DTO_Employee();
        DataTable dt;
        public fmManager()
        {
            InitializeComponent();
        }

        public fmManager(DTO_Employee emp) : this()
        {
            this.AutoSize = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            employee = emp;
            lblFullname.Text = "Hello " + emp.Fullname;
            loadRevenueByYear();
            loadTop5Revenue();
            
        }

        private void loadTop5Revenue()
        {
            BUS_Revenue bus = new BUS_Revenue();
            string datebegin = DateFrom.Value.ToString("yyyy-MM-dd 00:00:00.999");
            string dateend = DateTo.Value.ToString("yyyy-MM-dd 23:59:59.999");
            dt = bus.loadTop5Revenue(datebegin, dateend);
            dgvTotalOrder.DataSource = dt;

            List<DTO_Revenue> listRevenue = bus.toList(dt);
            chartTop.Series["Top"].Points.Clear();
            for (int i = 0; i < listRevenue.Count; i++)
            {
                chartTop.Series["Top"].Points.AddXY(listRevenue[i].nameProduct,listRevenue[i].totalRevenue);
                chartTop.Series["Top"].IsValueShownAsLabel = false;
                chartTop.Series["Top"]["PieLabelStyle"] = "Disabled";
                chartTop.Series["Top"].Points[i].Label = listRevenue[i].nameProduct+ "(#PERCENT)";
            }
        }

        private void loadRevenueByYear()
        {
            BUS_Revenue bus = new BUS_Revenue();
            List<DTO_Revenue> revenueslist = bus.loadRevenueByYear(txtYearSearch.Text + "-01-01 00:00:00.999", txtYearSearch.Text + "-12-31 23:59:59.999");
            chartRevenue.Series["Revenue"].Points.Clear();
            for (int i = 0; i < revenueslist.Count; i++)
            {
                chartRevenue.Series["Revenue"].Points.AddXY(revenueslist[i].month, revenueslist[i].totalRevenue);
                chartRevenue.Series["Revenue"].Points[i].Label = revenueslist[i].totalRevenue.ToString();
            }
        }

        private void DateFrom_ValueChanged(object sender, EventArgs e)
        {
            loadTop5Revenue();

        }

        private void DateTo_ValueChanged(object sender, EventArgs e)
        {
            loadTop5Revenue();
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

        
        private void txtYearSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loadRevenueByYear();
            }
            catch 
            {

            }  
        }
    }
}
