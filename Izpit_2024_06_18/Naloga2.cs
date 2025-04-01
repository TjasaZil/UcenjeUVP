namespace Izpit_2024_06_18
{
    internal class Naloga2
    {
        /// <summary>
        /// NALOGA 2:
        /// 
        /// V Nemčiji ravno poteka evropsko	nogometno prvenstvo, 
        /// mi pa želimo pripraviti razredni model za beleženje 
        /// statistik tekem na klubskem svetovnem prvenstvu. 
        /// V ta namen pripravite razrede Ekipa, Statistika in Tekma.
        /// 
        /// Razred Ekipa naj vsebuje: 
        /// - Lastnosti Ime, Klub in Igralci.
        /// - Natanko en konstruktor, ki nastavi lastnosti Ime in Klub.
        /// - Metodo ToString, ki izpiše vse lastnosti ekipe.               [4 točk]
        /// 
        /// Razred Statistika naj vsebuje: 
        /// - Lastnosti Goli, PosestZoge, Prekrski, RumeniKartoni in RdečiKartoni.
        /// - Metodo ToString, ki naj izpiše vse statistične enote.         [4 točk]
        /// 
        /// Razred Tekma naj vsebuje: 
        /// - Lastnosti Domači, Gosti, Datum, StatistikaDomači in StatistikaGosti. 
        ///   Vse lastnosti naj imajo ustrezen tip.
        /// - En konstruktor, ki omogoča zgolj določitev lastnosti Domači in Gosti.
        /// - Metodo ToString, ki naj izpiše vse podrobnosti o tekmi.
        /// - Metodo, ki vrne skupno število rumenih kartonov na tekmi.
        /// - Metodo, ki vrne rezultat tekme.                               [12 točk]
        /// 
        /// V metodi ResitevNaloge kreirajte dve instanci razreda Ekipa, 
        /// instanco razreda Tekma, instanci za statistiko obeh ekip na tekmi 
        /// in na koncu na zaslon izpišite rezultat ter podatke o tekmi.    [5 točk]
        /// </summary>
        /// 

        public static void ResitevNaloge()
        {
            Ekipa domaci = new Ekipa("Domača ekipa", "Klub Domača ekipa");
            domaci.Igralci.Add("France");
            domaci.Igralci.Add("Božo");
            domaci.Igralci.Add("Miki");
            domaci.Igralci.Add("Nikola");
            domaci.Igralci.Add("Andraž");
            Ekipa gosti = new Ekipa("Gostujoča ekipa", "Klub Gostujoča ekipa");
            gosti.Igralci.Add("France");
            gosti.Igralci.Add("Božo");
            gosti.Igralci.Add("Miki");
            gosti.Igralci.Add("Nikola");
            gosti.Igralci.Add("Andraž");

            Tekma tekma = new Tekma(domaci, gosti);
            Statistika statDomaci = new Statistika();
            statDomaci.Goli = 2;
            statDomaci.PosestZoge = 45;
            statDomaci.Prekrski = 13;
            statDomaci.RumeniKartoni = 2;
            statDomaci.RdeciKartoni = 0;
            Statistika statTuji = new Statistika();
            statTuji.Goli = 5;
            statTuji.PosestZoge = 55;
            statTuji.Prekrski = 5;
            statTuji.RumeniKartoni = 0;
            statTuji.RdeciKartoni = 3;
            tekma.StatistikaDomaci = statDomaci;
            tekma.StatistikaGosti = statTuji;
            tekma.Datum = DateTime.Now;

            Console.WriteLine(tekma.ToString());
            Console.WriteLine("Število rumenih kartonov: " + tekma.SteviloRumenihKartonov());
            Console.WriteLine("Rezultat tekme: " + tekma.RezultatTekme());
        }

    }

    public class Ekipa
    {
        public Ekipa(string ime, string klub)
        {
            Ime = ime;
            Klub = klub;
            Igralci = new List<string>();
        }
        public string Ime { get; set; }
        public string Klub { get; set; }
        public List<string> Igralci;

        public override string ToString()
        {
            string niz = $"Ime:{Ime}\nKlub:{Klub}\nIgralci:";
            foreach (var el in Igralci)
            {
                niz += $"{el} ";
            }
            return niz;
        }
    }

    public class Statistika
    {
        public int Goli;
        public double PosestZoge;
        public int Prekrski;
        public int RumeniKartoni;
        public int RdeciKartoni;

        public override string ToString()
        {

            return $"Goli:{Goli}\nPosestZoge:{PosestZoge}\nPrekrski:{Prekrski}\nRumeniKartoni:{RumeniKartoni}\nRdečiKartoni:{RdeciKartoni}\n";
        }
    }

    public class Tekma
    {
        public Tekma(Ekipa domaci, Ekipa gosti)
        {
            Domaci = domaci;
            Gosti = gosti;
        }
        public Ekipa Domaci { get; set; }
        public Ekipa Gosti { get; set; }
        public DateTime Datum;
        public Statistika StatistikaDomaci;
        public Statistika StatistikaGosti;

        public override string ToString()
        {
            return $"Podatki o tekmi:\nDomaci:\n{Domaci.ToString()}\nGosti:\n{Gosti.ToString()}\nDatum:{Datum}\n\nStatistika domaci:\n{StatistikaDomaci.ToString()}\nStatistika gosti:\n{StatistikaGosti.ToString()}\n";
        }

        public int SteviloRumenihKartonov()
        {
            return StatistikaDomaci.RumeniKartoni + StatistikaGosti.RumeniKartoni;
        }
        public string RezultatTekme()
        {
            return $"{StatistikaDomaci.Goli} : {StatistikaGosti.Goli}";
        }
    }
}
