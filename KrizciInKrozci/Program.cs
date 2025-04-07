namespace KrizciInKrozci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* DODATNO:
            - lahko izbereš X ali O kot igralec
            - dodaj errorje če user vpiše kaj drugega kot številke za koordinate
            - dodaj parsing tako da ni važno kako user vpiše koordinate
            - dodaj start screen in opcijo da user exita ali starta igro
            - dodaj števec zmage / leaderboard
            - opcijo za ponovno igro ali exit
             */

            int stevec = 0;
            //če izbran x potem ko števec%2==0 -> x začne

            string igralcevZnak = "X";
            string racunalnikZnak = "O";
            izrisiPraznoTabelo(); //izriše prazno tabelo zato da je bolj vizualno
            string[][] tabela = zgenerirajPraznoTabelo(); //naredi prazno tabelo v ozadju


            while (true)
            {
                if (stevec % 2 == 0)
                {
                    var koordinate = vnesiKoordinate(tabela); //izberejo se koordinate kam gre znak
                    tabela = zgenerirajTabelo(tabela, koordinate.Item1, koordinate.Item2, igralcevZnak);
                }
                else
                {
                    var koordinate = zgenerirajKoordinate(tabela); //izberejo se koordinate kam gre znak
                    tabela = zgenerirajTabelo(tabela, koordinate.Item1, koordinate.Item2, racunalnikZnak);

                }
                stevec++;
                bool zmaga = preveriTabelo(tabela);

                if (zmaga)
                {
                    string zmagovalec = stevec % 2 == 0 ? "racunalnik" : "igralec";
                    Console.WriteLine($"Zmaga! Zmagal je {zmagovalec}");
                    break;
                }
            }

            Console.ReadLine();
        }

        public static void izrisiPraznoTabelo()
        {
            int vrstice = 5;
            int stolpci = 5;
            string[][] grid = new string[vrstice][];

            for (int i = 0; i < vrstice; i++)
            {
                grid[i] = new string[stolpci];
                for (int j = 0; j < stolpci; j++)
                {
                    if (i % 2 != 0) grid[i][j] = "-";
                    else if (i % 2 == 0 && j % 2 != 0) grid[i][j] = "|";
                    else grid[i][j] = " ";
                    Console.Write(grid[i][j]);
                }
                Console.WriteLine();
            }
        }

        public static string[][] zgenerirajPraznoTabelo()
        {
            int vrstice = 5;
            int stolpci = 5;
            string[][] grid = new string[vrstice][];

            for (int i = 0; i < vrstice; i++)
            {
                grid[i] = new string[stolpci];
                for (int j = 0; j < stolpci; j++)
                {
                    if (i % 2 != 0) grid[i][j] = "-";
                    else if (i % 2 == 0 && j % 2 != 0) grid[i][j] = "|";
                    else grid[i][j] = " ";
                }
            }

            return grid;
        }

        public static (int, int) vnesiKoordinate(string[][] tabela)
        {
            Console.Write("Kam želite vnesti znak? (loči koordinate s presledkom): ");
            string koordinate = Console.ReadLine();
            int vrsta = Convert.ToInt32(koordinate.Split(" ")[0]);
            int stolpec = Convert.ToInt32(koordinate.Split(" ")[1]);
            while (true)
            {
                if (vrsta % 2 != 0 || stolpec % 2 != 0)
                {
                    Console.Write("Koordinate niso vredu. Prosim vnesite nove koordinate: ");

                }
                else if (tabela[vrsta][stolpec] == "X" || tabela[vrsta][stolpec] == "O")
                {
                    Console.Write("Koordinate niso vredu. Na tem mestu se že nahaja znak. Prosim vnesite nove koordinate: ");
                }
                else break;

                koordinate = Console.ReadLine();
                vrsta = Convert.ToInt32(koordinate.Split(" ")[0]);
                stolpec = Convert.ToInt32(koordinate.Split(" ")[1]);
            }
            Console.WriteLine();
            return (vrsta, stolpec);
        }

        public static (int, int) zgenerirajKoordinate(string[][] tabela)
        {
            Random random = new Random();

            int vrsta = random.Next(0, 5);
            int stolpec = random.Next(0, 5);

            while (true)
            {
                if (vrsta % 2 != 0) vrsta = random.Next(0, 5);
                else if (stolpec % 2 != 0) stolpec = random.Next(0, 5);
                else if (tabela[vrsta][stolpec] == "X" || tabela[vrsta][stolpec] == "O")
                {
                    vrsta = random.Next(0, 5);
                    stolpec = random.Next(0, 5);
                }
                else break;
            }


            Console.Write($"vstavljam znak O v vrsto {vrsta} in stolpec {stolpec}");
            Console.WriteLine();
            return (vrsta, stolpec);
        }


        public static string[][] zgenerirajTabelo(string[][] tabela, int vrsta, int stolpec, string znak)
        {
            int vrstice = 5;
            int stolpci = 5;

            if (stolpec < stolpci && vrsta < vrstice)
            {
                tabela[vrsta][stolpec] = znak;
                Console.WriteLine();
                for (int i = 0; i < vrstice; i++)
                {
                    for (int j = 0; j < stolpci; j++)
                    {
                        Console.Write(tabela[i][j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Na to mesto ne morete dodati znaka");
            }


            return tabela;
        }

        public static bool preveriTabelo(string[][] tabela)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tabela[i][j] == "X" || tabela[i][j] == "O")
                    {
                        if (tabela[i][0] == tabela[i][2] && tabela[0][0] == tabela[i][4]) return true;
                        else if (tabela[0][j] == tabela[2][j] && tabela[0][j] == tabela[4][j]) return true;
                        else if (tabela[0][0] == tabela[2][2] && tabela[0][0] == tabela[4][4]) return true;
                        else if (tabela[0][4] == tabela[2][2] && tabela[0][0] == tabela[4][0]) return true;
                    }

                }
            }
            return false;
        }
    }

}