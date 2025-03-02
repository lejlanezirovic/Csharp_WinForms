using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    public class Razmjene
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Univerziteti Univerzitet { get; set; }
        public DateTime PocetakRazmjene { get; set; }
        public DateTime KrajRazmjene { get; set; }
        public int ECTS { get; set; }
        public bool Okoncana { get; set; }
    }
}
