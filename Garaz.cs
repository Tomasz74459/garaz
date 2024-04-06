using System;

public class Garaz
{
    public string Adres { get; set; }
    public int Pojemnosc { get; set; }
    private int liczbaSamochodow = 0;
    private Samochod[] samochody;

    public Garaz()
    {
        Adres = "nieznany";
        Pojemnosc = 0;
        samochody = new Samochod[Pojemnosc];
    }

    public Garaz(string adres_, int pojemnosc_)
    {
        Adres = adres_;
        Pojemnosc = pojemnosc_;
        samochody = new Samochod[Pojemnosc];
    }

    public void WprowadzSamochod(Samochod samochod)
    {
        if (liczbaSamochodow < Pojemnosc)
        {
            samochody[liczbaSamochodow] = samochod;
            liczbaSamochodow++;
        }
        else
        {
            Console.WriteLine("Garaz jest pelny, nie mozna wprowadzic samochodu.");
        }
    }

    public Samochod WyprowadzSamochod()
    {
        if (liczbaSamochodow > 0)
        {
            Samochod ostatniSamochod = samochody[liczbaSamochodow - 1];
            samochody[liczbaSamochodow - 1] = null;
            liczbaSamochodow--;
            return ostatniSamochod;
        }
        else
        {
            Console.WriteLine("Garaz jest pusty, nie mozna wyprowadzic samochodu.");
            return null;
        }
    }

    public void WypiszInfo()
    {
        Console.WriteLine("Adres: " + Adres);
        Console.WriteLine("Pojemnosc: " + Pojemnosc);
        Console.WriteLine("Liczba samochodow: " + liczbaSamochodow);
        Console.WriteLine("Informacje o samochodach:");
        for (int i = 0; i < liczbaSamochodow; i++)
        {
            samochody[i].WypiszInfo();
            Console.WriteLine();
        }
    }
}