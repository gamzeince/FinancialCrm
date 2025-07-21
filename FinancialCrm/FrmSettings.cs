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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            cmbDefaultPage.Items.Clear();
            cmbDefaultPage.Items.Add("Dashboard");
            cmbDefaultPage.Items.Add("Bankalar");
            cmbDefaultPage.Items.Add("Giderler");
            cmbDefaultPage.Items.Add("Faturalar");
            cmbDefaultPage.Items.Add("Ayarlar");

           
            cmbDefaultPage.SelectedIndex = 0; 
            rbLightTheme.Checked = true;    
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            string selectedPage = cmbDefaultPage.SelectedItem?.ToString() ?? "Dashboard";
            string selectedTheme = rbLightTheme.Checked ? "Light" : "Dark";

            MessageBox.Show($"Ayarlar kaydedildi!\n\nTema: {selectedTheme}\nBaşlangıç Sayfası: {selectedPage}",
                            "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }
    }
}
