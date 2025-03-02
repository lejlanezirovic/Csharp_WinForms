using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data
{
    public class StudentiUloge
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Uloge Uloga { get; set; }

        public double Prosjek => Student.Prosjek;
        public string Indeks=> Student.Indeks;
        public bool Aktivan=>Student.Aktivan;
        public DateTime DatumRodjenja=>Student.DatumRodjenja;
    }
}
