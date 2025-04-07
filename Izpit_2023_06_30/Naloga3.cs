namespace Izpit_2023_06_30
{
    internal class Naloga3
    {
        /// <summary>
        /// NALOGA 3:
        /// Pripravite razreda Dijak in Razred.
        /// 
        /// Razred Dijak naj vsebuje: 
        /// -   Lastnosti Ime, PredmetiNaMaturi, ŠteviloTočkNaMaturi, KončniUspeh (zadosten, dober, prav dober, odličen).
        /// -   En konstruktor, ki omogoča določitev natanko dveh lastnosti, 
        ///     in en konstruktor, ki omogoča določitev vseh štirih lastnosti.
        /// -   Povozite metodo ToString, ki naj izpiše vse podatke o dijaku.               [10 točk]
        /// 
        /// Razred Razred naj vsebuje:
        /// -   Lastnosti SeznamDijakov in Razrednik.
        /// -   Konstruktor, ki inicializira seznam dijakov in kot parameter dobi razrednika.
        /// -   Metodo, ki izpiše povprečno število točk dijakov razreda na maturi.         [10 točk]
        /// 
        /// V metodi ResitevNaloge kreirajte instanco razreda Razred, ki naj vsebuje vsaj pet dijakov
        /// in izpišite podatke o vseh dijakih, ki so na maturi dosegli vsaj 24 točk.       [5 točk]
        /// </summary>
        /// 

        public static void ResitevNaloge()
        {
            List<string> predmeti = new List<string>() { "Matematika", "Fizika", "Slovenscina", "Nemscina", "Zgodovina" };
            Dijak Ana = new Dijak("Ana", predmeti, 24, "odlicno");
            Dijak Nik = new Dijak("Nik", predmeti, 21, "prav dobro");
            Dijak Peter = new Dijak("Peter", predmeti, 20, "dobro");
            Dijak Nika = new Dijak("Nika", predmeti, 30, "odlicno");
            Dijak Danaja = new Dijak("Danaja", predmeti, 16, "dobro");
            List<Dijak> seznamDijakov = new List<Dijak>() { Ana, Nik, Peter, Nika, Danaja };

            Razred razred = new Razred("prof. Smole");
            razred.SeznamDijakov.AddRange(seznamDijakov);

            Console.WriteLine("Dijaki ki so na maturi dosegli vsaj 24 točk: ");
            foreach (var dijak in razred.SeznamDijakov)
            {
                if (dijak.SteviloTockNaMaturi > 23)
                    Console.WriteLine(dijak.ToString());
            }

        }
    }

    public class Dijak
    {
        public Dijak(string ime, string koncniUspeh)
        {
            Ime = ime;
            KoncniUspeh = koncniUspeh;
        }
        public Dijak(string ime, List<string> predmetiNaMaturi, int steviloTockNaMaturi, string koncniUspeh)
        {
            Ime = ime;
            PredmetiNaMaturi = predmetiNaMaturi;
            SteviloTockNaMaturi = steviloTockNaMaturi;
            KoncniUspeh = koncniUspeh;
        }
        public string Ime { get; set; }
        public List<string> PredmetiNaMaturi { get; set; }
        public int SteviloTockNaMaturi { get; set; }
        public string KoncniUspeh { get; set; }

        public override string ToString()
        {
            return $"Ime dijaka: {Ime}\nPredmeti na maturi: {String.Join(", ", PredmetiNaMaturi)}\n Število Točk: {SteviloTockNaMaturi}\n Končni uspeh:{KoncniUspeh}";
        }
    }


    public class Razred
    {
        public Razred(string razrednik)
        {
            Razrednik = razrednik;
            SeznamDijakov = new List<Dijak>();
        }
        public string Razrednik { get; set; }
        public List<Dijak> SeznamDijakov { get; set; }

        public void povprecneTockeDijakov()
        {
            int vsotaTock = 0;
            foreach (var el in SeznamDijakov)
            {
                vsotaTock += el.SteviloTockNaMaturi;
            }
            double povprecneTocke = (double)vsotaTock / SeznamDijakov.Count();
            Console.WriteLine($"Povprečno število točk na maturi je bilo: {povprecneTocke:0.00}");
        }
    }
}
