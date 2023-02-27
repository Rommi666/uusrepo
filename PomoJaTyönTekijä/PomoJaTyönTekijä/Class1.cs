using System;
using System.Collections.Generic;
using System.Text;

namespace Henkilö
{
    public abstract class Henkilö


    {

        public abstract string Nimi { get; set; }

        public abstract void Puhu(); //metodi

        public static int Instanssit = 0;

        public Henkilö()
        {
            Instanssit++;
        }

        public static void johtaja()
        {
            Console.WriteLine("Johtaja: " + Instanssit);
        }

    }
}
