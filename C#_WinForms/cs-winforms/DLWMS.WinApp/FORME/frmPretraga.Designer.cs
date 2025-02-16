namespace DLWMS.WinApp.IB230012
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
            ImePrezime = new DataGridViewTextBoxColumn();
            Drzava = new DataGridViewTextBoxColumn();
            Grad = new DataGridViewTextBoxColumn();
            Spol = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Razmjene = new DataGridViewButtonColumn();
            txtfilter = new TextBox();
            cmbdrzava = new ComboBox();
            cmbspol = new ComboBox();
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
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { ImePrezime, Drzava, Grad, Spol, Aktivan, Razmjene });
            dgvPretraga.Location = new Point(22, 164);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.ReadOnly = true;
            dgvPretraga.RowHeadersWidth = 62;
            dgvPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPretraga.Size = new Size(964, 286);
            dgvPretraga.TabIndex = 0;
            dgvPretraga.CellClick += dgvPretraga_CellClick;
            
            // 
            // ImePrezime
            // 
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "ImePrezime";
            ImePrezime.MinimumWidth = 8;
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            ImePrezime.Width = 150;
            // 
            // Drzava
            // 
            Drzava.DataPropertyName = "Drzava";
            Drzava.HeaderText = "Drzava";
            Drzava.MinimumWidth = 8;
            Drzava.Name = "Drzava";
            Drzava.ReadOnly = true;
            Drzava.Width = 150;
            // 
            // Grad
            // 
            Grad.DataPropertyName = "Grad";
            Grad.HeaderText = "Grad";
            Grad.MinimumWidth = 8;
            Grad.Name = "Grad";
            Grad.ReadOnly = true;
            Grad.Width = 150;
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
            // txtfilter
            // 
            txtfilter.Location = new Point(170, 119);
            txtfilter.Name = "txtfilter";
            txtfilter.Size = new Size(299, 31);
            txtfilter.TabIndex = 1;
            txtfilter.TextChanged += textBox1_TextChanged;
            // 
            // cmbdrzava
            // 
            cmbdrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbdrzava.FormattingEnabled = true;
            cmbdrzava.Location = new Point(551, 116);
            cmbdrzava.Name = "cmbdrzava";
            cmbdrzava.Size = new Size(188, 33);
            cmbdrzava.TabIndex = 2;
            cmbdrzava.SelectedIndexChanged += cmbdrzava_SelectedIndexChanged;
            // 
            // cmbspol
            // 
            cmbspol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbspol.FormattingEnabled = true;
            cmbspol.Location = new Point(822, 114);
            cmbspol.Name = "cmbspol";
            cmbspol.Size = new Size(164, 33);
            cmbspol.TabIndex = 3;
            cmbspol.SelectedIndexChanged += cmbspol_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 119);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 4;
            label1.Text = "Ime i/ili prezime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(475, 122);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 5;
            label2.Text = "Drzava:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(764, 117);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 6;
            label3.Text = "Spol:";
            // 
            // frmPretraga
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 477);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbspol);
            Controls.Add(cmbdrzava);
            Controls.Add(txtfilter);
            Controls.Add(dgvPretraga);
            Name = "frmPretraga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPretraga";
            Load += frmPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPretraga;
        private TextBox txtfilter;
        private ComboBox cmbdrzava;
        private ComboBox cmbspol;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Razmjene;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}