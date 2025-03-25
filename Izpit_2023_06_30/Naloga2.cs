namespace Izpit_2023_06_30
{
    internal class Naloga2
    {
        /// <summary>
        /// NALOGA 2:
        /// V tej datoteki sta definirana razreda Kuhinja in KuhinjskiElement.
        /// Kuhinja predstavlja kuhinjo v stanovanju,
        /// ki ima kot lastnost elemente (omarice, hladilnik, pečico...)
        /// in površino, ki jo ima na voljo.
        /// 
        /// Za razred KuhinjskiElement naredite podrazred Hladilnik, 
        /// ki bo imel dodatno lastnost EnergijskiRazred,
        /// in še en podrazred po lastni izbiri.        da                             [3 točke]
        /// 
        /// V razredih KuhinjskiElement in Hladilnik povozite metodo ToString, 
        /// da bo ustrezno vračala vse lastnosti instanc.      da                     [5 točk]
        /// 
        /// Metodo ToString povozite tudi v razredu Kuhinja,
        /// vrne naj niz s površino in opisom vseh elementov kuhinje. da               [5 točk]
        /// 
        /// V razredu Kuhinja napišite še metodo, ki bo izpisala skupno površino elementov.
        /// Metoda vrača površino, ki je v kuhinji še na voljo za nove elemente. da   [7 točk]
        ///                                                         
        /// Pripravite instanco razreda Kuhinja,
        /// ki bo imela na seznamu vsaj štiri elemente 
        /// od tega natanko element tipa Hladilnik in eno instanco razreda, 
        /// ki ste ga definirali sami.
        /// Na koncu instanco kuhinje tudi izpišite.                                [5 točk]
        /// </summary>
        public static void ResitevNaloge()
        {
            /// Pripravite instanco razreda Kuhinja,
            /// ki bo imela na seznamu vsaj štiri elemente 
            /// od tega natanko element tipa Hladilnik in eno instanco razreda, 
            /// ki ste ga definirali sami.
            /// Na koncu instanco kuhinje tudi izpišite. 
            /// 

            Pecica pecica = new Pecica("Pečica", 750.5, 1.75, "Indukcijska");
            Hladilnik hladilnik = new Hladilnik("Hladilnik", 1213.16, 1.02, "A+");
            KuhinjskiElement lijak = new KuhinjskiElement("Lijak", 657.19, 1.7);
            KuhinjskiElement pult = new KuhinjskiElement("Pult", 475.2, 3.75);
            List<KuhinjskiElement> seznamElementov = new List<KuhinjskiElement>() { pecica, hladilnik, lijak, pult };

            Kuhinja kuhinja = new Kuhinja(20.22);
            kuhinja.KuhinjskiElementi.AddRange(seznamElementov);

            Console.WriteLine(kuhinja.ToString());

        }


        public class Kuhinja
        {
            public Kuhinja(double povrsina)
            {
                Povrsina = povrsina;
                KuhinjskiElementi = new List<KuhinjskiElement>();
            }

            public double Povrsina { get; set; }

            public List<KuhinjskiElement> KuhinjskiElementi { get; set; }

            public override string ToString()
            {
                string niz = "";
                niz += "Površina Kuhinje: " + Povrsina.ToString() + "\n";

                foreach (var el in KuhinjskiElementi)
                {
                    niz += $"{el.ToString()}\n";
                }
                return niz;
            }
            public double PreostalaPovrsina()
            {
                double vsaPovrsina = Povrsina;
                double povrsinaElementov = 0;
                foreach (var el in KuhinjskiElementi)
                {
                    povrsinaElementov += el.Povrsina;
                }
                Console.WriteLine("Skupna površina elementov v kuhinji: " + povrsinaElementov);
                return vsaPovrsina - povrsinaElementov;
            }
        }


        public class KuhinjskiElement
        {
            public KuhinjskiElement(string naziv, double cena, double povrsina)
            {
                Naziv = naziv;
                Cena = cena;
                Povrsina = povrsina;
            }

            public string Naziv { get; set; }
            public double Cena { get; set; }
            public double Povrsina { get; set; }

            public override string ToString()
            {
                return $"Naziv elementa: {Naziv}\nCena elementa: {Cena}\nPovršina elementa: {Povrsina}\n";
            }
        }

        public class Hladilnik : KuhinjskiElement
        {
            public Hladilnik(string naziv, double cena, double povrsina, string energijskiRazred) : base(naziv, cena, povrsina)
            {
                EnergijskiRazred = energijskiRazred;
            }
            public string EnergijskiRazred { get; set; }
            public override string ToString()
            {
                return $"Naziv elementa: {Naziv}\nCena elementa: {Cena}\nPovršina elementa: {Povrsina}\nEnergijski razred: {EnergijskiRazred}\n";
            }
        }

        public class Pecica : KuhinjskiElement
        {
            public Pecica(string naziv, double cena, double povrsina, string vrsta) : base(naziv, cena, povrsina)
            {
                Vrsta = vrsta;
            }
            public string Vrsta;
            public override string ToString()
            {
                return $"Naziv elementa: {Naziv}\nCena elementa: {Cena}\nPovršina elementa: {Povrsina}\nVrsta: {Vrsta}\n";
            }
        }
    }
}