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
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values  = db.Bills.ToList();    
            dataGridView1.DataSource = values;  
        }

     
        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            Bills bills = new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sisteme Eklendi", "Ödeme Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);


            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var remoteValue = db.Bills.Find(id);    
            db.Bills.Remove(remoteValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sistemden Silindi", "Ödeme Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string title  = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text; 
            int id = int.Parse(txtBillId.Text); 

             var updateValue = db.Bills.Find(id);   

            updateValue.BillTitle = title;
            updateValue.BillAmount = amount;    
            updateValue.BillPeriod = period;
            db.SaveChanges();

            MessageBox.Show("Ödeme Başarılı Bir Şekilde Güncellendi", "Ödeme Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks(); 
            frmBanks.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBillList_Click(object sender, EventArgs e)
        {

        }

        private void btnCategorieseww_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();  
            frmCategories.Show();   
                this.Hide();    
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();   
            frmBilling.Show();  
            this.Hide();    
        }

        private void btnCosts_Click(object sender, EventArgs e)
        {
           FrmExpenses frmExpenses = new FrmExpenses();   
            frmExpenses.Show();    
            this.Hide();    
        }
           

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard(); 
            frmDashboard.Show();    
            this.Hide();    
        }

        private void btnBanksTransactions_Click(object sender, EventArgs e)
        {
            FrmBankTransactions frmBankTransactions = new FrmBankTransactions();
            frmBankTransactions.Show();
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
