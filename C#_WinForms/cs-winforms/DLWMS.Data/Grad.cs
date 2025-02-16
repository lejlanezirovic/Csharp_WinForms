using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data
{
    [Table ("Gradovi")]
    public class Grad
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Oznaka{ get; set; }
        public Drzava Drzava { get; set; }
        
        public bool Aktivan { get; set; }

        public override string ToString()
        {
            return $"{Naziv}";

        }
        [NotMapped]
        public string DrzavaNaziv => Drzava.Naziv;
    }
}
