using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string BrojIndeksa { get; set; }
        public string Lozinka { get; set; }
        public Grad Grad { get; set; }
        public Spolovi Spol { get; set; }
        public byte[] Slika { get; set; }
        public bool Aktivan { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
        [NotMapped]
        public string ImePrezime => $"{Ime} {Prezime}";
        [NotMapped]
        public string IndeksImePrezime => $"({BrojIndeksa}) {Ime} {Prezime}";
        [NotMapped]
        public string Drzava => Grad.Drzava.Naziv;

        [NotMapped]
        public List<Razmjene> RazmjeneStudenta { get; set; } = new List<Razmjene>();
    }
}