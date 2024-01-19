using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB220116
{
    public class StudentiPredmetiIB220116
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int PredmetId { get; set; }
        public PredmetIB220116 Predmet { get; set; }

        public int Ocjena { get; set; }

        public DateTime Datum { get; set; }


        /// za ispit februar 2023
        public string BrojIndeksa => Student.BrojIndeksa;

    }
}
