using FIT.Data;
using FIT.Infrastructure;
using FIT.WinForms.Izvjestaji;
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

namespace FIT.WinForms.FORME
{
    public partial class frmPoruke : Form
    {
        private Student student;
        public DLWMSDbContext db = KonekcijaNaBazu.db;
        public frmPoruke(Student student)
        {
            InitializeComponent();
            this.student = student;
            label1.Text = $"Prikaz poruka za studenta{student.ImePrezime}";
            dgvPoruke.AutoGenerateColumns = false;
        }
        private void UcitajPoruke()
        {
            var poruke = db.StudentiPoruke.Include(x => x.Student).Include(x => x.Predmet).Where(x => x.Student.Id == student.Id).ToList();
            if (poruke.Count > 0)
            {
                dgvPoruke.DataSource = null;
                dgvPoruke.DataSource = poruke;
                Text = $"Broj ucitanih poruka {dgvPoruke.RowCount}";
            }
        }
        private void frmPoruke_Load(object sender, EventArgs e)
        {
            UcitajPoruke();
            UcitajCMB();
        }
        private void dgvPoruke_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var stPoruka = dgvPoruke.SelectedRows[0].DataBoundItem as StudentiPoruke;
            if (e.ColumnIndex == 5)
            {
                var poruka = MessageBox.Show("Jeste li sigurni da zelite obrisati poruku?", "Warning", MessageBoxButtons.OKCancel);
                if (poruka == DialogResult.OK)
                {
                    db.StudentiPoruke.Remove(stPoruka);
                    db.SaveChanges();
                    MessageBox.Show("Obrisano");
                    UcitajPoruke();
                }
            }
        }
        private void UcitajCMB()
        {
            var predmeti = db.Predmeti.ToList();
            comboBox1.DataSource = predmeti;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Naziv";
        }
        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            var frm = new frmNovaPoruka(student);
            frm.ShowDialog();
            UcitajPoruke();
        }
        private void button3_Click(object sender, EventArgs e)
        {   
           var poruke = dgvPoruke.DataSource as List<StudentiPoruke>;
            if (poruke?.Count >= 1)
            {
                var st = dgvPoruke.SelectedRows[0].DataBoundItem as StudentiPoruke;
                var slika = st.Slika;
                int brojPon;
                int provjera = int.TryParse(textBox2.Text, out brojPon) ? brojPon : 0;
                var predmet = comboBox1.SelectedItem as Predmeti;
                var validnost = dateTimePicker1.Value;

                Thread t = new Thread(() => dodaj(brojPon, predmet, validnost, slika));
                t.Start();
            }
            else
            {
                MessageBox.Show($"Ne mozete generisati poruke jer nemate ni jednu dodanu poruku!");
            }     
        }
        private void dodaj(int brojPon, Predmeti? predmet, DateTime validnost, byte[] st)
        {
            for (int i = 0; i < brojPon; i++)
            {
                var nova = new StudentiPoruke()
                {
                    Student = student,
                    Predmet = predmet,
                    Sadrzaj = $"{i + 1}. generisani sadrzaj",
                    Hitnost = "Srednja",
                    Validnost = validnost,
                    Slika = st
                };
                db.StudentiPoruke.Add(nova);
                db.SaveChanges();
                Action ac = () =>
                {
                    txtInfo.Text += $"{DateTime.Now}-> generisana poruka za {student.ImePrezime} na predmetu {predmet.Naziv}\n";
                    txtInfo.SelectionStart = txtInfo.Text.Length;
                    txtInfo.ScrollToCaret();
                };
                BeginInvoke(ac);
                Thread.Sleep(300);
            }
            BeginInvoke(UcitajPoruke);
            MessageBox.Show("Generisano");
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {          
           var poruke = dgvPoruke.DataSource as List<StudentiPoruke>;

            var frm = new frmIzvjestaji(poruke,student);
            frm.ShowDialog();
        }
    }
}
