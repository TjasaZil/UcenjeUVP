namespace SpremenljivkeInTipi
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



            //VAJE
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
            //Naloga23();
            //Naloga24();
            //Naloga25();
            //Naloga26();
            Console.ReadKey();
        }

        public static void Naloga1()
        {
            /* Naloga 2.2.1.1. Definirajte pet spremenljivk razlicnih tipov, dolocite jim poljubne vrednosti in na zaslon izpisite njihovo ime ter vrednost. Pred vsako od spremenljivk dodajte se komentar z njenim opisom. */

            char znak = 'A';
            Console.WriteLine($"To je spremenljivka tipa char, imena {nameof(znak)} in vrednosti {znak}.");

            int stevka = 2;
            Console.WriteLine($"To je spremenljivka tipa int, imena {nameof(stevka)} in vrednosti {stevka}.");

            ulong dolgaStevka = 12345678900987654321;
            Console.WriteLine($"To je spremenljivka tipa ulong, imena {nameof(dolgaStevka)} in vrednosti {dolgaStevka}.");

            short kratkaStevka = 123;
            Console.WriteLine($"To je spremenljivka tipa short, imena {nameof(kratkaStevka)} in vrednosti {kratkaStevka}.");

            string besedilo = "abcdefg";
            Console.WriteLine($"To je spremenljivka tipa string, imena {nameof(besedilo)} in vrednosti {besedilo}.");

            bool trueAliFalse = true;
            Console.WriteLine($"To je spremenljivka tipa bool, imena {nameof(trueAliFalse)} in vrednosti {trueAliFalse}.");
        }
        public static void Naloga2()
        {
            /* Naloga 2.2.1.2. Za vsako izmed naslednjih vrednosti ustvarite spremenljivko ustreznega
                tipa in vanjo shranite eno vrednost: naslov priljubljenega filma, stevilo igralcev na kosarkarski tekmi, ali je partija saha zakljucena, cena izdelka v trgovini, zacetnica priimka avtorja knjige. */

            string naslovFilma = "Gladiator";
            int steviloKosarkasev = 10;
            bool sahZakljucen = true;
            double cenaIzdelka = 3.75D;
            char zacetnicaImena = 'J';

        }
        public static void Naloga3()
        {
            /* Naloga 2.2.1.3. Zapisite priblizek stevila π s tremi razlicnimi tipi na vsaj stiri decimalna mesta natancno. */

            float floaty = 3.1415F;
            double doubly = 3.1415D;
            decimal decimalka = 3.1415M;
            Console.WriteLine($"float spremenljivka za pi vrne {floaty}, double vrne {doubly}, decimal pa {decimalka}.");
        }
        public static void Naloga4()
        {
            /* Naloga 2.2.1.4. Ustvarite dve spremenljivki, v eno shranite svoje ime in v drugo svoj priimek. Nato na zaslon v eni vrstici izpisite “Jaz sem IME PRIIMEK”. */

            string ime = "Ime";
            string priimek = "Priimek";
            Console.WriteLine($"Jaz sem {ime} {priimek}");
        }
        public static void Naloga5()
        {
            /* Naloga 2.2.1.5. Na zaslon izpisite svoj naslov v treh vrsticah s pomocjo treh spremenljivk, ki shranjujejo: ime in priimek, ulica in hisna stevilka, postna stevilka in posta. Kako bi to
            storili, ce bi lahko uporabili le eno spremenljivko? */

            string imeInPriimek = "Ime Priimek \n";
            string naslov = "Ulica 123 \n";
            string posta = "1000 Ljubljana";
            Console.WriteLine($"Uporabila sem le več spremenljivk:\n {imeInPriimek} {naslov} {posta}");

            string jaz = "Ime Priimek \n Ulica 123 \n 1000 Ljubljana";
            Console.WriteLine($"Uporabila sem le eno spremenljivko:\n {jaz}");
        }
        public static void Naloga6()
        {
            /* Naloga 2.2.1.6. V ukazno vrstico izpisite svoje ime samo z uporabo spremenljivk tipa
                char. Pri tem uporabite ukaz Console.Write(), ki deluje podobno kot Console.WriteLine(),
                le da ob izpisu vrednosti ne skoci v naslednjo vrstico. */


            char t = 'T';
            char j = 'j';
            char a = 'a';
            char s = 's';
            Console.Write($"ime: {t}{j}{a}{s}{a}");
        }
        public static void Naloga7()
        {
            /* Naloga 2.2.1.7. S kombinacijo ukazov Console.Write() in Console.WriteLine() izpisite
                seznam predmetov, ki ste jih oziroma jih obiskujete in pricakovano oceno za vsakega od
                njih. */


            Console.Write("predmet: Uvod v Informatiko -> ");
            Console.WriteLine("pricakovana ocena: 10");
            Console.Write("predmet: Uvod v Algoritme -> ");
            Console.WriteLine("pricakovana ocena: 10");
            Console.Write("predmet: Uvod v Programiranje -> ");
            Console.WriteLine("pricakovana ocena: 10");
            Console.Write("predmet: Baze podatkov in modeliranje podatkov -> ");
            Console.WriteLine("pricakovana ocena: 10");
            Console.Write("predmet: Spletno programiranje -> ");
            Console.WriteLine("pricakovana ocena: 10");
            Console.Write("predmet: Projekt razvoja spletne programske rešitve -> ");
            Console.WriteLine("pricakovana ocena: 10");

        }
        public static void Naloga8()
        {
            /* Naloga 2.2.1.8. Deklarirajte tri celostevilske spremenljivke in jim dolocite poljubne vrednosti. Vse tri spremenljivke nato sestejte in shranite v spremenljivko, ki jo na koncu
            program izpise na zaslon. Uporabite lahko le tri spremenljivke, ki ste jih deklarirali. */


            int stevilka1 = 1;
            short stevilka2 = -2;
            ushort stevilka3 = 3;
            long vsota = stevilka1 + stevilka2 + stevilka3;

            Console.WriteLine($"Vsota števk {stevilka1}, {stevilka2} in {stevilka3} je {vsota}");
        }
        public static void Naloga9()
        {
            /* Naloga 2.2.1.9. Deklarirajte dve spremenljivki enakega tipa, dolocite jima poljubno vrednost in ju izpisite na zaslon. Nato spremenljivkama v programu zamenjajte vrednosti in
              na zaslon izpisite njune nove vrednosti. */

            int prvaSpremenljivka = 3;
            char drugaSpremenljivka = 'b';
            Console.WriteLine($"Spremenljivke pred spremembo: {prvaSpremenljivka}, {drugaSpremenljivka}");

            prvaSpremenljivka = 2;
            drugaSpremenljivka = 'c';
            Console.WriteLine($"Spremenljivke po spremembi: {prvaSpremenljivka}, {drugaSpremenljivka}");

        }
        public static void Naloga10()
        {
            /* Naloga 1.0.0.2. Deklarirajte vsaj 6 osnovnih tipov spremenljivk in jim dolocite poljubne vrednosti. Vsako od spremenljivk tudi izpisite na zaslon. */

            //tip ime = vrednost;

            //logični tipi
            bool spr1 = true; //false

            //Znakovni tipi
            char spr2 = 'a';

            //celoštevilski tipi
            int spr3 = 4; //32 bitov
            //byte - 8 bitov
            //short - 16 bitov
            //long - 64 bitov
            long spr4 = 5L;

            //Decimalni tipi
            double spr5 = 5.1; //64 bitov
            float spr6 = 4.2F;
            decimal spr7 = 6.4M;

            //ni osnovni tip ampak sklicni tip
            string spr8 = "hello";
        }
        public static void Naloga11()
        {
            /* Naloga 1.0.0.3. Programu iz prejsnje naloge dodajte nekaj enovrsticnih komentarjev. V program dodajte se en vecvrsticni komentar. */


            /* To
             je
             večvrstični
             komentar
            */

            //to je enovrstični komentar :D
        }

        public static void Naloga12()
        {
            /* Naloga 1.0.0.4. Denimo, da zelite opisati lastnosti avta: znamka, stevilo vrat, hitrost in ali je nov/rabljen. Ugotovite kateri tip podatka bi uporabili za vsako izmed lastnosti, da bi najbolje ustrezal podatku, ki ga bo spremenljivka hranila. */


            string znamka = "Audi";
            int steviloVrat = 5;
            int hitrost1;
            double hitrost2;
            string hitrost3; //če želimo mersko enoto
            bool jeNov1; //true ali false -> true je nov, false ni nov
            string jeNov2; //napišeš 'rabljen' ali 'nov'
            char jeNov3; //N->nov, R->rabljen
        }
        public static void Naloga13()
        { /* Naloga 1.0.0.5. Ustvarite dve spremenljivki, v eno shranite svoje ime in v drugo svoj priimek. Nato na zaslon v eni vrstici izpisite “Moje ime je: IME PRIIMEK”. */


            string ime1 = "IME";
            string priimek1 = "PRIIMEK";
            Console.WriteLine($"Moje ime je: {ime1} {priimek1}");
            //lahko tudi
            Console.WriteLine("Moje ime je:" + ime1 + " " + priimek1);

        }
        public static void Naloga14()
        {


            /* Naloga 1.0.0.6. Na zaslon izpisite vase ime s pomocjo unicode zapisa za znake s pomocjo ukaza \u. */


            char unicodeZnak = '\u0041';
            Console.WriteLine(unicodeZnak);
            string ime2 = "\u0049\u004D\u0045";
            Console.WriteLine(ime2);
            char znakI = '\u0049';
            char znakM = '\u004D';
            char znakE = '\u0045';
            Console.WriteLine(znakI + znakM + znakE);

        }
        public static void Naloga15()
        {

            /* Naloga 1.0.0.7. Na zaslon izpisite svoj naslov z nizi (ime in priimek, ulica in hisna stevilka, postna stevilka in posta) v treh vrsticah. */

            string ime = "IME";
            string priimek = "PRIIMEK";
            string ulica = "ulica in hisna stevilka";
            string posta = "posta in postna stevilka";
            Console.WriteLine(ime + " " + priimek);
            Console.WriteLine(ulica);
            Console.WriteLine(posta);

        }
        public static void Naloga16()
        {
            /* Naloga 1.0.0.8. Program iz prejsnje naloge popravite tako, da ukaz za izpis na zaslon uporabite le enkrat. Pomagajte si z ukazom \n, ki ga morate zapisati v samem nizu. */

            string ime = "IME";
            string priimek = "PRIIMEK";
            string ulica = "ulica in hisna stevilka";
            string posta = "posta in postna stevilka";

            Console.WriteLine(ime + " " + priimek + "\n" + ulica + "\n" + posta);

        }
        public static void Naloga17()
        {
            /* Naloga 1.0.0.9. Ustvarite dve celostevilski spremenljivki in vanju shranite vrednosti 125 in 20. Nato na zaslon v razlicnih vrsticah izpisite njuno vsoto, razliko, produkt, deljenje in ostanek pri deljenju. Izpise primerjajte z dejanskimi vrednostmi. */
            /* Naloga 1.0.0.10. Prejsnjo nalogo popravite tako, da pred rezultatom na zaslon v isti vrstici izpisete tudi kaj rezultat predstavlja. Nato storite enako, le da bo opis rezultata zapisan za samo vrednostjo. */

            //nalogi 9 in 10

            int st1 = 5;
            int st2 = 3;
            Console.WriteLine(st1 + st2); //seštevanje
            Console.WriteLine(st1 - st2); //odštevanje
            Console.WriteLine(st1 * st2); //množenje
            Console.WriteLine(st1 / st2); //deljenje
            Console.WriteLine(st1 % st2); //ostanek pri deljenju
            Console.WriteLine("Vsota: " + (st1 + st2));
            Console.WriteLine(st1 + st2 + "je vsota");
            Console.WriteLine("Odštevanje: " + (st1 - st2));
            Console.WriteLine(st1 - st2 + "je razlika");
            Console.WriteLine("Množenje: " + (st1 * st2));
            Console.WriteLine(st1 * st2 + "je produkt");
            Console.WriteLine("Deljenje: " + (st1 / st2));
            Console.WriteLine("Ostanek pri deljenju: " + (st1 % st2));

        }
        public static void Naloga18()
        {
            /* Naloga 1.0.0.11. Ustvarite celostevilsko spremenljivko s poljubno vrednostjo. Ustvarjeno spremenljivko spremenite tako, da jo enkrat povecate, zmanjsate, pomnozite, delite in shranite vanjo ostanek pri deljenju z 2. Uporabite krajse oblike zapisov. */

            int stevilo = 5;
            stevilo = 2;
            stevilo += 2;
            stevilo -= 2;
            stevilo *= 2;
            stevilo /= 2;
            stevilo %= 2;

        }
        public static void Naloga19()
        {
            /* Naloga 1.0.0.12. Na zaslon izpisite rezultate naslednjih izrazov in jih primerjajte z dejanskimi vrednostmi.
                3
                a) −3 % 8
                b) −5 + 4 ∗ 7
                c) (25 + 3) % 8
                d) 10 + −3 ∗ 5 / 7
                e) 5 + 15 / 3 ∗ 2 − 8 % 3
                */

            //Console.WriteLine("rezultat a: " + (−3 % 8));
            //Console.WriteLine("rezultat b: " + (−5 + 4 ∗ 7));
            //Console.WriteLine("rezultat c: " + ((25 + 3) % 8));
            //Console.WriteLine("rezultat d: " + (10 + −3 ∗ 5 / 7));

            //Console.WriteLine("rezultat e: " + (5 + 15 / 3 ∗ 2 − 8 % 3));
        }
        public static void Naloga20()
        {
            /* Naloga 1.0.0.13. Za dano trimestno stevilo izpisite stevilo stotic, desetic in enic. */

            int x = 123;
            int stotice = x / 100;
            int desetice = (x % 100) / 10;
            int enice = x % 10;

            Console.WriteLine("stotice: " + stotice);
            Console.WriteLine("desetice: " + desetice);
            Console.WriteLine("enice: " + enice);
        }
        public static void Naloga21()
        {
            /* Naloga 1.0.0.14. Ustvarite tri poljubne celostevilske spremenljivke in na zaslon izpisite njihovo povprecje. */

            int st1 = 41;
            int st2 = 121;
            int st3 = 36;
            double povprecje = (double)(st1 + st2 + st3) / 3;
            Console.WriteLine("povprečna starost:" + povprecje);
        }
        public static void Naloga22()
        {
            /* Naloga 1.0.0.15. Deklarirajte stiri celostevilske spremenljivke a, b, c in d, ter jim dolocite poljubno vrednost. Nato na zaslon izpisite rezultate naslednjih logicnih izrazov.
                a) a manjse ali enako b
                b) c razlicno od d
                c) a + d vecje od c in b manjse od c
                d) b vecje ali enako d ali c manjse od a
                */

            int a1 = 3;
            int b = 5;
            int c = 8;
            int d = 4;
            Console.WriteLine($"a:{a1}, b:{b}, c:{c}, d:{d}");
            Console.WriteLine($"a manjse ali enako b: {a1 <= b}");
            Console.WriteLine($"c razlicno od d: {c != d}");
            Console.WriteLine($"a + d vecje od c in b manjse od c: {a1 + d > c && b < c}");
            Console.WriteLine($"b vecje ali enako d ali c manjse od a: {b >= d || c < a1}");
        }
        public static void Naloga23()
        {
            /* Naloga 1.0.0.16. Deklarirajte dve spremenljivki enakega tipa, dolocite jima poljubno vrednost in ju izpisite na zaslon. Nato spremenljivkama v programu zamenjajte vrednosti in na zaslon izpisite njune nove vrednosti. */


            int b = 3;
            int c = 4;
            Console.WriteLine($"To je b: {b}, to je c:{c}");

            b = 4;
            c = 3;
            Console.WriteLine($"To je b: {b}, to je c:{c}");
        }
        public static void Naloga24()
        {
            /* Naloga 1.0.0.17. Izracunajte ploscino kvadrata in kroga s stranico (oziroma polmerom) enako/-im 2.5. Konstanto π dobimo s pomocjo ukaza Math.P I. */

            double r = 2.5;
            double plKvadrat = r * r;
            double plKrog = Math.PI * r * r;

            Console.WriteLine($"Tukaj je ploščina kvadrata: {plKvadrat} in ploščina kroga: {plKrog}");
        }
        public static void Naloga25()
        {
            /* Naloga 1.0.0.18. Da dobimo najmanjso in najvecjo vrednost, ki jo lahko spremenljivka tipa short shrani, lahko uporabimo ukaz short.MinValue oziroma short.MaxValue. Na
               zaslon izpisite ti dve vrednosti. Enako naredite tudi za ushort, int, uint, long in ulong, da vidite kaksne vrednosti lahko sprejmejo. */

            Console.WriteLine($"short min: {short.MinValue} \n short max: {short.MaxValue} \n ushort min: {ushort.MinValue} \n ushort max: {ushort.MaxValue} \n int min: {int.MinValue} \n int max: {int.MaxValue} \n uint min: {uint.MinValue} \n uint max: {uint.MaxValue} \n long min: {long.MinValue} \n long max: {long.MaxValue} \n ulong min: {ulong.MinValue} \n ulong max: {ulong.MaxValue} \n");
        }
        public static void Naloga26()
        {
            /* Naloga 1.0.0.19. Deklarirajte decimalno stevilo z vsaj petimi decimalkami, med katerimi naj bo vsaj ena manjsa od 5 in vsaj ena vecja ali enaka 5. Nato preizkusite zaokrozevanje na nekaj decimalnih mest. To lahko storite z uporabo ukaza Math.Round("vrednost", stevilo decimalnih mest").*/

            double doubleStevilka = 1.2354726;
            Console.WriteLine($"Zaokroženo na 6 decimalk: {Math.Round(doubleStevilka, 6)} \n Zaokroženo na 5 decimalk: {Math.Round(doubleStevilka, 5)} \n Zaokroženo na 4 decimalke: {Math.Round(doubleStevilka, 4)} \n Zaokroženo na 3 decimalke: {Math.Round(doubleStevilka, 3)} \n Zaokroženo na 2 decimalki: {Math.Round(doubleStevilka, 2)} \n Zaokroženo na 1 decimalko: {Math.Round(doubleStevilka, 1)} \n");
        }

    }
}
