namespace RazrediInObjekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PREDAVANJA 
            //Naloga1();
            //Naloga2();
            //Naloga3();
            //Naloga4();
            //Naloga5();
            Naloga6();
            //Naloga7();
            //Naloga8();
            //Naloga9();

            // VAJE

            //knjiga
            //Avtor avtor = new Avtor("Maja", "Tomic", "Zenski", 29, "maja.tomic@gmail.com");
            //Console.WriteLine(avtor.izpisAvtorja());
            //Knjig knjig = new Knjig("Maja", "Tomic", "Zenski", 29, "maja.tomic@gmail.com", "Knjiga dolga 500 strani", "Mladinska knjiga", 500);
            //knjig.izpisPodatkov();

            //naselje

            //banka
            Console.ReadKey();
        }

        public static void Naloga1()
        {

            /* Naloga 8.1.1.1. Razmislite, katere lastnosti bi pripisali rozi in katere bi ji pripisali v konstruktorjih. Definirajte razred Flower, dodajte mu vsaj tri spremenljivke, ki bodo hranile neke podatke o vsaki instanci, in definirajte vsaj dva konstruktorja.*/
            //definirana spodaj

            Flower roza1 = new Flower("Rose", "pink", true, 1, 0.75);
            Flower tulip = new Flower("Tulip", "Yellow", false, 1, 0.5);
            Flower kaktus = new Flower("Kaktus", "", false, 0, 0.25);

        }
        public static void Naloga2()
        {
            /* Naloga 8.2.1.1. Razredu Dress iz razdelka dolocite se dve lastnosti: cena z DDV in cena brez DDV, kjer v konstruktorju kot parameter dobite samo ceno brez DDV. Ceno z DDV izracunate z upostevanjem, da je DDV na obleke 22%.*/

            Dress rdecaObleka = new Dress(100);
            Console.WriteLine($"cena rdece obleke z DDV je {rdecaObleka.WithDDV}");

        }
        public static void Naloga3()
        {
            /* Naloga 8.2.1.2. Napisite razred Drink, ki opisuje napitek, ki ga lahko narocite v lokalni  kavarni. Dolocite mu vsaj dva konstruktorja in vsaj stiri lastnosti, pri cemer sta lahko najvec dve samodejno implementirani.*/

            Drink brezkofeinskaBelaKava = new Drink(true, true, "sweet", false, "brown", true, true);
            Drink kapucino;
            Drink podaljsanaKava = new Drink();
            Drink Kakav;
            Drink sadniCaj;
            Drink zeleniCaj;
        }
        public static void Naloga4()
        {
            /* Naloga 8.3.1.1. Napisite razred Figura, ki predstavlja sahovsko figuro. Razmislite, katere lastnosti bi figura morala imeti, in jih implementirajte. Podobno implementirajte tudi vsaj eno metodo zanjo.*/
            //ime, barva, material

            Figura konj = new Figura("konj", "bela", "les");
            Console.WriteLine(konj.lastnostiFigure());
        }
        public static void Naloga5()
        {
            /* Naloga 8.3.1.2. Definirajte razred Glagol, ki bo kot vrednost prejel nek glagol, njegove dodatne lastnosti pa bodo Oseba, Stevilo, Cas. Napisite tudi objektno metodo, ki bo vrnila seznam vseh oblik glagola za vse osebe v ednini (vsaj za nekatere korene glagolov).*/

            Glagol okno = new Glagol("okno", "prva", "ednina", "imenovalnik", "srednji");
            Glagol slon = new Glagol("slon", "prva", "ednina", "imenovalnik", "moski");
            Glagol zena = new Glagol("zena", "prva", "ednina", "imenovalnik", "zenski");

            Console.WriteLine(string.Join(", ", okno.glagolVEdnini()));
            Console.WriteLine(string.Join(", ", slon.glagolVEdnini()));
            Console.WriteLine(string.Join(", ", zena.glagolVEdnini()));
        }
        public static void Naloga6()
        {
            /* Naloga 8.3.1.3. Napisite razred NakupovalnaKosarica, ki predstavlja nakupovalno kosarico. Pripravite se razred Artikel, ki predstavlja artikel, ki ga dodamo v nakupovalno kosarico, zanj pa naredite se nekaj podrazredov. Razredu Artikel dodajte lastnost Koda in Cena, ki ju dolocite v konstruktorju, vsakemu od podrazredov pa nekaj primernih dodatnih lastnosti. Za razred NakupovalnaKosarica povozite se metodo ToString, ki izpise vse artikle v kosarici.*/
        }
        public static void Naloga7()
        {
            /* Naloga 8.3.1.4. Se enkrat razmislite, kaksna je razlika med staticnimi in objektnimi metodami. Definirajte razred, ki bo definiral vsaj tri lastnosti za vsako instanco razreda, vsaj dve objektni metodi in eno staticno.*/
        }
        public static void Naloga8()
        {
            /* Naloga 8.3.1.5. Pripravite razreda Igralec in NogometniKlub. Razred Igralec naj vsebuje: Lastnosti Ime, CenaIgralca, Polozaj (napadalec, vezni, vratar,...), Starost (tej lastnosti lahko vrednost nastavimo samo v konstruktorju!). En konstruktor, ki omogoca dolocitev natanko dveh lastnosti, in en konstruktor, ki omogoca dolocitev vsaj treh lastnosti. Povozite metodo ToString, ki naj izpise vse podatke o igralcu. Razred NogometniKlub naj vsebuje: Lastnosti SeznamIgralcev in VisinaProracuna. Konstruktor, ki inicializira seznam igralcev in nastavi visino proracuna. Metodo, ki izpise vse igralce, ki imajo ceno visjo od danega maksimuma. V metodi Main kreirajte instanco razreda NogometniKlub, ki naj vsebuje vsaj pet igralcev in izpisite podatke o vseh igralcih, ki imajo ceno vsaj 100 000 evrov in so mlajsi od 30 let.*/

            Igralec Benjamin = new Igralec("Benjamin", 100000, "vratar", 30);
            Igralec Beno = new Igralec("Beno", 120000, "napadalec", 28);
            Igralec Aljaz = new Igralec("Aljaž", 90000, "napadalec", 32);
            Igralec Ziga = new Igralec("Žiga", 85000, "napadalec", 24);
            Igralec Peter = new Igralec("Peter", 105000, "vratar", 35);
            Igralec Nik = new Igralec("Nik", 75000, "vezni", 27);
            Igralec Nikola = new Igralec("Nikola", 100000, "vezni", 27);

            List<Igralec> listaIgralcev = new List<Igralec>() { Benjamin, Beno, Aljaz, Ziga, Peter, Nik, Nikola };
            //Console.WriteLine(Benjamin.ToString());
            NogometniKlub sava = new NogometniKlub(listaIgralcev, 100000);

            //sava.predragiIgralci();
            Console.WriteLine("Igralci: ");
            for (int i = 0; i < sava.SeznamIgralcev.Count; i++)
            {
                Igralec igralec = sava.SeznamIgralcev[i];
                if (igralec.Starost < 30 && igralec.CenaIgralca >= 100000)
                {
                    Console.WriteLine($"Ime: {igralec.Ime} Cena: {igralec.CenaIgralca} Polozaj: {igralec.Polozaj} Starost: {igralec.Starost}");
                }
            }
        }
        public static void Naloga9()
        {
            /* Naloga 8.3.1.6. Napisite razreda Dijak in Razred. Razred Dijak naj vsebuje: Lastnosti Ime, PredmetiNaMaturi, SteviloTockNaMaturi, KoncniUspeh (zadosten, dober, prav dober, odliˇcen). En konstruktor, ki omogoca dolocitev natanko dveh lastnosti, in en konstruktor, ki omogoca doloˇcitev vseh stirih lastnosti. Povozite metodo ToString, ki naj izpise vse podatke o dijaku. Razred Razred naj vsebuje: Lastnosti SeznamDijakov in Razrednik. Konstruktor, ki inicializira seznam dijakov in kot parameter dobi razrednika. Metodo, ki izpise povprecno stevilo tock dijakov razreda na maturi. V metodi Main kreirajte instanco razreda Razred, ki naj vsebuje vsaj pet dijakov in izpisite podatke o vseh dijakih, ki so na maturi dosegli vsaj 24 tock. */

            List<string> predmeti = new List<string>() { "Matematika", "Nemščina", "Slovenščina", "Filozofija", "Sociologija" };
            Dijak Ana = new Dijak("Ana", predmeti, 24, "odlično");
            //Console.Write(Ana.ToString());

            Razred razred = new Razred("razrednik");
            Console.Write(razred.povprecjeTock());

            Console.WriteLine("Podatki o dijakih ki so dosegli vsaj 24 točk na maturi: ");
            for (int i = 0; i < razred.Dijaki.Count(); i++)
            {
                if (razred.Dijaki[i].SteviloTockNaMaturi > 23)
                {
                    Console.WriteLine($"ime: {razred.Dijaki[i].Ime} Predmeti: {string.Join(", ", razred.Dijaki[i].PredmetiNaMaturi)} št. točk: {razred.Dijaki[i].SteviloTockNaMaturi} končni uspeh: {razred.Dijaki[i].KoncniUspeh}");
                }
            }

        }



    }


    /* Naloga 8.1.1.1. Razmislite, katere lastnosti bi pripisali rozi in katere bi ji pripisali v konstruktorjih. Definirajte razred Flower, dodajte mu vsaj tri spremenljivke, ki bodo hranile neke podatke o vsaki instanci, in definirajte vsaj dva konstruktorja.*/
    public class Flower
    {
        public Flower(string name, string color, bool smell, int numOfFlowers, double height)
        {
            Name = name;
            Color = color;
            Smell = smell;
            NumOfFlowers = numOfFlowers;
            Height = height;

        }

        public string Name { get; set; }
        public string Color { get; set; }
        public bool Smell { get; set; }
        public int NumOfFlowers { get; set; }
        public double Height { get; set; }
    }

    /* Naloga 8.2.1.1. Razredu Dress iz razdelka dolocite se dve lastnosti: cena z DDV in cena brez DDV, kjer v konstruktorju kot parameter dobite samo ceno brez DDV. Ceno z DDV izracunate z upostevanjem, da je DDV na obleke 22%.*/
    public class Dress
    {

        public Dress(double noddv)
        {
            NoDDV = noddv;
        }

        public double NoDDV { get; set; }
        public double WithDDV
        {
            get
            {
                return NoDDV * 1.22;
            }
        }
    }

    /* Naloga 8.2.1.2. Napisite razred Drink, ki opisuje napitek, ki ga lahko narocite v lokalni  kavarni. Dolocite mu vsaj dva konstruktorja in vsaj stiri lastnosti, pri cemer sta lahko najvec dve samodejno implementirani.*/
    public class Drink
    {

        public Drink(bool isHot, bool hasFoam, string taste, bool hasCaffeine, string color, bool isSweet, bool hasMilk)
        {
            this.IsHot = isHot;
            this.HasFoam = hasFoam;
            this.Taste = taste;
            this.HasCaffeine = hasCaffeine;
            this.Color = color;
            this.IsSweet = isSweet;
            this.HasMilk = hasMilk;
        }
        public Drink()
        {
            this.IsHot = true;
            this.HasFoam = false;
            this.Taste = "crap";
            this.HasCaffeine = true;
            this.Color = "black";
            this.IsSweet = false;
            this.HasMilk = false;
        }


        public bool IsHot { get; set; }
        public bool HasFoam { get; set; }
        public string Taste { get; set; }
        public bool HasCaffeine { get; set; }
        public string Color { get; set; }
        public bool IsSweet { get; set; }
        public bool HasMilk { get; set; }
    }

    /* Naloga 8.3.1.6. Napisite razreda Dijak in Razred. Razred Dijak naj vsebuje: Lastnosti Ime, PredmetiNaMaturi, SteviloTockNaMaturi, KoncniUspeh (zadosten, dober, prav dober, odlicen). En konstruktor, ki omogoca dolocitev natanko dveh lastnosti, in en konstruktor, ki omogoca doloˇcitev vseh stirih lastnosti. Povozite metodo ToString, ki naj izpise vse podatke o dijaku. Razred Razred naj vsebuje: Lastnosti SeznamDijakov in Razrednik. Konstruktor, ki inicializira seznam dijakov in kot parameter dobi razrednika. Metodo, ki izpise povprecno stevilo tock dijakov razreda na maturi. V metodi Main kreirajte instanco razreda Razred, ki naj vsebuje vsaj pet dijakov in izpisite podatke o vseh dijakih, ki so na maturi dosegli vsaj 24 tock. */

    public class Dijak
    {

        public Dijak(string ime, List<string> predmetiNaMaturi, int steviloTockNaMaturi, string koncniUspeh)
        {
            Ime = ime;
            PredmetiNaMaturi = predmetiNaMaturi;
            SteviloTockNaMaturi = steviloTockNaMaturi;
            KoncniUspeh = koncniUspeh;
        }
        public Dijak(string ime, string koncniUspeh)
        {
            Ime = ime;
            KoncniUspeh = koncniUspeh;
        }

        private List<string> predmeti = new List<string> { "Matematika", "Slovenscina", "Anglescina", "Fizika", "Zgodovina" };
        private int tocke = 0;
        public string Ime { get; set; }
        public List<string> PredmetiNaMaturi
        {
            get
            {
                return predmeti;
            }

            set
            {
                predmeti = value;
            }
        }
        public int SteviloTockNaMaturi
        {
            get
            {
                return tocke;
            }

            set
            {
                tocke = value;
            }
        }
        public string KoncniUspeh { get; set; }

        public override string ToString()
        {
            return $"Podatki o dijaku:\n ime: {Ime} \n Predmeti na Maturi: {string.Join(", ", PredmetiNaMaturi)} \n Število točk na maturi: {SteviloTockNaMaturi} \n Končni uspeh: {KoncniUspeh}";
        }
    }
    /* Razred Razred naj vsebuje: Lastnosti SeznamDijakov in Razrednik. Konstruktor, ki inicializira seznam dijakov in kot parameter dobi razrednika. Metodo, ki izpise povprecno stevilo tock dijakov razreda na maturi. V metodi Main kreirajte instanco razreda Razred, ki naj vsebuje vsaj pet dijakov in izpisite podatke o vseh dijakih, ki so na maturi dosegli vsaj 24 tock. */
    public class Razred
    {

        public List<Dijak> Dijaki;
        public string Razrednik { get; set; }

        public Razred(string razrednik)
        {
            Razrednik = razrednik;
            List<string> predmeti = new List<string>() { "Matematika", "Nemščina", "Slovenščina", "Filozofija", "Sociologija" };
            Dijak Ana = new Dijak("Ana", predmeti, 24, "odločno");
            Dijak Anja = new Dijak("Anja", predmeti, 20, "prav dobro");
            Dijak Luka = new Dijak("Luka", predmeti, 23, "odločno");
            Dijak Peter = new Dijak("Peter", predmeti, 24, "odločno");
            Dijak Nika = new Dijak("Nika", predmeti, 24, "prav dobro");
            Dijak Anze = new Dijak("Anze", predmeti, 22, "prav dobro");
            Dijaki = new List<Dijak>() { Ana, Anja, Luka, Peter, Nika, Anze };
        }



        public int povprecjeTock()
        {
            int vseTocke = 0;
            for (int i = 0; i < Dijaki.Count; i++)
            {

                vseTocke += Dijaki[i].SteviloTockNaMaturi;
            }

            return vseTocke / Dijaki.Count();
        }

    }

    /* Naloga 8.3.1.5. Pripravite razreda Igralec in NogometniKlub. Razred Igralec naj vsebuje: Lastnosti Ime, CenaIgralca, Polozaj (napadalec, vezni, vratar,...), Starost (tej lastnosti lahko vrednost nastavimo samo v konstruktorju!). En konstruktor, ki omogoca dolocitev natanko dveh lastnosti, in en konstruktor, ki omogoca dolocitev vsaj treh lastnosti. Povozite metodo ToString, ki naj izpise vse podatke o igralcu. Razred NogometniKlub naj vsebuje: Lastnosti SeznamIgralcev in VisinaProracuna. Konstruktor, ki inicializira seznam igralcev in nastavi visino proracuna. Metodo, ki izpise vse igralce, ki imajo ceno visjo od danega maksimuma. V metodi Main kreirajte instanco razreda NogometniKlub, ki naj vsebuje vsaj pet igralcev in izpisite podatke o vseh igralcih, ki imajo ceno vsaj 100 000 evrov in so mlajsi od 30 let.*/

    public class Igralec
    {
        public Igralec(string ime, int cenaIgralca, string polozaj, int starost)
        {
            Ime = ime;
            CenaIgralca = cenaIgralca;
            Polozaj = polozaj;
            Starost = starost;
        }
        public Igralec(string ime, int starost)
        {
            Ime = ime;
            Starost = starost;
        }
        public string Ime { get; set; }
        public int CenaIgralca { get; set; }
        public string Polozaj { get; set; }
        public int Starost { get; set; }

        public override string ToString()
        {
            return $"Ime: {Ime}, cena igralca: {CenaIgralca}, polozaj: {Polozaj}, starost: {Starost}";
        }
    }

    /*  Razred NogometniKlub naj vsebuje: Lastnosti SeznamIgralcev in VisinaProracuna. Konstruktor, ki inicializira seznam igralcev in nastavi visino proracuna. Metodo, ki izpise vse igralce, ki imajo ceno visjo od danega maksimuma. V metodi Main kreirajte instanco razreda NogometniKlub, ki naj vsebuje vsaj pet igralcev in izpisite podatke o vseh igralcih, ki imajo ceno vsaj 100 000 evrov in so mlajsi od 30 let.*/
    public class NogometniKlub
    {
        public NogometniKlub(List<Igralec> seznamIgralcev, int visinaProracuna)
        {

            SeznamIgralcev = seznamIgralcev;
            VisinaProracuna = visinaProracuna;
        }
        public List<Igralec> SeznamIgralcev { get; set; }
        public int VisinaProracuna { get; set; }

        public void predragiIgralci()
        {
            List<string> predragiIgralec = new List<string>();

            for (int i = 0; i < SeznamIgralcev.Count; i++)
            {
                if (SeznamIgralcev[i].CenaIgralca > VisinaProracuna)
                {
                    predragiIgralec.Add(SeznamIgralcev[i].Ime);
                }
            }

            Console.Write("Ti igralci imajo višjo ceno od minimuma: ");
            foreach (string el in predragiIgralec)
            {
                Console.Write(" " + el);
            }
            Console.WriteLine();

        }
    }

    /* Naloga 8.3.1.1. Napisite razred Figura, ki predstavlja sahovsko figuro. Razmislite, katere lastnosti bi figura morala imeti, in jih implementirajte. Podobno implementirajte tudi vsaj eno metodo zanjo.*/
    //ime, barva, material

    public class Figura
    {
        public Figura(string ime, string barva, string material)
        {
            Ime = ime;
            Barva = barva;
            Material = material;
        }

        public string Ime { get; set; }
        public string Barva { get; set; }
        public string Material { get; set; }

        public string lastnostiFigure()
        {
            return $"Ime: {Ime} Barva: {Barva} Material: {Material}";
        }
    }

    /* Naloga 8.3.1.2. Definirajte razred Glagol, ki bo kot vrednost prejel nek glagol, njegove dodatne lastnosti pa bodo Oseba, Stevilo, Cas. Napisite tudi objektno metodo, ki bo vrnila seznam vseh oblik glagola za vse osebe v ednini (vsaj za nekatere korene glagolov).*/

    public class Glagol
    {
        public Glagol(string beseda, string oseba, string stevilo, string cas, string spol)
        {
            Beseda = beseda;
            Oseba = oseba;
            Stevilo = stevilo;
            Cas = cas;
            Spol = spol;
        }

        public string Beseda { get; set; }
        public string Oseba { get; set; }
        public string Stevilo { get; set; }
        public string Cas { get; set; }
        public string Spol { get; set; }

        public List<string> glagolVEdnini()
        {
            List<string> sklanjatve = new List<string>();
            for (int i = 1; i <= 6; i++)
            {
                string krajsaBeseda = Beseda.Substring(0, Beseda.Length - 1);
                if (Spol.ToLower() == "moski")
                {
                    if (i == 1) sklanjatve.Add(Beseda);
                    else if (i == 2) sklanjatve.Add(Beseda + "a");
                    else if (i == 3) sklanjatve.Add(Beseda + "u");
                    else if (i == 4) sklanjatve.Add(Beseda + "a");
                    else if (i == 5) sklanjatve.Add(Beseda + "u");
                    else if (i == 6) sklanjatve.Add(Beseda + "om");
                    else break;
                }
                else if (Spol.ToLower() == "zenski")
                {
                    if (i == 1) sklanjatve.Add(Beseda);
                    else if (i == 2) sklanjatve.Add(krajsaBeseda + "e");
                    else if (i == 3) sklanjatve.Add(krajsaBeseda + "i");
                    else if (i == 4) sklanjatve.Add(krajsaBeseda + "o");
                    else if (i == 5) sklanjatve.Add(krajsaBeseda + "i");
                    else if (i == 6) sklanjatve.Add(krajsaBeseda + "o");
                    else break;
                }
                else
                {
                    if (i == 1) sklanjatve.Add(Beseda);
                    else if (i == 2) sklanjatve.Add(krajsaBeseda + "a");
                    else if (i == 3) sklanjatve.Add(krajsaBeseda + "u");
                    else if (i == 4) sklanjatve.Add(krajsaBeseda + "o");
                    else if (i == 5) sklanjatve.Add(krajsaBeseda + "u");
                    else if (i == 6) sklanjatve.Add(krajsaBeseda + "om");
                    else break;
                }

            }
            return sklanjatve;

        }
    }
}
