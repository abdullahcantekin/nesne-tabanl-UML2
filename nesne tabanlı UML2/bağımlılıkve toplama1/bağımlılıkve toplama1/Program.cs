using System;
using System.Collections.Generic;

class Oda
{
    public string Boyut { get; set; }
    public string Tip { get; set; }

    public Oda(string boyut, string tip)
    {
        Boyut = boyut;
        Tip = tip;
    }

    public void OdaBilgisi()
    {
        Console.WriteLine($"Oda Boyutu: {Boyut}, Tip: {Tip}");
    }
}

class Ev
{
    public string Ad { get; set; }
    public List<Oda> Odalar { get; set; }

    public Ev(string ad)
    {
        Ad = ad;
        Odalar = new List<Oda>();
    }

    public void OdaEkle(Oda oda)
    {
        Odalar.Add(oda);
    }

    public void EvBilgisi()
    {
        Console.WriteLine($"Ev Adı: {Ad}");
        Console.WriteLine("Odalar:");
        foreach (var oda in Odalar)
        {
            oda.OdaBilgisi();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Oda oda1 = new Oda("20 m²", "Yatak Odası");
        Oda oda2 = new Oda("15 m²", "Oturma Odası");

        Ev ev = new Ev("Aile Evi");
        ev.OdaEkle(oda1);
        ev.OdaEkle(oda2);

        ev.EvBilgisi();

        Console.WriteLine("Odalar evden bağımsız olarak varlığını sürdürüyor:");
        oda1.OdaBilgisi();
        oda2.OdaBilgisi();
    }
}

