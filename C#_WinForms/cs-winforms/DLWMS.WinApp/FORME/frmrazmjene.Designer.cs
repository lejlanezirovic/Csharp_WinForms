namespace DLWMS.WinApp.IB230012
{
    partial class frmrazmjene
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
            dataGridView1 = new DataGridView();
            Univerzitet = new DataGridViewTextBoxColumn();
            Pocetak = new DataGridViewTextBoxColumn();
            Kraj = new DataGridViewTextBoxColumn();
            ECTS = new DataGridViewTextBoxColumn();
            Okoncana = new DataGridViewCheckBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            cmbUni = new ComboBox();
            cmbDrzava = new ComboBox();
            cmbECTS = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnSacuvaj = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            cmbuniverzi = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Univerzitet, Pocetak, Kraj, ECTS, Okoncana, Brisi });
            dataGridView1.Location = new Point(12, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1116, 292);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Univerzitet
            // 
            Univerzitet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Univerzitet.DataPropertyName = "Univerzitet";
            Univerzitet.HeaderText = "Univerzitet";
            Univerzitet.MinimumWidth = 8;
            Univerzitet.Name = "Univerzitet";
            Univerzitet.ReadOnly = true;
            // 
            // Pocetak
            // 
            Pocetak.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Pocetak.DataPropertyName = "PocetakRazmjene";
            Pocetak.HeaderText = "Pocetak";
            Pocetak.MinimumWidth = 8;
            Pocetak.Name = "Pocetak";
            Pocetak.ReadOnly = true;
            // 
            // Kraj
            // 
            Kraj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kraj.DataPropertyName = "KrajRazmjene";
            Kraj.HeaderText = "Kraj";
            Kraj.MinimumWidth = 8;
            Kraj.Name = "Kraj";
            Kraj.ReadOnly = true;
            // 
            // ECTS
            // 
            ECTS.DataPropertyName = "ECTS";
            ECTS.HeaderText = "ECTS";
            ECTS.MinimumWidth = 8;
            ECTS.Name = "ECTS";
            ECTS.ReadOnly = true;
            ECTS.Width = 150;
            // 
            // Okoncana
            // 
            Okoncana.DataPropertyName = "Okoncana";
            Okoncana.HeaderText = "Okoncana";
            Okoncana.MinimumWidth = 8;
            Okoncana.Name = "Okoncana";
            Okoncana.ReadOnly = true;
            Okoncana.Resizable = DataGridViewTriState.True;
            Okoncana.SortMode = DataGridViewColumnSortMode.Automatic;
            Okoncana.Width = 150;
            // 
            // Brisi
            // 
            Brisi.HeaderText = "Brisi";
            Brisi.MinimumWidth = 8;
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            Brisi.Width = 150;
            // 
            // cmbUni
            // 
            cmbUni.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUni.FormattingEnabled = true;
            cmbUni.Location = new Point(12, 85);
            cmbUni.Name = "cmbUni";
            cmbUni.Size = new Size(163, 33);
            cmbUni.TabIndex = 1;
            // 
            // cmbDrzava
            // 
            cmbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzava.FormattingEnabled = true;
            cmbDrzava.Location = new Point(200, 85);
            cmbDrzava.Name = "cmbDrzava";
            cmbDrzava.Size = new Size(147, 33);
            cmbDrzava.TabIndex = 2;
            cmbDrzava.SelectedIndexChanged += cmbDrzava_SelectedIndexChanged;
            // 
            // cmbECTS
            // 
            cmbECTS.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbECTS.FormattingEnabled = true;
            cmbECTS.Items.AddRange(new object[] { "30", "10", "20" });
            cmbECTS.Location = new Point(371, 83);
            cmbECTS.Name = "cmbECTS";
            cmbECTS.Size = new Size(91, 33);
            cmbECTS.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(495, 83);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 31);
            dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(745, 83);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(214, 31);
            dateTimePicker2.TabIndex = 5;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(976, 80);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(152, 34);
            btnSacuvaj.TabIndex = 6;
            btnSacuvaj.Text = "Dodaj razmjenu";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(cmbuniverzi);
            groupBox1.Location = new Point(12, 477);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1116, 189);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 26);
            label8.Name = "label8";
            label8.Size = new Size(99, 25);
            label8.TabIndex = 7;
            label8.Text = "Univerzitet:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 106);
            label7.Name = "label7";
            label7.Size = new Size(142, 25);
            label7.TabIndex = 6;
            label7.Text = "Broj ponavljanja:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(180, 106);
            label6.Name = "label6";
            label6.Size = new Size(113, 25);
            label6.TabIndex = 5;
            label6.Text = "ECTS bodovi";
            // 
            // button1
            // 
            button1.Location = new Point(180, 41);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Generisi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(341, 41);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(743, 124);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(87, 31);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(87, 31);
            textBox1.TabIndex = 1;
            // 
            // cmbuniverzi
            // 
            cmbuniverzi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbuniverzi.FormattingEnabled = true;
            cmbuniverzi.Location = new Point(29, 54);
            cmbuniverzi.Name = "cmbuniverzi";
            cmbuniverzi.Size = new Size(122, 33);
            cmbuniverzi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 9;
            label1.Text = "Univerzitet:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 46);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 10;
            label2.Text = "Drzava:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 46);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 11;
            label3.Text = "ECTS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(495, 46);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 12;
            label4.Text = "Pocetak razmjene:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(745, 46);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 13;
            label5.Text = "Kraj razmjene:";
            // 
            // frmrazmjene
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 678);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnSacuvaj);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbECTS);
            Controls.Add(cmbDrzava);
            Controls.Add(cmbUni);
            Controls.Add(dataGridView1);
            Name = "frmrazmjene";
            Text = "frmrazmjene";
            Load += frmrazmjene_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmbUni;
        private ComboBox cmbDrzava;
        private ComboBox cmbECTS;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btnSacuvaj;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox cmbuniverzi;
        private DataGridViewTextBoxColumn Univerzitet;
        private DataGridViewTextBoxColumn Pocetak;
        private DataGridViewTextBoxColumn Kraj;
        private DataGridViewTextBoxColumn ECTS;
        private DataGridViewCheckBoxColumn Okoncana;
        private DataGridViewButtonColumn Brisi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}