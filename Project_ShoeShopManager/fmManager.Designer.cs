namespace Project_ShoeShopManager
{
    partial class fmManager
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtYearSearch = new System.Windows.Forms.TextBox();
            this.chartTop = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTotalOrder = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFullname = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1676, 935);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtYearSearch);
            this.tabPage1.Controls.Add(this.chartTop);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chartRevenue);
            this.tabPage1.Controls.Add(this.dgvTotalOrder);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.DateTo);
            this.tabPage1.Controls.Add(this.DateFrom);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1668, 902);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Statistic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtYearSearch
            // 
            this.txtYearSearch.Location = new System.Drawing.Point(1496, 26);
            this.txtYearSearch.Name = "txtYearSearch";
            this.txtYearSearch.Size = new System.Drawing.Size(149, 26);
            this.txtYearSearch.TabIndex = 18;
            this.txtYearSearch.Text = "2020";
            this.txtYearSearch.TextChanged += new System.EventHandler(this.txtYearSearch_TextChanged);
            // 
            // chartTop
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTop.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTop.Legends.Add(legend1);
            this.chartTop.Location = new System.Drawing.Point(42, 536);
            this.chartTop.Name = "chartTop";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Top";
            this.chartTop.Series.Add(series1);
            this.chartTop.Size = new System.Drawing.Size(679, 311);
            this.chartTop.TabIndex = 17;
            this.chartTop.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1434, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Year";
            // 
            // chartRevenue
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend2);
            this.chartRevenue.Location = new System.Drawing.Point(796, 77);
            this.chartRevenue.Name = "chartRevenue";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelForeColor = System.Drawing.Color.OrangeRed;
            series2.Legend = "Legend1";
            series2.Name = "Revenue";
            series2.ShadowColor = System.Drawing.Color.LightSkyBlue;
            series2.YValuesPerPoint = 2;
            this.chartRevenue.Series.Add(series2);
            this.chartRevenue.Size = new System.Drawing.Size(849, 770);
            this.chartRevenue.TabIndex = 13;
            this.chartRevenue.Text = "chart1";
            // 
            // dgvTotalOrder
            // 
            this.dgvTotalOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalOrder.Location = new System.Drawing.Point(27, 77);
            this.dgvTotalOrder.MultiSelect = false;
            this.dgvTotalOrder.Name = "dgvTotalOrder";
            this.dgvTotalOrder.ReadOnly = true;
            this.dgvTotalOrder.RowHeadersWidth = 62;
            this.dgvTotalOrder.RowTemplate.Height = 28;
            this.dgvTotalOrder.Size = new System.Drawing.Size(694, 405);
            this.dgvTotalOrder.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "From";
            // 
            // DateTo
            // 
            this.DateTo.Location = new System.Drawing.Point(444, 30);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(277, 26);
            this.DateTo.TabIndex = 10;
            this.DateTo.ValueChanged += new System.EventHandler(this.DateTo_ValueChanged);
            // 
            // DateFrom
            // 
            this.DateFrom.Location = new System.Drawing.Point(85, 30);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(291, 26);
            this.DateFrom.TabIndex = 6;
            this.DateFrom.ValueChanged += new System.EventHandler(this.DateFrom_ValueChanged);
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFullname.Location = new System.Drawing.Point(19, 13);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(82, 29);
            this.lblFullname.TabIndex = 1;
            this.lblFullname.Text = "Name";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1587, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(97, 33);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // fmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 1002);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.tabControl1);
            this.Name = "fmManager";
            this.Text = "fmManager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvTotalOrder;
        private System.Windows.Forms.DateTimePicker DateFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop;
        private System.Windows.Forms.TextBox txtYearSearch;
    }
}