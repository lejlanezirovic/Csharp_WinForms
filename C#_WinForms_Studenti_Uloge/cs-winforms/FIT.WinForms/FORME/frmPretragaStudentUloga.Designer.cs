namespace FIT.WinForms.FORME
{
    partial class frmPretragaStudentUloga
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
            Indeks = new DataGridViewTextBoxColumn();
            ImePezime = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            Uloga = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Poruke = new DataGridViewButtonColumn();
            cmbSemestri = new ComboBox();
            cmbUloge = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).BeginInit();
            SuspendLayout();
            // 
            // dgvPretraga
            // 
            dgvPretraga.AllowUserToAddRows = false;
            dgvPretraga.AllowUserToDeleteRows = false;
            dgvPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { Indeks, ImePezime, DatumRodjenja, Prosjek, Uloga, Aktivan, Poruke });
            dgvPretraga.Location = new Point(23, 141);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.ReadOnly = true;
            dgvPretraga.RowHeadersWidth = 62;
            dgvPretraga.RowTemplate.Height = 33;
            dgvPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPretraga.Size = new Size(1140, 306);
            dgvPretraga.TabIndex = 0;
            dgvPretraga.CellClick += dgvPretraga_CellClick;
            // 
            // Indeks
            // 
            Indeks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Indeks";
            Indeks.MinimumWidth = 8;
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            // 
            // ImePezime
            // 
            ImePezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePezime.DataPropertyName = "Student";
            ImePezime.HeaderText = "ImePezime";
            ImePezime.MinimumWidth = 8;
            ImePezime.Name = "ImePezime";
            ImePezime.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "DatumRodjenja";
            DatumRodjenja.MinimumWidth = 8;
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            DatumRodjenja.Width = 150;
            // 
            // Prosjek
            // 
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.MinimumWidth = 8;
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            Prosjek.Width = 150;
            // 
            // Uloga
            // 
            Uloga.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uloga.DataPropertyName = "Uloga";
            Uloga.HeaderText = "Uloga";
            Uloga.MinimumWidth = 8;
            Uloga.Name = "Uloga";
            Uloga.ReadOnly = true;
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
            // Poruke
            // 
            Poruke.HeaderText = "Poruke";
            Poruke.MinimumWidth = 8;
            Poruke.Name = "Poruke";
            Poruke.ReadOnly = true;
            Poruke.Text = "Poruke";
            Poruke.UseColumnTextForButtonValue = true;
            Poruke.Width = 150;
            // 
            // cmbSemestri
            // 
            cmbSemestri.FormattingEnabled = true;
            cmbSemestri.Location = new Point(114, 76);
            cmbSemestri.Name = "cmbSemestri";
            cmbSemestri.Size = new Size(175, 33);
            cmbSemestri.TabIndex = 1;
            cmbSemestri.SelectedIndexChanged += cmbSemestri_SelectedIndexChanged;
            // 
            // cmbUloge
            // 
            cmbUloge.FormattingEnabled = true;
            cmbUloge.Location = new Point(360, 77);
            cmbUloge.Name = "cmbUloge";
            cmbUloge.Size = new Size(182, 33);
            cmbUloge.TabIndex = 2;
            cmbUloge.SelectedIndexChanged += cmbUloge_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(730, 79);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(177, 31);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(953, 76);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(210, 31);
            dateTimePicker2.TabIndex = 4;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 84);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 5;
            label1.Text = "Semestar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 84);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 6;
            label2.Text = "Uloga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(548, 86);
            label3.Name = "label3";
            label3.Size = new Size(180, 25);
            label3.TabIndex = 7;
            label3.Text = "Rodjeni u periodu od";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(913, 82);
            label4.Name = "label4";
            label4.Size = new Size(34, 25);
            label4.TabIndex = 8;
            label4.Text = "do";
            // 
            // frmPretragaStudentUloga
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 498);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbUloge);
            Controls.Add(cmbSemestri);
            Controls.Add(dgvPretraga);
            Name = "frmPretragaStudentUloga";
            Text = "frmPretragaStudentUloga";
            Load += frmPretragaStudentUloga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPretraga;
        private ComboBox cmbSemestri;
        private ComboBox cmbUloge;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn ImePezime;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn Uloga;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Poruke;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}