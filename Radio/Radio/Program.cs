using System;

namespace Radio
{
    class Program
    {
        static void Main(string[] args)
        {

            Radio radio = new Radio();
            Kanavat kanavat = new Kanavat();
            Kanavat kanavat2 = new Kanavat();
            kanavat.Nimi = "Radiosputnik";
            kanavat.Taajuus = 89.0;
            kanavat2.Nimi = "Meluradio";
            kanavat2.Taajuus = 97.0;
            bool validInput = false;
            string asetus;
            while (!validInput)
            {
                Console.Write("Syötä uusi äänenvoimakkuus (0-9): ");
                if (int.TryParse(Console.ReadLine(), out int newVolume))
                {
                    if (newVolume >= 0 && newVolume <= 9)
                    {
                        radio.Volume = newVolume.ToString();
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Tapahtui virhe. äänenvoimqkkuuden piää olla 0 ja 9 välillä.");
                    }
                }
                else
                {

                    Console.WriteLine("Virhe. Syötä numero.");
                }
            }
            Console.WriteLine("Äänenvoimakkuudentaso on nyt: " + radio.Volume);

            validInput = false;
            while (!validInput)
            {
                Console.Write("Syötä uusi taajuus 88.0-107.9): ");
                if (double.TryParse(Console.ReadLine(), out double newTaajuus))
                {
                    if (newTaajuus >= 88.0 && newTaajuus <= 107.9)
                    {
                        if (kanavat.Taajuus == newTaajuus)
                        {
                            Console.WriteLine("Kuuntelet kanavaa " + kanavat.Nimi + "Taajuudella "+ kanavat.Taajuus);
                        }
                        else if (kanavat2.Taajuus == newTaajuus)
                        {
                            Console.WriteLine("Kuuntelet kanavaa " + kanavat2.Nimi + "Taajuudella " + kanavat2.Taajuus);
                        }
                        
                        Console.WriteLine("Haluatko poistua radiosta?, jos haluat paina x");
                        asetus = Console.ReadLine();
                        if (asetus == "x")
                        {
                            validInput = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tapahtui virhe. taajuus piää olla 88.0 ja 107.9 välillä.");
                    }
                }
                else
                {

                    Console.WriteLine("Virhe. Syötä numero.");
                }


            }
        }
    }
    
}
