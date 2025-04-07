namespace Izpit_2025_03_22;

/// <summary>
/// NALOGA 3:
/// Za potrebe društva tabornikov pripravljamo aplikacijo za evidentiranje dreves v gozdovih.

/// Napišite razred Drevo, ki ima lastnosti Vrsta, Višina, Volumen in Starost. 
/// V razredu pripravite še natanko en konstruktor, 
/// ki kot parameter dobi vrsto drevesa. 
/// Povozite tudi funkcijo ToString.                                            [6 točk]

/// Za razred Drevo pripravite dva podrazreda: Listavec in Iglavec. 
/// Za vsakega od podrazredov si zamislite po eno ustrezno 
/// specifično lastnost in jo implementirajte. 
/// V vsakem od podrazredov ustrezno popravite še funkcijo ToString.            [7 točk]

/// Napišite še razred Gozd, ki naj ima lastnosti Lokacija in Drevesa.
/// Dodajte še funkcijo, ki vrne skupen volumen iglavcev v gozdu, 
/// in funkcijo, ki vrne povprečno starost dreves, 
/// katera imajo višino višjo od danega parametra.                              [7 točk]
 
/// V funkciji ResitevNaloge ustvarite eno instanco razreda Gozd 
/// in na njegov seznam dreves dodajte štiri drevesa različnih tipov. 
/// V ukazno vrstico s pomočjo klica ustrezne funkcije 
/// izpišite skupen volumen vseh iglavcev v gozdu.                              [5 točk]
/// </summary>
public class Naloga3
{
    /// <summary>
    /// V tej funkciji se začne izvajati program za reševanje Naloge 3
    /// </summary>
    public static void ResitevNaloge()
    {
        Listavec Hrast = new Listavec("Hrast", "rumena");
        Hrast.Starost = 10;
        Hrast.Volumen = 13.2;
        Hrast.Visina = 5;
        Iglavec Macesen = new Iglavec("Macesen", false);
        Macesen.Starost = 13;
        Macesen.Volumen = 3.2;
        Macesen.Visina = 2;
        Listavec Kostanj = new Listavec("Kostanj", "Zelena");
        Kostanj.Starost = 26;
        Kostanj.Volumen = 33.2;
        Kostanj.Visina = 15;
        Iglavec Bor = new Iglavec("Bor", true);
        Bor.Starost = 50;
        Bor.Volumen = 23.2;
        Bor.Visina = 13;
        Drevo randomDrevo = new Drevo("Ne poznam");
        randomDrevo.Starost = 10;
        randomDrevo.Volumen = 13.2;
        randomDrevo.Visina = 5;
        Gozd gozd = new Gozd();
        gozd.Drevesa.Add(Hrast);
        gozd.Drevesa.Add(Macesen);
        gozd.Drevesa.Add(Kostanj);
        gozd.Drevesa.Add(Bor);
        gozd.Drevesa.Add(randomDrevo);

        double volumenIglavcev = gozd.VolumenIglavcev();
        Console.WriteLine($"Skupen volumen iglavcev v gozdu je : {volumenIglavcev:0.00}");
    }


}

public class Drevo
{
    public Drevo(string vrsta)
    {
        Vrsta = vrsta;
    }

    public string Vrsta { get; set; }
    public double Visina { get; set; }
    public double Volumen { get; set; }
    public int Starost { get; set; }
    public override string ToString()
    {
        return $"Vrsta: {Vrsta}\nVisina: {Visina:0.00}\nVolumen:{Volumen:0.00}\nStarost:{Starost}\n";
    }

}


public class Listavec : Drevo
{

    public Listavec(string vrsta, string barvaListov) : base(vrsta)
    {
        BarvaListov = barvaListov;
    }

    public string BarvaListov { get; set; }
    public override string ToString()
    {
        return base.ToString() + $"Barva Listov: {BarvaListov}\n";
    }
}
public class Iglavec : Drevo
{
    public Iglavec(string vrsta, bool jeZimzelen) : base(vrsta)
    {
        JeZimzelen = jeZimzelen;
    }
    public bool JeZimzelen { get; set; }
    public override string ToString()
    {
        string zimzelen = JeZimzelen ? "da" : "ne";
        return base.ToString() + $"Je Zimzelen: {zimzelen}\n";
    }
}


public class Gozd
{
   
    public string Lokacija { get; set; }
    public List<Drevo> Drevesa { get; set; } = new List<Drevo>();

    public double VolumenIglavcev()
    {
        double skupniVolumen = 0;
        foreach (var drevo in Drevesa)
        {
            if (drevo is Iglavec) skupniVolumen += drevo.Volumen;

        }
        return skupniVolumen;
    }

    public double PovprecnaStarost(double parameter)
    {
        double skupnaStarost = 0;
        int stDreves = 0;
        foreach (var drevo in Drevesa)
        {
            if (parameter < drevo.Visina)
            {
                skupnaStarost += drevo.Starost;
                stDreves++;
            }
        }
        return (double)skupnaStarost / stDreves;
    }
}