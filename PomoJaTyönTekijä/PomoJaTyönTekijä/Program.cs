using System;

namespace PomoJaTyönTekijä
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PomoJaTyönTekijä");
            Työntekijä Tt = new Työntekijä();
            Tt.Nimi = "Pekka";
            Tt.Palkka = "3520e/kk";
            Tt.TyöTunnit = "37h";
            Tt.Työpaikka = "Toimisto";

            Pomo pomo = new Pomo();
            pomo.Nimi = "Jaakko";
            pomo.Bonukset = "10%";
            pomo.Auto = "Musta Toyota";
            pomo.Työpaikka = "Toimisto";
            Console.WriteLine( "Työntekijäntiedot:"+ Tt.Nimi +" "+ Tt.Palkka +" "+ Tt.Työpaikka +" "+ Tt.TyöTunnit);
            Console.WriteLine("Pomontiedot:" + pomo.Nimi +" "+ pomo.Bonukset +" Bonuksia "+ pomo.Auto +" "+ pomo.Työpaikka);





        }
    }
}
