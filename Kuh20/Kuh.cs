using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kuh20
{
    public class Kuh : Saeugetier
    {
        public DateTime Melkzeit1 { get; set; }

        public Kuh():base() //Variante 1, schau zu Ziege für Variante2
        {
            Alter = 0;
            Name = "Berta";
            Gewicht = 40;
        }       
        public Kuh(string name, int alter, double gewicht, double milchvorrat) : base(name, alter, gewicht, milchvorrat)  //Parameter konstruktor kuh ruft den parameterkonstruktor von saugetier auf
        {
         
        }
        public void Nahrungsaufnahme(double Heu)
        {
            Gewicht = Gewicht + (Heu / 10);
            Milchvorrat = Milchvorrat + (Heu / 3);
        }
        public double Melken()
        {
            double rueckgabeMilch = Milchvorrat;
            Gewicht = Gewicht - Milchvorrat;
            Milchvorrat = 0;

            return rueckgabeMilch;
        }
    }
}
