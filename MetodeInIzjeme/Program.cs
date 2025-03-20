namespace MetodeInIzjeme
{
    internal class Program
    {



        static void Main(string[] args)
        {
            char[] tabela = ['u', 'd', 's', 'a', 'q', 'Q', 'a', 'A'];

            List<string> listaNakljucnihBesed = ["jabolko", "miza", "stol", "knjiga", "sonce", "mesec", "reka", "gora", "gozd", "veter", "dež", "cvet", "ptica", "avtomobil", "letalo", "telefon", "računalnik", "svetloba", "senca", "pot", "most", "vrata", "okno", "sončnica", "drevo", "travnik", "oblak", "pes", "mačka", "zvezda"];

            string niz = "to je beseda nekaj presledkov sledi      halo halo je kdo tu";
            string niz1 = "1htiH6798,.O-30179XOIczd56q-.,+";

            // PREDAVANJA
            //Naloga1();
            //Naloga2();
            //Naloga3(10, 10);
            //Naloga4();

            // VAJE
            //Naloga5(10, 13);
            //Naloga6(1345);
            //Naloga7(tabela, 'p');
            //Naloga8(11, 23);
            //Naloga9(tabela, 'a');
            // Naloga10(niz);
            //Naloga11(listaNakljucnihBesed, 'r');
            //Naloga12(niz);

            //var par = Naloga13(listaNakljucnihBesed);
            //Console.WriteLine($"Najdaljša beseda je {par.Item1} na indeksu {par.Item2}");

            //Naloga14(); //TO DO

            //var trojica = Naloga15(niz1);
            //Console.WriteLine($"Stevilo crk je {trojica.Item1}, stevilo stevk je {trojica.Item2} in stevilo preostalih znakov je {trojica.Item3}");

            //Console.WriteLine("Vsota: " + Naloga16());

            //bool ustreznost = Naloga17();
            //if (ustreznost) Console.WriteLine("Geslo ustreza");
            //else Console.WriteLine("Geslo ne ustreza");

            Naloga18(); //TO DO
            Naloga19(); //TO DO
            Console.ReadLine();
        }

        public static void Naloga1()
        {
            /* Naloga 6.1.1.1. Zapisite metodo, ki kot parameter dobi celo stevilo n, kot rezultat pa vrne seznam vseh prastevil manjsih od n. */

            Console.Write("Vpišite celo število: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Helpers.preveriPrastevilo(x);
        }


        public static void Naloga2()
        {
            /* Naloga 6.1.1.2. Zapisite metodo, ki kot parameter dobi stevilo v desetiskem zapisu in ga pretvori v dvojiski zapis. Zapisite se metodo, ki zgornjo metodo izvede na vseh stevilih od 1 do n in rezultate zapise v seznam.*/

            Console.Write("Vpišite števko v desetiškem zapisu:");
            int x = Convert.ToInt32(Console.ReadLine());
            int stevka = x;
            List<int> listaBinarnihStevil = new List<int>();
            int binarna = Helpers.izracunBinarneStevke(stevka);

            Console.Write($"Številka {x} v desetiškem zapisu je: {binarna}");
            Console.WriteLine();
            for (int i = 1; i <= x; i++)
            {
                int n = Helpers.izracunBinarneStevke(i);
                listaBinarnihStevil.Add(n);

            }
            Console.Write($"Vsa binarna števila od 1 do {x} so:");
            foreach (int stevilka in listaBinarnihStevil)
            {
                Console.Write(" " + stevilka);
            }
            Console.WriteLine();
        }


        public static void Naloga3(int n, int m)
        {
            /* Naloga 6.1.1.3. Zapisite metodo, ki kot rezultat izrise sahovnico dimenzije n × m, kjer sta n in m parametra metode. */

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= m; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0 || i % 2 != 0 && j % 2 != 0)
                    {
                        Console.Write("//");
                    }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
        public static void Naloga4()
        {
            /* Naloga 6.2.1.1. Zapisite metodo, ki uporabnika sprasuje po kvadratu danega, slucajno izbranega stevila (uporabite razred Random). Predvidite razlicne moznosti napacnih vnosov in jih ustrezno ujemite. */
            Random random = new Random();

            while (true)
            {
                int randomStevilka = random.Next(1, 21);
                try
                {
                    Console.Write($"Kakšen je kvadrat številke {randomStevilka}? \n 0 - exit \n");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Helpers.preveriVpisanoStevilko(x);
                    if (x == 0) break;
                    if (x == randomStevilka * randomStevilka)
                    {
                        Console.WriteLine($"Bravo! {x} je kvadrat {randomStevilka} ");
                    }
                    else if (x > 0 && x <= 400 && x != randomStevilka * randomStevilka) Console.WriteLine($"Škoda :( {x} ni kvadrat {randomStevilka}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Format ni v pravilni obliki!: {ex.Message}");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"Vpisano število je preveliko oziroma premajhno za izbrani format spremenljivke: {ex.Message}");
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine($"Vhodni podatek je null: {ex.Message}");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Vpisana cifra ni v predvidenih okvirjih {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Prišlo je do nepredvidene napake: {ex.Message}");
                }
            }
        }


        public static void Naloga5(int a, int b)
        {
            /* Naloga 6.0.0.1. Napisite metodo, ki za dani naravni stevili a in b izracuna vrednost a^b brez uporabe knjiznice Math z eno od zank. */
            try
            {
                int potenca = 1;
                // checked -> preveri če je rezultat potence večji od max števila ki ga lahko sprejme int. Tako vedno dobimo pravi rezultat ali pa error :D
                checked
                {
                    for (int i = 0; i <= b; i++)
                    {
                        potenca *= a;
                    }
                }
                Console.WriteLine($"Rezultat je: {potenca}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public static void Naloga6(int n)
        {
            /* Naloga 6.0.0.2. Napisite metodo, ki prejme celo stevilo in zanj na zaslon izpise vse njegove delitelje in vrne koliko deliteljev ima. */

            int stevec = 0;
            List<int> listaDeljiteljev = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    listaDeljiteljev.Add(i);
                    stevec++;
                }
            }
            Console.WriteLine($"Število {n} ima {stevec} deljiteljev. To so: ");

            Helpers.napisiListo(listaDeljiteljev);
        }


        public static void Naloga7(char[] tabela, char znak)
        {
            /* Naloga 6.0.0.3. Napisite metodo, ki prejme tabelo znakov in nek znak, ter vrne ali je podan znak v tabeli ali ne. */
            bool najdenZnak = false;
            for (int i = 0; i < tabela.Length; i++)
            {
                if (tabela[i] == znak)
                {
                    najdenZnak = true;
                    Console.WriteLine($"Znak {znak} je v tabeli na mestu {i}");
                    break;
                }
            }
            if (!najdenZnak)
            {
                Console.WriteLine($"Znaka {znak} ni v tabeli. Več sreče prihodnjič");
            }
        }
        public static void Naloga8(int n, int m)
        {
            /* Naloga 6.0.0.4. Napisite metodo, ki za podani naravni stevili n in m vrne tabelo vseh stevil med njima. Tabelo nato izpisite na zaslon. */
            int dolzina = m - n - 1;
            int[] tabela = new int[dolzina];
            int x = n + 1; //rabim zato da izpisem pravo cifro v končnem console.write
            for (int i = 0; i < dolzina; i++)
            {
                tabela[i] = x++;
            }
            Console.Write($"Tabela števil med {n} in {m} je: ");
            Helpers.napisiTabelo(tabela);
        }
        public static void Naloga9(char[] tabela, char znak)
        {
            /* Naloga 6.0.0.5. Napisite metodo, ki prejme niz in znak ter vrne stevilo pojavitev znaka v nizu. */

            int stevec = 0;
            for (int i = 0; i < tabela.Length; i++)
            {
                if (tabela[i] == znak) stevec++;
            }

            Console.Write($"Znak {znak} se v tabeli ponovi {stevec} krat.");
        }
        public static void Naloga10(string niz)
        {
            /* Naloga 6.0.0.6. Napisite metodo, ki prejme niz in ga pretvori v tabelo znakov, ki jo nato vrne. Tabelo nato izpisite na zaslon. */
            int dolzina = niz.Length;
            char[] tabelaZnakov = new char[dolzina];
            string[] tabelaNizov = niz.Split(' ');
            int k = 0;

            for (int i = 0; i < tabelaNizov.Length; i++)
            {
                for (int j = 0; j < tabelaNizov[i].Length; j++)
                {

                    tabelaZnakov[k] = tabelaNizov[i][j];
                    k++;
                }
            }
            Helpers.napisiTabelo(tabelaZnakov);
        }

        public static void Naloga11(List<string> list, char znak)
        {
            /* Naloga 6.0.0.7. Napisite metodo, ki za podan seznam besed in podano crko vrne seznam vseh besed, ki se zacnejo z dano crko. */
            List<string> seznamBesed = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                string beseda = list[i];
                if (beseda.IndexOf(znak) == 0) seznamBesed.Add(beseda);
            }

            Console.Write($"Besede v listi, ki se začnejo s črko {znak}: ");
            Helpers.napisiListo(seznamBesed);
        }
        public static void Naloga12(string niz)
        {
            /* Naloga 6.0.0.8. Napisite metodo, ki vrne stevilo besed v podanem nizu. Predpostavite lahko, da so besede v nizu locene le s presledki in ne vsebujejo nobenih drugih znakov. */

            string[] tabelaBesed = niz.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int dolzina = tabelaBesed.Length;

            Console.WriteLine($"V nizu je {dolzina} besed");

        }
        public static (string, int) Naloga13(List<string> seznam)
        {
            /* Naloga 6.0.0.9. Napisite metodo, ki prejme seznam besed in vrne par, kjer je na prvem mestu najdaljsa beseda, na drugem pa njen indeks v seznamu. */
            int index = 0;
            string beseda = "";
            int stevecZnakov = 0;

            for (int i = 0; i < seznam.Count; i++)
            {
                if (seznam[i].Length > stevecZnakov)
                {
                    stevecZnakov = seznam[i].Length;
                    beseda = seznam[i];
                    index = i;
                }

            }

            return (beseda, index);

        }
        public static void Naloga14()
        {
            /* Naloga 6.0.0.10. Napisite metodo, ki vrne tabelo malih crk angleske abecede, metodo, ki vrne tabelo velikih crk angleske abecede in metodo, ki vrne tabelo stevk. */
            char[] tabelaVelikihCrk = Helpers.vrniVelikeCrke();
            char[] tabelaMalihCrk = Helpers.vrniMaleCrke();
            int[] tabelaStevk = Helpers.vrniStevke();
        }


        public static (int, int, int) Naloga15(string niz)
        {
            /* Naloga 6.0.0.11. Napisite metodo, ki prejme niz in vrne trojico vrednosti, kjer je na prvem mestu stevilo crk, na drugem mestu stevilo stevk, na tretjem mestu pa stevilo preostalih znakov v nizu. */

            int steviloCrk = 0;
            int steviloStevk = 0;
            int steviloZnakov = 0;
            char[] tabelaVelikihCrk = Helpers.vrniVelikeCrke();
            char[] tabelaMalihCrk = Helpers.vrniMaleCrke();
            char[] tabelaStevk = Helpers.vrniCharStevke();

            for (int i = 0; i < niz.Length; i++)
            {
                if (tabelaVelikihCrk.Contains(niz[i]) || tabelaMalihCrk.Contains(niz[i])) steviloCrk++;
                else if (tabelaStevk.Contains(niz[i])) steviloStevk++;
                else steviloZnakov++;
            }

            return (steviloCrk, steviloStevk, steviloZnakov);
        }
        public static int Naloga16()
        {
            /* Naloga 6.0.0.12. Napisite metodo, ki bo izracunala vsoto stevil v celostevilskem seznamu v primeru, da ta ni prazen. Nato v Main metodi to vsoto izpisite v kolikor je bila izracunana. */

            List<int> seznamStevil = Helpers.generirajSeznamInt(0, 200, 10);
            //Helpers.napisiListo(seznamStevil); -> da lahko vidiš kakšen seznam generira. Ni nujno, samo za pomoč in da preveriš če ostalo lepo dela
            int vsota = 0;
            for (int i = 0; i < seznamStevil.Count; i++)
            {
                vsota += seznamStevil[i];
            }
            return vsota;

        }
        public static bool Naloga17()
        {
            /* Naloga 6.0.0.13. Napisite program, ki bo od uporabnika zahteval nastavitev gesla. Geslo je ustrezno, ce ima vsaj 8 znakov, vsebuje vsaj dve crki in vsaj dve stevki, ob tem pa ima vsaj eno veliko in vsaj eno majhno crko. */

            int steviloVelikihCrk = 0;  //vsaj ena velika crka
            int steviloStevk = 0; //vsaj dve stevki
            int steviloMalihCrk = 0; //vsaj ena mala crka
            char[] tabelaVelikihCrk = Helpers.vrniVelikeCrke();
            char[] tabelaMalihCrk = Helpers.vrniMaleCrke();
            char[] tabelaStevk = Helpers.vrniCharStevke();
            //bool gesloUstreza = false;
            string vpisanoGeslo = "";

            Console.Write("Prosim vpišite željeno geslo");
            vpisanoGeslo = Console.ReadLine();
            Console.WriteLine();
            if (vpisanoGeslo == null) return false;
            for (int i = 0; i < vpisanoGeslo.Length; i++)
            {
                char znak = vpisanoGeslo[i];
                if (tabelaVelikihCrk.Contains(znak)) steviloVelikihCrk++;
                else if (tabelaMalihCrk.Contains(znak)) steviloMalihCrk++;
                else if (tabelaStevk.Contains(znak)) steviloStevk++;
            }

            if (vpisanoGeslo.Length >= 8)
            {
                if (steviloMalihCrk >= 1 && steviloVelikihCrk >= 1 && steviloStevk >= 2) return true;
                else return false;
            }
            else return false;


        }
        public static void Naloga18()
        {
            /* Naloga 6.0.0.14. Napisite program, ki bo uporabniku 10-krat na zaslon izpisal nakljucno stevilo, ki ga more uporabnik vnesti. Na koncu naj se izpise stevilo pravilnih vnosov, napacnih vnosov in napak pri vnosu. */

            //to do
        }
        public static void Naloga19()
        {
            /* Naloga 6.0.0.15. Napisite program, ki bo uporabniku omogocal vnasanje enostavnih matematicnih izrazov z dvema vrednostima v obliki enega niza, kjer je med stevilkami in operacijo le en presledek. Program naj nato vrne rezultat izraza. Uporabite metode in pa try-catch stavek za moznost deljenja z 0. */

            //to do
        }

    }
}
