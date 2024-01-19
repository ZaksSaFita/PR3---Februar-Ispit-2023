using DLWMS.Data;
using DLWMS.Data.IB220116;
using DLWMS.WinForms.Helpers;
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
    public partial class frmNovaPorukaIB220116 : Form
    {
        private StudentiPredmetiIB220116 studentPredmet;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovaPorukaIB220116(StudentiPredmetiIB220116 studentPredmet)
        {
            InitializeComponent();
            this.studentPredmet = studentPredmet;
        }

        private void frmNovaPorukaIB220116_Load(object sender, EventArgs e)
        {
            Text = "Poruke";
            cmbPredmeti.DataSource= db.Predmeti.ToList();
            dtpValidan.Value = new DateTime(2026, 1, 1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                var predmet = cmbPredmeti.SelectedItem as PredmetIB220116;
                var NovaPoruka = new StudentiPorukeIB220116
                {
                    StudentId = studentPredmet.Student.Id,
                    Predmet = predmet,
                    Validnost = dtpValidan.Value,
                    Sadrzaj = txtSadrzaj.Text,
                    Slika = ImageHelper.FromImageToByte(pbSlika.Image)
                };
                db.StudentiPorukeIB220116.Add(NovaPoruka);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
        private bool Validacija()
        {
            return Validator.ValidirajKontrolu(cmbPredmeti, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(dtpValidan, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtSadrzaj, errorProvider1, Kljucevi.ObaveznaVrijednost)&&
                Validator.ValidirajKontrolu(pbSlika, errorProvider1, Kljucevi.ObaveznaVrijednost);
        }
    }
}
