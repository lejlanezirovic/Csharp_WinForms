using FIT.Data;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.FORME
{
    public partial class frmNovaPoruka : Form
    {
        private Student student;
        public DLWMSDbContext db = KonekcijaNaBazu.db;
        public frmNovaPoruka(Student student)
        {
            InitializeComponent();
            this.student = student;
        }
        private bool ProvjeriKontrole()
        {
            return Helpers.Validator.ProvjeriUnos(cmbPredmeti, errorProvider1, "Obavezna vrijednost") &&
                Helpers.Validator.ProvjeriUnos(cmbHitnost, errorProvider1, "Obavezna vrijednost") &&
                Helpers.Validator.ProvjeriUnos(txtSadrzaj, errorProvider1, "Obavezna vrijednost") &&
                Helpers.Validator.ProvjeriUnos(pictureBox1, errorProvider1, "Obavezna vrijednost") &&
                Helpers.Validator.ProvjeriUnos(dateTimePicker1, errorProvider1, "Obavezna vrijednost");
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void UcitajCMB()
        {
            var predmeti = db.Predmeti.ToList();
            cmbPredmeti.DataSource = predmeti;
            cmbPredmeti.ValueMember = "Id";
            cmbPredmeti.DisplayMember = "Naziv";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var predmet = cmbPredmeti.SelectedItem as Predmeti;
            var hitnost = cmbHitnost.SelectedItem as string;
            var sadrzaj = txtSadrzaj.Text;
            var slika = pictureBox1.Image;
            var validnost = dateTimePicker1.Value;

            if (ProvjeriKontrole())
            {
                var novaPoruka = new StudentiPoruke()
                {
                    Student = student,
                    Predmet = predmet,
                    Sadrzaj = sadrzaj,
                    Hitnost = hitnost,
                    Validnost = validnost,
                    Slika = Helpers.Ekstenzije.ToByteArray(slika)
                };
                db.StudentiPoruke.Add(novaPoruka);
                db.SaveChanges();
                MessageBox.Show("Uspjesno ste dodali poruku na predmetu");
                Close();
            }
        }
        private void frmNovaPoruka_Load(object sender, EventArgs e)
        {
            UcitajCMB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
