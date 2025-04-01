namespace Izpit_2024_04_20
{
    internal class Naloga3
    {
        /// <summary>
        /// NALOGA 3:
        /// Pripravite razreda Predstava in Gledalisce.
        /// 
        /// Razred Predstava naj vsebuje:
        /// -   Lastnosti Naslov, Avtor, Datum, UraPricetka (kot celo število), 
        ///     CasTrajanja (v urah, ki so lahko decimalno število).
        /// -   Natanko en konstruktor, ki nastavi samo lastnost UraPricetka.                      
        /// -   Metodo ToString, ki izpiše vse podrobnosti o predstavi.           [6 točk]
        /// 
        /// Razred Gledalisce naj vsebuje: 
        /// -   Lastnosti Naziv, Naslov, Direktor, SeznamPredstav.
        /// -   En konstruktor, ki omogoča določitev natanko dveh lastnosti, 
        ///     in en prazen konstruktor, v katerem inicializirate seznam predstav.
        /// -   Metodo ToString, ki naj izpiše vse podrobnosti o gledališču,
        ///     vključno z vsemi predstavami.                                       [8 točk]
        ///     
        /// V razredu Gledalisce napišite še metodo IzpišiPredstave, 
        /// ki v ukazno vrstico izpiše vse predstave, ki se končajo 
        /// (pozor - končajo, ne začnejo!) do dane ure.
        /// Število takih predstav pa metoda vrne.                                  [6 točk]
        /// 
        /// V metodi ResitevNaloge kreirajte instanco razreda Gledalisce, 
        /// ki naj vsebuje vsaj tri predstave. 
        /// Pokličite še metodo IzpišiPredstave.                                    [5 točk]
        /// </summary>
        /// 

        public static void ResitevNaloge()
        {
            Gledalisce gledalisce = new Gledalisce();
            Predstava predstava1 = new Predstava(19);
            predstava1.Avtor = "avtor 1";
            predstava1.Naslov = "naslov 1";
            predstava1.Datum = DateTime.Now;
            predstava1.CasTrajanja = 2.5;
            Predstava predstava2 = new Predstava(15);
            predstava2.Avtor = "avtor 2";
            predstava2.Naslov = "naslov 2";
            predstava2.Datum = DateTime.Now;
            predstava2.CasTrajanja = 1.0;
            Predstava predstava3 = new Predstava(13);
            predstava3.Avtor = "avtor 3";
            predstava3.Naslov = "naslov 3";
            predstava3.Datum = DateTime.Now;
            predstava3.CasTrajanja = 2.0;

            gledalisce.SeznamPredstav.Add(predstava1);
            gledalisce.SeznamPredstav.Add(predstava2);
            gledalisce.SeznamPredstav.Add(predstava3);

            Console.WriteLine(gledalisce.IzpisiPredstave(16.00));

        }


        public class Predstava
        {

            public Predstava(int uraPricetka)
            {
                UraPricetka = uraPricetka;
            }

            public string Naslov;
            public string Avtor;
            public DateTime Datum;
            public int UraPricetka { get; set; }
            public double CasTrajanja;

            public override string ToString()
            {
                return $"Naslov: {Naslov}\nAvtor: {Avtor}\nDatum: {Datum}\nUraPricetka: {UraPricetka}\nCasTrajanja: {CasTrajanja}\n";
            }
        }

        public class Gledalisce
        {
            public Gledalisce()
            {
                SeznamPredstav = new List<Predstava>();
            }
            public Gledalisce(string naziv, string naslov)
            {
                Naziv = naziv;
                Naslov = naslov;
            }
            public string Naslov;
            public string Naziv;
            public string Direktor;
            public List<Predstava> SeznamPredstav;

            public override string ToString()
            {
                string niz = $"Naslov: {Naslov}\nNaziv: {Naziv}\nDirektor: {Direktor}\n";
                foreach (var el in SeznamPredstav)
                {

                    niz += el.ToString();
                }
                return niz;
            }

            public int IzpisiPredstave(double konec)
            {
                int stevec = 0;
                foreach (var el in SeznamPredstav)
                {
                    if (Convert.ToDouble(el.UraPricetka) + el.CasTrajanja <= konec)
                    {
                        Console.WriteLine(el.ToString());
                        stevec++;
                    }
                }

                return stevec;
            }
        }
    }
}
