using System;
using System.Collections.Generic;
using System.Text;

namespace Albumi
{
    class albumi1
    {
       public string Artisti;
        public string Genre;
        public string Nimi;
        public int Hinta;

        List<kappale> soittolista = new List<kappale>();

        public void lisää(kappale s)

        {
            soittolista.Add(s);
            
        }

        public string tulostaAlbumi()
        {
            string data = "Albumi: \n -Artisti: " + Artisti + "\n Nimi: " + Nimi + "\n Genre:" + Genre + "\n Hinta: " + Hinta;

            Console.WriteLine(data);

            return data;
            
        }

        public void TulostaKappaleet()
        {

            
            foreach (kappale kappale in soittolista)
            {

                //kappale.tulostaKappale();

                Console.WriteLine(kappale.tulostaKappale());

               
            }
        }
    }
}
