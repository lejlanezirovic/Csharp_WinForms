﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data
{
    public class PolozeniPredmeti
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Predmeti Predmet { get; set; }  
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public string Napomena { get; set; }

    }
}
