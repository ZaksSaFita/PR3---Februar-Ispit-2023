using DLWMS.Data;
using DLWMS.Data.IB220116;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
using Microsoft.CodeAnalysis.FlowAnalysis;
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
    public partial class frmPorukeIB220116 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiPorukeIB220116> _studentPoruke;

        private StudentiPredmetiIB220116 _studentPredmet;
        public frmPorukeIB220116(StudentiPredmetiIB220116 selectedStudent)
        {
            InitializeComponent();
            this._studentPredmet = selectedStudent;
            dataGridView1.AutoGenerateColumns = false;
        }
        private void frmPorukeIB220116_Load(object sender, EventArgs e)
        {
            Ucitaj();
            lblStudent.Text = $"Poruke studenta {_studentPredmet.Student}: ";
            cmbPredmeti.DataSource = db.Predmeti.ToList();
            dtpValidan.Value = new DateTime(2028, 1, 1);
        }
        private void Ucitaj()
        {
            _studentPoruke = db.StudentiPorukeIB220116.Include("Student").Include("Predmet")
               .Where(x => x.Student == _studentPredmet.Student && x.Validnost > DateTime.Now)
               .ToList();

            if (_studentPoruke != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _studentPoruke;
            }

            Text = $"Broj poruka: {_studentPoruke.Count}";

            if(_studentPoruke.Count == 0)
            {
                btnDodaj.Enabled= false;
            }
            else {
                btnDodaj.Enabled= true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var thechosenone = _studentPoruke[e.RowIndex];

                if (e.ColumnIndex == 4)
                {
                    if (MessageBox.Show("Da li ste sigurni da zelite obrisati", "Penis", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK)
                    {
                        db.StudentiPorukeIB220116.Remove(thechosenone);
                        db.SaveChanges();
                        Ucitaj();
                    }               
                }
            }
        }
        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            frmIzvjestaji izvjestaj = new frmIzvjestaji (_studentPoruke, _studentPredmet);
            izvjestaj.ShowDialog();
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            frmNovaPorukaIB220116 novaPoruka = new frmNovaPorukaIB220116(_studentPredmet);
            if (novaPoruka.ShowDialog()==DialogResult.OK)
            {
                Ucitaj();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                var BrojPoruka = int.Parse(txtBroj.Text);
                var predmet = cmbPredmeti.SelectedItem as PredmetIB220116;
                var _Datum = dtpValidan.Value;

                Thread t1 = new Thread(() => Generisi(BrojPoruka, predmet, _Datum));
                t1.Start();
            }
        }

        private void Generisi(int brojPoruka, PredmetIB220116 predmet, DateTime datum)
        {
            for (int i = 0; i < brojPoruka; i++)
            {
                var NovaPoruka = new StudentiPorukeIB220116
                {
                    StudentId = _studentPredmet.Student.Id,
                    Predmet = predmet,
                    Validnost = datum,
                    //1.GENERISANA PORUKA
                    Sadrzaj = $"{i+1}.GENERISANA PORUKA",
                    Slika = _studentPoruke[0].Slika
                };
                Thread.Sleep(300);

                var ispis = $"{datum.ToString("dd.MM.yyyy")} -> generisana poruka za {_studentPredmet.Student} na predmetu {predmet}"+Environment.NewLine;

                Action upadteInfo = () => txtInfo.AppendText(ispis);
                txtInfo.Invoke(upadteInfo);

                db.StudentiPorukeIB220116.Add(NovaPoruka);
                db.SaveChanges();
            }

            Action action = () =>
            {
                Ucitaj();
                if (MessageBox.Show("Dodavanje je zavrseno." + Environment.NewLine + "Zelite li reset polja?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtBroj.Text = ""; txtInfo.Text = "";
                }
            };
            BeginInvoke(action);    
        }

        private bool Validacija()
        {
            return Validator.ValidirajKontrolu(txtBroj, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cmbPredmeti, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(dtpValidan, errorProvider1, Kljucevi.ObaveznaVrijednost);
        }
    }
}
