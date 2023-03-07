using System;
using System.Collections.Generic;
using System.Text;

namespace Sm_Liiga
{
    class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        private Dictionary<int, Pelaaja> Pelaajat { get; set; }

        public Joukkue()
        {
            Pelaajat = new Dictionary<int, Pelaaja>();
        }

        public Pelaaja HaePelaaja(int numero)
        {
            if (Pelaajat.ContainsKey(numero))
            {
                return Pelaajat[numero];
            }
            else
            {
                throw new Exception("Pelaajaa ei löytynyt");
            }
        }

        public void LisääPelaaja(Pelaaja pelaaja)
        {
            if (Pelaajat.ContainsKey(pelaaja.PelaajaNumero))
            {
                throw new Exception("Pelaaja on jo lisätty");
            }
            else
            {
                Pelaajat.Add(pelaaja.PelaajaNumero, pelaaja);
            }
        }

        public void PoistaPelaaja(int numero)
        {
            if (Pelaajat.ContainsKey(numero))
            {
                Pelaajat.Remove(numero);
            }
            else
            {
                throw new Exception("Pelaajaa ei löytynyt");
            }
        }

        public List<Pelaaja> HaePelaajat()
        {
            List<Pelaaja> pelaajat = new List<Pelaaja>();

            foreach (Pelaaja pelaaja in Pelaajat.Values)
            {
                pelaajat.Add(pelaaja);
            }

            return pelaajat;
        }
    }
}
