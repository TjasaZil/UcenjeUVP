namespace Izpit_2025_03_22;

/// <summary>
/// NALOGA 2:
/// 
/// Pripravljamo aplikacijo za samodejno generiranje izpitov. 
/// Zanjo bomo pripravili dva razreda: razred Naloga, ki bo predstavljal izpitno nalogo, 
/// in razred Izpit, ki bo predstavljal izpit iz programiranja. 
/// 
/// Razred Naloga naj vsebuje: 
/// - Lastnosti Besedilo, MozneTocke, DosezeneTocke, Avtor in Tezavnost.
/// - Natanko en konstruktor, ki nastavi lastnost Sestavljalec.
/// - Funkcijo, ki vrne odstotek doseženih točk.
/// - Metodo ToString, ki izpiše vse lastnosti naloge.                              [10 točk]
/// 
/// Razred Izpit naj vsebuje: 
/// - Lastnosti Predmet, DatumPisanja, Naloge in CasPisanja.
/// - Konstruktor, ki kot parameter dobi datum pisanja.
/// - Funkcijo ToString, ki naj izpiše vse podrobnosti izpita.
/// - Funkcijo, ki izračuna skupno število doseženih točk na izpitu.                [10 točk]
/// 
/// V funkciji ResitevNaloge kreirajte tri instance razreda Naloga 
/// in eno instanco razreda Izpit ter naloge dodajte k nalogam izpita. 
/// Vsem instancam za vse lastnosti določite neke vrednosti. 
/// Nato v ukazno vrstico izpišite število doseženih točk na izpitu.                [5 točk]
/// </summary>
public class Naloga2
{
    /// <summary>
    /// V tej funkciji se začne izvajati program za reševanje Naloge 2
    /// </summary>
    public static void ResitevNaloge()
    {
        Naloga naloga1 = new Naloga();
        naloga1.Avtor = "Avtor 1";
        naloga1.Tezavnost = "Zelo tezko";
        naloga1.DosezeneTocke = 20;
        naloga1.MozneTocke = 25;
        Naloga naloga2 = new Naloga();
        naloga2.Avtor = "Avtor 2";
        naloga2.Tezavnost = "Zelo lahko";
        naloga2.DosezeneTocke = 25;
        naloga2.MozneTocke = 25;
        Naloga naloga3 = new Naloga();
        naloga3.Avtor = "Avtor 3";
        naloga3.Tezavnost = "Zelo zelo tezko";
        naloga3.DosezeneTocke = 15;
        naloga3.MozneTocke = 25;

        DateTime danasnjiDatum = DateTime.Today;
        Izpit izpit = new Izpit(danasnjiDatum);
        izpit.Naloge.Add(naloga1);
        izpit.Naloge.Add(naloga2);
        izpit.Naloge.Add(naloga3);
        izpit.CasPisanja = 90;
        izpit.Predmet = "UVP";

        int dosezeneTocke = izpit.VseTocke();
        Console.WriteLine($"Student je na izpitu dosegel {dosezeneTocke}");

    }
}

public class Naloga
{
    public Naloga()
    {
        string Sestavljalec = "Borut Luzar";
    }
    public string Besedilo { get; set; }
    public int MozneTocke { get; set; }
    public int DosezeneTocke { get; set; }
    public string Avtor { get; set; }
    public string Tezavnost { get; set; }

    public double OdstotekTock()
    {
        double procentTock = (double)(DosezeneTocke / MozneTocke) * 100;

        return procentTock;
    }
    public override string ToString()
    {
        return $"Besedilo: {Besedilo}\nMozne Tocke: {MozneTocke}\nDosezene Tocke:{DosezeneTocke}\nAvtor:{Avtor}\nTezavnost:{Tezavnost}\n";
    }
}


public class Izpit
{
    public Izpit(DateTime datum)
    {
        DatumPisanja = datum;
        Naloge = new List<Naloga>();
    }
    public string Predmet { get; set; }
    public DateTime DatumPisanja { get; set; }
    public List<Naloga> Naloge { get; set; }
    public int CasPisanja { get; set; }


    public int VseTocke()
    {
        int vsotaTock = 0;
        foreach (var el in Naloge)
        {
            vsotaTock += el.DosezeneTocke;
        }
        return vsotaTock;
    }

    public override string ToString()
    {
        return $"Predmet: {Predmet}\nDatum Pisanja: {DatumPisanja}\nNaloge:{Naloge.ToString()}\nCas Pisanja:{CasPisanja}\n";
    }
}