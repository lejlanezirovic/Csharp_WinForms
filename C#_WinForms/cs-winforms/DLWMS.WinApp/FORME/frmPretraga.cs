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
    public partial class frmPretraga : Form
    {
        public DLWMSContext db = KonekcijaNaBazu.db;
        public List<Student> studentiLista = new List<Student>();
        public bool loaded = false;
        public frmPretraga()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }
        private void UcitajCmB()
        {
            var drzave = db.Drzave.ToList();
            cmbdrzava.DataSource = drzave;
            cmbdrzava.ValueMember = "Id";
            cmbdrzava.DisplayMember = "Naziv";

            var spolovi = db.Spolovi.ToList();
            cmbspol.DataSource = spolovi;
            cmbspol.ValueMember = "Id";
            cmbspol.DisplayMember = "Naziv";
        }
        private void ucitajStudente()
        {
            var filter = string.IsNullOrEmpty(txtfilter.Text) ? "" : txtfilter.Text.ToLower();
            var drzava = cmbdrzava.SelectedItem as Drzava;
            var spol = cmbspol.SelectedItem as Spolovi;
            if (loaded)
            {

                var studenti = db.Studenti.Include(x => x.grad).ThenInclude(x => x.Drzava).
                    Where(x => (x.Ime.ToLower().Contains(filter) || x.Prezime.ToLower().Contains(filter)) &&
                x.grad.Drzava == drzava && x.Spol == spol).ToList();

                dgvPretraga.DataSource = null;
                studentiLista.Clear();
                if (studenti.Count > 0)
                {
                    foreach (var st in studenti)
                    {
                        studentiLista.Add(st);
                    }
                    dgvPretraga.DataSource = studentiLista;
                    Text += studentiLista.Count().ToString();
                }
                else
                {
                    MessageBox.Show("nema takvih studenata");
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }
        private void frmPretraga_Load(object sender, EventArgs e)
        {
            UcitajCmB();
            loaded = true;

        }
        private void cmbdrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void cmbspol_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

      

        private void dgvPretraga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = dgvPretraga.SelectedRows[0].DataBoundItem as Student;
            if (e.ColumnIndex == 5)
            {
                var frma = new frmrazmjene(student);
                frma.ShowDialog();
            }
            else
            {
                var frm = new frmStudentEdit(student);
                frm.ShowDialog();
            }
        }
    }
}
