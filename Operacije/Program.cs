namespace Operacije
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //PREDAVANJA
            //Naloga1();
            //Naloga2();
            //Naloga3();
            //Naloga4();
            //Naloga5();
            //Naloga6();
            //Naloga7();
            //Naloga8();
            //Naloga9();
            //Naloga10();
            //Naloga11();
            //Naloga12();
            //Naloga13();
            Console.ReadLine();
        }

        public static void Naloga1()
        {
            /* Naloga 3.1.2.1. Definirajte dve celostevilski spremenljivki slo in hr. Spremenljivka slo naj kot vrednost dobi (priblizno) stevilo prebivalcev Slovenije, spremenljivka hr pa (priblizno) vrednost prebivalcev Hrvaske. Na zaslon izpisite njun produkt in rezultat preverite se s kalkulatorjem. Ali je vas rezultat pravilen in zakaj ne? */


            int slo = 2000000;
            int hr = 3800000;
            int produkt = slo * hr;
            Console.WriteLine("produkt:" + produkt);
            //rezultat ni pravilen verjetno ker je velika številka
        }
        public static void Naloga2()
        {
            /* Naloga 3.1.2.2. V ukazno vrstico izpisite visine vseh druzinskih clanov in vsoto le-teh,
                pri cemer ne smete definirati nobene spremenljivke. */


            Console.WriteLine(2.00 + 1.65);

        }
        public static void Naloga3()
        {
            /* Naloga 3.1.2.3. Za vsakega druzinskega clana deklarirajte spremenljivko, ki shranjuje
                njegovo starost, nato na zaslon izpisite povprecno starost vase druzine na vsaj dve decimalki. */


            int starost1 = 61;
            int starost2 = 61;
            int starost3 = 36;
            int starost4 = 32;
            double povprecje = (double)(starost1 + starost2 + starost3 + starost4) / 4;
            Console.WriteLine("povprečna starost:" + povprecje);
        }
        public static void Naloga4()
        {
            /* Naloga 3.1.2.4. Indeks telesne mase je vrednost definirana kot nasa teza v kilogramih deljena s kvadratom nase visine v metrih. Definirajte spremenljivke ustreznih tipov,
                izracunajte indeks telesne mase in ga izpisite na zaslon. */


            double teza = 60;
            double visina = 1.65F;
            double index = teza / (visina * visina);

            Console.WriteLine("index telsene teze: " + index);
        }
        public static void Naloga5()
        {
            /* Naloga 3.1.2.5. Na zaslon izpisite dolzino poti v kilometrih, ki jo v enem prestopnem
               letu opravi vesoljska ladja, ce brez prestanka leti s hitrostjo 241 km/s. */


            long cas = 366 * 24 * 60 * 60;
            long pot = cas * 241;
            Console.WriteLine($"Vesoljska ladja naredi {pot} km dolgo pot.");
        }
        public static void Naloga6()
        {  /* Naloga 3.1.2.6. Izberite si trimestno stevilo in ga shranite v spremenljivko. Nato na zaslon izpisite izbrano stevilo s stevkami zapisanimi v obratnem vrstnem redu. */


            int stevilo = 123;
            int zadnjaStevka = stevilo % 10;
            int srednjaStevka = (stevilo / 10) % 10;
            int prvaStevka = stevilo / 100;

            Console.WriteLine($"Stevilka prav obrnjena: {stevilo} in narobe obrnjena: {zadnjaStevka}{srednjaStevka}{prvaStevka}");

        }
        public static void Naloga7()
        {  /* Naloga 3.1.2.7. S pomocjo knjiznice Math in njene spremenljivke za vrednost konstante
            π, izracunajte povrsino in volumen krogle s polmerom 4,5 cm in ju izpisite. */


            double polmer = 4.5;
            double povrsinaKrogle = 4 * Math.PI * polmer * polmer;
            double volumenKrogle = 4 * Math.PI * polmer * polmer * polmer / 3;

            double zaokrozenaPovrsina = Math.Round(povrsinaKrogle, 3);
            double zaokrozenVolumen = Math.Round(volumenKrogle, 3);

            Console.WriteLine($"Povrsina krogle je {zaokrozenaPovrsina}, volumen krogle pa je {zaokrozenVolumen}");

        }
        public static void Naloga8()
        {
            /* Naloga 3.1.2.8. Da dobimo najmanjso in najvecjo vrednost, ki jo lahko spremenljivka
            tipa short shrani, lahko uporabimo ukaz short.MinValue oziroma short.MaxValue. Na
            zaslon izpisite ti dve vrednosti skupaj z besedilom kaj predstavljata. Enako naredite tudi
            za ushort, int, uint, long in ulong, da vidite kaksne vrednosti lahko sprejmejo. */


            Console.WriteLine($"short min: {short.MinValue} \n short max: {short.MaxValue} \n ushort min: {ushort.MinValue} \n ushort max: {ushort.MaxValue} \n int min: {int.MinValue} \n int max: {int.MaxValue} \n uint min: {uint.MinValue} \n uint max: {uint.MaxValue} \n long min: {long.MinValue} \n long max: {long.MaxValue} \n ulong min: {ulong.MinValue} \n ulong max: {ulong.MaxValue} \n");

        }
        public static void Naloga9()
        { /* Naloga 3.1.2.9. Deklarirajte decimalno stevilo z vsaj petimi decimalkami, med katerimi
            naj bo vsaj ena manjsa od 5 in vsaj ena vecja ali enaka 5. Nato preizkusite zaokrozevanje na
            nekaj decimalnih mest. To lahko storite z uporabo ukaza Math.Round(vrednost, stevilo
            decimalk). */


            double doubleStevilka = 1.2354726;
            Console.WriteLine($"Zaokroženo na 6 decimalk: {Math.Round(doubleStevilka, 6)} \n Zaokroženo na 5 decimalk: {Math.Round(doubleStevilka, 5)} \n Zaokroženo na 4 decimalke: {Math.Round(doubleStevilka, 4)} \n Zaokroženo na 3 decimalke: {Math.Round(doubleStevilka, 3)} \n Zaokroženo na 2 decimalki: {Math.Round(doubleStevilka, 2)} \n Zaokroženo na 1 decimalko: {Math.Round(doubleStevilka, 1)} \n");
        }
        public static void Naloga10()
        {
            /* Naloga 3.3.1.1. Deklarirajte stiri celostevilske spremenljivke a, b, c in d, ter jim dolocite
            poljubno vrednost. Nato na zaslon izpisite rezultate naslednjih logicnih izrazov.
            a) a manjse ali enako b
            b) c razlicno od d
            c) a + d vecje od c in b manjse od c
            d) b vecje ali enako d ali c manjse od a */


            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            Console.WriteLine($"a:{a}, b:{b}, c:{c}, d:{d}");
            Console.WriteLine($"a manjse ali enako b: {a <= b}");
            Console.WriteLine($"c razlicno od d: {c != d}");
            Console.WriteLine($"a + d vecje od c in b manjse od c: {a + d > c && b < c}");
            Console.WriteLine($"b vecje ali enako d ali c manjse od a: {b >= d || c < a}");
        }

        public static void Naloga11()
        {

            /* Naloga 3.3.1.2. Preizkusite primerjavo razlicnih znakov po velikosti. Preizkusite tako
            velike in male crke, kot tudi kaksne izmed drugih znakov. Kaj mislite, kako je doloceno
            kateri znak je vecji in kateri manjsi? */


            char prviA = 'a';
            char drugiA = 'A';

            Console.WriteLine(prviA < drugiA);

        }
        public static void Naloga12()
        {
            /* Naloga 3.3.1.3. Definirajte spremenljivki, v katero boste zapisali trenutno temperaturo
            v predavalnici in trenutno temperaturo zunaj. S pomocjo primerjav dolocite vrednost
            spremenljivki normalno, ki bo imela vrednost true, ce je zunaj kvecjemu 7 stopinj celzija,
            notri pa vsaj 21. */

            Console.Write("Kakšna je temperatura zunaj?");
            int temperaturaZunaj = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kakšna je temperatura notri?");
            int temperaturaNotri = Convert.ToInt32(Console.ReadLine());

            bool normalno;

            if (temperaturaZunaj <= 7 && temperaturaNotri >= 21)
            {
                normalno = true;
            }
            else
            {
                normalno = false;
            }

            Console.WriteLine($"Vrednost spremenljivke normalno je: {normalno}");

        }
        public static void Naloga13()
        {

            /* Naloga 3.3.1.4. Definirajte spremenljivko, v katero boste zapisali svojo visino, in spremenljivko spol, ki bo imela vrednost true, ce ste zenska, in false, ce ste moski. S pomocjo
            primerjav dolocite vrednost spremenljivki nadpovprecna, ki bo imela vrednost true, ce je
            vasa visina vsaj 180 cm, ce ste moski, in vsaj 170 cm, ce ste zenska. */

            Console.Write("Kakšna je vaša višina?");
            int visina = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Kakšen je vaš spol?");
            string spolString = Console.ReadLine();
            bool spol;
            bool nadpovprecna;

            if (spolString == "ženska") spol = false;
            else spol = true;

            if (!spol && visina >= 170) nadpovprecna = true;
            else if (spol && visina >= 180) nadpovprecna = true;
            else nadpovprecna = false;

            Console.WriteLine($"Vrednost spremenljivke nadpovprečna je: {nadpovprecna}");

        }
    }
}
