using System;
using System.Collections.Generic; 



    class Program
{
    static void Main(string[] args)
    {
        // Luodaan korttipakka stringeinä
        List<string> deck = new List<string>(); string[] suits = { "Risti", "Ruutu", "Hertta", "Pata" };
        string[] ranks = { "Ässä", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jätkä", "Kuningatar", "Kuningas" }; foreach (string suit in suits)
        {
            foreach (string rank in ranks)
            {
                deck.Add(rank + " on " + suit);
            }
        }         // Tulostaa sekoittomattoman pakan
        Console.WriteLine("Korttipakkaa ei sekoitettu:");
        PrintDeck(deck);         // Shuffle
        Shuffle(deck);         // Tulostaa pakan
        Console.WriteLine("Kortipakka sekooitettu:");
        PrintDeck(deck); Console.ReadLine();
    }
    static void PrintDeck(List<string> deck)
    {
        foreach (string card in deck)
        {
            Console.WriteLine(card);
        }
    }
    static void Shuffle(List<string> deck)
    {
        Random random = new Random(); for (int i = deck.Count - 1; i >= 1; i--)
        {
            int j = random.Next(i + 1);
            string temp = deck[j];
            deck[j] = deck[i];
            deck[i] = temp;
        }
    }
}

