namespace DLWMS.WinApp.IB230012
{
    partial class frmStudentEdit
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
            pictureBox1 = new PictureBox();
            btnslika = new Button();
            label1 = new Label();
            label2 = new Label();
            cmbdrzava = new ComboBox();
            cmbgrad = new ComboBox();
            btnsacuvaj = new Button();
            openFileDialog1 = new OpenFileDialog();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(52, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 307);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnslika
            // 
            btnslika.Location = new Point(52, 373);
            btnslika.Name = "btnslika";
            btnslika.Size = new Size(232, 34);
            btnslika.TabIndex = 1;
            btnslika.Text = "Ucitaj sliku";
            btnslika.UseVisualStyleBackColor = true;
            btnslika.Click += btnslika_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 42);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 104);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // cmbdrzava
            // 
            cmbdrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbdrzava.FormattingEnabled = true;
            cmbdrzava.Location = new Point(337, 203);
            cmbdrzava.Name = "cmbdrzava";
            cmbdrzava.Size = new Size(182, 33);
            cmbdrzava.TabIndex = 4;
            // 
            // cmbgrad
            // 
            cmbgrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbgrad.FormattingEnabled = true;
            cmbgrad.Location = new Point(337, 287);
            cmbgrad.Name = "cmbgrad";
            cmbgrad.Size = new Size(182, 33);
            cmbgrad.TabIndex = 5;
            // 
            // btnsacuvaj
            // 
            btnsacuvaj.Location = new Point(337, 373);
            btnsacuvaj.Name = "btnsacuvaj";
            btnsacuvaj.Size = new Size(182, 34);
            btnsacuvaj.TabIndex = 6;
            btnsacuvaj.Text = "Sacuvaj";
            btnsacuvaj.UseVisualStyleBackColor = true;
            btnsacuvaj.Click += btnsacuvaj_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 164);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 7;
            label3.Text = "Drzava:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 259);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 8;
            label4.Text = "Grad:";
            // 
            // frmStudentEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 461);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnsacuvaj);
            Controls.Add(cmbgrad);
            Controls.Add(cmbdrzava);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnslika);
            Controls.Add(pictureBox1);
            Name = "frmStudentEdit";
            Text = "frmStudentEdit";
            Load += frmStudentEdit_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnslika;
        private Label label1;
        private Label label2;
        private ComboBox cmbdrzava;
        private ComboBox cmbgrad;
        private Button btnsacuvaj;
        private OpenFileDialog openFileDialog1;
        private Label label3;
        private Label label4;
    }
}