using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kuh20
{
    public class Saeugetier
    {
        
        protected string _name;
        protected int _alter;
        protected double _gewicht;
        protected double _euterInhalt;
        //Set-Methoden
        public void SetName(string name)
        {
            _name = name;
        }
        public void SetAlter(int alter)
        {
            _alter = alter;
        }
        public void SetGewicht(double gewicht)
        {
            _gewicht = gewicht;
        }

        public int MyProperty { get; set; }
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public void SetEuterInhalt(double euterInhalt)
        {
            _euterInhalt = euterInhalt;
        }
        //Get-Methoden
        public string GetName()
        {
            return _name;
        }
        public int GetAlter()
        {
            return _alter;
        }
        public double GetGewicht()
        {
            return _gewicht;
        }
        public double GetEuterInhalt()
        {
            return _euterInhalt;
        }

        /// Poporties

        //protected string _name; siehe oben; propfull 
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >0)
                {
                    _name = value;
                }
            }
        }


        public int Alter { get; set; }
        public double Gewicht { get; set; }
        public double Milchvorrat { get; set; }

        public Saeugetier() 
        {
            Alter = 0;
            Name = "";
            Gewicht = 0;
            Milchvorrat = 0;
        }

        public Saeugetier(string name, int alter, double gewicht, double milchvorrat)
        {
                
            Name = name;
           // _alter = alter; // Felder im Konstrutor nicht unbedingt verwenden, da sie private sind und von außen nicht verändert/validiert werden können
            Alter = alter;  //geht in Proportie im Validierung zu überprüfen
            Gewicht = gewicht;
            Milchvorrat = milchvorrat;
            
        }
    }
}
