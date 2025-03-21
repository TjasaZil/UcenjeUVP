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
            //Naloga6();
            //Naloga7();
            //Naloga8();
            //Naloga9();

            // VAJE
            //Naloga10();
            //Naloga11();
            //Naloga12();
            //Naloga13();
            //Naloga14();
            //Naloga15();
            //Naloga16();
            //Naloga17();
            //Naloga18();
            //Naloga19();
            //Naloga20();
            //Naloga21();
            //Naloga22();
            Console.ReadKey();
        }

        public static void Naloga1()
        {
            /* Naloga 8.1.1.1. Razmislite, katere lastnosti bi pripisali rozi in katere bi ji pripisali v konstruktorjih. Definirajte razred Flower, dodajte mu vsaj tri spremenljivke, ki bodo hranile neke podatke o vsaki instanci, in definirajte vsaj dva konstruktorja.*/
        }
        public static void Naloga2()
        {
            /* Naloga 8.2.1.1. Razredu Dress iz razdelka dolocite se dve lastnosti: cena z DDV in cena brez DDV, kjer v konstruktorju kot parameter dobite samo ceno brez DDV. Ceno z DDV izracunate z upostevanjem, da je DDV na obleke 22%.*/
        }
        public static void Naloga3()
        {
            /* Naloga 8.2.1.2. Napisite razred Drink, ki opisuje napitek, ki ga lahko narocite v lokalni  kavarni. Dolocite mu vsaj dva konstruktorja in vsaj stiri lastnosti, pri cemer sta lahko najvec dve samodejno implementirani.*/
        }
        public static void Naloga4()
        {
            /* Naloga 8.3.1.1. Napisite razred Figura, ki predstavlja sahovsko figuro. Razmislite, katere lastnosti bi figura morala imeti, in jih implementirajte. Podobno implementirajte tudi vsaj eno metodo zanjo.*/
        }
        public static void Naloga5()
        {
            /* Naloga 8.3.1.2. Definirajte razred Glagol, ki bo kot vrednost prejel nek glagol, njegove dodatne lastnosti pa bodo Oseba, Stevilo, Cas. Napisite tudi objektno metodo, ki bo vrnila seznam vseh oblik glagola za vse osebe v ednini (vsaj za nekatere korene glagolov).*/
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
        }
        public static void Naloga9()
        {
            /* Naloga 8.3.1.6. Napisite razreda Dijak in Razred. Razred Dijak naj vsebuje: Lastnosti Ime, PredmetiNaMaturi, SteviloTockNaMaturi, KoncniUspeh (zadosten, dober, prav dober, odliˇcen). En konstruktor, ki omogoca dolocitev natanko dveh lastnosti, in en konstruktor, ki omogoca doloˇcitev vseh stirih lastnosti. Povozite metodo ToString, ki naj izpise vse podatke o dijaku. Razred Razred naj vsebuje: Lastnosti SeznamDijakov in Razrednik. Konstruktor, ki inicializira seznam dijakov in kot parameter dobi razrednika. Metodo, ki izpise povprecno stevilo tock dijakov razreda na maturi. V metodi Main kreirajte instanco razreda Razred, ki naj vsebuje vsaj pet dijakov in izpisite podatke o vseh dijakih, ki so na maturi dosegli vsaj 24 tock. */
        }

        // 8.1 Knjiga
        public static void Naloga10()
        {
            /* Naloga 8.1.0.1. Ustvarite razred Avtor s polji za ime, priimek, spol, starost in email naslov. Dodajte mu konstruktor, ki omogoˇca doloˇcitev vrednosti vseh polj in metodo za izpis njegovih podatkov, ki vrne niz. */
        }
        public static void Naloga11()
        {
            /* Naloga 8.1.0.2. Ustvarite razred Knjiga s polji za naslov knjige, avtorja (iz prejsnje  naloge), zalozbo in stevilo strani. Dodajte mu tudi konstruktor, ki doloci avtorja. Ob tem naj vsebuje tudi metodo za izpis, ki izpise podatke o knjigi skupaj s podatki o avtorju. */
        }

        // 8.2 Naselje
        public static void Naloga12()
        {
            /* Naloga 8.2.0.1. Ustvarite razred Zgradba, ki shranjuje nekaj lastnosti o zgradbi. Vsebuje naj tudi staticno metodo Zgradi, ki uporabnika vprasa po podatkih o zgradbi in vrne objekt tipa Zgradba. Objektu dodajte tudi metodo Porusi, ki objekt unici. Vsebuje naj tudi metodo, ki kreira niz podatkov za izpis. */
        }
        public static void Naloga13()
        {
            /* Naloga 8.2.0.2. Ustvarite razred Parcela, ki shranjuje podatek o stevilki parcele, o tem ali je na parceli zgradba ali ne, ter ali je zazidljiva ali ne. Dodajte ji metodo za spremembo namembnosti, ter za kreiranje niza podatkov za izpis. */
        }
        public static void Naloga14()
        {
            /* Naloga 8.2.0.3. Ustvarite razred Naselje, ki shranjuje tabelo parcel. Vse parcele so na zacetku nezazidljive. V razred dodajte se uporabniski vmesnik, ki bo omogocal gradnjo in rusenje zgradb ter spremembo namembnosti parcel glede na stevilko parcele. */
        }
        public static void Naloga15()
        {
            /* Naloga 8.2.0.4. Razrede Zgradba, Parcela in Naselje ustrezno popravite tako, da boste med izvajanjem programa lahko vse podatke zapisali v datoteko, da bi lahko v prihodnje nadaljevali z delom tam, kjer smo ostali.*/
        }

        // 8.3 Banka
        public static void Naloga16()
        {
            /* Naloga 8.3.0.1. Ustvarite objekt Stranka s polji: ime (string), naslov (string), starost (int) in spol (char). Dodajte mu konstruktor za poljubno dolocitev vrednosti vseh polj. */
        }
        public static void Naloga17()
        {
            /* Naloga 8.3.0.2. Ustvarite objekt BancniRacun s polji: stevilka bancnega racuna (int),stranka (Stranka), stanje na racunu (double), seznam transakcij (List<double>) in mudodajte konstruktor, ki nastavi zacetno vrednost za stevilko racuna in stranko. Dodajte mu se funkcionalnosti za polog in izplacilo, ki naj se dodajo v seznam transakcij, ter za
                  prikaz financnega stanja stranke na racunu. Vsebuje naj tudi izpis vseh transakcij na racunu. */
        }
        public static void Naloga18()
        {
            /* Naloga 8.3.0.3. Objektu Stranka dodajte polje denarnica (double) in popravite funkcionalnosti za polog in izplacilo razreda BancniRacun, da popravite tudi stanje v denarnici stranke (najprej morate preveriti, ali je podana vrednost za polog oz. izplacilo sploh mogoca). */
        }
        public static void Naloga19()
        {
            /* Naloga 8.3.0.4. Ustvarite objekt Banka, ki shranjuje seznam strank in bancnih racunov. Vsebovati mora tudi funkcionalnost za izpis stevilke racuna in stanja za vse bancne racune glede na ime stranke. Ob tem naj vsebuje tudi funkcionalnosti za ustvariti racun stranke, ter za izbris racuna stranke po stevilki racuna. V kolikor stranka nima vec nobenega racuna na banki, naj se izbrise iz seznama strank. */
        }
        public static void Naloga20()
        {
            /* Naloga 8.3.0.5. Ustvarite razred UporabniskiVmesnik za upravljanje banke. Uporabnik naj ima na voljo kreiranje novega bancnega racuna, brisanje obstojecega bancnega racuna in vpogled v stanje svojih bancnih racunov. Ob tem naj ima moznost tudi upravljanja z dolocenim bancnim racunom, kjer lahko opravi polog, izplacilo ali pa izpis transakcij na
                banˇcnem racunu. */
        }

        public static void Naloga21()
        {
            /* Naloga 8.3.0.6. Programu za upravljanje z banko dodajte moznost za shranjevanje podatkov v datoteko in branje iz nje tako, da boste lahko vsakic, ko ponovno poˇzenete program ponovno upravljali z enakim stanjem, kot ste program zakljucili. */
        }
        public static void Naloga22()
        {
            /* Naloga 8.3.0.7 (Dodatno). V program za upravljanje banke v celoti vkljucite moznost za nakazilo sredstev na poljuben obstojeci bancni racun glede na stevilo racuna. */
        }
    }
}
