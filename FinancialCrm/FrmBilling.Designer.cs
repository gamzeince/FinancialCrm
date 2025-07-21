namespace FinancialCrm
{
    partial class FrmBilling
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBanksTransactions = new System.Windows.Forms.Button();
            this.btnCosts = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnBanks = new System.Windows.Forms.Button();
            this.btnCategorieseww = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateBill = new System.Windows.Forms.Button();
            this.btnRemoveBill = new System.Windows.Forms.Button();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.btnBillList = new System.Windows.Forms.Button();
            this.txtBillPeriod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.lblBankProcess2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnBanksTransactions);
            this.panel1.Controls.Add(this.btnCosts);
            this.panel1.Controls.Add(this.btnInvoice);
            this.panel1.Controls.Add(this.btnBanks);
            this.panel1.Controls.Add(this.btnCategorieseww);
            this.panel1.Location = new System.Drawing.Point(1, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 484);
            this.panel1.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Location = new System.Drawing.Point(16, 419);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(150, 50);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = " Çıkış Yap";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.btnSettings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.ForeColor = System.Drawing.Color.Transparent;
            this.btnSettings.Location = new System.Drawing.Point(16, 363);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(150, 50);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.btnDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Location = new System.Drawing.Point(16, 307);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(150, 50);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnBanksTransactions
            // 
            this.btnBanksTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.btnBanksTransactions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksTransactions.ForeColor = System.Drawing.Color.Transparent;
            this.btnBanksTransactions.Location = new System.Drawing.Point(16, 251);
            this.btnBanksTransactions.Name = "btnBanksTransactions";
            this.btnBanksTransactions.Size = new System.Drawing.Size(150, 50);
            this.btnBanksTransactions.TabIndex = 4;
            this.btnBanksTransactions.Text = "Banka Hareketleri";
            this.btnBanksTransactions.UseVisualStyleBackColor = false;
            this.btnBanksTransactions.Click += new System.EventHandler(this.btnBanksTransactions_Click);
            // 
            // btnCosts
            // 
            this.btnCosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.btnCosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCosts.ForeColor = System.Drawing.Color.Transparent;
            this.btnCosts.Location = new System.Drawing.Point(16, 195);
            this.btnCosts.Name = "btnCosts";
            this.btnCosts.Size = new System.Drawing.Size(150, 50);
            this.btnCosts.TabIndex = 3;
            this.btnCosts.Text = "Giderler";
            this.btnCosts.UseVisualStyleBackColor = false;
            this.btnCosts.Click += new System.EventHandler(this.btnCosts_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.btnInvoice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInvoice.ForeColor = System.Drawing.Color.Transparent;
            this.btnInvoice.Location = new System.Drawing.Point(16, 139);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(150, 50);
            this.btnInvoice.TabIndex = 2;
            this.btnInvoice.Text = "Faturalar";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnBanks
            // 
            this.btnBanks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.btnBanks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanks.ForeColor = System.Drawing.Color.Transparent;
            this.btnBanks.Location = new System.Drawing.Point(16, 83);
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.Size = new System.Drawing.Size(150, 50);
            this.btnBanks.TabIndex = 1;
            this.btnBanks.Text = "Bankalar";
            this.btnBanks.UseVisualStyleBackColor = false;
            this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
            // 
            // btnCategorieseww
            // 
            this.btnCategorieseww.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.btnCategorieseww.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategorieseww.ForeColor = System.Drawing.Color.Transparent;
            this.btnCategorieseww.Location = new System.Drawing.Point(16, 24);
            this.btnCategorieseww.Name = "btnCategorieseww";
            this.btnCategorieseww.Size = new System.Drawing.Size(150, 50);
            this.btnCategorieseww.TabIndex = 0;
            this.btnCategorieseww.Text = "Kategoriler";
            this.btnCategorieseww.UseVisualStyleBackColor = false;
            this.btnCategorieseww.Click += new System.EventHandler(this.btnCategorieseww_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdateBill);
            this.panel2.Controls.Add(this.btnRemoveBill);
            this.panel2.Controls.Add(this.btnCreateBill);
            this.panel2.Controls.Add(this.btnBillList);
            this.panel2.Controls.Add(this.txtBillPeriod);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtBillAmount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBillTitle);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtBillId);
            this.panel2.Controls.Add(this.lblBankProcess2);
            this.panel2.Location = new System.Drawing.Point(192, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 165);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnUpdateBill
            // 
            this.btnUpdateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(135)))));
            this.btnUpdateBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateBill.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateBill.Location = new System.Drawing.Point(603, 102);
            this.btnUpdateBill.Name = "btnUpdateBill";
            this.btnUpdateBill.Size = new System.Drawing.Size(150, 50);
            this.btnUpdateBill.TabIndex = 15;
            this.btnUpdateBill.Text = "Ödeme Güncelle";
            this.btnUpdateBill.UseVisualStyleBackColor = false;
            this.btnUpdateBill.Click += new System.EventHandler(this.btnUpdateBill_Click);
            // 
            // btnRemoveBill
            // 
            this.btnRemoveBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(135)))));
            this.btnRemoveBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveBill.ForeColor = System.Drawing.Color.Transparent;
            this.btnRemoveBill.Location = new System.Drawing.Point(440, 102);
            this.btnRemoveBill.Name = "btnRemoveBill";
            this.btnRemoveBill.Size = new System.Drawing.Size(150, 50);
            this.btnRemoveBill.TabIndex = 14;
            this.btnRemoveBill.Text = "Ödeme Sil";
            this.btnRemoveBill.UseVisualStyleBackColor = false;
            this.btnRemoveBill.Click += new System.EventHandler(this.btnRemoveBill_Click);
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(135)))));
            this.btnCreateBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateBill.ForeColor = System.Drawing.Color.Transparent;
            this.btnCreateBill.Location = new System.Drawing.Point(284, 102);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(150, 50);
            this.btnCreateBill.TabIndex = 13;
            this.btnCreateBill.Text = "Yeni Ödeme";
            this.btnCreateBill.UseVisualStyleBackColor = false;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // btnBillList
            // 
            this.btnBillList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(135)))));
            this.btnBillList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillList.ForeColor = System.Drawing.Color.Transparent;
            this.btnBillList.Location = new System.Drawing.Point(128, 102);
            this.btnBillList.Name = "btnBillList";
            this.btnBillList.Size = new System.Drawing.Size(150, 50);
            this.btnBillList.TabIndex = 8;
            this.btnBillList.Text = "Ödeme Listesi";
            this.btnBillList.UseVisualStyleBackColor = false;
            this.btnBillList.Click += new System.EventHandler(this.btnBillList_Click);
            // 
            // txtBillPeriod
            // 
            this.txtBillPeriod.Location = new System.Drawing.Point(542, 35);
            this.txtBillPeriod.Name = "txtBillPeriod";
            this.txtBillPeriod.Size = new System.Drawing.Size(141, 20);
            this.txtBillPeriod.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(449, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Periyot";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(542, 2);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(141, 20);
            this.txtBillAmount.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(449, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Miktar";
            // 
            // txtBillTitle
            // 
            this.txtBillTitle.Location = new System.Drawing.Point(257, 37);
            this.txtBillTitle.Name = "txtBillTitle";
            this.txtBillTitle.Size = new System.Drawing.Size(141, 20);
            this.txtBillTitle.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(164, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Başlık";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBillId
            // 
            this.txtBillId.Location = new System.Drawing.Point(257, 3);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(141, 20);
            this.txtBillId.TabIndex = 6;
            // 
            // lblBankProcess2
            // 
            this.lblBankProcess2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankProcess2.Location = new System.Drawing.Point(161, 2);
            this.lblBankProcess2.Name = "lblBankProcess2";
            this.lblBankProcess2.Size = new System.Drawing.Size(90, 23);
            this.lblBankProcess2.TabIndex = 5;
            this.lblBankProcess2.Text = "Ödeme ID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(192, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(840, 274);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(1, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1055, 47);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(25, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Banka Formu: Faturalandırma";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 550);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme & Fatura Formu";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBanksTransactions;
        private System.Windows.Forms.Button btnCosts;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Button btnCategorieseww;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.Label lblBankProcess2;
        private System.Windows.Forms.TextBox txtBillPeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBillList;
        private System.Windows.Forms.Button btnUpdateBill;
        private System.Windows.Forms.Button btnRemoveBill;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
    }
}