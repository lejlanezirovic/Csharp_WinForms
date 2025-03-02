using FIT.Data;
using FIT.Infrastructure;
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
    public partial class frmPretragaStudentUloga : Form
    {
        public DLWMSDbContext db = KonekcijaNaBazu.db;
        private bool loaded = false;
        public frmPretragaStudentUloga()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }
        private void UcitajCMB()
        {
            var semestri = db.Semestri.ToList();
            cmbSemestri.DataSource = semestri;
            cmbSemestri.ValueMember = "Id";
            cmbSemestri.DisplayMember = "Oznaka";

            var uloge = db.Uloge.ToList();
            cmbUloge.DataSource = uloge;
            cmbUloge.ValueMember = "Id";
            cmbUloge.DisplayMember = "Naziv";
        }
        private void UcitajStudente()
        {
            var semestar = cmbSemestri.SelectedItem as Semestri;
            var uloga = cmbUloge.SelectedItem as Uloge;
            var DatumOd = dateTimePicker1.Value;
            var DatumDO = dateTimePicker2.Value;

            if (loaded)
            {
                var studentiUloge = db.StudentiUloge.Include(x => x.Student).ThenInclude(x=>x.Polozeni).Include(x => x.Uloga)
                    .Where(x => x.Student.Semestar.Id == semestar.Id && x.Uloga.Id == uloga.Id && x.Student.DatumRodjenja >= DatumOd && x.Student.DatumRodjenja <= DatumDO)
                    .ToList();

                if (studentiUloge.Count > 0)
                {
                    dgvPretraga.DataSource = null;
                    dgvPretraga.DataSource = studentiUloge;
                }
                else
                {
                    MessageBox.Show("U bazi nema takvih studenata");
                    dgvPretraga.DataSource = null;
                }
            }
        }
        private void frmPretragaStudentUloga_Load(object sender, EventArgs e)
        {
            UcitajCMB();
            loaded = true;
        }
        private void cmbSemestri_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }
        private void cmbUloge_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }
        private void dgvPretraga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var ulogestudenti = dgvPretraga.SelectedRows[0].DataBoundItem as StudentiUloge;
            var student = ulogestudenti.Student;
            if (e.ColumnIndex == 6)
            {
                var frm = new frmPoruke(student);
                frm.ShowDialog();
            }
        }
    }
}
