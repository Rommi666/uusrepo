using System;
//Roni
namespace Kiuas
{
    class Program
    {
        static void Main(string[] args)
        {
            string asetus;
            Console.WriteLine("Tervetuola Harvia kiukaan tietoihin");
            kiuas Harvia = new kiuas(); // kiuas olion luonti
            while (true) //while loop toimii niin kauan kunnes se breikataan
            {
                Console.WriteLine("Aseta kiuas päälle/pois: virta");
                asetus = Console.ReadLine().ToLower(); //asetetaan stringi muuttuja pikku kirjaimin
                if (asetus == "virta" && Harvia.on == true)
                {
                    break;
                }
                else Harvia.Päällä(); //käytetään kiuas luokan metodia, kiukaan päälle laittamiseen

                Console.Write("aseta kiukaan arvot \n aseta lämpötila: ");
               
                Harvia.asetalampotila( int.Parse (Console.ReadLine())); //käytetään kiuasluokan metodia, käännetään string muuttuja int parsella
                Console.Write("aseta kosteus: ");
                Harvia.asetakosteus(int.Parse(Console.ReadLine()));
                Console.WriteLine(Harvia.tiedot()); //tulostetaan kiukaan tiedot, käyttäen kiuas luokan metodia

            }
            Console.WriteLine("Kiitos Harvia kiukaan käytöstä ");
        }
    }
}
