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

namespace DLWMS.WinApp.FORME
{
    public partial class frmStudentiEdit : Form
    {
        private Student? student;
        public DLWMSContext db = KonekcijaNABAzu.db;
        public Drzava drzava = new Drzava();
        public frmStudentiEdit(Student? student)
        {
            InitializeComponent();
            this.student = student;
            label1.Text = $"{student.ImePrezime}";
            label2.Text = $"{student.BrojIndeksa}";
        }
        private void UcitajPodatke()
        {
            pictureBox1.Image = Helpers.Ekstenzije.ToImage(student.Slika);
            cmbDrzava.Text = student.Grad.Drzava.Naziv;
            cmbGradovi.Text = student.Grad.Naziv;

        }

        private void frmStudentiEdit_Load(object sender, EventArgs e)
        {
            UcitajCMB();
            UcitajPodatke();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void UcitajCMB()
        {
            var drzave = db.Drzave.Include(x => x.gradovi).ToList();
            cmbDrzava.DataSource = drzave;
            cmbDrzava.ValueMember = "Id";
            cmbDrzava.DisplayMember = "Naziv";
        }
        private void UcitajGradove()
        {
            drzava = cmbDrzava.SelectedItem as Drzava;

            var gradovi = db.Gradovi.Include(x => x.Drzava).Where(x => x.Drzava.Id == drzava.Id).ToList();
            cmbGradovi.DataSource = gradovi;
            cmbGradovi.ValueMember = "Id";
            cmbGradovi.DisplayMember = "Naziv";
        }
        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajGradove();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var slika = pictureBox1.Image;
            var drzava=cmbDrzava.SelectedItem as Drzava;
            var grad=cmbGradovi.SelectedItem as Grad;    
            student.Slika = Helpers.Ekstenzije.ToByteArray(slika);
            student.Grad = grad;
            db.SaveChanges();
            MessageBox.Show("Podaci uspjesno promjenjeni");
            Close();
        }
    }
}
