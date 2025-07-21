namespace FinancialCrm
{
    partial class FrmLogin
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
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserPs = new System.Windows.Forms.TextBox();
            this.lnkForgot = new System.Windows.Forms.LinkLabel();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkSignUp = new System.Windows.Forms.LinkLabel();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBrand.Location = new System.Drawing.Point(4, 31);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(455, 32);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "\tHesabınıza Giriş Yapın – Financial CRM";
            this.lblBrand.Click += new System.EventHandler(this.lblBrand_Click);
            // 
            // pnlCard
            // 
            this.pnlCard.AutoSize = true;
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.lnkSignUp);
            this.pnlCard.Controls.Add(this.label4);
            this.pnlCard.Controls.Add(this.label1);
            this.pnlCard.Controls.Add(this.txtUser);
            this.pnlCard.Controls.Add(this.btnLogin);
            this.pnlCard.Controls.Add(this.label3);
            this.pnlCard.Controls.Add(this.txtUserPs);
            this.pnlCard.Controls.Add(this.lnkForgot);
            this.pnlCard.Controls.Add(this.lblBrand);
            this.pnlCard.Controls.Add(this.chkRemember);
            this.pnlCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.pnlCard.Location = new System.Drawing.Point(8, 12);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(463, 594);
            this.pnlCard.TabIndex = 3;
            this.pnlCard.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogin.Location = new System.Drawing.Point(157, 398);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 50);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(114, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre";
            // 
            // txtUserPs
            // 
            this.txtUserPs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserPs.Location = new System.Drawing.Point(118, 234);
            this.txtUserPs.Name = "txtUserPs";
            this.txtUserPs.Size = new System.Drawing.Size(200, 20);
            this.txtUserPs.TabIndex = 8;
            // 
            // lnkForgot
            // 
            this.lnkForgot.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.lnkForgot.AutoSize = true;
            this.lnkForgot.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.lnkForgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.lnkForgot.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lnkForgot.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.lnkForgot.Location = new System.Drawing.Point(115, 307);
            this.lnkForgot.Name = "lnkForgot";
            this.lnkForgot.Size = new System.Drawing.Size(121, 13);
            this.lnkForgot.TabIndex = 6;
            this.lnkForgot.TabStop = true;
            this.lnkForgot.Text = "Parolanızı mı unuttunuz?";
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Location = new System.Drawing.Point(118, 276);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(80, 17);
            this.chkRemember.TabIndex = 5;
            this.chkRemember.Text = "Beni Hatırla";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Location = new System.Drawing.Point(118, 165);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 20);
            this.txtUser.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(114, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(39, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hesabınıza Erişmek İçin Kullanıcı Adı ve Şifrenizi Giriniz";
            // 
            // lnkSignUp
            // 
            this.lnkSignUp.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(42)))), ((int)(((byte)(70)))));
            this.lnkSignUp.AutoSize = true;
            this.lnkSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lnkSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.lnkSignUp.Location = new System.Drawing.Point(30, 546);
            this.lnkSignUp.Name = "lnkSignUp";
            this.lnkSignUp.Size = new System.Drawing.Size(135, 13);
            this.lnkSignUp.TabIndex = 15;
            this.lnkSignUp.TabStop = true;
            this.lnkSignUp.Text = "Hesabınız yok mu? Kayıt Ol\n";
            this.lnkSignUp.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(483, 618);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.LinkLabel lnkForgot;
        private System.Windows.Forms.TextBox txtUserPs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkSignUp;
    }
}