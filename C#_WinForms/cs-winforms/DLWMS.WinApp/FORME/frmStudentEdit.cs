using DLWMS.Data;
using DLWMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp.IB230012
{
    public partial class frmStudentEdit : Form
    {
        private Student? student;
        public DLWMSContext db = KonekcijaNaBazu.db;

        public frmStudentEdit(Student? student)
        {
            InitializeComponent();

            this.student = student;
            label1.Text = student.ImePrezime;
            label2.Text = student.BrojIndeksa;
            cmbdrzava.Text = student.grad.Drzava.Naziv;
            cmbgrad.Text = student.grad.Naziv;
            pictureBox1.Image = Helpers.Ekstenzije.ToImage(student.Slika);

        }
        void ucitajCMb()
        {
            var drzave = db.Drzave.ToList();
            cmbdrzava.DataSource = drzave;
            cmbdrzava.ValueMember = "Id";
            cmbdrzava.DisplayMember = "Naziv";

            var grad = db.Gradovi.Include(x => x.Drzava).ToList();
            cmbgrad.DataSource = grad;
            cmbgrad.ValueMember = "Id";
            cmbgrad.DisplayMember = "Naziv";

        }

        private void frmStudentEdit_Load(object sender, EventArgs e)
        {
            ucitajCMb();
        }

        private void btnslika_Click(object sender, EventArgs e)
        {
            //sliku ucitaj
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

            }
        }

        private void btnsacuvaj_Click(object sender, EventArgs e)
        {
            var slika=pictureBox1.Image;
            var grad = cmbgrad.SelectedItem as Grad;
            var drzava=cmbdrzava.SelectedItem as Drzava;

            if (grad.Drzava.Id == drzava.Id)
            {
                student.Slika=Helpers.Ekstenzije.ToByteArray(slika);
                  student.grad = grad;
            MessageBox.Show("podaci uspjesno promjenjeni");
            db.SaveChanges();
            Close();
            }
            else
            {
                MessageBox.Show("taj grad se ne nalazi u toj drzavi");
            }
        }
        //promjena slike i grrada

    }
}
