using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBankTransactions : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        public FrmBankTransactions()
        {
            InitializeComponent();
            this.Load += FrmBankTransactions_Load;
        }

        private void FrmBankTransactions_Load(object sender, EventArgs e)
        {
          
            var banks = db.Banks
                          .Select(b => new { b.BankId, b.BankTitle })
                          .ToList();

            cmbBankAllList.DisplayMember = "BankTitle";
            cmbBankAllList.ValueMember = "BankId";
            cmbBankAllList.DataSource = banks;
           
            rbLast5.Checked = false;
            rbLast30Days.Checked = false;
            rbThisMonth.Checked = false;
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            if (cmbBankAllList.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir banka seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedBankId = (int)cmbBankAllList.SelectedValue;
            DateTime today = DateTime.Today;

            var query = db.BankProcesses
                          .Where(p => p.BankId == selectedBankId);

            if (rbLast5.Checked)
            {
                query = query.OrderByDescending(p => p.ProcessDate).Take(5);
            }
            else if (rbLast30Days.Checked)
            {
                DateTime limitDate = today.AddDays(-30);
                query = query.Where(p => p.ProcessDate >= limitDate)
                             .OrderByDescending(p => p.ProcessDate);
            }
            else if (rbThisMonth.Checked)
            {
                DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
                query = query.Where(p => p.ProcessDate >= firstDayOfMonth)
                             .OrderByDescending(p => p.ProcessDate);
            }
            else
            {
                query = query.OrderByDescending(p => p.ProcessDate);
            }

           
            dgvBankTransactions.DataSource = query
                .Select(p => new
                {
                    Tarih = p.ProcessDate,
                    Tür = p.ProcessType,
                    Açıklama = p.Description,
                    Tutar = p.Amount
                })
                .ToList();
        }

      
        private void btnBanksTransactions_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCategorieseww_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnCosts_Click(object sender, EventArgs e)
        {
            FrmExpenses frm = new FrmExpenses();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.ShowDialog();
            this.Hide();
        }

        private void cmbBankAllList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();    
            frmSettings.Show(); 
            this.Hide();    
        }
    }
}
