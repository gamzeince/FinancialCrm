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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        int count = 0;

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();   
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totatlBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totatlBalance.ToString() + "₺";

            var lastBankProcessAmount = db.BankProcesses.OrderByDescending
                (x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lblLasrBankProcessAmount.Text = lastBankProcessAmount.ToString() + "₺";


            //chart1 kodları 
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance,

            }).ToList();

            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
           
            foreach (var item in bankData)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }


            //chart2 kodları 

            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount,

            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar"); 
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko;    
            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 4 == 1)
            {
                var bill1 = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();

                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text = bill1.ToString() + "₺";
;            }

            if (count % 4 == 2)
            {
                var bill1 = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();

                lblBillTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = bill1.ToString() + "₺";
                
            }

            if (count % 4 == 3)
            {
                var bill1 = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();

                lblBillTitle.Text = "Su Faturası";
                lblBillAmount.Text = bill1.ToString() + "₺";

            }

            if (count % 4 == 0)
            {
                var bill1 = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();

                lblBillTitle.Text = "İnternet Faturası";
                lblBillAmount.Text = bill1.ToString() + "₺";

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCategorieseww_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();  
            frmCategories.Show();   
            this.Hide();    
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks(); 
            frmBanks.Show();    
            this.Hide();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();   
            frmBilling.Show();  
            this.Hide();    
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
          FrmExpenses frmExpenses = new FrmExpenses();   
            frmExpenses.Show();    
            this.Hide();
        }

        private void btnBanksTransactions_Click(object sender, EventArgs e)
        {
            FrmBankTransactions frmBankTransactions = new FrmBankTransactions();    
            frmBankTransactions.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard(); 
            frmDashboard.Show();    
            this.Hide();    
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show(); 
            this.Hide();    
        }
    }
}
