namespace DLWMS.WinApp.FORME
{
    partial class frmRazmjene
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
            components = new System.ComponentModel.Container();
            dgvRazmjene = new DataGridView();
            Univerzitet = new DataGridViewTextBoxColumn();
            Pocetak = new DataGridViewTextBoxColumn();
            Kraj = new DataGridViewTextBoxColumn();
            ECTS = new DataGridViewTextBoxColumn();
            Okoncana = new DataGridViewCheckBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            cmbDrzava = new ComboBox();
            cmbUniverzitet = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            txtECTS = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            button2 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            comboBox3 = new ComboBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRazmjene).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRazmjene
            // 
            dgvRazmjene.AllowUserToAddRows = false;
            dgvRazmjene.AllowUserToDeleteRows = false;
            dgvRazmjene.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRazmjene.Columns.AddRange(new DataGridViewColumn[] { Univerzitet, Pocetak, Kraj, ECTS, Okoncana, Brisi });
            dgvRazmjene.Location = new Point(8, 126);
            dgvRazmjene.Name = "dgvRazmjene";
            dgvRazmjene.ReadOnly = true;
            dgvRazmjene.RowHeadersWidth = 62;
            dgvRazmjene.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRazmjene.Size = new Size(1153, 282);
            dgvRazmjene.TabIndex = 0;
            dgvRazmjene.CellClick += dgvRazmjene_CellClick;
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
            // cmbDrzava
            // 
            cmbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzava.FormattingEnabled = true;
            cmbDrzava.Location = new Point(12, 74);
            cmbDrzava.Name = "cmbDrzava";
            cmbDrzava.Size = new Size(182, 33);
            cmbDrzava.TabIndex = 1;
            cmbDrzava.SelectedIndexChanged += cmbDrzava_SelectedIndexChanged;
            // 
            // cmbUniverzitet
            // 
            cmbUniverzitet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUniverzitet.FormattingEnabled = true;
            cmbUniverzitet.Location = new Point(224, 74);
            cmbUniverzitet.Name = "cmbUniverzitet";
            cmbUniverzitet.Size = new Size(182, 33);
            cmbUniverzitet.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(585, 72);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(209, 31);
            dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(823, 72);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 31);
            dateTimePicker2.TabIndex = 4;
            // 
            // txtECTS
            // 
            txtECTS.Location = new Point(449, 74);
            txtECTS.Name = "txtECTS";
            txtECTS.Size = new Size(112, 31);
            txtECTS.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(1049, 74);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 7;
            label1.Text = "Drzava:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 24);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 8;
            label2.Text = "Univerzitet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(449, 24);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 9;
            label3.Text = "ECTS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(585, 24);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 10;
            label4.Text = "Datum pocetka:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(823, 24);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 11;
            label5.Text = "Datum zavrsetka:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Location = new Point(8, 468);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1153, 301);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(287, 57);
            label9.Name = "label9";
            label9.Size = new Size(48, 25);
            label9.TabIndex = 15;
            label9.Text = "Info:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 57);
            label8.Name = "label8";
            label8.Size = new Size(99, 25);
            label8.TabIndex = 14;
            label8.Text = "Univerzitet:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(140, 175);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 6;
            label7.Text = "ponavljanja:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 175);
            label6.Name = "label6";
            label6.Size = new Size(43, 25);
            label6.TabIndex = 5;
            label6.Text = "Ects";
            // 
            // button2
            // 
            button2.Location = new Point(23, 249);
            button2.Name = "button2";
            button2.Size = new Size(220, 34);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(287, 102);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(860, 183);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(23, 203);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(91, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(103, 31);
            textBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(23, 102);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(220, 33);
            comboBox3.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(977, 422);
            button3.Name = "button3";
            button3.Size = new Size(168, 53);
            button3.TabIndex = 13;
            button3.Text = "Potvrde";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // frmRazmjene
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 793);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtECTS);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbUniverzitet);
            Controls.Add(cmbDrzava);
            Controls.Add(dgvRazmjene);
            Name = "frmRazmjene";
            Text = "frmRazmjene";
            Load += frmRazmjene_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRazmjene).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRazmjene;
        private ComboBox cmbDrzava;
        private ComboBox cmbUniverzitet;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox txtECTS;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox1;
        private Button button2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private ComboBox comboBox3;
        private DataGridViewTextBoxColumn Univerzitet;
        private DataGridViewTextBoxColumn Pocetak;
        private DataGridViewTextBoxColumn Kraj;
        private DataGridViewTextBoxColumn ECTS;
        private DataGridViewCheckBoxColumn Okoncana;
        private DataGridViewButtonColumn Brisi;
        private Label label7;
        private Label label6;
        private Button button3;
        private Label label9;
        private Label label8;
    }
}