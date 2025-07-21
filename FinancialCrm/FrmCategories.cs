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
using System.Windows.Forms.DataVisualization.Charting;



namespace FinancialCrm
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            var values = db.Categories
                           .Select(c => new 
                           {
                               c.CategoryId,
                               c.CategoryName
                           })
                           .ToList();

            dgvCategories.DataSource = values;

          
            if (dgvCategories.Columns.Contains("Spendings"))
            {
                dgvCategories.Columns["Spendings"].Visible = false;
            }
       
        }

        private void btnCategoryId_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Kategori adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categories category = new Categories();
            category.CategoryName = categoryName;

            db.Categories.Add(category);
            db.SaveChanges();

            MessageBox.Show("Kategori başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadCategories();

        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            var categories = db.Categories.ToList();
            dgvCategories.DataSource = categories;

            if (dgvCategories.Columns.Contains("Spendings"))
            {
                dgvCategories.Columns["Spendings"].Visible = false;
            }
           
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtCategoryID.Text, out id))
            {
                MessageBox.Show("Geçerli bir ID giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var category = db.Categories.Find(id);
            if (category == null)
            {
                MessageBox.Show("Kategori bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            db.Categories.Remove(category);
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadCategories();
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtCategoryID.Text, out int id))
            {


                MessageBox.Show("Geçerli bir Kategori ID giriniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var category = db.Categories.Find(id);
            if (category == null)
            {
                MessageBox.Show("Bu ID'ye sahip bir kategori bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string newName = txtCategoryName.Text.Trim();
            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Kategori adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            category.CategoryName = newName;
            db.SaveChanges();

            MessageBox.Show("Kategori başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCategories();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }

        private void btnBanks_Click_1(object sender, EventArgs e)
        {

            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnInvoice_Click_1(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btnBillForm_Click_1(object sender, EventArgs e)
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
