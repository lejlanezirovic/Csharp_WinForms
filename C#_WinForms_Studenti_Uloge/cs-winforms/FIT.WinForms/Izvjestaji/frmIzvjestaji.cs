using FIT.Data;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<StudentiPoruke>? poruke;
        private Student student;

        public frmIzvjestaji(List<StudentiPoruke>? poruke, Student student)
        {
            InitializeComponent();

            this.poruke = poruke;
            this.student = student;
        }
        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var tabelaPoruka = new DataSet.dtPorukeDataTable();
            var rds = new ReportDataSource();
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("rpStudent", student.ImePrezime));
            for (int i = 0; i < poruke.Count; i++)
            {
                var red = tabelaPoruka.NewdtPorukeRow();
                red.RB = $"{i}.";
                red.Predmet = poruke[i]?.Predmet?.Naziv ?? "Nepoznat predmet";
                red.Poruka = poruke[i].Sadrzaj;
                red.BrojZnakova = $"{poruke[i].Sadrzaj.Length}";
                red.Validnost = poruke[i].Validnost.ToString();
                tabelaPoruka.AdddtPorukeRow(red);
            }
            rds.Value = tabelaPoruka;
            rds.Name = "DataSet1";
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }
    }
}
