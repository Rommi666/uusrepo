using System;

namespace Sm_Liiga
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Joukkue joukkue = new Joukkue();
                joukkue.Nimi = "JYP";
                joukkue.Kotikaupunki = "Jyväskylä";

                Pelaaja pelaaja1 = new Pelaaja();
                pelaaja1.Etunimi = "Juuso";
                pelaaja1.Sukunimi = "Puustinen";
                pelaaja1.PelaajaNumero = 13;
                joukkue.LisääPelaaja(pelaaja1);

                Pelaaja pelaaja2 = new Pelaaja();
                pelaaja2.Etunimi = "Ossi";
                pelaaja2.Sukunimi = "Louhivaara";
                pelaaja2.PelaajaNumero = 9;
                joukkue.LisääPelaaja(pelaaja2);

                try
                {
                    Pelaaja haettuPelaaja = joukkue.HaePelaaja(13);
                    Console.WriteLine("Haettu pelaaja: {0} {1}, #{2}", haettuPelaaja.Etunimi, haettuPelaaja.Sukunimi, haettuPelaaja.PelaajaNumero);

                    joukkue.PoistaPelaaja(9);
                    Console.WriteLine("Pelaaja 9 on poistettu");
                }
                catch { }
             }
        }
    } 
}

