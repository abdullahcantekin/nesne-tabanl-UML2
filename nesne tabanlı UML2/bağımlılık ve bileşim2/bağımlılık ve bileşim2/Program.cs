using System;

class Motor
{
    public int Guc { get; set; } 
    public string Tip { get; set; } 

    public Motor(int guc, string tip)
    {
        Guc = guc;
        Tip = tip;
    }

    public void MotorBilgisi()
    {
        Console.WriteLine($"Motor Gücü: {Guc} Beygir, Tip: {Tip}");
    }
}

class Otomobil
{
    public string Marka { get; set; }
    public Motor Motor { get; set; }

    public Otomobil(string marka)
    {
        Marka = marka;
        Motor = new Motor(180, "Benzinli"); 
    }

    public void OtomobilBilgisi()
    {
        Console.WriteLine($"Otomobil Markası: {Marka}");
        Motor.MotorBilgisi();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Otomobil otomobil = new Otomobil("Toyota Camry");
        otomobil.OtomobilBilgisi();
    }
}

