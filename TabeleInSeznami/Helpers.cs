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
            foreach (var stevka in seznam)
            {
                Console.Write(stevka + " ");
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
    }
}
