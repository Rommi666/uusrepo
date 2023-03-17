using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

[Serializable]
public class Opiskelija
{
    public string Etunimi;
    public string Sukunimi;
    public int OpiskelijaID;
}

public class OpiskelijaSovellus
{
    private const string tiedostonimi = "opiskelijat.dat";
    private List<Opiskelija> opiskelijat;

    public OpiskelijaSovellus()
    {
        // lataa opiskelijat tiedostosta, jos tiedosto on olemassa
        if (File.Exists(tiedostonimi))
        {
            opiskelijat = DeserializeOpiskelijat(tiedostonimi);
        }
        else
        {
            opiskelijat = new List<Opiskelija>();
        }
    }

    public void LisaaOpiskelija(string etunimi, string sukunimi, int opiskelijaID)
    {
        Opiskelija uusiOpiskelija = new Opiskelija();
        uusiOpiskelija.Etunimi = etunimi;
        uusiOpiskelija.Sukunimi = sukunimi;
        uusiOpiskelija.OpiskelijaID = opiskelijaID;
        opiskelijat.Add(uusiOpiskelija);
        SerializeOpiskelijat(tiedostonimi, opiskelijat); // tallenna opiskelijat tiedostoon
        Console.WriteLine("Opiskelija lisätty onnistuneesti.");
    }

    public void PoistaOpiskelija(int opiskelijaID)
    {
        for (int i = 0; i < opiskelijat.Count; i++)
        {
            if (opiskelijat[i].OpiskelijaID == opiskelijaID)
            {
                opiskelijat.RemoveAt(i);
                SerializeOpiskelijat(tiedostonimi, opiskelijat); // tallenna opiskelijat tiedostoon
                Console.WriteLine("Opiskelija poistettu onnistuneesti.");
                return;
            }
        }
        Console.WriteLine("Opiskelijaa ei löytynyt.");
    }

    public void TulostaOpiskelijat()
    {
        Console.WriteLine("Opiskelijat:");
        foreach (Opiskelija opiskelija in opiskelijat)
        {
            Console.WriteLine(opiskelija.Etunimi + " " + opiskelija.Sukunimi + ", ID: " + opiskelija.OpiskelijaID);
        }
    }

    // tallentaa opiskelijalistan tiedostoon
    private static void SerializeOpiskelijat(string tiedosto, List<Opiskelija> opiskelijat)
    {
        FileStream stream = new FileStream(tiedosto, FileMode.Create);
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, opiskelijat);
        stream.Close();
    }

    // lataa opiskelijalistan tiedostosta
    private static List<Opiskelija> DeserializeOpiskelijat(string tiedosto)
    {
        FileStream stream = new FileStream(tiedosto, FileMode.Open);
        BinaryFormatter formatter = new BinaryFormatter();
        List<Opiskelija> opiskelijat = (List<Opiskelija>)formatter.Deserialize(stream);
        stream.Close();
        return opiskelijat;
    }
}

public class Testi
{
    public static void Main()
    {
        OpiskelijaSovellus sovellus = new OpiskelijaSovellus();

        // lisää testiopiskelijoita
        sovellus.LisaaOpiskelija("Matti", "Meikäläinen", 1001);
        sovellus.LisaaOpiskelija("Teppo", "Testaaja", 1002);
        sovellus.LisaaOpiskelija("Anna", "Asiantuntija", 1003);

        sovellus.TulostaOpiskelijat();

        // poistaa yhden opiskelijan
        sovellus.PoistaOpiskelija(1002);

        sovellus.TulostaOpiskelijat();
    }
}
