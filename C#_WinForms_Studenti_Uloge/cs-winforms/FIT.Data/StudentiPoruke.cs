using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data
{
    public class StudentiPoruke
    {
        public int Id { get; set; } 
        public Student Student { get; set; }
        public Predmeti Predmet {  get; set; }
        public string Sadrzaj {  get; set; }
        public string Hitnost {  get; set; }
        public DateTime Validnost { get; set; }
        public byte[] Slika { get; set; }
    }
}
