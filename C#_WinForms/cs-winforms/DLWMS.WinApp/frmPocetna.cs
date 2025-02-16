using DLWMS.Infrastructure;
using DLWMS.WinApp.IB230012;
using DLWMS.WinApp.Izvjestaji;

namespace DLWMS.WinApp
{
    public partial class frmPocetna : Form
    {
        DLWMSContext db = new DLWMSContext();
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            lblKonekcijaInfo.Text = $"Broj studenata u bazi -> {db.Studenti.Count()}";
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frmPretraga();
            frm.ShowDialog();
        }
    }
}
