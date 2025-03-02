using DLWMS.Data;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Izvjestaji;
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
    public partial class frmRazmjene : Form
    {
        private Student? student;
        public DLWMSContext db = KonekcijaNABAzu.db;
        public bool loaded = false;
        public Drzava drzava = new Drzava();
        public frmRazmjene(Student? student)
        {
            InitializeComponent();
            this.student = student;
            dgvRazmjene.AutoGenerateColumns = false;
        }

        private void UcitajCMB()
        {
            var drzave = db.Drzave.Include(x => x.gradovi).ToList();
            cmbDrzava.DataSource = drzave;
            cmbDrzava.ValueMember = "Id";
            cmbDrzava.DisplayMember = "Naziv";

            var uni = db.Univerziteti.Include(x => x.Drzava).ToList();
            cmbUniverzitet.DataSource = uni;
            cmbUniverzitet.ValueMember = "Id";
            cmbUniverzitet.DisplayMember = "Naziv";

            comboBox3.DataSource = uni;
            comboBox3.ValueMember = "Id";
            comboBox3.DisplayMember = "Naziv";
        }
        private void UcitajUniverzitete()
        {
            drzava = cmbDrzava.SelectedItem as Drzava;
            var uni = db.Univerziteti.Include(x => x.Drzava).Where(x => x.Drzava.Id == drzava.Id).ToList();
            if (uni.Count > 0)
            {
                cmbUniverzitet.DataSource = uni;
                cmbUniverzitet.ValueMember = "Id";
                cmbUniverzitet.DisplayMember = "Naziv";
            }
            else
            {
                cmbUniverzitet.DataSource = null;
                MessageBox.Show("Nema evidentiranih univerziteta za datu drzavu!");
            }           
        }
        private void UCitajrazmjene()
        {
            var razmjene = db.Razmjene.Include(x => x.Student).Include(x => x.Univerzitet).Where(x => x.Student.Id == student.Id).ToList();
            if (razmjene.Count > 0)
            {
                dgvRazmjene.DataSource = razmjene;
                Text = $"Broj razmjena {dgvRazmjene.RowCount}";
            }
        }
        private void frmRazmjene_Load(object sender, EventArgs e)
        {
            UcitajCMB();
            loaded = true;
            UCitajrazmjene();
        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajUniverzitete();
        }
        private bool Validiraj()
        {
            return Helpers.Validator.ProvjeriUnos(cmbDrzava, errorProvider1, "Obavezna vrijednost") &&
                Helpers.Validator.ProvjeriUnos(cmbUniverzitet, errorProvider1, "Obavezna vrijednost") &&
                Helpers.Validator.ProvjeriUnos(txtECTS, errorProvider1, "Obavezna vrijednost") &&
                Helpers.Validator.ProvjeriUnos(dateTimePicker1, errorProvider1, "Obavezna vrijednost") &&
                Helpers.Validator.ProvjeriUnos(dateTimePicker2, errorProvider1, "Obavezna vrijednost");
        }
        private void dgvRazmjene_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var razmjena = dgvRazmjene.SelectedRows[0].DataBoundItem as Razmjene;
            if (e.ColumnIndex == 5)
            {
                var poruka = MessageBox.Show("Jeste li sigurni da zelite obrisati razmjenu?", "Warning", MessageBoxButtons.OKCancel);
                if (poruka == DialogResult.OK)
                {
                    db.Razmjene.Remove(razmjena);
                    db.SaveChanges();
                    MessageBox.Show("Obrisano");
                    UCitajrazmjene();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var univerzitet = cmbUniverzitet.SelectedItem as Univerziteti;
            int ects;
            int pr = int.TryParse(txtECTS.Text, out ects) ? ects : 0;
            var pocetak = dateTimePicker1.Value;
            var kraj = dateTimePicker2.Value;
            if (Validiraj())
            {
                if(ValidirajDatume(pocetak, kraj))
                {
                    var novi = new Razmjene()
                    {
                        Student = student,
                        Univerzitet = univerzitet,
                        PocetakRazmjene = pocetak,
                        KrajRazmjene = kraj,
                        ECTS = ects,
                        Okoncana = kraj.Date < DateTime.Now.Date
                    };
                    db.Razmjene.Add(novi);
                    db.SaveChanges();
                    MessageBox.Show("Razmjena dodana");
                    UCitajrazmjene();
                }
                else
                {
                    MessageBox.Show("datum pocetka razmjene mora biti manji od kraja");

                }
                
            }
        }
        private bool ValidirajDatume(DateTime datumOd, DateTime datumDo)
        {
            return datumOd < datumDo;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var univerzitet = comboBox3.SelectedItem as Univerziteti;
            int ects;
            int pr = int.TryParse(textBox3.Text, out ects) ? ects : 0;
            int brojPon;
            int pro = int.TryParse(textBox2.Text, out brojPon) ? brojPon : 0;
            var datumOd = new DateTime(2025, 1, 1);
            var datumDo = datumOd.AddDays(ects);
            
            Thread t = new Thread(() => dodaj(brojPon, ects, univerzitet, datumOd, datumDo));
            t.Start();
        }
        private void dodaj(int brojPon, int ects, Univerziteti? univerzitet, DateTime datumOd, DateTime datumDo)
        {
            for (int i = 0; i < brojPon; i++)
            {
                var novi = new Razmjene()
                {
                    Student = student,
                    Univerzitet = univerzitet,
                    ECTS = ects,
                    PocetakRazmjene = datumOd,
                    KrajRazmjene = datumDo,
                    Okoncana = datumDo.Date<DateTime.Now.Date
                };
                db.Razmjene.Add(novi);
                db.SaveChanges();
                Action ac = () =>
                {
                    textBox4.Text += $"{i}. razmjena za {student.IndeksImePrezime} na univerzitetu {univerzitet.Naziv} {datumOd}-{datumDo}\n";
                    textBox4.SelectionStart = textBox4.Text.Length;
                    textBox4.ScrollToCaret();
                };
                BeginInvoke(ac);
                Thread.Sleep(300);
            }
            BeginInvoke(UCitajrazmjene);
            MessageBox.Show("Generisano");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var razmjene=dgvRazmjene.DataSource as List<Razmjene>;
            var ffrm = new frmIzvjestaji(razmjene,student);
            ffrm.ShowDialog();
        }
    }
}
