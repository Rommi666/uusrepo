using System;
using System.Collections.Generic;
using System.Text;

namespace Albumi
{
    class kappale
    {
        public string nimi;
       public string pituus;

        public string tulostaKappale()
        {
            string data = "-Pituus: " + pituus + "\n Nimi: " + nimi;
            
            return data;

        }
    }

}
