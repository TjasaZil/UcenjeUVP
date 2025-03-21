namespace TabeleInSeznami
{
    internal class Helpers
    {
        public static void manipulacijaTabele(int ukaz, int[] tabela)
        {
            List<int> lista = new List<int>();
            if (ukaz == 0)
            {
                foreach (int stevka in tabela)
                {
                    if (stevka % 2 == 0) lista.Add(stevka);
                }
            }
            else if (ukaz == 1)
            {
                foreach (int stevka in tabela)
                {
                    if (stevka % 2 != 0) lista.Add(stevka);
                }
            }
            else if (ukaz == 2)
            {
                foreach (int stevka in tabela)
                {
                    lista.Add(stevka);
                }
            }

            Console.Write("Vračam števke iz tabele ki ustrezajo pogoju:");
            foreach (int stevka in lista)
            {
                Console.Write(" " + stevka);
            }
            Console.WriteLine();
        }

        public static void izpisDvodimenzionalneTabele(int[][] dvodimTabela)
        {
            foreach (int[] x in dvodimTabela)
            {
                foreach (int stevka in x)
                {
                    Console.Write(stevka + " ");
                }
                Console.WriteLine();
            }
        }

        public static void izpisSeznama(List<int> seznam)
        {
            foreach (var stevka in seznam)
            {
                Console.Write(stevka + " ");
            }
            Console.WriteLine();
        }
        public static void izpisSeznama(List<string> seznam)
        {
            foreach (var niz in seznam)
            {
                Console.Write(niz + " ");
            }
            Console.WriteLine();
        }
        public static void izpisSeznama(List<char> seznam)
        {
            foreach (var znak in seznam)
            {
                Console.Write(znak + " ");
            }
            Console.WriteLine();
        }
        public static void izpisTabele(int[] tabela)
        {
            foreach (var stevka in tabela)
            {
                Console.Write(stevka + " ");
            }
            Console.WriteLine();
        }

        public static void izpisListe(List<int> lista)
        {
            Console.Write("Trenutni elementi v seznamu: ");
            foreach (int el in lista)
            {
                Console.Write(" " + el);
            }
            Console.WriteLine();
        }

        public static List<int> dodajanjeElementa(List<int> lista)
        {
            Console.Write("Katero številko želite dodati v seznam?:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            lista.Add(n);
            Console.WriteLine("Število je dodano v seznam!");
            return lista;
        }

        public static List<int> odstranitevElementa(List<int> lista)
        {
            Console.Write("Katero številko želite dodati v seznam?: ");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (lista.Contains(j))
            {
                lista.RemoveAll(el => el == j); //odstrani vse elemente ki so enaki vpisani vrednosti
                Console.WriteLine($"Vse pojavitve števila {j} so izbrisane iz seznama");
            }
            else Console.WriteLine("Te številke ni v seznamu");

            return lista;
        }
    }
}
