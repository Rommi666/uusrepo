using System;
using System.Collections.Generic;
using System.Text;

namespace Radio
{
    class Kanavat : Radio
    {
        private double taajuus;


        private string nimi;
        public string Nimi
        {
            get { return nimi; }
            set { nimi = value; }
        }
        public double Taajuus
        {
            get { return taajuus; }
            set { taajuus = value; }
        }


    }
}
