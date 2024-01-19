using DLWMS.Data.IB220116;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<StudentiPorukeIB220116> _studentPoruke;
        private StudentiPredmetiIB220116 _studentPredmet;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(List<StudentiPorukeIB220116> studentPoruke, StudentiPredmetiIB220116 studentPredmet)
        {
            InitializeComponent();
            this._studentPoruke = studentPoruke;
            this._studentPredmet = studentPredmet;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var tabela = new dsDLWMS.dsDLWMSDataTable();
            for (int i = 0; i < _studentPoruke.Count; i++)
            {
                var Red = tabela.NewdsDLWMSRow();
                Red.Rb = (i + 1).ToString();
                Red.Predmet= _studentPoruke[i].Predmet.ToString();
                Red.Poruka = _studentPoruke[i].Sadrzaj;
                Red.BrojZnakova = _studentPoruke[i].Sadrzaj.Count().ToString();
                Red.Validnost = _studentPoruke[i].Validnost.ToString();
                tabela.Rows.Add( Red );
            }
            var Source = new ReportDataSource();
            Source.Name = "dsDLWMS";
            Source.Value = tabela;
            reportViewer1.LocalReport.DataSources.Add(Source);

            var parametri = new ReportParameterCollection();
            parametri.Add(new ReportParameter("Student",_studentPredmet.Student.ToString()));
            parametri.Add(new ReportParameter("Poruka", _studentPoruke.Count().ToString())); 
            parametri.Add(new ReportParameter("Karakter", _studentPoruke.Average(x=>x.Sadrzaj.Count()).ToString()));
            reportViewer1.LocalReport.SetParameters(parametri);

            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            reportViewer1.RefreshReport();
        }
    }
}
