using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(
            new Pen(ColorTranslator.FromHtml("#E1E7F0"), 1),
            0, 0, pnlCard.Width - 1, pnlCard.Height - 1);
        }

        private void lblBrand_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Multiline = true;

            txtUserPs.Multiline = false;
            txtUserPs.UseSystemPasswordChar = true;


            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.BackColor = Color.White;
            txtUser.ForeColor = ColorTranslator.FromHtml("#212529"); 

            txtUserPs.BorderStyle = BorderStyle.FixedSingle;
            txtUserPs.BackColor = Color.White;
            txtUserPs.ForeColor = ColorTranslator.FromHtml("#212529");
        }

        private void pnlUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();  
            string password = txtUserPs.Text.Trim();
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) 
            {
                MessageBox.Show("Kullanıcı adı ve şifre giriniz..", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new FinancialCrmDbEntities())
            {
                var user = db.Users
                    .FirstOrDefault(u => u.Username == username && u.Password == password);
                if (user != null)
                {
                    FrmDashboard frm = new FrmDashboard();
                    frm.Show(); 
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
