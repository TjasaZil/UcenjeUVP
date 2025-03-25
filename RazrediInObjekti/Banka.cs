namespace RazrediInObjekti
{
    internal class Banka
    {
        // 8.3 Banka      

    }

    /* Naloga 8.3.0.1. Ustvarite objekt Stranka s polji: ime (string), naslov (string), starost (int) in spol (char). Dodajte mu konstruktor za poljubno dolocitev vrednosti vseh polj. */
    /* Naloga 8.3.0.3. Objektu Stranka dodajte polje denarnica (double) in popravite funkcionalnosti za polog in izplacilo razreda BancniRacun, da popravite tudi stanje v denarnici stranke (najprej morate preveriti, ali je podana vrednost za polog oz. izplacilo sploh mogoca). */
    public class Stranka
    {
        public Stranka(string ime, string naslov, int starost, char spol, double denarnica)
        {
            Ime = ime;
            Naslov = naslov;
            Starost = starost;
            Spol = spol;
            Denarnica = denarnica;
        }
        public Stranka() { }
        public string Ime { get; set; }
        public string Naslov { get; set; }
        public int Starost { get; set; }
        public char Spol { get; set; }
        public double Denarnica { get; set; }
    }

    /* Naloga 8.3.0.2. Ustvarite objekt BancniRacun s polji: stevilka bancnega racuna (int),stranka (Stranka), stanje na racunu (double), seznam transakcij (List<double>) in mudodajte konstruktor, ki nastavi zacetno vrednost za stevilko racuna in stranko. Dodajte mu se funkcionalnosti za polog in izplacilo, ki naj se dodajo v seznam transakcij, ter za
          prikaz financnega stanja stranke na racunu. Vsebuje naj tudi izpis vseh transakcij na racunu. */

    public class BancniRacun
    {
        public BancniRacun(int stevilkaRacuna, Stranka stranka)
        {
            StevilkaRacuna = stevilkaRacuna;
            Stranka = stranka;
            SeznamTransakcij = new List<double>();
        }
        public int StevilkaRacuna { get; set; }
        public Stranka Stranka { get; set; }
        public double StanjeRacuna { get; set; }
        public List<double> SeznamTransakcij { get; set; }

        public void Polog()
        {
            Console.Write("Koliko želite položiti na račun?: ");
            double polog = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            if (Stranka.Denarnica > polog)
            {
                SeznamTransakcij.Add(polog);
                StanjeRacuna += polog;
            }
            else Console.WriteLine("Polog ni mogoč ker je v denarnici premalo denarja.");
        }
        public void Izplacilo()
        {
            Console.Write("Koliko želite vzeti iz računa?: ");
            double izplacilo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            SeznamTransakcij.Add(-izplacilo);
            StanjeRacuna -= izplacilo;
            Stranka.Denarnica += izplacilo;
        }
        public void StanjeNaRacunu()
        {
            Console.WriteLine($"Trenutno stanje na računu: {StanjeRacuna}");
            Console.WriteLine();

            foreach (var el in SeznamTransakcij)
            {
                if (el > 0) Console.ForegroundColor = ConsoleColor.Green;
                else Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(el);
            }
        }


    }



    /* Naloga 8.3.0.4. Ustvarite objekt Banka, ki shranjuje seznam strank in bancnih racunov. Vsebovati mora tudi funkcionalnost za izpis stevilke racuna in stanja za vse bancne racune glede na ime stranke. Ob tem naj vsebuje tudi funkcionalnosti za ustvariti racun stranke, ter za izbris racuna stranke po stevilki racuna. V kolikor stranka nima vec nobenega racuna na banki, naj se izbrise iz seznama strank. */

    public class Bank
    {
        public Bank()
        {
            SeznamStrank = new List<Stranka>();
            SeznamRacunov = new List<BancniRacun>();

        }
        public List<Stranka> SeznamStrank { get; set; }
        public List<BancniRacun> SeznamRacunov { get; set; }

        public void UstvaritevRacuna(int stRacuna, Stranka stranka)
        {
            BancniRacun novRacun = new BancniRacun(stRacuna, stranka);
            SeznamRacunov.Add(novRacun);
        }
        public void IzbrisRacuna(int stRacuna)
        {
            bool imaRacun = false;
            Stranka stranka = new Stranka();

            foreach (var el in SeznamRacunov)
            {
                if (el.StevilkaRacuna == stRacuna)
                {
                    stranka = el.Stranka;
                    SeznamRacunov.Remove(el);

                }

            }
            foreach (var str in SeznamRacunov)
            {
                if (stranka == str.Stranka)
                {
                    imaRacun = true;
                    break;
                }
            }
            if (!imaRacun)
            {
                Console.WriteLine($"Stranka {stranka} nima na banki odprtega nobenega računa, zato jo bomo izbrisali");
                SeznamStrank.Remove(stranka);
            }


        }
    }

    /* Naloga 8.3.0.5. Ustvarite razred UporabniskiVmesnik za upravljanje banke. Uporabnik naj ima na voljo kreiranje novega bancnega racuna, brisanje obstojecega bancnega racuna in vpogled v stanje svojih bancnih racunov. Ob tem naj ima moznost tudi upravljanja z dolocenim bancnim racunom, kjer lahko opravi polog, izplacilo ali pa izpis transakcij na
        bancnem racunu. */


    /* Naloga 8.3.0.6. Programu za upravljanje z banko dodajte moznost za shranjevanje podatkov v datoteko in branje iz nje tako, da boste lahko vsakic, ko ponovno pozenete program ponovno upravljali z enakim stanjem, kot ste program zakljucili. */

    /* Naloga 8.3.0.7 (Dodatno). V program za upravljanje banke v celoti vkljucite moznost za nakazilo sredstev na poljuben obstojeci bancni racun glede na stevilo racuna. */
}
