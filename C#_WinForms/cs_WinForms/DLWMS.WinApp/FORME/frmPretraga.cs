using DLWMS.Infrastructure;
using DLWMS.Data;
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
    public partial class frmPretraga : Form
    {
        public DLWMSContext db = KonekcijaNABAzu.db;
        public bool loaded = false;
        public frmPretraga()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }
        private void UcitajCMB()
        {
            var drzave = db.Drzave.Include(x => x.gradovi).ToList();
            cmbDrzave.DataSource = drzave;
            cmbDrzave.ValueMember = "Id";
            cmbDrzave.DisplayMember = "Naziv";

            var spolovi = db.Spolovi.ToList();
            cmbSpolovi.DataSource = spolovi;
            cmbSpolovi.ValueMember = "Id";
            cmbSpolovi.DisplayMember = "Naziv";
        }
        private void UcitajStudente()
        {
            var filter = txtFilter.Text.ToLower();
            var drzava = cmbDrzave.SelectedItem as Drzava;
            var spol = cmbSpolovi.SelectedItem as Spolovi;

            if (loaded)
            {
                var studenti = db.Studenti.Include(x => x.Spol).Include(x => x.Grad)
                .Where(x => (x.Ime.ToLower().Contains(filter) || x.Prezime.ToLower().Contains(filter)) && x.Grad.Drzava.Id == drzava.Id && x.Spol.Id == spol.Id).ToList();
                if (studenti.Count > 0)
                {
                    dgvPretraga.DataSource = null;
                    dgvPretraga.DataSource = studenti;
                    Text = $"broj studenata {dgvPretraga.RowCount}";
                }
                else
                {
                    MessageBox.Show($"U bazi nisu evidentirani studenti {spol} spola, koji u imenu i prezimenu posjeduju sadržaj {filter}, a koji su državljani {drzava.Naziv}");
                }
            }
        }
        private void frmPretraga_Load(object sender, EventArgs e)
        {
            UcitajCMB();
            loaded = true;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void cmbDrzave_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void cmbSpolovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dgvPretraga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = dgvPretraga.SelectedRows[0].DataBoundItem as Student;
          
            if (e.ColumnIndex == 5)
            {
                var frm = new frmRazmjene(student);
                frm.ShowDialog();
            }
            if (e.ColumnIndex == 4)
            {
                if (student.Aktivan == true)
                {
                    student.Aktivan = false;
                    db.SaveChanges();
                    UcitajStudente();
                }
                else
                {
                    student.Aktivan = true;
                    db.SaveChanges();
                    UcitajStudente();
                }                 
            }
            else
            { 
                var frm = new frmStudentiEdit(student);
                frm.ShowDialog();
                UcitajStudente();

            }
        }
    }
}
