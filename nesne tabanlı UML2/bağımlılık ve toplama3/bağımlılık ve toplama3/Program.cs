using System;
using System.Collections.Generic;

class Kitap
{
    public string Baslik { get; set; }
    public string Yazar { get; set; }

    public Kitap(string baslik, string yazar)
    {
        Baslik = baslik;
        Yazar = yazar;
    }

    public void KitapBilgisi()
    {
        Console.WriteLine($"Kitap Başlığı: {Baslik}, Yazar: {Yazar}");
    }
}

class Kutuphane
{
    public string Ad { get; set; }
    public List<Kitap> Kitaplar { get; set; }

    public Kutuphane(string ad)
    {
        Ad = ad;
        Kitaplar = new List<Kitap>();
    }

    public void KitapEkle(Kitap kitap)
    {
        Kitaplar.Add(kitap);
    }

    public void KutuphaneBilgisi()
    {
        Console.WriteLine($"Kütüphane Adı: {Ad}");
        Console.WriteLine("Kitaplar:");
        foreach (var kitap in Kitaplar)
        {
            kitap.KitapBilgisi();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kitap kitap1 = new Kitap("Savaş ve Barış", "Tolstoy");
        Kitap kitap2 = new Kitap("1984", "George Orwell");

        Kutuphane kutuphane = new Kutuphane("Merkez Kütüphane");
        kutuphane.KitapEkle(kitap1);
        kutuphane.KitapEkle(kitap2);

        kutuphane.KutuphaneBilgisi();

        Console.WriteLine("Kitaplar kütüphaneden bağımsız olarak varlığını sürdürüyor:");
        kitap1.KitapBilgisi();
        kitap2.KitapBilgisi();
    }
}
