namespace IzbirniStavkiInZanke
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //PREDAVANJA
            //Naloga0();
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
            //Naloga27();
            //Naloga28();
            //Naloga29();
            //Naloga30();
            //Naloga31();
            //Naloga32();
            //Naloga33();
            //Naloga34();
            //Naloga35();
            //Naloga36();
            //Naloga37();
            //Naloga38();
            //Naloga39();
            //Naloga40();
            //Naloga41();
            //Naloga42();
            //Naloga43();
            //Naloga44();
            //Naloga45();
            //Naloga46();
            //Naloga47();
            //Naloga48(); 
            //Naloga49();
            //Naloga50();
            //Naloga51();
            //Naloga52();
            //Naloga53();  
            //Naloga54();
            //Naloga55();
            Naloga56();  //TO DO
            Naloga57();  //TO DO
            Naloga58();  //TO DO
            Naloga59();  //TO DO
            //Naloga60(); 

            Console.ReadKey();

        }

        public static void Naloga0()
        {
            /* Naloga 4.1.3.1. Definirajte spremenljivko ocena in ji kot vrednost podajte stevilsko oceno, ki jo pricakujete pri tem predmetu. Nato s pomocjo stavka if - else if izpisite opisno ime vase pricakovane ocene (6 - zadostno, 7 - dobro, 8 in 9 - prav dobro, 10 - odlicno).*/

            int ocena = 8;

            if (ocena == 10)
            {
                Console.WriteLine("odlično");
            }
            else if (ocena == 9 || ocena == 8)
            {
                Console.WriteLine("prav dobro");
            }
            else if (ocena == 7)
            {
                Console.WriteLine("dobro");
            }
            else if (ocena == 6)
            {
                Console.WriteLine("zadostno");
            }
            else
            {
                Console.WriteLine("nezadostno");
            }

        }
        public static void Naloga1()
        {
            /* Naloga 4.1.3.2. Definirajte spremenljivko, ki kot vrednost prejme stevilko meseca (1 za
               januar, 2 za februar itd.). Pripravite izpis, ki bo povedal, ce ima mesec 31 dni ali ne. */


            int mesec = 6;

            if (mesec == 1 || mesec == 3 || mesec == 5 || mesec == 7 || mesec == 8 || mesec == 10 || mesec == 12)
            {
                Console.WriteLine("mesec ima 31 dni");
            }
            else
            {
                Console.WriteLine("mesec nima 31 dni");
            }
        }
        public static void Naloga2()
        {
            /* Naloga 4.1.3.3. V programiranju se izogibamo pisanju enake kode veckrat, kot je nujno
                potrebno. Nalogo 4.1.3.2 resite s stavkom switch, ki bo imel le dve jedri, pa vseeno 12
                stavkov case. */
            /* Naloga 4.1.3.4. Se enkrat resite Nalogo 4.1.3.2 s stavkom switch, ki bo imel le dve jedri,
            vendar tokrat z uporabo primerjalnih vzorcev v dveh stavkih case. */

            int mesec = 6;
            switch (mesec)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("mesec ima 31 dni");
                    break;
                default:
                    Console.WriteLine("mesec nima 31 dni");
                    break;
            }
        }
        public static void Naloga3()
        {
            /* Naloga 4.2.1.1. Za dano stevilo n izracunajte in izpisite vsoto vseh stevil od 1 do n. */


            int n = 10;
            int vsota = 0;
            for (int i = 0; i <= n; i++)
            {
                vsota += i;
            }

            Console.WriteLine($"vsota vseh števil do {n} je {vsota}");
        }
        public static void Naloga4()
        {
            /* Naloga 4.2.1.2. Za dano stevilo n izracunajte in izpisite vsoto vseh stevil od 1 do n, ki so deljiva s 7. */

            int n = 10;
            int vsota = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 7 == 0) { vsota += i; }

            }
            Console.WriteLine($"vsota vseh števil do {n}, ki so deljiva s 7, je {vsota}");
        }
        public static void Naloga5()
        {
            /*  Naloga 4.2.1.3. Za dano stevilo n zapisite njegovo vrednost v petiskem sistemu.  */

            int n = 643;
            string petiskiZapis = "";
            int ost;
            int stevilo = n;

            while (stevilo > 0)
            {
                ost = stevilo % 5;
                petiskiZapis = ost.ToString() + petiskiZapis;
                stevilo /= 5;
            }

            Console.WriteLine($"Število {n} v petiškem sistemu je: {petiskiZapis}");
        }
        public static void Naloga6()
        {
            /* Naloga 4.2.1.4. Fibonaccijevo zaporedje je definirano z rekurzivno zvezo an = an−1+an−2, kjer sta a1 = 1 in a2 = 1. Izpisite prvih 20 clenov zaporedja. Poskusite nalogo resiti se z uporabo zgolj dveh spremenljivk (poleg iteratorja zanke). */

            int a = 1, b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 3; i <= 20; i++)
            {
                b = a + b;
                Console.WriteLine(b);
                a = b - a;
            }
        }
        public static void Naloga7()
        {
            /* Naloga 4.2.1.5. Uporabite dve gnezdeni zanki in ustrezne stavke if za izris diamanta, ki ima eno stranico dolzine n, s pomocjo zvezdic. Rezultat za n = 4 mora biti kot spodaj.

                   *
                  * *
                 *   *
                *     *
                 *   *
                  * *
                   *

                   */
        }
        public static void Naloga8()
        {

            /* Naloga 4.3.1.1. Razmislite, kako bi primer z odgovarjanjem, dokler ne podate pravilnega odgovora, resili brez stavka break. */

            // lahko rešimo z zanko while in kot pogoj damo dokler odgovor ni pravi

        }
        public static void Naloga9()
        {
            /* Naloga 4.3.1.2. Z uporabo stavka break izpisite zaporedje stevil od 1 do n, tako da bo v prvi vrstici samo stevilo 1, v drugi 1 in 2 in tako dalje do zadnje vrstice, kjer bodo izpisana vsa stevila. */

            int n = 10;

            // brez break rešitev
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");

                }
                Console.WriteLine();
            }

            // z break rešitev

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(j + " ");
                    if (j == i)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Naloga10()
        {
            /* Naloga 2.1.0.1. Napisite program, ki za dano celo stevilo preveri ali je sodo ali liho. */

            int celoStevilo = 5;
            if (celoStevilo % 2 == 0)
            {
                Console.WriteLine("Stevilo je sodo");
            }
            else
            {
                Console.WriteLine("Stevilo je liho");

            }
        }
        public static void Naloga11()
        { /* Naloga 2.1.0.2. Napisite program, ki za dve dani realni stevili izpise vecjega izmed njiju. */

            int x = 5;
            int y = 10;
            if (x > y)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(y);

            }
        }
        public static void Naloga12()
        {
            /* Naloga 2.1.0.3. Napisite program, ki izpise najvecje stevilo izmed treh danih celih stevil. */

            int x = 113;
            int y = 110;
            int z = 12;

            if (x > y && x > z) Console.WriteLine($"Največje število je x: {x}");
            else if (y > x && y > z) Console.WriteLine($"Največje število je y: {y}");
            else Console.WriteLine($"Največje število je z: {z}");

        }
        public static void Naloga13()
        {
            /* Naloga 2.1.0.4. Napisite program, ki izpise absolutno vrednost danega stevila (brez uporabe knjiznice Math). */

            Console.Write("Napiši neko število: ");
            int stevilo = Convert.ToInt32(Console.ReadLine());

            //če se uporabi math abs
            Console.WriteLine($"Absolutna vrednost vpisanega števila z uporabo Math.Abs() je: {Math.Abs(stevilo)}");

            //brez math abs

            int absolutnoStev = stevilo > 0 ? stevilo : -stevilo;
            Console.WriteLine($"Absolutna vrednost vpisanega števila brez uporabe Math.Abs() je: {absolutnoStev}");

        }
        public static void Naloga14()
        {
            /* Naloga 2.1.0.5. Napisite program, ki za dano stevilo preveri ali je pozitivno, negativno, ali enako 0. */

            int x = -5;
            if (x > 0)
            {
                Console.WriteLine("Pozitivno");
            }
            else if (x < 0)
            {
                Console.WriteLine("Negativno");

            }
            else
            {
                Console.WriteLine("Enako je 0");
            }
        }
        public static void Naloga15()
        {
            /* Naloga 2.1.0.6. Napisite program, ki preveri ali je dano celo stevilo deljivo s 3, s 5, obema ali pa ni deljivo z nobenim od teh dveh stevil. Odgovor naj se izpise na zaslonu. */

            int x = 12;
            if (x % 3 == 0 && x % 5 == 0)
            {
                Console.WriteLine("Deljivo je s 3 in 5");
            }
            else if (x % 5 == 0)
            {
                Console.WriteLine("Deljivo je s 5");
            }
            else if (x % 3 == 0)
            {
                Console.WriteLine("Deljivo je s 3 ");
            }
            else
            {
                Console.WriteLine("Deljivo ni z nobenim");
            }
        }
        public static void Naloga16()
        {
            /* Naloga 2.1.0.7. Napisite program, ki za dana tri stevila izpise ali obstaja trikotnik s temi dolzinami stranic. Tak trikotnik obstaja, ce dolzine stranic ustrezajo tako imenovani trikotniski neenakosti, ki pravi, da je vsota dolzin poljubnih dveh stranic vedno vecja od dolzine tretje stranice. */

            int x = 10;
            int y = 11;
            int z = 13;

            if (x + y > z && x + z > y && y + z > x) Console.WriteLine($"Obstaja trikotnik s stranicami: {x}, {y} in {z}");
            else Console.WriteLine($"trikotnik s stranicami: {x}, {y} in {z} ne obstaja");

        }
        public static void Naloga17()
        {
            /* Naloga 2.1.0.8. Napisite program, ki za dano crko crko na zaslon izpise ali je crka soglasnik ali samoglasnik. Pri tem upostevajte tako male, kot velike crke. */

            char crka = 'A';
            switch (crka)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine("Črka " + crka + " je samoglasnik");
                    break;
                default:
                    Console.WriteLine("Črka " + crka + " ni samoglasnik");
                    break;
            }

        }
        public static void Naloga18()
        {
            /* Naloga 2.1.0.9. Napisite program, ki za dano celo stevilo n med 1 in 7 izpise ime n-tega dneva v tednu. */

            int danVTednu = 8;
            if (danVTednu == 1) Console.WriteLine($"{danVTednu}. dan v tednu je ponedeljek");
            else if (danVTednu == 2) Console.WriteLine($"{danVTednu}. dan v tednu je torek");
            else if (danVTednu == 3) Console.WriteLine($"{danVTednu}. dan v tednu je sreda");
            else if (danVTednu == 4) Console.WriteLine($"{danVTednu}. dan v tednu je četrtek");
            else if (danVTednu == 5) Console.WriteLine($"{danVTednu}. dan v tednu je petek");
            else if (danVTednu == 6) Console.WriteLine($"{danVTednu}. dan v tednu je sobota");
            else if (danVTednu == 7) Console.WriteLine($"{danVTednu}. dan v tednu je nedelja");
            else Console.WriteLine($"{danVTednu} dan v tednu ne obstaja");

        }
        public static void Naloga19()
        {
            /* Naloga 2.1.0.10. Napisite program, ki za dano pozitivno celo stevilo leto izpise ali je leto prestopno ali ne. Leto je prestopno, ce je deljivo s 4, razen v primeru, ko je deljivo s 100 in ni deljivo s 400. */

            int leto = 1992;
            if (leto % 4 == 0 && leto % 100 != 0 || leto % 100 == 0 && leto % 400 == 0)
            {
                Console.WriteLine("Leto " + leto + " je prestopno");
            }
            else
            {
                Console.WriteLine("Leto " + leto + " ni prestopno");
            }

        }
        public static void Naloga20()
        {
            /* Naloga 2.1.0.11. Napisite program, ki za dan datum sestavljen iz treh danih celostevilskih vrednosti (dan, mesec, leto) preveri ali je datum veljaven (to je, stevilka meseca in stevilo dni v mesecu je ustrezno) in, ce je, izpisete datum na zaslon in ali je leto prestopno. */

            int dan = 31;
            int mesec = 3;
            int leto = 2024;

            if (leto > 0 && mesec > 0 && dan > 0 && mesec < 13)
            {
                //preverimo za 29ga februarja ker je možno samo na prestopna leta

                if (leto % 4 == 0 && leto % 100 != 0 || leto % 100 == 0 && leto % 400 == 0)
                {
                    Console.WriteLine("Leto je prestopno");
                    if (mesec == 2)
                    {
                        if (dan <= 29)
                            Console.WriteLine($"{dan}.{mesec}.{leto} datum je veljaven");
                        else Console.WriteLine($"{dan}.{mesec}.{leto} datum ni veljaven");
                    }
                }
                else
                {
                    if (mesec == 2)
                    {
                        if (dan <= 28)
                            Console.WriteLine($"{dan}.{mesec}.{leto} datum je veljaven");
                        else Console.WriteLine($"{dan}.{mesec}.{leto} datum ni veljaven");
                    }
                }

                // preverimo za mesece z 31 možnimi dnevi
                if (mesec == 1 || mesec == 3 || mesec == 5 || mesec == 7 || mesec == 8 || mesec == 10 || mesec == 12)
                {
                    if (dan <= 31)
                        Console.WriteLine($"{dan}.{mesec}.{leto} datum je veljaven");
                    else Console.WriteLine($"{dan}.{mesec}.{leto} datum ni veljaven");
                }

                //preverimo za mesece z 30 možnimi dnevi
                if (mesec == 4 || mesec == 6 || mesec == 9 || mesec == 11 || mesec == 10 || mesec == 12)
                {
                    if (dan <= 30)
                        Console.WriteLine($"{dan}.{mesec}.{leto} datum je veljaven");
                    else Console.WriteLine($"{dan}.{mesec}.{leto} datum ni veljaven");
                }
            }
            else
            {
                Console.WriteLine($"{dan}.{mesec}.{leto} datum ne obstaja");
            }

        }
        public static void Naloga21()
        {
            /* Naloga 2.2.0.1. Deklarirajte poljubno celostevilsko spremenljivko. Nato uporabite ternarni operator (pogojni izraz), da v spremenljivko za nize shranite vrednost “sodo”, ce je stevilo sodo in “liho”, sicer. Rezultat izpiˇsite na zaslon. */

            //pogoj ? izraz1 : izraz2
            int x = 5;
            string sodoLiho = x % 2 == 0 ? "sodo" : "liho";
            Console.WriteLine(sodoLiho);
        }
        public static void Naloga22()
        {
            /* Naloga 2.2.0.2. Deklarirajte dve celostevilski spremenljivki in uporabite ternarni operator, da v novi spremenljivki z imenom min in max shranite manjse, oziroma vecje izmed njiju. Oba rezultata izpisite na zaslon. */

            int x = 10;
            int y = -3;
            int min = x < y ? x : y;
            int max = x < y ? y : x;

            Console.WriteLine($"min: {min}, max: {max}");
        }
        public static void Naloga23()
        {

            /* Naloga 2.2.0.3. S pomocjo ternarnega operatorja na zaslon izpisite absolutno vrednost danega stevila. */

            int x = -10;
            int absolutniX = x >= 0 ? x : -x;
            Console.WriteLine("Absolutno število x: " + absolutniX);

        }
        public static void Naloga24()
        {
            /* Naloga 2.2.0.4. Deklarirajte poljuben znak in z uporabo ternarnega operatorja shranite v novo spremenljivko za nize vrednost “crka”, ce je znak crka angleske abecede in prazen niz, sicer. */

            char znak = 'a';
            string cr = ((znak >= 'A' && znak <= 'Z') || (znak >= 'a' && znak <= 'z')) ? znak.ToString() : " ";
            Console.WriteLine(cr);

        }
        public static void Naloga25()
        {
            /* Naloga 2.3.0.1. Z uporabo stavka switch za dano starost osebe preverite ali se lahko udelezi volitev ali ne. */

            int starost = 17;

            switch (starost)
            {
                case <= 17:
                    Console.WriteLine("Ne");
                    break;
                default:
                    Console.WriteLine("Da");
                    break;
            }
        }
        public static void Naloga26()
        {
            /* Naloga 2.3.0.2. Z uporabo stavka switch na zaslon izpisite ali je dano stevilo sodo ali liho. */

            int x = 11;
            int ostanek = x % 2;
            switch (x % 2 == 0)
            {
                case true:
                    Console.WriteLine("Sodo");
                    break;
                default:
                    Console.WriteLine("liho");
                    break;
            }
        }
        public static void Naloga27()
        {
            /* Naloga 2.3.0.3. Z uporabo stavka switch preverite ali je dana crka samoglasnik ali soglasnik. Nalogo resite tako, da uporabite le dva jedrna dela. */

            char crka = 'x';
            switch (crka)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine("Črka " + crka + " je samoglasnik");
                    break;
                default:
                    Console.WriteLine("Črka " + crka + " ni samoglasnik");
                    break;
            }

        }
        public static void Naloga28()
        {
            /* Naloga 2.3.0.4. Z uporabo stavka switch za dano celo stevilo n med 1 in 7 izpisite ime n-tega dneva v tednu. */

            int danVTednu = 2;
            switch (danVTednu)
            {
                case 1:
                    Console.WriteLine($"{danVTednu}. dan v tednu je ponedeljek");
                    break;
                case 2:
                    Console.WriteLine($"{danVTednu}. dan v tednu je torek");
                    break;
                case 3:
                    Console.WriteLine($"{danVTednu}. dan v tednu je sreda");
                    break;
                case 4:
                    Console.WriteLine($"{danVTednu}. dan v tednu je četrtek");
                    break;
                case 5:
                    Console.WriteLine($"{danVTednu}. dan v tednu je petek");
                    break;
                case 6:
                    Console.WriteLine($"{danVTednu}. dan v tednu je sobota");
                    break;
                case 7:
                    Console.WriteLine($"{danVTednu}. dan v tednu je nedelja");
                    break;
                default:
                    Console.WriteLine($"{danVTednu}. dan v tednu ne obstaja");
                    break;
            }


        }
        public static void Naloga29()
        {
            /* Naloga 2.3.0.5. Uporabite stavek switch, da ustvarite preprost kalkulator, to je, da sestejete, odˇstejete, pomnozite, delite ali pa izracunate ostanek pri deljenju za dve poljubno izbrani celi stevili glede na moˇzne znake (+, −, ∗, /, %). */

            double stevilo1 = 5.1;
            double stevilo2 = 1.2;
            char operacija = '*';

            switch (operacija)
            {
                case '+':
                    Console.WriteLine(stevilo1 + stevilo2);
                    break;
                case '-':
                    Console.WriteLine(stevilo1 - stevilo2);
                    break;
                case '/':
                    Console.WriteLine(stevilo1 / stevilo2);
                    break;
                case '*':
                    Console.WriteLine(stevilo1 * stevilo2);
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
        public static void Naloga30()
        {
            /* Naloga 2.3.0.6. Deklarirajte spremenljivko ocena in ji kot vrednost podajte celostevilsko oceno, ki jo pricakujete pri tem predmetu. Nato s pomocjo stavka switch izpisite opisno ime vase pricakovane ocene (≤ 5 - nezadostno, 6 - zadostno, 7 - dobro, 8 in 9 - prav dobro in 10 - odlicno). V programu uporabite primerjalni vzorec. */

            int ocena = 8;

            switch (ocena)
            {
                case 10:
                    Console.WriteLine("odlično");
                    break;
                case 9:
                case 8:
                    Console.WriteLine("prav dobro");
                    break;
                case 7:
                    Console.WriteLine("dobro");
                    break;
                case 6:
                    Console.WriteLine("zadostno");
                    break;
                default:
                    Console.WriteLine("nezadostno");
                    break;
            }

        }
        public static void Naloga31()
        {
            /* Naloga 3.0.0.1. Izracunajte vsoto prvih desetih naravnih stevil z uporabo vseh treh zank. */

            int vsota = 0;
            for (int i = 0; i <= 10; i++)
            {
                vsota += i;
            }
            Console.WriteLine("Vsota izračunana s for zanko:" + vsota);

            vsota = 0;
            int stevka = 0;
            while (stevka <= 10)
            {
                vsota += stevka;
                stevka++;
            }
            Console.WriteLine("Vsota izračunana s while zanko:" + vsota);

            vsota = 0;
            stevka = 0;
            do
            {
                vsota += stevka;
                stevka++;
            } while (stevka <= 10);
            Console.WriteLine("Vsota izračunana s do while zanko:" + vsota);

        }
        public static void Naloga32()
        {
            /* Naloga 3.0.0.2. Izpisite vsa soda stevila manjsa od 100 z uporabo zanke for. */

            Console.Write("Sode števke manjše od 100:");
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0) Console.Write(" " + i);
            }

            Console.WriteLine("");

        }
        public static void Naloga33()
        {
            /* Naloga 3.0.0.3. Za dano pozitivno celo stevilo izracunajte vsoto njegovih stevk z uporabo
            zanke while. */

            int x = 100;
            int vsota = 0;
            int stevka = 0;

            while (stevka <= x)
            {
                vsota += stevka;
                stevka++;
            }
            Console.WriteLine($"Vsota vseh števk celega števila {x} je {vsota}");

        }
        public static void Naloga34()
        {
            /* Naloga 3.0.0.4. Generator nakljucnih stevil deklariramo z ukazom
                Random <imeSpremenljivke> = new Random();.
                Nakljucno vrednost lahko zgeneriramo z ukazom
                <imeSpremenljivke>.Next(<min>,<max>),
                ki vzame nakljucno vrednost med vkljucno z min in izkljucno z max. Z uporabo zanke
                do-while napisite kodo, ki bo nakljucno generirala stevila od 0 do 100 in jih izpisovala na
                zaslon. Izpisovanje naj se zakljuci, ko je zgenerirana vrednost vecja od 90. Na koncu naj
                se izpise stevilo vseh zgeneriranih nakljucnih vrednosti. */

            int stevec = 0;
            Random nakljucnaStevilka = new Random();
            int nakljStev;

            do
            {
                nakljStev = nakljucnaStevilka.Next(0, 100);
                stevec++;
                Console.Write(" " + nakljStev);
            } while (nakljStev < 90);

            Console.WriteLine();
            Console.WriteLine($"Število zgeneriranih naključnih vrednosti je: {stevec}");


        }
        public static void Naloga35()
        {
            /* Naloga 3.0.0.5. Izpisite vsa pozitivna cela stevila manjsa od 200, ki so deljiva z 2 in niso deljiva s 5. */

            for (int i = 0; i < 200; i++)
            {
                if (i % 2 == 0 && i % 5 != 0) Console.Write(" " + i);
            }

            Console.WriteLine();
        }
        public static void Naloga36()
        {
            /* Naloga 3.0.0.6. Deklarirajte celostevilsko spremenljivko n in izracunajte vsoto vseh stevil manjsih ali enakih n, ki so deljiva s 3 ali s 5. */

            int x = 100;
            int vsota = 0;

            for (int i = 0; i <= x; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    vsota += i;
                }
            }

            Console.WriteLine($"Vsota vseh števil manjših ali enakih {x}, ki so deljiva z 3 ali 5 je: {vsota}");
        }
        public static void Naloga37()
        {
            /* Naloga 3.0.0.7. Napisite program, ki stevke danega celega stevila zapise v obratnem vrstnem redu. */
            int n = 12345678;
            int obrnjenaStevka = 0;

            while (n != 0)
            {
                obrnjenaStevka += n % 10;
                obrnjenaStevka *= 10;
                n = n / 10;
            }
            obrnjenaStevka = obrnjenaStevka / 10;
            Console.WriteLine($" Obrnjeno število je: {obrnjenaStevka}");
        }
        public static void Naloga38()
        {
            /* Naloga 3.0.0.8. Napisite program, ki za dano celo stevilo preveri ali je palindrom. Palindrom je zaporedje znakov, ki je enako, ce ga beremo iz leve proti desni ali iz desne proti levi. */

            int n = 12321;
            int obrnjenaStevka = 0;
            int kopija = n;
            while (n != 0)
            {
                obrnjenaStevka += n % 10;
                obrnjenaStevka *= 10;
                n = n / 10;
            }
            obrnjenaStevka = obrnjenaStevka / 10;

            if (kopija == obrnjenaStevka) Console.WriteLine($"Število {kopija} je palindrom");
            else Console.WriteLine($"Število {kopija} ni palindrom");


        }
        public static void Naloga39()
        {
            /* Naloga 3.0.0.9. Izpisite vsa razlicna 4-mestna naravna stevila sestavljena iz stevk 1, 2, 3, 4
            in 5. Izpisite tudi stevilo takih stevil. */

            int count = 0;

            // Zanka za prvo števko (tisočice)
            for (int a = 1; a <= 5; a++)
            {
                for (int b = 1; b <= 5; b++)
                {
                    if (b == a) continue;
                    for (int c = 1; c <= 5; c++)
                    {
                        if (c == a || c == b) continue;
                        for (int d = 1; d <= 5; d++)
                        {
                            if (d == a || d == b || d == c) continue;
                            int number = a * 1000 + b * 100 + c * 10 + d;
                            Console.WriteLine(number);
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine("Skupno število: " + count);
        }
        public static void Naloga40()
        {
            /* Naloga 3.0.0.10. Za dano pozitivno celo stevilo n izpisite vsa Fibonaccijeva stevila, ki so manjsa od n. */

            int a = 1;
            int b = 1;
            int x = 1230;
            int temp;
            Console.WriteLine($"Vsa števila v Fibonacci zaporedju manjša od {x}: ");
            Console.Write(" " + a + " " + b);
            while (a + b < x)
            {
                temp = a + b;
                a = b;
                b = temp;
                Console.Write(" " + temp);
            }
        }
        public static void Naloga41()
        {
            /* Naloga 3.0.0.11. Izracunajte vsoto vseh trimestnih stevil, ki vsebujejo stevko 1. Nato izracunajte vsoto vseh trimestnih stevil, ki vsebujejo natanko eno stevko 1. */

            int vsota1 = 0;
            int vsota2 = 0;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        if (a == 1 || b == 1 || c == 1)
                        {
                            int number = a * 100 + b * 10 + c;
                            vsota1 += number;
                        }
                        bool pogoj1 = a == 1 && b != 1 && c != 1;
                        bool pogoj2 = a != 1 && b == 1 && c != 1;
                        bool pogoj3 = a != 1 && b != 1 && c == 1;

                        if (pogoj1 || pogoj2 || pogoj3)
                        {
                            int number = a * 100 + b * 10 + c;
                            vsota2 += number;
                        }
                    }
                }
            }
            Console.WriteLine($"Vsota vseh trimestnih stevil ki imajo vsaj eno stevko 1: {vsota1}");
            Console.WriteLine($"Vsota vseh trimestnih stevil ki imajo samo eno stevko 1: {vsota2}");
        }
        public static void Naloga42()
        {
            /* Naloga 3.0.0.12. Za pozitivno celo stevilo, ki ga vnese uporabnik, izpisite vse lihe stevke in vsoto sodih stevk, do prve pojavitve stevke 0. Pri tem lahko uporabite samo if stavke in nobenega else ali else if stavka. */
            Console.Write("Vnesi pozitivno celo število:");
            int n = Convert.ToInt32(Console.ReadLine());
            int vsota = 0;

            while (n % 10 != 0)
            {
                int ostanek = n % 10;
                if (ostanek % 2 == 0)
                {
                    vsota += ostanek;
                    n = n / 10;
                    continue;
                }
                if (ostanek % 2 == 1)
                {
                    Console.Write(" " + ostanek);
                    n = n / 10;
                    continue;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Vsoda sodih števil do števke 0 je: {vsota}");
        }
        public static void Naloga43()
        {
            /* Naloga 3.0.0.13. Za dano pozitivno celo stevilo n, ki ga vnese uporabnik, na zaslon izpisite vsa soda stevila manjsa ali enaka n, ter stevilo vseh lihih stevil od 1 do vkljucno z n. Pri tem lahko uporabite le if stavek in nobenega else ali else if stavka. */

            Console.Write("Vnesi pozitivno celo število:");
            int n = Convert.ToInt32(Console.ReadLine());
            int stevec = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    stevec++;
                    continue;
                }
                if (i % 2 == 0)
                {
                    Console.Write(" " + i);
                    continue;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"od 1 do {n} je {stevec} lihih stevil.");
        }
        public static void Naloga44()
        {
            /* Naloga 3.0.0.14. V vsaki od vrstic 1 do 9 izpisite vse stevke z izjemo i-te stevke, kjer je i zaporedna stevilka vrstice. V 3. vrstici bi se tako izpisalo 012456789. Uporabite lahko le if stavek in nobenega else ali else if stavka. */

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    Console.Write(" " + j);
                }
                Console.WriteLine();
            }
        }
        public static void Naloga45()
        {
            /*Naloga 3.0.0.15. Izpisite vsa stevila manjsa od 1000, za katera so vsi delitelji razlicni od 1 sodi. Uporabite lahko le if stavek in nobenega else ali else if stavka. */
            bool sodo = true;
            Console.WriteLine("Števila manjša od 1000 s samo sodimi deljitelji:");
            for (int i = 2; i < 1000; i++)
            {

                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0 && j % 2 != 0)
                    {
                        sodo = false;
                        break;
                    }
                }
                if (sodo) Console.Write(" " + i);
                sodo = true;
            }
        }
        public static void Naloga46()
        {
            /* Naloga 3.1.0.1. Na zaslon z zvezdicami izrisite kvadrat visine n, kjer stevilo n vnese
            uporabnik.
            Primer za n = 5:
            *****
            *****
            *****
            *****
            *****
            */


            int n = 5;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void Naloga47()
        {
            /* Naloga 3.1.0.2. Na zaslon z zvezdicami izrisite okvir kvadrata visine n, kjer stevilo n
                vnese uporabnik.
                Primer za n = 5:
                *****
                *   *
                *   *
                *   *
                *****
                */

            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || j == n - 1 || i == 0 || i == n - 1) Console.Write("*");
                    else Console.Write(" ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void Naloga48()
        {
            /* Naloga 3.1.0.3. Na zaslon z zvezdicami izrisite velik X visine n, kjer stevilo n vnese
                uporabnik. Program naj deluje vsaj za lihe vrednosti n.
                Primer za n = 5:

                *   *
                 * *
                  *
                 * *
                *   *

                 */
            int n = 5;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    //|| j == n - i
                    if (j == i || j == n - 1 - i) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public static void Naloga49()
        {
            /* Naloga 3.1.0.4. Na zaslon z zvezdicami izriˇsite zgornji levi trikotnik visine n, kjer stevilo
            n vnese uporabnik.
            Primer za n = 5:
            *****
            ****
            ***
            **
            *
            */

            int n = 5;
            for (int i = n; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void Naloga50()
        {
            /* Naloga 3.1.0.5. Na zaslon z zvezdicami izrisite spodnji levi trikotnik visine n, kjer stevilo
            n vnese uporabnik.
            Primer za n = 5:
            *
            **
            ***
            ****
            *****
            */

            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void Naloga51()
        {
            /* Naloga 3.1.0.6. Na zaslon z zvezdicami izrisite zgornji desni trikotnik visine n, kjer stevilo n vnese uporabnik.
               Primer za n = 5:
               *****
                ****
                 ***
                  **
                   *
               */
            int n = 5;
            for (int i = n; i > 0; i--)
            {

                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void Naloga52()
        {
            /* Naloga 3.1.0.7. Na zaslon z zvezdicami izrisite spodnji desni trikotnik visine n, kjer stevilo n vnese uporabnik.
                Primer za n = 5:

                    *
                   **
                  ***
                 ****
                *****
                */
            int n = 5;
            for (int i = n; i > 0; i--)
            {
                for (int k = i - 1; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = n - i; j >= 0; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        public static void Naloga53()
        {
            /* Naloga 3.1.0.8. Na zaslon z zvezdicami izrisite piramido visine n, kjer stevilo n vnese uporabnik. Program naj deluje vsaj za lihe vrednosti n.
            Primer za n = 5:
                *
               ***
              *****
             *******
            *********
            */

            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Naloga54()
        {
            /* Naloga 3.1.0.9. Na zaslon z zvezdicami izrisite obrnjeno piramido visine n, kjer stevilo n vnese uporabnik. Program naj deluje vsaj za lihe vrednosti n.
                Primer za n = 5:
                *********
                 *******
                  *****
                   ***
                    *
                    *
                */
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * (n - i) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
        public static void Naloga55()
        {
            /* Naloga 3.1.0.10. Na zaslon z zvezdicami izrisite diamant visine n, kjer stevilo n vnese uporabnik. Program naj deluje vsaj za lihe vrednosti n.
                Primer za n = 7:
                *
                ***
                *****
                *******
                *****
                ***
                *
                */

            int n = 7;
            for (int i = 0; i <= n / 2; i++)
            {
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = (n / 2) + 2; i > 0; i -= 2)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Naloga56()
        {
            /* Naloga 3.1.0.11. Na zaslon z zvezdicami izrisite pesceno uro visine n, kjer stevilo n vnese
                        uporabnik. Program naj deluje vsaj za lihe vrednosti n.
                        Primer za n = 7:
                        10
                        *******
                         *****
                          ***
                           *
                          ***
                         *****
                        *******
                        */
        }
        public static void Naloga57()
        {
            /* Naloga 3.1.0.12. Na zaslon z zvezdicami izriˇsite rob diamanta visine n, kjer stevilo n vnese uporabnik. Program naj deluje vsaj za lihe vrednosti n.
                Primer za n = 7:
                   *
                  * *
                 *   *
                *     *
                 *   *
                  * *
                   *
                */
        }
        public static void Naloga58()
        {
            /* Naloga 3.1.0.13. Na zaslon z zvezdicami izrisite metuljcka visine n, kjer stevilo n vnese uporabnik. Program naj deluje vsaj za lihe vrednosti n.
               Primer za n = 7:

               *     *
               **   **
               *** ***
               *******
               *** ***
               **   **
               *     *

                */
        }
        public static void Naloga59()
        {
            /* Naloga 3.1.0.14. Na zaslon izrisite vzorec sahovnice sestavljen iz 2 × 2 praznih crnih kvadratkov in 2 × 2 belih kvadratkov sestavljenih iz zvezdic.Velikost sahovnice naj vnese uporabnik.
            Primer za ˇsahovnico velikosti 4 × 4:
            **  **
            **  **
              **  **
              **  **
            **  **
            **  **
              **  **
              **  **
            */
        }
        public static void Naloga60()
        {
            /* Naloga 3.2.0.1. Napisite program za igranje igre ugibanja stevila. Stevilo naj se zgenerira samodejno z uporabo generatorja Random (glej nalogo 3.0.0.4), kjer uporabnik sam odloci najvecje mozno stevilo. Nato naj uporabnik vnasa stevila dokler ne ugane iskanega stevila. Ob vsakem ugibanju mora program uporabniku povedati ali je iskano stevilo vecje ali manjse od vnesenega stevila, ce pa je uporabnik uganil iskano stevilo, mu program izpise koliko poskusov je potreboval, da je stevilo uganil. 
            */
            Random random = new Random();
            Console.Write("Določi največje možno število: ");
            int najvecjeMozno = Convert.ToInt32(Console.ReadLine());

            int randomStevilka = random.Next(0, najvecjeMozno + 1);
            int stevec = 1;
            while (true)
            {
                Console.Write($"Zgeneriral sem neko random stevilo med 0 in {najvecjeMozno}. Ugani ga! ");
                int uganjenaStevilka = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (uganjenaStevilka > randomStevilka)
                {
                    Console.WriteLine("V mislih imam manjšo številko");
                    stevec++;
                    continue;
                }
                if (uganjenaStevilka < randomStevilka)
                {
                    Console.WriteLine("V mislih imam večjo številko");
                    stevec++;
                    continue;
                }
                else
                {
                    Console.WriteLine($"Bravo! Zgeneriral sem številko {randomStevilka}. Potreboval si {stevec} poizkusov");
                    break;
                }

            }
        }


    }
}
