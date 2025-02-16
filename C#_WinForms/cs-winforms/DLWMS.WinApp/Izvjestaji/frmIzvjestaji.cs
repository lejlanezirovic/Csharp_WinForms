using DLWMS.Data;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private Student? student;

        public frmIzvjestaji(Student? student)
        {
            InitializeComponent();
            this.student = student;
        }


        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var razmjene = new dsDLWMS.razmjeneTableDataTable();
            var rds = new ReportDataSource();
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("rpIme", student.ImePrezime));
            rpc.Add(new ReportParameter("rpBrIndeksa", student.BrojIndeksa));

            for (int i = 0; i < student.razmjene.Count; i++)
            {
                var red = razmjene.NewrazmjeneTableRow();
                red.RB = $"{i}";
                red.Pocetak = $"{student.razmjene[i].PocetakRazmjene}";
                red.Kraj = $"{student.razmjene[i].KrajRazmjene}";
                red.Univerzitet = student.razmjene[i].Univerzitet.Naziv;
                red.ECTS = student.razmjene[i].ECTS.ToString();
                red.Okoncano = student.razmjene[i].Okoncana.ToString();
                razmjene.AddrazmjeneTableRow(red);

            }
            rds.Value= razmjene;
            rds.Name = "DataSourceRDLC";
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport(); 
        }
    }
}
