using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data
{
    [Table("Studenti")]
    public class Student
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string BrojIndeksa { get; set; }
        public string Lozinka { get; set; }
       // public int GradId { get; set; }
        public Spolovi Spol { get; set; }
        public byte[] Slika { get; set; }
        public bool Aktivan { get; set; }
        public override string ToString()
        {
            return $"{BrojIndeksa} {Ime} {Prezime}";
        }

        [NotMapped]
        public string ImePrezime => $"{Ime} {Prezime}";
        [NotMapped]
        public string Drzava => grad.Drzava.Naziv;
        public Grad grad { get; set; }

        [NotMapped]
        public List<Razmjene> razmjene {  get; set; }=new List<Razmjene>();

    }
}