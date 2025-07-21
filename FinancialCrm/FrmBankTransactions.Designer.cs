namespace FinancialCrm
{
    partial class FrmBankTransactions
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBankAllList = new System.Windows.Forms.ComboBox();
            this.btnShowData = new System.Windows.Forms.Button();
            this.dgvBankTransactions = new System.Windows.Forms.DataGridView();
            this.grpFilterOptions = new System.Windows.Forms.GroupBox();
            this.rbThisMonth = new System.Windows.Forms.RadioButton();
            this.rbLast30Days = new System.Windows.Forms.RadioButton();
            this.rbLast5 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankTransactions)).BeginInit();
            this.grpFilterOptions.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 478);
            this.panel1.TabIndex = 5;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(225, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Banka Seçiniz:";
            // 
            // cmbBankAllList
            // 
            this.cmbBankAllList.FormattingEnabled = true;
            this.cmbBankAllList.Location = new System.Drawing.Point(346, 77);
            this.cmbBankAllList.Name = "cmbBankAllList";
            this.cmbBankAllList.Size = new System.Drawing.Size(144, 21);
            this.cmbBankAllList.TabIndex = 7;
            this.cmbBankAllList.SelectedIndexChanged += new System.EventHandler(this.cmbBankAllList_SelectedIndexChanged);
            // 
            // btnShowData
            // 
            this.btnShowData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(135)))));
            this.btnShowData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowData.ForeColor = System.Drawing.Color.Transparent;
            this.btnShowData.Location = new System.Drawing.Point(346, 104);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(144, 41);
            this.btnShowData.TabIndex = 19;
            this.btnShowData.Text = "Verileri Göster";
            this.btnShowData.UseVisualStyleBackColor = false;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // dgvBankTransactions
            // 
            this.dgvBankTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankTransactions.Location = new System.Drawing.Point(411, 233);
            this.dgvBankTransactions.Name = "dgvBankTransactions";
            this.dgvBankTransactions.Size = new System.Drawing.Size(564, 292);
            this.dgvBankTransactions.TabIndex = 20;
            // 
            // grpFilterOptions
            // 
            this.grpFilterOptions.Controls.Add(this.rbThisMonth);
            this.grpFilterOptions.Controls.Add(this.rbLast30Days);
            this.grpFilterOptions.Controls.Add(this.rbLast5);
            this.grpFilterOptions.Location = new System.Drawing.Point(205, 233);
            this.grpFilterOptions.Name = "grpFilterOptions";
            this.grpFilterOptions.Size = new System.Drawing.Size(200, 292);
            this.grpFilterOptions.TabIndex = 21;
            this.grpFilterOptions.TabStop = false;
            this.grpFilterOptions.Text = "groupBox1";
            // 
            // rbThisMonth
            // 
            this.rbThisMonth.AutoSize = true;
            this.rbThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbThisMonth.Location = new System.Drawing.Point(24, 130);
            this.rbThisMonth.Name = "rbThisMonth";
            this.rbThisMonth.Size = new System.Drawing.Size(76, 17);
            this.rbThisMonth.TabIndex = 3;
            this.rbThisMonth.TabStop = true;
            this.rbThisMonth.Text = "Son 1 Ay";
            this.rbThisMonth.UseVisualStyleBackColor = true;
            // 
            // rbLast30Days
            // 
            this.rbLast30Days.AutoSize = true;
            this.rbLast30Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbLast30Days.Location = new System.Drawing.Point(24, 92);
            this.rbLast30Days.Name = "rbLast30Days";
            this.rbLast30Days.Size = new System.Drawing.Size(92, 17);
            this.rbLast30Days.TabIndex = 2;
            this.rbLast30Days.TabStop = true;
            this.rbLast30Days.Text = "Son 30 Gün";
            this.rbLast30Days.UseVisualStyleBackColor = true;
            // 
            // rbLast5
            // 
            this.rbLast5.AutoSize = true;
            this.rbLast5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbLast5.Location = new System.Drawing.Point(24, 51);
            this.rbLast5.Name = "rbLast5";
            this.rbLast5.Size = new System.Drawing.Size(107, 17);
            this.rbLast5.TabIndex = 1;
            this.rbLast5.TabStop = true;
            this.rbLast5.Text = "Son 5 Hareket";
            this.rbLast5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(23, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Banka Hareketleri";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(-2, -11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1055, 61);
            this.panel4.TabIndex = 4;
            // 
            // FrmBankTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 550);
            this.Controls.Add(this.grpFilterOptions);
            this.Controls.Add(this.dgvBankTransactions);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.cmbBankAllList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBankTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBankTransactions";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankTransactions)).EndInit();
            this.grpFilterOptions.ResumeLayout(false);
            this.grpFilterOptions.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBankAllList;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.DataGridView dgvBankTransactions;
        private System.Windows.Forms.GroupBox grpFilterOptions;
        private System.Windows.Forms.RadioButton rbThisMonth;
        private System.Windows.Forms.RadioButton rbLast30Days;
        private System.Windows.Forms.RadioButton rbLast5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
    }
}