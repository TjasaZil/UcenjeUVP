namespace Izpit_2024_03_23
{
    internal class Naloga2
    {
        /// <summary>
        /// NALOGA 2:
        /// 
        /// Pripravite razreda Prostor in Zgradba.
        /// Prostor naj ima kot lastnosti površino in ime prostora, Zgradba pa
        /// naj ima za lastnost seznam prostorov.                   [3 točke]
        /// 
        /// Pripravite razreda StanovanjskiBlok in Hisa,
        /// ki naj dedujeta iz razreda Zgradba.
        /// Vsakemu od teh dveh razredov določite še po eno specifično lastnost.
        ///                                                         [5 točk]
        /// 
        /// V razredu Zgradba povozite metodo ToString, da bo vračala zapis
        /// vseh prostorov v zgradbi skupaj z njihovo površino.
        /// Metodo ToString dopolnite v obeh podrazredih, da bo ustrezno 
        /// izpisovala tudi njuni posebni lastnosti.                [5 točk]
        /// 
        /// V razredu Zgradba napišite metodo ŠteviloProstorov, 
        /// ki bo vrnila število vseh prostorov,
        /// katerih površina je večja od danega parametra.          [7 točk]
        ///                                                         
        /// V metodi ResitevNaloge ustvarite tri instance razreda Hisa 
        /// in dve instanci razreda StanovanjskiBlok. 
        /// Vsaki od instanc dodajte na seznam prostorov vsaj dva prostora.
        /// Na koncu za dve od instanc izpišite število prostorov 
        /// večjih od 10 kvadratnih metrov.                         [5 točk]
        /// </summary>

        public static void ResitevNaloge()
        {
            Prostor kuhinja1 = new Prostor(20.1, "Kuhinja");
            Prostor kuhinja2 = new Prostor(10.1, "Kuhinja");
            Prostor kuhinja3 = new Prostor(22.1, "Kuhinja");
            Prostor dnevna = new Prostor(9.1, "Dnevna");
            Prostor jedilnica = new Prostor(5.1, "Jedilnica");
            Prostor spalnica = new Prostor(15, "Spalnica");
            Prostor dnevna1 = new Prostor(8, "Dnevna");
            Prostor jedilnica1 = new Prostor(9, "Jedilnica");
            Prostor spalnica1 = new Prostor(15, "Spalnica");
            Hisa hisa1 = new Hisa(true);
            hisa1.SeznamProstorov.Add(kuhinja1);
            hisa1.SeznamProstorov.Add(kuhinja2);
            Hisa hisa2 = new Hisa(false);
            hisa2.SeznamProstorov.Add(jedilnica1);
            hisa2.SeznamProstorov.Add(spalnica1);
            Hisa hisa3 = new Hisa(true);
            hisa3.SeznamProstorov.Add(dnevna);
            hisa3.SeznamProstorov.Add(jedilnica);
            StanovanjskiBlok blok1 = new StanovanjskiBlok(10);
            blok1.SeznamProstorov.Add(dnevna1);
            blok1.SeznamProstorov.Add(jedilnica1);
            StanovanjskiBlok blok2 = new StanovanjskiBlok(20);
            blok2.SeznamProstorov.Add(spalnica);
            blok2.SeznamProstorov.Add(kuhinja1);

            Console.WriteLine("Hiša 1, število prostorov večjih od 10 kvadratnih metrov: " + hisa1.SteviloProstorov(10).ToString());
            Console.WriteLine("Blok 1, število prostorov večjih od 10 kvadratnih metrov: " + blok1.SteviloProstorov(10).ToString());

        }
    }

    public class Prostor
    {
        public Prostor(double povrsina, string ime)
        {
            Povrsina = povrsina;
            Ime = ime;
        }
        public double Povrsina { get; set; }
        public string Ime { get; set; }

    }


    public class Zgradba
    {
        public Zgradba()
        {
            SeznamProstorov = new List<Prostor>();
        }
        public List<Prostor> SeznamProstorov { get; set; }

        public override string ToString()
        {
            string niz = "";
            foreach (var el in SeznamProstorov)
            {
                niz += "Površina prostora: " + el.Povrsina + "/n" + "Ime prostora: " + el.Ime + "/n";
            }
            return niz;
        }

        public int SteviloProstorov(double parameter)
        {
            int n = 0;
            foreach (var el in SeznamProstorov)
            {
                if (el.Povrsina > parameter) n++;
            }
            return n;
        }
    }

    public class StanovanjskiBlok : Zgradba
    {
        public StanovanjskiBlok(int stStanovanj) : base()
        {
            SteviloStanovanj = stStanovanj;
        }
        public int SteviloStanovanj { get; set; }

        public override string ToString()
        {
            /* string niz = "";
             foreach (var el in SeznamProstorov)
             {
                 niz += el + "/n";
             }
             niz += "Stevilo stanovanj: " + SteviloStanovanj + "\n";
             return niz;*/
            return "Stevilo stanovanj: " + SteviloStanovanj + "\n";
        }
    }

    public class Hisa : Zgradba
    {
        public Hisa(bool imaVrt) : base()
        {
            ImaVrt = imaVrt;
        }
        public bool ImaVrt { get; set; }
        public override string ToString()
        {
            /*string niz = "";
            foreach (var el in SeznamProstorov)
            {
                niz += el + "/n";
            }
            niz += "Ima vrt: " + ImaVrt + "\n";
            return niz;*/
            return "Ima vrt: " + ImaVrt + "\n";
        }


    }
}
