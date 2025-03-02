using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data
{
    public class Drzava
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }        
        public bool Aktivan { get; set; }
        public override string ToString()
        {
            return $"{Naziv}";
        }
        [NotMapped]
        public List<Grad> gradovi { get; set; }=new List<Grad>();
    }
}
