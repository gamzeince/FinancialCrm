namespace FinancialCrm
{
    partial class FrmExpenses
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBanksTransactions = new System.Windows.Forms.Button();
            this.btnCosts = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnBanks = new System.Windows.Forms.Button();
            this.btnCategorieseww = new System.Windows.Forms.Button();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.chartExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnShowData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAllData = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(-1, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1055, 52);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(23, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Banka Formu: Giderler";
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
            this.panel1.Location = new System.Drawing.Point(-1, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 478);
            this.panel1.TabIndex = 4;
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
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(352, 76);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(144, 21);
            this.cmbMonth.TabIndex = 5;
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Location = new System.Drawing.Point(190, 225);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.Size = new System.Drawing.Size(400, 271);
            this.dgvExpenses.TabIndex = 6;
            // 
            // chartExpenses
            // 
            chartArea1.Name = "ChartArea1";
            this.chartExpenses.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartExpenses.Legends.Add(legend1);
            this.chartExpenses.Location = new System.Drawing.Point(596, 225);
            this.chartExpenses.Name = "chartExpenses";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartExpenses.Series.Add(series1);
            this.chartExpenses.Size = new System.Drawing.Size(453, 271);
            this.chartExpenses.TabIndex = 7;
            this.chartExpenses.Text = "chart1";
            this.chartExpenses.Click += new System.EventHandler(this.chartExpenses_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(135)))));
            this.btnShowData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowData.ForeColor = System.Drawing.Color.Transparent;
            this.btnShowData.Location = new System.Drawing.Point(352, 103);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(144, 41);
            this.btnShowData.TabIndex = 18;
            this.btnShowData.Text = "Aylık Veriyi Göster";
            this.btnShowData.UseVisualStyleBackColor = false;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(208, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aylık Gider Raporu";
            // 
            // btnShowAllData
            // 
            this.btnShowAllData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(135)))));
            this.btnShowAllData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowAllData.ForeColor = System.Drawing.Color.Transparent;
            this.btnShowAllData.Location = new System.Drawing.Point(352, 162);
            this.btnShowAllData.Name = "btnShowAllData";
            this.btnShowAllData.Size = new System.Drawing.Size(144, 41);
            this.btnShowAllData.TabIndex = 19;
            this.btnShowAllData.Text = "Tümünü Göster";
            this.btnShowAllData.UseVisualStyleBackColor = false;
            this.btnShowAllData.Click += new System.EventHandler(this.btnShowAllData_Click);
            // 
            // FrmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 550);
            this.Controls.Add(this.btnShowAllData);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.chartExpenses);
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExpenses";
            this.Load += new System.EventHandler(this.FrmExpenses_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBanksTransactions;
        private System.Windows.Forms.Button btnCosts;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Button btnCategorieseww;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpenses;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAllData;
    }
}