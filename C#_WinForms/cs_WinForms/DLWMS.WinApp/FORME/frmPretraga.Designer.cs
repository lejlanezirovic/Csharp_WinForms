namespace DLWMS.WinApp.FORME
{
    partial class frmPretraga
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
            dgvPretraga = new DataGridView();
            IndeksImePrezime = new DataGridViewTextBoxColumn();
            Drzava = new DataGridViewTextBoxColumn();
            Grad = new DataGridViewTextBoxColumn();
            Spol = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Razmjene = new DataGridViewButtonColumn();
            cmbDrzave = new ComboBox();
            cmbSpolovi = new ComboBox();
            txtFilter = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).BeginInit();
            SuspendLayout();
            // 
            // dgvPretraga
            // 
            dgvPretraga.AllowUserToAddRows = false;
            dgvPretraga.AllowUserToDeleteRows = false;
            dgvPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { IndeksImePrezime, Drzava, Grad, Spol, Aktivan, Razmjene });
            dgvPretraga.Location = new Point(12, 145);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.ReadOnly = true;
            dgvPretraga.RowHeadersWidth = 62;
            dgvPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPretraga.Size = new Size(1130, 300);
            dgvPretraga.TabIndex = 0;
            dgvPretraga.CellClick += dgvPretraga_CellClick;
            // 
            // IndeksImePrezime
            // 
            IndeksImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IndeksImePrezime.DataPropertyName = "IndeksImePrezime";
            IndeksImePrezime.HeaderText = "Indeks Ime Prezime";
            IndeksImePrezime.MinimumWidth = 8;
            IndeksImePrezime.Name = "IndeksImePrezime";
            IndeksImePrezime.ReadOnly = true;
            // 
            // Drzava
            // 
            Drzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Drzava.DataPropertyName = "Drzava";
            Drzava.HeaderText = "Drzava";
            Drzava.MinimumWidth = 8;
            Drzava.Name = "Drzava";
            Drzava.ReadOnly = true;
            // 
            // Grad
            // 
            Grad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grad.DataPropertyName = "Grad";
            Grad.HeaderText = "Grad";
            Grad.MinimumWidth = 8;
            Grad.Name = "Grad";
            Grad.ReadOnly = true;
            // 
            // Spol
            // 
            Spol.DataPropertyName = "Spol";
            Spol.HeaderText = "Spol";
            Spol.MinimumWidth = 8;
            Spol.Name = "Spol";
            Spol.ReadOnly = true;
            Spol.Width = 150;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 8;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Width = 150;
            // 
            // Razmjene
            // 
            Razmjene.HeaderText = "Razmjene";
            Razmjene.MinimumWidth = 8;
            Razmjene.Name = "Razmjene";
            Razmjene.ReadOnly = true;
            Razmjene.Text = "Razmjene";
            Razmjene.UseColumnTextForButtonValue = true;
            Razmjene.Width = 150;
            // 
            // cmbDrzave
            // 
            cmbDrzave.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzave.FormattingEnabled = true;
            cmbDrzave.Location = new Point(707, 93);
            cmbDrzave.Name = "cmbDrzave";
            cmbDrzave.Size = new Size(182, 33);
            cmbDrzave.TabIndex = 1;
            cmbDrzave.SelectedIndexChanged += cmbDrzave_SelectedIndexChanged;
            // 
            // cmbSpolovi
            // 
            cmbSpolovi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpolovi.FormattingEnabled = true;
            cmbSpolovi.Location = new Point(960, 93);
            cmbSpolovi.Name = "cmbSpolovi";
            cmbSpolovi.Size = new Size(182, 33);
            cmbSpolovi.TabIndex = 2;
            cmbSpolovi.SelectedIndexChanged += cmbSpolovi_SelectedIndexChanged;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(138, 90);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(491, 31);
            txtFilter.TabIndex = 3;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(906, 96);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 4;
            label1.Text = "Spol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(635, 96);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 5;
            label2.Text = "Drzava";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 6;
            label3.Text = "Ime i prezime";
            // 
            // frmPretraga
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 561);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFilter);
            Controls.Add(cmbSpolovi);
            Controls.Add(cmbDrzave);
            Controls.Add(dgvPretraga);
            Name = "frmPretraga";
            Text = "frmPretraga";
            Load += frmPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPretraga;
        private DataGridViewTextBoxColumn IndeksImePrezime;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Razmjene;
        private ComboBox cmbDrzave;
        private ComboBox cmbSpolovi;
        private TextBox txtFilter;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}