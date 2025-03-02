namespace DLWMS.WinApp.FORME
{
    partial class frmStudentiEdit
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
            cmbDrzava = new ComboBox();
            cmbGradovi = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(43, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 237);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cmbDrzava
            // 
            cmbDrzava.FormattingEnabled = true;
            cmbDrzava.Location = new Point(281, 161);
            cmbDrzava.Name = "cmbDrzava";
            cmbDrzava.Size = new Size(182, 33);
            cmbDrzava.TabIndex = 1;
            cmbDrzava.SelectedIndexChanged += cmbDrzava_SelectedIndexChanged;
            // 
            // cmbGradovi
            // 
            cmbGradovi.FormattingEnabled = true;
            cmbGradovi.Location = new Point(281, 248);
            cmbGradovi.Name = "cmbGradovi";
            cmbGradovi.Size = new Size(182, 33);
            cmbGradovi.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 22);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 76);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.Location = new Point(281, 331);
            button1.Name = "button1";
            button1.Size = new Size(182, 34);
            button1.TabIndex = 5;
            button1.Text = "Sacuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(43, 331);
            button2.Name = "button2";
            button2.Size = new Size(209, 34);
            button2.TabIndex = 6;
            button2.Text = "Ucitaj sliku";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 124);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 7;
            label3.Text = "Drzava:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 211);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 8;
            label4.Text = "Grad:";
            // 
            // frmStudentiEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 432);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbGradovi);
            Controls.Add(cmbDrzava);
            Controls.Add(pictureBox1);
            Name = "frmStudentiEdit";
            Text = "frmStudentiEdit";
            Load += frmStudentiEdit_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cmbDrzava;
        private ComboBox cmbGradovi;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private Label label3;
        private Label label4;
    }
}