namespace Izpit_2024_04_20
{
    internal class Naloga2
    {
        /// <summary>
        /// NALOGA 2:
        /// 
        /// Člani atletskega kluba se z avtobusom odpravljajo na tekmovanje.
        /// S seboj imajo kup atletske prtljage.
        /// Da svoje opreme ne bi izgubili, si želijo pripraviti evidenco.
        /// Pomagajte jim tako, da pripravite naslednje razrede.
        /// 
        /// Razred AtletskoOrodje, ki ima lastnosti Proizvajalec in LetnicaProizvodnje.
        /// V razredu pripravite še natanko en konstruktor, 
        /// ki kot parameter dobi proizvajalca orodja. 
        /// Povozite tudi metodo ToString.                                  [6 točk]
        /// 
        /// Za razred AtletskoOrodje pripravite tri podrazrede, 
        /// ki vsak predstavlja eno od atletskih orodij 
        /// (npr. kroglo, kopje, disk, kladivo).
        /// V vsakem razredu določite eno primerno specifično lastnost,
        /// konstruktor in povozite metodo ToString.                        [10 točk]
        /// 
        /// Pripravite še razred AtletskiKlub, ki ima lastnosti
        /// Naziv, Naslov in SeznamOrodij.
        /// V njem povozite metodo ToString, ki naj vrača opis kluba.       [4 točk]
        /// 
        /// V metodi ResitevNaloge ustvarite eno instanco razreda AtletskiKlub 
        /// in na njegov seznam dodajte tri atletska orodja različnih tipov.
        ///                                                                 [5 točk]
        /// </summary>


        public static void ResitevNaloge()
        {
            AtletskiKlub klub = new AtletskiKlub();
            klub.Naziv = "AK Novo Mesto";
            klub.Naslov = "Mala ulica 123";
            Kladivo kladivo = new Kladivo("proizvajalec 1", 30.2);
            kladivo.LetnicaProizvodnje = 1992;
            Kopje kopje = new Kopje("proizvajalec 2", 200.5);
            kopje.LetnicaProizvodnje = 2020;
            Krogla krogla = new Krogla("proizvajalec 3", 20.4);
            krogla.LetnicaProizvodnje = 2002;
            klub.SeznamOrodij.Add(krogla);
            klub.SeznamOrodij.Add(kopje);
            klub.SeznamOrodij.Add(kladivo);
            Console.WriteLine(klub.ToString());

        }
    }

    public class AtletskoOrodje
    {
        public AtletskoOrodje(string proizvajalec)
        {
            Proizvajalec = proizvajalec;
        }
        public string Proizvajalec { get; set; }
        public int LetnicaProizvodnje;

        public override string ToString()
        {
            return $"Proizvajalec: {Proizvajalec}\nLetnicaProizvodnje: {LetnicaProizvodnje}\n";
        }
    }

    public class Krogla : AtletskoOrodje
    {
        public Krogla(string proizvajalec, double radij) : base(proizvajalec)
        {
            Radij = radij;
        }
        public double Radij { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Radij: {Radij}\n";
        }
    }
    public class Kopje : AtletskoOrodje
    {
        public Kopje(string proizvajalec, double dolzina) : base(proizvajalec)
        {
            Dolzina = dolzina;
        }
        public double Dolzina { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Dolzina: {Dolzina}\n";
        }
    }
    public class Kladivo : AtletskoOrodje
    {
        public Kladivo(string proizvajalec, double teza) : base(proizvajalec)
        {
            Teza = teza;
        }
        public double Teza { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Teza: {Teza}\n";
        }
    }


    public class AtletskiKlub
    {
        public AtletskiKlub()
        {
            SeznamOrodij = new List<AtletskoOrodje>();
        }
        public string Naziv;
        public string Naslov;
        public List<AtletskoOrodje> SeznamOrodij;

        public override string ToString()
        {
            string niz = "";
            niz += $"Naslov: {Naslov}\nNaziv: {Naziv}\n";

            foreach (var el in SeznamOrodij)
            {
                niz += el.ToString();
            }
            return niz;
        }

    }

}
