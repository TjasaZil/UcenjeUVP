namespace Izpit_1_2023_04_08
{
    internal class Naloga2
    {
        /// <summary>
        /// NALOGA 2:
        /// V tej datoteki sta definirana razreda Menu in Jed.
        /// Menu predstavlja dnevni menu v restavraciji (glede na dan),
        /// ki ima kot lastnost tudi seznam jedi.
        /// Posamezna jed ima lastnosti naziv in cena.
        
        /// Za razred Jed naredite podrazred Sladica, 
        /// ki bo imel dodatno lastnost Kalorije.                   [3 točke]
         
        /// V razredih Jed in Sladica povozite metodo ToString, 
        /// da bo ustrezno vračala vse lastnosti instanc.           [5 točk]
         
        /// Metodo ToString povozite tudi v razredu Menu,
        /// vrne naj niz z dnevom in vsemi jedmi, ki so na menuju, 
        /// med seboj pa naj bodo ločene s prazno vrstico.          [5 točk]
          
        /// V razredu Menu napišite še metodo, ki bo izpisala skupno ceno menuja.
        /// Metoda naj ima vhodni parameter tipa bool, ki bo določal, 
        /// ali želite ob ceni plačati še 10% napitnine ali ne.
        /// Če je vrednost parametra true, naj se skupna cena primerno izračuna. 
                                                                 
        /// Za vsaj dva dni v tednu pripravite instanci razreda Menu,
        /// ki bosta imeli na seznamu jedi vsaj po tri jedi, 
        /// od tega vsak natanko eno jed tipa Sladica. 
        /// Na koncu oba menuja tudi izpišite                       [5 točk]
        /// </summary>
        
        /// Za vsaj dva dni v tednu pripravite instanci razreda Menu,
        /// ki bosta imeli na seznamu jedi vsaj po tri jedi, 
        /// od tega vsak natanko eno jed tipa Sladica. 
        /// Na koncu oba menuja tudi izpišite   

        public static void ResitevNaloge()
        {
            Sladica Tiramisu = new Sladica(250, "Tiramisu", 5.3);
            Sladica SacherTorta = new Sladica(450, "Sacher Torta", 9.3);
            Jed Pizza = new Jed("Pizza", 13.9);
            Jed Lazanja = new Jed("Lazanja", 10.5);
            Jed Solata = new Jed("Cezarjeva Solata", 13.5);
            Jed SolataM = new Jed("Mešana Solata", 11.5);
            List<Jed> ponedeljkoveJedi = new List<Jed>() { Tiramisu, Pizza, Solata };
            List<Jed> torkoveJedi = new List<Jed>() { SacherTorta, Lazanja, SolataM };
            Menu ponedeljek = new Menu("Ponedeljek");
            Menu torek = new Menu("Torek");

            ponedeljek.Jedi.AddRange(ponedeljkoveJedi);
            torek.Jedi.AddRange(torkoveJedi);
            Console.WriteLine(ponedeljek.ToString());
            Console.WriteLine(torek.ToString());
        }

    }


    public class Menu
    {
        public Menu(string dan)
        {
            Dan = dan;
            Jedi = new List<Jed>();
        }

        public string Dan { get; set; }

        public List<Jed> Jedi { get; set; }

        public override string ToString()
        {
            string niz = "";
            niz += $"Dan: {Dan}\n";

            foreach (var jed in Jedi)
            {
                niz += $"{jed.ToString()}\n\n";
            }
            return niz;
        }


        public double CenaMenija(bool napitnina)
        {
            double cena = 0;
            foreach (var jed in Jedi)
            {
                cena += jed.Cena;
            }
            if (napitnina) return cena * 1.1;
            else return cena;
        }

    }

    public class Jed
    {
        public Jed(string naziv, double cena)
        {
            Naziv = naziv;
            Cena = cena;
        }

        public string Naziv { get; set; }
        public double Cena { get; set; }

        public override string ToString()
        {
            return $"Lastnosti:\n Naziv: {Naziv}\n Cena: {Cena}";
        }
    }

    public class Sladica : Jed
    {
        public Sladica(double kalorije, string naziv, double cena) : base(naziv, cena)
        {
            Kalorije = kalorije;
        }
        public double Kalorije { get; set; }

        public override string ToString()
        {
            return $"Lastnosti:\n Naziv: {Naziv}\n Cena: {Cena}\n Kalorije: {Kalorije}";
        }
    }
}
