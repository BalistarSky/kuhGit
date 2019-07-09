using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kuh20
{
    public class Ziege : Saeugetier
    {
        public bool IstAngeleint { get; set; }
        public Ziege():base("Otto",0,10,0) //Variante 2, schau für Variante 1 zu Standartkonstruktor der Kuh
        {
            //Konstruktor springt in die Basis Klasse, Werte werden den Proporties zugewiesen, dann zurück in den Konstrukter, dann ins Programm, wo Ziege als Objekt erzeugt wird
        }
        public Ziege(string name, int alter, double gewicht, double milchvorrat):base(name, alter, gewicht, milchvorrat)
        {
            
        }
    }
}
