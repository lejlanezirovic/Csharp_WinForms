using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace FIT.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }        
        public Semestri Semestar { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }

        [NotMapped]
        public string ImePrezime => $"{Ime} {Prezime}";
        [NotMapped]
        public List<PolozeniPredmeti> Polozeni { get; set; } = new List<PolozeniPredmeti>();
        [NotMapped]
        public double Prosjek => Polozeni.Count > 0 ? Polozeni.Average(x => x.Ocjena) : 5;
        [NotMapped]
        public List<StudentiUloge> Uloge { get; set; } = new List<StudentiUloge>();
        [NotMapped]
        public List<StudentiPoruke> Poruke { get; set; } = new List<StudentiPoruke>();
    }
}
