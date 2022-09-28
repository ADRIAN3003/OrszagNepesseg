using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrszagNepesseg
{
    class Orszag
    {
        public string Nev { get; set; }

        public int Nepesseg { get; set; }

        public string Kontinens { get; set; }

        public Orszag(string nev, int nepesseg, string kontinens)
        {
            Nev = nev;
            Nepesseg = nepesseg;
            Kontinens = kontinens;
        }

        public override string ToString()
        {
            return $"{Nev} - {Nepesseg} - {Kontinens}";
        }
    }
}
