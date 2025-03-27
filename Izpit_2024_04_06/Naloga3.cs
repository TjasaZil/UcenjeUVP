namespace Izpit_2024_04_06
{
    internal class Naloga3
    {
        /// <summary>
        /// NALOGA 3:
        /// Pripravite razrede Kviz, Vprasanje in Odgovor.
        /// 
        /// Razred Odgovor naj vsebuje:
        /// -   Lastnosti Besedilo in Oznaka (oznaka je črka, ki označuje odgovor, 
        ///     ko imamo na vprašanja na voljo nekaj odgovorov).
        /// -   Konstruktor, ki omogoča določitev obeh lastnosti.                   [3 točke]
        /// 
        /// Razred Vprasanje naj vsebuje:
        /// -   Lastnosti Besedilo (tu bo besedilo vprašanja), 
        ///     MozniOdgovori (to bo seznam možnih odgovorov) in SteviloTock.
        /// -   Natanko en konstruktor, ki nastavi vsaj dve lastnosti.                      
        /// -   Povozite metodo ToString, ki izpiše vprašanje skupaj z možnimi odgovori 
        ///     in številom točk za pravilen odgovor.               
        /// -   Napišite objektno metodo PodajVprasanje, ki izpiše vprašanje 
        ///     in od uporabnika pričakuje odgovor - črko oznake odgovora - 
        ///     ter to črko vrne.                                                   [12 točk]
        /// 
        /// Razred Kviz naj vsebuje: 
        /// -   Lastnosti Naziv, Datum, 
        ///     CasResevanja (tej lastnosti lahko vrednost nastavimo samo v konstruktorju!),
        ///     Vprasanja (seznam vprasanj).
        /// -   En konstruktor, ki omogoča določitev natanko ene lastnosti, 
        ///     in en prazen konstruktor, v katerem določimo čas reševanja.
        /// -   Povozite metodo ToString, ki naj izpiše kviz z vsemi vprašanji.     [5 točk]
        /// 
        /// V metodi ResitevNaloge kreirajte instanco razreda Kviz, 
        /// ki naj vsebuje vsaj pet vprašanj, vsako vprašanje pa naj ima 
        /// vsaj dva možna odgovora. 
        /// Za vsa vprašanja na kvizu pokličite metodo PodajVprasanje.              [5 točk]
        /// </summary>
        /// 
        public static void ResitevNaloge()
        {
            Kviz kviz = new Kviz("Kviz1");
            //pet vprasanji vsak z dvema moznima odgovoroma
            Odgovor da = new Odgovor("da", 'A');
            Odgovor ne = new Odgovor("ne", 'B');
            Odgovor mogoce = new Odgovor("mogoče", 'C');
            Odgovor neVem = new Odgovor("ne vem", 'D');
            List<Odgovor> seznamOdgovorov = new List<Odgovor>() { da, ne, mogoce, neVem };
            Vprasanje vprasanje1 = new Vprasanje("Ali znate odgovor na to vprašanje?", 20);
            vprasanje1.MozniOdgovori.AddRange(seznamOdgovorov);
            Vprasanje vprasanje2 = new Vprasanje("Mogoče znate odgovor na to vprašanje?", 20);
            vprasanje2.MozniOdgovori.AddRange(seznamOdgovorov);
            Vprasanje vprasanje3 = new Vprasanje("Kaj pa to vprašanje?", 20);
            vprasanje3.MozniOdgovori.AddRange(seznamOdgovorov);
            Vprasanje vprasanje4 = new Vprasanje("Gotovo znate odgovor na to vprašanje?", 20);
            vprasanje4.MozniOdgovori.AddRange(seznamOdgovorov);
            Vprasanje vprasanje5 = new Vprasanje("Verjetno znate odgovor na to vprašanje?", 20);
            vprasanje5.MozniOdgovori.AddRange(seznamOdgovorov);

            List<Vprasanje> seznamVprasanj = new List<Vprasanje>() { vprasanje1, vprasanje2, vprasanje3, vprasanje4, vprasanje5 };
            kviz.Vprasanja.AddRange(seznamVprasanj);
            kviz.Datum = DateTime.Now;

            foreach (var el in kviz.Vprasanja) Console.WriteLine(el.ToString() + "\n");

        }
    }

    public class Odgovor
    {
        public Odgovor(string besedilo, char oznaka)
        {
            Besedilo = besedilo;
            Oznaka = oznaka;
        }
        public string Besedilo { get; set; }
        public char Oznaka { get; set; }
    }

    public class Vprasanje
    {
        public Vprasanje(string besedilo, int steviloTock)
        {
            Besedilo = besedilo;
            SteviloTock = steviloTock;
            MozniOdgovori = new List<Odgovor>();
        }
        public string Besedilo { get; set; }
        public List<Odgovor> MozniOdgovori { get; set; }
        public int SteviloTock { get; set; }

        public override string ToString()
        {
            string niz = "";
            niz += Besedilo + "\n";
            foreach (var odgovor in MozniOdgovori)
            {
                niz += odgovor.Oznaka + "-" + odgovor.Besedilo + "\n";
            }
            niz += $"Stevilo moznih tock: {SteviloTock}";
            return niz;
        }

        public char PodajOdgovor()
        {
            char odgovor = ' ';
            ToString();
            Console.Write("Napišite črko pri pravilnem odgovoru: ");
            odgovor = char.Parse(Console.ReadLine());

            return odgovor;
        }
    }

    public class Kviz
    {
        public Kviz()
        {
            CasResevanja = 90;
        }
        public Kviz(string naziv)
        {
            Naziv = naziv;
            Vprasanja = new List<Vprasanje>();
        }
        public string Naziv { get; set; }
        public DateTime Datum;
        public static int CasResevanja { get; set; }
        public List<Vprasanje> Vprasanja { get; set; }

        public override string ToString()
        {
            string niz = "";
            niz += "Naziv: " + Naziv + "\n";
            niz += "Datum: " + Datum + "\n";
            niz += "Cas Resevanja: " + CasResevanja + " min" + "\n";
            foreach (var vprasanje in Vprasanja)
            {
                niz += vprasanje.ToString();
            }
            return niz;
        }

        public char PodajOdgovor()
        {
            char odgovor = ' ';
            ToString();
            Console.Write("Napišite črko pri pravilnem odgovoru: ");
            odgovor = char.Parse(Console.ReadLine());

            return odgovor;
        }
    }
}
