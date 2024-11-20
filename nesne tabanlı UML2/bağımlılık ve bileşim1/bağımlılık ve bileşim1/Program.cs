using System;

class Islemci
{
    public int Cekirdek { get; set; }
    public int Frekans { get; set; } 

    public Islemci(int cekirdek, int frekans)
    {
        Cekirdek = cekirdek;
        Frekans = frekans;
    }

    public void IslemciBilgisi()
    {
        Console.WriteLine($"İşlemci Çekirdek: {Cekirdek}, Frekans: {Frekans} GHz");
    }
}

class Bilgisayar
{
    public string Model { get; set; }
    public Islemci Islemci { get; set; }

    public Bilgisayar(string model)
    {
        Model = model;
        Islemci = new Islemci(8, 3); 
    }

    public void BilgisayarBilgisi()
    {
        Console.WriteLine($"Bilgisayar Modeli: {Model}");
        Islemci.IslemciBilgisi();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bilgisayar bilgisayar = new Bilgisayar("Lenovo ThinkPad");
        bilgisayar.BilgisayarBilgisi();
    }
}
