namespace MetodeInIzjeme
{
    internal class Helpers
    {
        public static void preveriPrastevilo(int stevka)
        {
            bool jePrastevilo = true;
            for (int i = 2; i < stevka; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0 && j != i)
                    {
                        jePrastevilo = false;
                        break;
                    }
                }

                if (jePrastevilo)
                {
                    Console.WriteLine($"{i} je prastevilo manjse od {stevka}");
                }
                jePrastevilo = true;
            }
        }

        public static int izracunBinarneStevke(int stevka)
        {
            int obrnjena = 0;
            List<int> binarna = new List<int>();
            while (stevka > 0)
            {
                binarna.Add(stevka % 2);
                stevka = stevka / 2;

            }

            for (int i = binarna.Count - 1; i >= 0; i--)
            {
                obrnjena += binarna[i];
                obrnjena = obrnjena * 10;
            }
            obrnjena = obrnjena / 10;

            return obrnjena;


        }

        public static void preveriVpisanoStevilko(int number)
        {
            if (number < 0 || number > 400) throw new ArgumentOutOfRangeException($"Vpisana številka mora biti med 1 in 400. Vpisali ste {number}");
        }

        public static void napisiListo(List<int> list)
        {
            foreach (int el in list)
            {
                Console.Write(el + " ");
            }
        }

        public static void napisiListo(List<string> list)
        {
            foreach (string el in list)
            {
                Console.Write(el + " ");
            }
        }

        public static void napisiTabelo(int[] tabela)
        {
            foreach (int el in tabela)
            {
                Console.Write(el + " ");
            }
        }
        public static void napisiTabelo(string[] tabela)
        {
            foreach (string el in tabela)
            {
                Console.Write(el + " ");
            }
        }
        public static void napisiTabelo(char[] tabela)
        {
            foreach (char el in tabela)
            {
                Console.Write(el + " ");
            }
        }

        public static char[] vrniVelikeCrke()
        {
            char[] tabela = new char[26];
            char j = 'A';
            for (int i = 0; i < tabela.Length; i++)
            {
                tabela[i] = j;
                j++;
            }

            return tabela;
        }
        public static char[] vrniMaleCrke()
        {
            char[] tabela = new char[26];
            char j = 'a';
            for (int i = 0; i < tabela.Length; i++)
            {
                tabela[i] = j;
                j++;
            }

            return tabela;
        }

        public static int[] vrniStevke()
        {
            int[] tabela = new int[10];
            for (int i = 0; i < tabela.Length; i++)
            {
                tabela[i] = i;
            }
            return tabela;
        }
        public static char[] vrniCharStevke()
        {
            char j = '0';
            char[] tabela = new char[10];
            for (int i = 0; i < tabela.Length; i++)
            {
                tabela[i] = j;
                j++;

            }
            return tabela;
        }

        public static List<int> generirajSeznamInt(int zacetek, int konec, int korak)
        {
            //metoda zgenerira listo random celih števil
            List<int> list = new List<int>();
            Random random = new Random();

            for (int i = zacetek; i <= konec; i += korak)
            {
                int element = random.Next(i);
                list.Add(element);
            }

            return list;
        }
    }
}
