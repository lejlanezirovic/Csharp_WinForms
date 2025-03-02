namespace FIT.WinForms.FORME
{
    partial class frmNovaPoruka
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
            pictureBox1 = new PictureBox();
            cmbPredmeti = new ComboBox();
            cmbHitnost = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtSadrzaj = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(293, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 290);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.DoubleClick += pictureBox1_DoubleClick;
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(26, 89);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(248, 33);
            cmbPredmeti.TabIndex = 1;
            // 
            // cmbHitnost
            // 
            cmbHitnost.FormattingEnabled = true;
            cmbHitnost.Items.AddRange(new object[] { "Visoka", "Srednja", "Niska" });
            cmbHitnost.Location = new Point(26, 158);
            cmbHitnost.Name = "cmbHitnost";
            cmbHitnost.Size = new Size(248, 33);
            cmbHitnost.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(26, 239);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(248, 31);
            dateTimePicker1.TabIndex = 3;
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(26, 310);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.Size = new Size(248, 145);
            txtSadrzaj.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(441, 407);
            button1.Name = "button1";
            button1.Size = new Size(112, 48);
            button1.TabIndex = 5;
            button1.Text = "Sacuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(293, 407);
            button2.Name = "button2";
            button2.Size = new Size(117, 48);
            button2.TabIndex = 6;
            button2.Text = "Odustani";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 282);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 7;
            label1.Text = "Sadrzaj";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 199);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 8;
            label2.Text = "Validnost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 130);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 9;
            label3.Text = "Hitnost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 49);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 10;
            label4.Text = "Predmet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(293, 49);
            label5.Name = "label5";
            label5.Size = new Size(48, 25);
            label5.TabIndex = 11;
            label5.Text = "Slika";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovaPoruka
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 504);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtSadrzaj);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbHitnost);
            Controls.Add(cmbPredmeti);
            Controls.Add(pictureBox1);
            Name = "frmNovaPoruka";
            Text = "frmNovaPoruka";
            Load += frmNovaPoruka_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cmbPredmeti;
        private ComboBox cmbHitnost;
        private DateTimePicker dateTimePicker1;
        private TextBox txtSadrzaj;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}