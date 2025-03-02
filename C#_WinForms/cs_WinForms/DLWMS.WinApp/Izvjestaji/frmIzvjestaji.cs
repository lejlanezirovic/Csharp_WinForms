using DLWMS.Data;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<Razmjene>? razmjene;
        public Student s;

        public frmIzvjestaji(List<Razmjene>? razmjene, Student s)
        {
            InitializeComponent();
            this.razmjene = razmjene;
            this.s = s;
        }
        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var razmjeneReport = new dsDLWMS.DataTable1DataTable();
            var rds = new ReportDataSource();
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("rpStudent", s.IndeksImePrezime));
            rpc.Add(new ReportParameter("rpECTSSum", razmjene.Where(x=>x.Okoncana==true).Sum(x => x.ECTS).ToString()));
            for (int i = 0; i < razmjene.Count; i++) {
                var red = razmjeneReport.NewDataTable1Row();
                red.RB = $"{i}";
                red.Univerzitet = razmjene[i].Univerzitet.Naziv;
                red.Pocetak = razmjene[i].PocetakRazmjene.ToString();
                red.Kraj = razmjene[i].KrajRazmjene.ToString();
                red.Okoncana = razmjene[i].Okoncana ? "Da" : "Ne";
                red.ECTS = razmjene[i].ECTS.ToString();
                razmjeneReport.AddDataTable1Row(red);
            }
            rds.Value = razmjeneReport;
            rds.Name = "DataSet1";
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport(); 
        }
    }
}
