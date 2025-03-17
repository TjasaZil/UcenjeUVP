namespace TabeleInSeznami
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

            //VAJE


            //Naloga6();
            //Naloga7();
            //Naloga8();
            //Naloga9();
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
            Naloga23();
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

            Console.ReadKey();

        }

        public static void Naloga1()
        {
            /* Naloga 5.1.2.1. Ustvarite tabelo znakov s 25 polji in vanjo zapisite vse (velike) znake slovenske abecede. */
            char[] tabela;
            tabela = new char[26];
            int stevec = 0;
            char x = 'A';

            do
            {
                tabela[stevec] = x;
                stevec++;
                x++;
            }
            while (stevec != 26);
            Console.WriteLine(tabela);

        }
        public static void Naloga2()
        {
            /* Naloga 5.1.2.2. Ustvarite tabelo celih stevil s 40 polji in vanjo zapisite zacetnih 40 vrednosti Fibonaccijevega zaporedja. Pokusite storiti enako v vecji tabeli za prvih 100 vrednosti zaporedja. Izpisite jih in preverite, ce je z njimi vse v redu. Kaj je tezava? */
            long[] tabela;
            tabela = new long[40];
            long a = 1;
            long b = 1;
            tabela[0] = a; tabela[1] = b;

            for (int i = 2; i < tabela.Length; i++)
            {

                tabela[i] = a + b;
                a = b;
                b = tabela[i];


            }

            Console.WriteLine("Prvih 40 števil Fibonaccijevega zaporedja: " + string.Join(", ", tabela));

            long[] tabelaDolga;
            tabelaDolga = new long[100];
            a = 1;
            b = 1;
            tabelaDolga[0] = a; tabelaDolga[1] = b;
            for (int i = 2; i < tabelaDolga.Length; i++)
            {
                tabelaDolga[i] = a + b;
                a = b;
                b = tabelaDolga[i];
            }
            //začne metati ven negativne številke, ker so tako dolge/velike cifre
            Console.WriteLine("Prvih 100 števil Fibonaccijevega zaporedja: " + string.Join(", ", tabelaDolga));
        }
        public static void Naloga3()
        {
            /* Naloga 5.1.2.3. Ustvarite dvodimenzionalno tabelo, ki bo predstavljala figure na sahovski plosci. Figuro in njeno barvo predstavite z dvema crkama, npr. beli kralj dobi oznako “bK”. Prazna polja oznacite z dvema presledkoma, ce so bela, oziroma z dvema posevnicama, ce so crna. Elemente tabele tudi izpisite in pazite na razmike med polji (dodajte ustrezno stevilo presledkov). Za lepsi izpis lahko dodate se stevilke vrstic in oznake stolpcev (od A do H). */
            string[] tabelaCrk = ["   ", " A ", " B ", " C ", " D ", " E ", " F ", " G ", " H ", "   "];
            string[] beleFigure = ["bT ", "bkn", "bt ", "bK ", "bkr", "bt ", "bkn", "bT"];
            string[] crneFigure = ["cT ", "ckn", "ct ", "cK ", "ckr", "ct ", "ckn", "cT"];
            string[][] sahovnica = new string[10][];
            for (int i = 0; i < 10; i++)
            {
                sahovnica[i] = new string[10];
                for (int y = 0; y < 10; y++)
                {
                    //tole je da izpiše črke:
                    if (i == 0 || i == 9)
                    {
                        sahovnica[i][y] = tabelaCrk[y];

                    }
                    else if (y == 0 || y == 9)
                    {
                        sahovnica[i][y] = tabelaCrk[i];

                    }
                    //tole nariše prazna bela in črna polja
                    else if (i > 2 && i < 7)
                    {
                        if (i % 2 == 0 && y % 2 != 0) sahovnica[i][y] = "// ";
                        else if (i % 2 != 0 && y % 2 == 0) sahovnica[i][y] = "// ";
                        else sahovnica[i][y] = "   ";

                    }
                    //napise crne in bele kmete
                    else if (i == 2) sahovnica[i][y] = "ck ";
                    else if (i == 7) sahovnica[i][y] = "bk ";
                    else if (i == 1) sahovnica[i][y] = crneFigure[y - 1];
                    else if (i == 8) sahovnica[i][y] = beleFigure[y - 1];


                    Console.Write(sahovnica[i][y]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
        public static void Naloga4()
        {
            /* Naloga 5.2.1.1. Zapisite kodo, ki bo v dani seznam zapisala vsa prastevila od 1 do izbranega stevila n.*/
            int n = 100;
            List<int> seznamPrastevil = new List<int>();
            //int[] tabela = new int[n];
            bool jePrastevilo = false;
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0 && j != 1)
                    {
                        jePrastevilo = true;
                        break;
                    }
                }
                if (!jePrastevilo)
                {
                    seznamPrastevil.Add(i);
                }
                jePrastevilo = false;
            }
            Console.WriteLine("praštevila do " + n + ": ");
            foreach (var prastevilo in seznamPrastevil)
            {
                Console.Write(" " + prastevilo);
            }
            Console.WriteLine();
        }
        public static void Naloga5()
        {
            /* Naloga 5.2.1.2. Seznam lahko kot tip vrednosti prejme katerikoli tip. Tudi drug seznam. Kako bi to dejstvo uporabili pri kreiranju nakupovalnega seznama, ki poleg produktov, ki jih zelite kupiti, navedete se njihovo kolicino? Na primer, 3kg makaronov, 5 zemelj in 12 jajc. */
            List<(int kolicina, string ime)> nakupovalniSeznam = new List<(int, string)>() {
            (3, "kg makaronov"),
            (5, "zemelj"),
            (12, "jajc")
            };
            Console.WriteLine("Nakupovalni seznam:");
            foreach (var par in nakupovalniSeznam)
            {
                Console.Write(par.kolicina + " " + par.ime);
                Console.WriteLine();
            }
        }
        public static void Naloga6()
        {
            /* Naloga 4.0.0.1. Deklarirajte tabelo poljubnega tipa in izpisite prvi in zadnji element. */

            int[] tabela = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            Console.WriteLine("Prvi element v tabeli: " + tabela[0] + " Zadnji element v tabeli: " + tabela[tabela.Length - 1]);
        }
        public static void Naloga7()
        {
            /* Naloga 4.0.0.2. Deklarirajte tabelo poljubnega tipa in izpisite vse njene elemente. */
            int[] tabela = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            Console.Write("Vsi elementi tabele:");
            foreach (var tab in tabela)
            {
                Console.Write(" " + tab);
            }
            Console.WriteLine();
        }
        public static void Naloga8()
        {
            /* Naloga 4.0.0.3. Tabelo iz prejsnje naloge izpisite se v obratnem vrstnem redu. */
            int[] tabela = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            Console.Write("Vsi elementi tabele v obratnem vrstnem redu:");

            for (int i = 9; i >= 0; i--)
            {
                Console.Write(" " + tabela[i]);
            }
            Console.WriteLine();

        }
        public static void Naloga9()
        {
            /* Naloga 4.0.0.4. Deklarirajte tabelo poljubnega tipa in ji zamenjajte vrstni red elementov.*/

            int[] tabela = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];
            int temp;
            int j = tabela.Length - 1;

            for (int i = 0; i <= j; i++)
            {

                temp = tabela[j];
                tabela[j] = tabela[i];
                tabela[i] = temp;
                j--;
            }
            Console.WriteLine("Obrnjena tabela: " + string.Join(", ", tabela));
        }
        public static void Naloga10()
        {
            /* Naloga 4.0.0.5. Za dano tabelo celih stevil izpisite indeks elementa, ki ga vnese uporabnik, ce le ta obstaja. Sicer izpisite, da element ne obstaja. */

            Console.Write("Vnesite celo število: ");
            int vnesenoStevilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] tabela = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];
            int index;
            bool najdenIndex = false;
            for (int i = 0; i <= tabela.Length - 1; i++)
            {
                if (tabela[i] == vnesenoStevilo)
                {
                    Console.Write("Vneseno stevilo je v tabeli na mestu z indeksom: " + i);
                    najdenIndex = true;
                    break;
                }
            }
            if (!najdenIndex)
            {
                Console.WriteLine("Element ne obstaja");
            }
            najdenIndex = false;
        }

        public static void Naloga11()
        {
            /* Naloga 4.0.0.6. Deklarirajte poljubno celostevilsko tabelo in izpisite vsoto vseh lihih elementov v tabeli. */

            int[] tabela = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];
            int vsota = 0;

            foreach (int i in tabela)
            {
                if (i % 2 != 0) vsota += i;
            }
            Console.WriteLine($"Vsota vseh lihih elementov v tabeli je: {vsota}");
        }
        public static void Naloga12()
        {
            /* Naloga 4.0.0.7. Deklarirajte poljubno celostevilsko tabelo. Nato vsem sodim elementom zamenjajte vrednost na 0. */

            int[] tabela = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];

            for (int i = 0; i < tabela.Length; i++)
            {
                if (tabela[i] % 2 == 0) tabela[i] = 0;
            }
            Console.WriteLine("tabela z zamenjanimi sodimi števili: " + string.Join(", ", tabela));
        }
        public static void Naloga13()
        {
            /* Naloga 4.0.0.8. Deklarirajte poljubno celoˇstevilsko tabelo in iz nje izpisite vse elemente, ki so vecji od stevila, ki ga vnese uporabnik. */
            Console.Write("Vpišite pozitivno naravno celo število: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] tabela = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];
            Console.WriteLine();
            Console.Write($"Števila v tabeli, večja od vpisanega števila {x}: ");
            foreach (int i in tabela)
            {
                if (i > x) Console.Write(" " + i);
            }
            Console.WriteLine();
        }
        public static void Naloga14()
        {
            /* Naloga 4.0.0.9. Deklarirajte poljubno celostevilsko tabelo in v njej poiscite najvecji in najmanjsi element, ter indeks njune pozicije v tabeli. */

            int[] tabela = [42, 87, 19, 33, 56, 11, 74, 9, 61, 22, 39, 68, 55, 80, 3, 29, 47, 65, 91, 7];

            int min = tabela[0];
            int indexMin = 0;
            int max = tabela[0];
            int indexMax = 0;

            for (int i = 1; i < tabela.Length; i++)
            {
                if (tabela[i] < min)
                {
                    min = tabela[i];
                    indexMin = i;
                    continue;
                }
                if (tabela[i] > max)
                {
                    max = tabela[i];
                    indexMax = i;
                    continue;
                }
            }
            Console.WriteLine($"Najmanjše število v tabeli je {min} na indeksu {indexMin}, največje pa {max} na indeksu {indexMax}");
        }
        public static void Naloga15()
        {
            /* Naloga 4.0.0.10. Deklarirajte poljubno celostevilsko tabelo in iz nje izpisite n-to zaporedno sodo stevilo, kjer stevilo n vnese uporabnik. Ce je n vecji od stevila sodih elementov v tabeli, naj program izpise, da tako stevilo ne obstaja. */

            int[] tabela = [42, 87, 19, 33, 56, 11, 74, 9, 61, 22, 39, 68, 55, 80, 3, 29, 47, 65, 91, 7];

            Console.Write("Vnesi poljubno pozitivno celo število: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int steviloSodih = 0;
            int sodiIndex = 0;

            //preveri koliko je sodih in preveri dolžino tabele. Če je število sodih manjše od vpisane številke, ali če je tabela prekratka, vrne da ne more narest ničesar.
            foreach (int tab in tabela)
            {

                if (tab % 2 == 0) steviloSodih++;
            }
            if (x > steviloSodih || x > tabela.Length)
            {
                Console.WriteLine("Ne morem izpisati primernega sodega števila");
            }
            //če vse štima potem poiščemo cifro
            else
            {
                for (int i = 0; i < tabela.Length; i++)
                {
                    if (tabela[i] % 2 == 0) sodiIndex++;
                    if (sodiIndex == x)
                    {
                        Console.WriteLine($"{x}-to sodo število v tabeli je {tabela[i]}");
                        break;
                    }
                }
            }
        }
        public static void Naloga16()
        {
            /* Naloga 4.0.0.11. Deklarirajte poljubno celostevilsko tabelo. Nato naj uporabnik vnese poljubno stevilo in na zaslon izpisite indekse poljubnih dveh elementov tabele, ki se sestejeta v stevilo, ki ga je vnesel uporabnik. Ce taki stevili ne obstajata, naj program izpise, da taksne vsote ne moremo dobiti. */

            int[] tabela = [2, 8, 15, 21, 26, 34, 40, 49, 57, 63, 70, 76, 84, 88, 95, 6, 12, 18, 24, 30];

            //dva indexa pošljemo čez tabelo in seštevamo. loop v loopu; break če najdemo
            Console.Write("Vnesi poljubno pozitivno celo število: ");
            int x = Convert.ToInt32(Console.ReadLine());
            bool nasliVsoto = false;
            for (int i = 0; i < tabela.Length; i++)
            {
                for (int j = 0; j < tabela.Length; j++)
                {
                    if (j != i && tabela[j] + tabela[i] == x)
                    {
                        Console.WriteLine($"števki na indeksih {i} in {j} imata vsoto {x}");
                        nasliVsoto = true;
                        break;
                    }
                }
                if (nasliVsoto) break;
            }

            if (!nasliVsoto) Console.WriteLine($"Nobena kombinacija števil v tabeli ne vrne vsote {x}");
        }
        public static void Naloga17()
        {
            /* Naloga 4.0.0.12. Deklarirajte poljubno tabelo znakov. Nato izpisite vse razlicne znake, ki se pojavijo v tabeli. */

            //iz tabele pogledamo znake, definitamo listo, damo znak iz tabele v listo če tega znaka še ni v listi. Na koncu izpišemo listo.

            char[] tabela = ['A', 'M', 'F', 'B', 'X', 'K', 'R', 'T', 'Z', 'O', 'P', 'Q', 'S', 'J', 'E', 'U', 'I', 'C', 'D', 'L', 'N', 'W', 'G', 'Y', 'V', 'H', 'U', 'Z', 'M', 'R'];

            List<char> nepodvojenSeznam = new List<char>();

            foreach (char crka in tabela)
            {
                if (!nepodvojenSeznam.Contains(crka)) nepodvojenSeznam.Add(crka);
            }
            Console.Write("Različni znaki v tabeli: ");
            for (int i = 0; i < nepodvojenSeznam.Count(); i++)
            {
                Console.Write(" " + nepodvojenSeznam[i]);
            }
            Console.WriteLine();
        }
        public static void Naloga18()
        {
            /* Naloga 4.0.0.13. Deklarirajte poljubno tabelo znakov. Nato izpisite vse znake, ki se v tabeli pojavijo natanko enkrat. */
            char[] tabela = ['A', 'M', 'A', 'B', 'A', 'K', 'A', 'T', 'B', 'O', 'O', 'B', 'A', 'J', 'J', 'U', 'I', 'C', 'M', 'L', 'N', 'W', 'G', 'Y', 'V', 'H', 'U', 'Z', 'M', 'A'];
            List<char> unikatniSeznam = new List<char>();
            bool podvojenaCrka = false;
            for (int i = 0; i < tabela.Length; i++)
            {
                for (int j = 0; j < tabela.Length; j++)
                {
                    if (tabela[i] == tabela[j] && i != j)
                    {
                        podvojenaCrka = true;
                        break;
                    }

                }
                if (!podvojenaCrka) unikatniSeznam.Add(tabela[i]);

                podvojenaCrka = false;
            }
            Console.Write("Nepodvojeni znaki v tabeli: ");
            foreach (char crka in unikatniSeznam)
            {
                Console.Write(" " + crka);
            }
            Console.WriteLine();
        }
        public static void Naloga19()
        {
            /* Naloga 4.0.0.14. Deklarirajte poljubno tabelo osnovnega tipa in iz nje izpisite vse razlicne elemente, ki se v tabeli pojavijo vsaj dvakrat. */
            char[] tabela = ['A', 'M', 'A', 'B', 'A', 'K', 'A', 'T', 'B', 'O', 'O', 'B', 'A', 'J', 'J', 'U', 'I', 'C', 'M', 'L', 'N', 'W', 'G', 'Y', 'V', 'H', 'U', 'Z', 'M', 'A'];
            List<char> podvojeniSeznam = new List<char>();
            int stevec = 0;

            for (int i = 0; i < tabela.Length; i++)
            {
                for (int j = 0; j < tabela.Length; j++)
                {
                    if (tabela[i] == tabela[j] && i != j)
                    {
                        stevec++;
                        break;
                    }

                }
                if (stevec > 0 && !podvojeniSeznam.Contains(tabela[i])) podvojeniSeznam.Add(tabela[i]);

                stevec = 0;
            }
            Console.Write("Podvojeni znaki v tabeli: ");
            foreach (char crka in podvojeniSeznam)
            {
                Console.Write(" " + crka);
            }
            Console.WriteLine();

        }
        public static void Naloga20()
        {
            /* Naloga 4.0.0.15. Napisite program, ki elemente celostevilske tabele razvrsti po velikosti od najmanjsega do najvecjega. Na koncu tabelo izpisite na zaslon. */
            int[] tabela = [2, 8, 15, 21, 26, 34, 40, 49, 57, 63, 70, 76, 84, 88, 95, 6, 12, 18, 24, 30];

            for (int i = 0; i < tabela.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < tabela.Length; j++)
                {
                    if (tabela[j] < tabela[minIndex]) minIndex = j;
                }

                int temp = tabela[i];
                tabela[i] = tabela[minIndex];
                tabela[minIndex] = temp;
            }
            Console.Write("Urejena tabela:");

            foreach (int stevka in tabela)
            {
                Console.Write(" " + stevka);
            }
            Console.WriteLine();
        }

        public static void Naloga21()
        {
            /* Naloga 4.0.0.16. Za dano po velikosti urejeno celostevilsko tabelo poiscite indeks elementa, ki je enak poljubni dani vrednosti, ce ta obstaja, sicer poiscite indeks na katerega bi element postavili, da bi tabela ostala urejena. */
            int[] tabela = [2, 6, 8, 12, 15, 18, 21, 24, 26, 30, 34, 40, 49, 57, 63, 70, 76, 84, 88, 95];
            Console.Write("Vpišite poljubno pozitivno celo število: ");
            int x = Convert.ToInt32(Console.ReadLine());
            bool najdenIndeks = false;
            Console.WriteLine();
            for (int i = 0; i < tabela.Length; i++)
            {
                if ((tabela[i] == x))
                {
                    Console.WriteLine($"Število {x} je prisotno v tabeli na indeksu {i}");
                    najdenIndeks = true;
                    break;
                }
            }
            if (!najdenIndeks)
            {
                for (int i = 0; i < tabela.Length; i++)
                {
                    if ((tabela[i] > x))
                    {
                        Console.WriteLine($"Število {x} ni prisotno v tabeli, lahko bi ga vstavili na indeks {i}, tako da tabela ostane urejena.");
                        break;
                    }
                }
            }
        }
        public static void Naloga22()
        {
            /* Naloga 4.0.0.16. Za dano po velikosti urejeno celostevilsko tabelo poiscite indeks elementa, ki je enak poljubni dani vrednosti, ce ta obstaja, sicer poiscite indeks na katerega bi element postavili, da bi tabela ostala urejena. */

            int[] tabela = [2, 6, 8, 12, 15, 18, 21, 24, 26, 30, 34, 40, 49, 57, 63, 70, 76, 84, 88, 95];
            Console.Write("Vpišite poljubno pozitivno celo število: ");
            int x = Convert.ToInt32(Console.ReadLine());
            bool najdenIndeks = false;
            Console.WriteLine();
            for (int i = 0; i < tabela.Length; i++)
            {
                if ((tabela[i] == x))
                {
                    Console.WriteLine($"Število {x} je prisotno v tabeli na indeksu {i}");
                    najdenIndeks = true;
                    break;
                }
            }
            if (!najdenIndeks)
            {
                for (int i = 0; i < tabela.Length; i++)
                {
                    if ((tabela[i] > x))
                    {
                        Console.WriteLine($"Število {x} ni prisotno v tabeli, lahko bi ga vstavili na indeks {i}, tako da tabela ostane urejena.");
                        break;
                    }
                }
            }

        }

        public static void Naloga23()
        {
            /* Naloga 4.0.0.17. Deklarirajte dve po velikosti urejeni tabeli celih stevil in ju zdruzite v eno tabelo tako, da bodo njeni elementi prav tako urejeni po velikost. */
        }
        public static void Naloga24()
        {
            /* Naloga 4.0.0.18. Deklarirajte poljubno tabelo in njene elemente premaknite za n mest v desno, kjer je n pozitivno celo stevilo, ki ga vnese uporabnik. Na koncu izpisite elemente nove tabele. */
        }
        public static void Naloga25()
        {
            /* Naloga 4.0.0.19. Napisite program, ki bo od uporabnika zahteval vnos dolzine celostevilske tabele, nato pa se vnos njenih elementov, ter ustvaril tabelo s podanimi elementi. Dodatno omogocite uporabniku vnos vrednosti 0 ali 1, kjer 0 pomeni, da zeli izpisati vse sode elemente tabele in 1 pomeni, da zeli izpisati vse lihe elemente tabele. */
        }
        public static void Naloga26()
        {
            /* Naloga 4.0.0.20. Za dano celo stevilo n vecje ali enako 1 na zaslon izpisite prvih n vrstic Pascalovega trikotnika. Pascalov trikotnik nam pove koeficiente pri razsiritvi vsote dvoclenika na n-to potenco, to je (a + b)n. Kot namig, ker izracun vrednosti v posamezni vrstici sloni na predhodni vrstici, si lahko predhodno vrstico vsakic shranimo kot tabelo. */
        }
        public static void Naloga27()
        {
            /* Naloga 4.1.0.1. Deklarirajte poljubno dvodimenzionalno tabelo (tabelo tabel) in jo izpisite na zaslon. */
        }
        public static void Naloga28()
        {
            /* Naloga 4.1.0.2. Deklarirajte poljubno dvodimenzionalno tabelo in jo obrnite tako, da bodo vrstice postali stolpci in stolpci vrstice. Izpisite jo na zaslon. */
        }
        public static void Naloga29()
        {
            /* Naloga 4.1.0.3. Deklarirajte poljubno celostevilsko dvodimenzionalno tabelo in na zaslon izpisite vsote njenih elementov po stolpcih. */
        }
        public static void Naloga30()
        {
            /* Naloga 4.1.0.4. Ustvarite dvodimenzionalno tabelo, ki predstavlja postevanko do stevila 10 in jo izpisite na zaslon. */

        }

        public static void Naloga31()
        {
            /* Naloga 4.1.0.5. Napisite program, ki za dano dvodimenzionalno tabelo celih stevil preveri ali je simetricna preko glavne diagonale. Glavna diagonala se zacne levo zgoraj in konca desno spodaj. */
        }
        public static void Naloga32()
        {
            /* Naloga 4.1.0.6. Deklarirajte poljubno celostevilsko dvodimenzionalno tabelo z imenom tabela in ustvarite novo tabelo katere elementi naj bodo najmanjsi elementi posamezne vrstice tabele tabela. Na koncu tabelo izpisite na zaslon. */
        }
        public static void Naloga33()
        {
            /* Naloga 5.0.0.1. Ustvarite seznam prvih 10-ih naravnih stevil in ga izpisite. */
        }
        public static void Naloga34()
        {
            /* Naloga 5.0.0.2. V seznam iz prejsnje naloge vrinite stevilo 11 med stevili 5 in 6. */
        }
        public static void Naloga35()
        {
            /* Naloga 5.0.0.3. Napisite program, ki bo v danem celostevilskem seznamu preveril ali obstaja stevilo, ki ga vnese uporabnik. Program naj izpise vse pozicije tega elementa, ce le ta obstaja v seznamu, sicer naj izpise, da elementa ni mogoce najti. */
        }
        public static void Naloga36()
        {
            /* Naloga 5.0.0.4. Deklarirajte poljuben celostevilski seznam. Tega nato razdelite na seznam sodih in seznam lihih elementov. */
        }
        public static void Naloga37()
        {
            /* Naloga 5.0.0.5. Deklarirajte poljuben celo stevilski seznam in v njem poiscite najmanjsi element in ga izpisite. Izpisite tudi pozicijo tega elementa. */
        }
        public static void Naloga38()
        {
            /* Naloga 5.0.0.6. Napisite program, ki bo od uporabnika zahteval vnos nizov dokler uporabnik ne vnese niza ”X”. Nizi naj se shranjujejo v seznam, ki se na koncu izpise. */
        }
        public static void Naloga39()
        {
            /* Naloga 5.0.0.7. Deklarirajte poljuben seznam in napisite program, ki bo za dano pozitivno celo stevilo n ustvaril nov seznam, ki je sestavljen iz n kopij originalnega seznama. Kaj pa, ce zelimo originalni seznam le podaljsati in ne kreiramo novega seznama? */
        }
        public static void Naloga40()
        {
            /* Naloga 5.0.0.8. Deklarirajte poljuben seznam in zamenjajte prvi in zadnji element. */
        }

        public static void Naloga41()
        {
            /* Naloga 5.0.0.9. Deklarirajte poljuben seznam in mu zamenjajte vrstni red elementov. Seznam nato izpiˇsite na zaslon. */
        }
        public static void Naloga42()
        {
            /* Naloga 5.0.0.10. Deklarirajte poljuben seznam celih stevil in ga razvrstite tako, da bodo vsa liha stevila na zacetku seznama in vsa soda stevila na koncu seznama. */
        }
        public static void Naloga43()
        {
            /* Naloga 5.0.0.11. Deklarirajte poljuben celostevilski seznam in v njem vse sode elemente pomnozite z 2. */
        }
        public static void Naloga44()
        {

            /* Naloga 5.0.0.12. Deklarirajte poljuben seznam znakov in ga napolnite z vsaj 10 znaki. Nato iz njega izbrisite vse samoglasnike. */
        }
        public static void Naloga45()
        {
            /* Naloga 5.0.0.13. Napisite program, ki bo iz danega seznama celih stevil izbrisal vse podvojene elemente. */
        }

        public static void Naloga46()
        {

            /* Naloga 5.0.0.14. Deklarirajte dva poljubna seznama enakega tipa in na zaslon izpisite vse elemente, ki pripadajo natanko enemu izmed obeh seznamov. */
        }
        public static void Naloga47()
        {
            /* Naloga 5.1.0.1. Napisite program, ki bo uporabniku omogocal sprotno dodajanje in brisanje elementov seznama podatkov tipa int dokler se uporabnik ne odloci zakljuciti z delom.*/
        }
        public static void Naloga48()
        {
            /* Naloga 5.1.0.2. Napisite program, ki nam bo pomagal shranjevati podatke o kolicini sadja v shrambi. Podatki se shranjujejo v en seznam, za vsako sadje pa moramo shraniti dva podatka, in sicer, ime sadeza in koliko kosov ga imamo. Nato naj program od uporabnika zahteva vnos imena sadeza in kolicine, kolikor ga zeli dodati v shrambo. Pri tem moramo paziti, da v kolikor sadez ze obstaja v shrambi, mu kolicino le pristejemo. */
        }
        public static void Naloga49()
        {
            /* Naloga 5.1.0.3. Denimo, da imamo tri sezname v katerih imamo shranjene podatke o delavcih v podjetju. V prvem seznamu so shranjena imena in priimki delavcev, v drugem seznamu so shranjene starosti delavcev, v tretjem seznamu pa so shranjene place delavcev. V vseh treh seznamih je so podatki o doloˇcenem delavcu na istem mestu v seznamu. Napisite program, ki bo omogocal izpisovanje podatkov o delavcih glede na dolocene pogoje.
                   (a) Izpis povprecne starosti in place vseh zaposlenih.
                   (b) Izpis podatkov vseh delavcev s starostjo nad ali pod starostjo, ki jo poda uporabnik.
                   (c) Izpis podatkov vseh delavcev s placo visjo ali nizjo od povprecne place in skupnim stevilom teh delavcev. */
        }
    }
}
