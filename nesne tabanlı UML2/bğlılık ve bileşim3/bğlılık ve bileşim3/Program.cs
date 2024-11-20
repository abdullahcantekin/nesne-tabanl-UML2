using System;
using System.Collections.Generic;

class Ogrenci
{
    public string Ad { get; set; }
    public int Yas { get; set; }

    public Ogrenci(string ad, int yas)
    {
        Ad = ad;
        Yas = yas;
    }

    public void OgrenciBilgisi()
    {
        Console.WriteLine($"Öğrenci Adı: {Ad}, Yaşı: {Yas}");
    }
}

class Okul
{
    public string Ad { get; set; }
    public List<Ogrenci> Ogrenciler { get; set; }

    public Okul(string ad)
    {
        Ad = ad;
        Ogrenciler = new List<Ogrenci>
        {
            new Ogrenci("Mehmet", 15),
            new Ogrenci("Elif", 14)
        }; 
    }

    public void OkulBilgisi()
    {
        Console.WriteLine($"Okul Adı: {Ad}");
        Console.WriteLine("Öğrenciler:");
        foreach (var ogrenci in Ogrenciler)
        {
            ogrenci.OgrenciBilgisi();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Okul okul = new Okul("Atatürk Lisesi");
        okul.OkulBilgisi();
    }
}
