using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusRechner
{
    class Rechner
    {
        //Instanzvariablen
        private double _Zahl1, _Zahl2;

        //Konstruktor
        public Rechner(): this (0,0)
        {

        }
        public Rechner(double Zahl1, double Zahl2)
        {
            this.Zahl1 = Zahl1;
            this.Zahl2 = Zahl2;
        }



        //Eigenschaften
        public double Zahl1
        {
            set { _Zahl1 = value; }
            get { return _Zahl1; }
        }

        public double Zahl2
        {
            set { _Zahl2 = value; }
            get { return _Zahl2; }
        }

        //Addieren
        public double Addieren()
        {
            return Zahl1 + Zahl2;
        }

        //Subtrahieren
        public double Subtrahieren()
        {
            return Zahl1 - Zahl2;
        }

        //Multiplizieren
        public double Multiplizieren()
        {
            return Zahl1 * Zahl2;
        }

        //Dividieren
        public double Dividieren()
        {
            return Zahl1 / Zahl2;
        }

    }
}
