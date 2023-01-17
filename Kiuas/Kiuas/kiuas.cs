using System;
using System.Collections.Generic;
using System.Text;

namespace Kiuas
{
    class kiuas
    {
        string nimi = "Harvia";
        int lampotila = 0;
        int kosteus = 0;
        public bool on = false;
        string paalla;

        public void asetalampotila(int i)
        {
            lampotila = i;


        }

        public void asetakosteus(int i)
        {
            kosteus = i;


        }


        public void Päällä()
        {

            if (on == true)
            {
                on = false;
                paalla = "pois päältä";
            }
            else
            {
                on = true;
                paalla = "päällä";
            }

        }
        public string tiedot()
        {            
            string data = "kiukaan nimi: " + nimi + "\n kiukaanlampotila: " + lampotila + " celcius astetta\n kosteus: " + kosteus + "%\n kiuas: " + paalla;
            return data;
        }
    }
}
