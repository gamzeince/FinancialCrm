using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;


namespace FinancialCrm
{
    public partial class FrmExpenses : Form
    {

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();   
        public FrmExpenses()
        {
            InitializeComponent();
        
        }

        private void FrmExpenses_Load(object sender, EventArgs e)
        {
            cmbMonth.Items.AddRange(new string[]
            {
                "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran",
                "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"
            });
        }

  
     
        private void ShowChartAndGrid(dynamic data, string chartTitle)
        {
            dgvExpenses.DataSource = data;

            chartExpenses.Series.Clear();
            chartExpenses.Titles.Clear();
            var chartArea = chartExpenses.ChartAreas[0];
            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

          
            chartArea.AxisX.LabelStyle.Angle = -45;
            chartArea.AxisX.Interval = 1; 

         
            var series = chartExpenses.Series.Add(chartTitle);
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series.Color = Color.DeepSkyBlue;
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.DarkSlateGray;
            series.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            foreach (var item in data)
            {
                series.Points.AddXY(item.Kategori, item.ToplamTutar);
            }
        }



        private void btnCategorieseww_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.ShowDialog();
            this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
                frmBanks.ShowDialog();  
            this.Hide();    
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
           FrmBilling frmBilling = new FrmBilling();
            frmBilling.ShowDialog();
            this.Hide();
        }

        private void btnCosts_Click(object sender, EventArgs e)
        {
            FrmExpenses frmExpenses = new FrmExpenses();
            frmExpenses.ShowDialog();   
            this.Hide();    

        }

        private void btnBanksTransactions_Click(object sender, EventArgs e)
        {
            FrmBankTransactions frmBankTransactions = new FrmBankTransactions();
            frmBankTransactions.ShowDialog();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard(); 
            frmDashboard.ShowDialog();  
            this.Hide();    
        }

        private void btnShowAllData_Click(object sender, EventArgs e)
        {
            var data = db.Spendings
                       .Where(s => s.SpendingDate.HasValue)
                       .GroupBy(s => s.Categories.CategoryName)
                       .Select(g => new
                       {
                           Kategori = g.Key,
                           ToplamTutar = g.Sum(x => x.SpendingAmount)
                       })
                       .ToList();

            ShowChartAndGrid(data, "Toplam Giderler");
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir ay seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedMonth = cmbMonth.SelectedIndex + 1;

            var data = db.Spendings
                         .Where(s => s.SpendingDate.HasValue && s.SpendingDate.Value.Month == selectedMonth)
                         .GroupBy(s => s.Categories.CategoryName)
                         .Select(g => new
                         {
                             Kategori = g.Key,
                             ToplamTutar = g.Sum(x => x.SpendingAmount)
                         })
                         .ToList();

            ShowChartAndGrid(data, "Aylık Giderler");
        }

        private void chartExpenses_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.ShowDialog();   
            this.Hide();    
        }
    }
}
