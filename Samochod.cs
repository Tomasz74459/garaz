using System;

public class Samochod
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public int IloscDrzwi { get; set; }
    public double PojemnoscSilnika { get; set; }
    public double SrednieSpalanie { get; set; }
    
    private static int iloscSamochodow = 0;

    public Samochod()
    {
        Marka = "nieznana";
        Model = "nieznany";
        IloscDrzwi = 0;
        PojemnoscSilnika = 0.0;
        SrednieSpalanie = 0.0;
        iloscSamochodow++;
    }

    public Samochod(string marka_, string model_, int iloscDrzwi_, double pojemnoscSilnika_, double srednieSpalanie_)
    {
        Marka = marka_;
        Model = model_;
        IloscDrzwi = iloscDrzwi_;
        PojemnoscSilnika = pojemnoscSilnika_;
        SrednieSpalanie = srednieSpalanie_;
        iloscSamochodow++;
    }

    private double ObliczSpalanie(double dlugoscTrasy)
    {
        return (SrednieSpalanie * dlugoscTrasy) / 100.0;
    }

    public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
    {
        double spalanie = ObliczSpalanie(dlugoscTrasy);
        return spalanie * cenaPaliwa;
    }

    public void WypiszInfo()
    {
        Console.WriteLine("Marka: " + Marka);
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Ilość drzwi: " + IloscDrzwi);
        Console.WriteLine("Pojemność silnika: " + PojemnoscSilnika);
        Console.WriteLine("Średnie spalanie: " + SrednieSpalanie);
    }

    public static void WypiszIloscSamochodow()
    {
        Console.WriteLine("Liczba utworzonych samochodów: " + iloscSamochodow);
    }
}