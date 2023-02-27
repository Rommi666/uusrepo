using System;
using System.Collections.Generic;
using System.Text;

namespace PomoJaTyönTekijä
{
    public abstract class Henkilö
    {

        //protected string nimi;

        public string nimi;

        public abstract string Nimi { get; set; }

        public string Työpaikka;

        public string Palkka;

        public string TyöTunnit;

        public string Bonukset;

        public string Auto;

        //public abstract void puhu();
    }


    
    public class Työntekijä : Henkilö
    {
        public override string Nimi
        {
            get { return nimi; }
            set { nimi = value; }
        }
        

    }
    public class Pomo : Henkilö
    {
        public override string Nimi
        {
            get { return nimi; }
            set { nimi = value; }
        }

    
        //public class Pomo : Henkilö
        //{

       }
    }
