using DLWMS.Data;
using DLWMS.Data.IB220116;
using DLWMS.WinForms.Helpers;
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

namespace DLWMS.WinForms.IB220116
{
    public partial class frmPretragaIB220116 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiPredmetiIB220116> _studentPredmet;
        public frmPretragaIB220116()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
            dtpDatumOd.Value = new DateTime(2010, 1, 1);
        }

        private void frmPretragaIB220116_Load(object sender, EventArgs e)
        {
            uciitaj();
        }

        private void uciitaj()
        {
                var ocjenaOD = cmbOcjenaOd.SelectedItem == null ? 6 : int.Parse(cmbOcjenaOd.SelectedItem.ToString());
                var ocjenaDO = cmdOcjenaDo.SelectedItem == null ? 10 : int.Parse(cmdOcjenaDo.SelectedItem.ToString());
                var datumOD = dtpDatumOd.Value;
                var datumDO = dtpDatumDo.Value;

                _studentPredmet = db.StudentiPredmeti.Include(x => x.Student).Include(x => x.Predmet)
                .Where(x=>x.Ocjena >= ocjenaOD && x.Ocjena <= ocjenaDO)
                .Where(x=> x.Datum >=  datumOD && x.Datum <= datumDO)
                .ToList();
               
                if (_studentPredmet!=null)
                {
                    dgvPretraga.DataSource = null;
                    dgvPretraga.DataSource= _studentPredmet;
                }
       
                if (_studentPredmet.Count == 0)
                   MessageBox.Show($"U periodu od {datumOD.ToString("dd.MM.yyyy")} - {datumDO.ToString("dd.MM.yyyy")} ne postoje evidentirane ocjene u opsegu od {ocjenaOD} do {ocjenaDO} za bilo kojeg studenta.","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var selectedStudent = _studentPredmet[e.RowIndex];
                if (e.ColumnIndex == 5)
                {
                    frmPorukeIB220116 poruke = new frmPorukeIB220116(selectedStudent);
                    poruke.ShowDialog();
                }
            }

        }
        private void cmbOcjenaOd_SelectedIndexChanged(object sender, EventArgs e)
        {
            uciitaj();
        }

        private void cmdOcjenaDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            uciitaj();
        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            uciitaj();
        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            uciitaj();
        }


    }
}
