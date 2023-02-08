using System;

namespace Albumi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Albumi Sovellus");
            albumi1 albumi2 = new albumi1();
            albumi2.Nimi = "Greatest Album Ever";
            albumi2.Genre = "Metalli";
            albumi2.Artisti = "Musty socks";
            
            kappale kappale1 = new kappale();
            kappale1.nimi = "Wow";
            kappale1.pituus = "3:50";
            albumi2.lisää(kappale1);

            kappale kappale2 = new kappale();
            kappale2.nimi = "Wow2";
            kappale2.pituus = "3:51";
            albumi2.lisää(kappale2);

            kappale kappale3 = new kappale();
            kappale3.nimi = "Wow3";
            kappale3.pituus = "3:31";
            albumi2.lisää(kappale3);

            kappale kappale4 = new kappale();
            kappale4.nimi = "Wow4";
            kappale4.pituus = "2:40";
            albumi2.lisää(kappale4);

            kappale kappale5 = new kappale();
            kappale5.nimi = "Wow5";
            kappale5.pituus = "2:40";
            albumi2.lisää(kappale5);

            albumi2.tulostaAlbumi();
            albumi2.TulostaKappaleet();
            
            
        }
    }
}
