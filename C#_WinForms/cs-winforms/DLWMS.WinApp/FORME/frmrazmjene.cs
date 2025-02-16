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

namespace DLWMS.WinApp.IB230012
{
    public partial class frmrazmjene : Form
    {
        private Student? student;
        public DLWMSContext db = KonekcijaNaBazu.db;
        public Drzava drzava = new Drzava();
        public frmrazmjene(Student? student)
        {
            InitializeComponent();
            this.student = student;
            dataGridView1.AutoGenerateColumns = false;
            uictajCMB();
            Text = $"Prikaz razmjena za {student.ImePrezime}";
        }
        private void ucitajRazmjene()
        {
            var razmjene = db.Razmjene.Include(x => x.Student).Include(x => x.Univerzitet).Where(x => x.Student.Id == student.Id).ToList();

            if (razmjene.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = razmjene;
            }
        }
        private void UcitajUniverzitete()
        {
            drzava = cmbDrzava.SelectedItem as Drzava;
            var uni = db.Univerziteti.Include(x => x.Drzava).Where(x => x.Drzava == drzava).ToList();
            cmbUni.DataSource = uni;
            cmbUni.ValueMember = "Id";
            cmbUni.DisplayMember = "Naziv";
        }
        private void uictajCMB()
        {
            var drzave = db.Drzave.ToList();
            cmbDrzava.DataSource = drzave;
            cmbDrzava.ValueMember = "Id";
            cmbDrzava.DisplayMember = "Naziv";

            var univ = db.Univerziteti.Include(x => x.Drzava).ToList();
            cmbuniverzi.DataSource = univ;
            cmbuniverzi.ValueMember = "Id";
            cmbuniverzi.DisplayMember = "Naziv";
        }
        private void frmrazmjene_Load(object sender, EventArgs e)
        {
            ucitajRazmjene();
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var drzava = cmbDrzava.SelectedItem as Drzava;
            var Uni = cmbUni.SelectedItem as Univerziteti;
            var datumOD = dateTimePicker1.Value;
            var datDO = dateTimePicker2.Value;
            int ects;
            int Ects = int.TryParse(cmbECTS.Text, out ects) ? ects : 15;

            if (Uni.Drzava.Id == drzava.Id)
            {
                var novi = new Razmjene()
                {
                    Student = student,
                    Univerzitet = Uni,
                    PocetakRazmjene = datumOD,
                    KrajRazmjene = datDO,
                    ECTS = Ects,
                    Okoncana = false
                };
                db.Razmjene.Add(novi);
                db.SaveChanges();
                MessageBox.Show("uspjesno dodana razmjena");
            }
            ucitajRazmjene();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int brPon;
            int rez = int.TryParse(textBox1.Text, out brPon) ? brPon : 0;
            int ects;
            int bodovi = int.TryParse(textBox2.Text, out ects) ? ects : 0;

            var uni = cmbuniverzi.SelectedItem as Univerziteti;
            Thread t = new Thread(() => Dodaj(brPon, ects, uni));
            t.Start();
        }
        private void Dodaj(int brPonavljanja, int ects, Univerziteti? uni)
        {
            for (int i = 0; i < brPonavljanja; i++)
            {
                var novi = new Razmjene()
                {
                    ECTS = ects,
                    Student = student,
                    Okoncana = false,
                    PocetakRazmjene = dateTimePicker1.Value,
                    KrajRazmjene = dateTimePicker2.Value,
                    Univerzitet = uni
                };
                db.Razmjene.Add(novi);
                db.SaveChanges();
                Action ac = () =>
                {
                    textBox3.Text += $"{i} razmjena za {student.ImePrezime} na {uni.Naziv}";
                    textBox3.SelectionStart = textBox3.Text.Length;
                    textBox3.ScrollToCaret();
                };
                BeginInvoke(ac);
                Thread.Sleep(300);
            }
            MessageBox.Show("generisano");
            BeginInvoke(ucitajRazmjene);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var razmjena = dataGridView1.SelectedRows[0].DataBoundItem as Razmjene;

            if (e.ColumnIndex == 5)
            {
                var poruka = MessageBox.Show("jeste li sigurni da zelite obrisati ovaj podatak? ", "Warning", MessageBoxButtons.OKCancel);
                if (poruka == DialogResult.OK)
                {
                    db.Razmjene.Remove(razmjena);
                    db.SaveChanges();
                    MessageBox.Show("obrisano");
                    ucitajRazmjene();
                }
                else
                {
                    Close();
                }
            }
        }
        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajUniverzitete();
        }
        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var frm = new frmIzvjestaji(student);
            frm.ShowDialog();
        }
    }
}
