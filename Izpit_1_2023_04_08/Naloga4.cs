namespace Izpit_1_2023_04_08
{
    internal class Naloga4
    {
        /// <summary>
        /// NALOGA 4:
        /// Napišite metodo Poštevanka, ki za dan parameter n 
        /// izpiše poštevanko od 1 do števila n tako,
        /// da so v vsaki vrstici izpisani večkratniki enega števila.
        /// Pri tem števila, ki so na pozicijah, 
        /// katerih vsota stolpca in vrstice je liha (če jih štejemo od 0 dalje), 
        /// nadomestimo z zvezdicami (razen v primeru začetnih in končnih stolpcev in vrstic!).
        /// 
        /// Za vrednost n=5 bi bil izris kot na spodnjem primeru:                   [20 točk]
        /// 
        /// 1   2   3   4   5
        /// 2   *   6   *  10
        /// 3   6   *  12  15
        /// 4   *  12   *  20
        /// 5  10  15  20  25
        /// 
        /// V metodi ResitevNaloge pripravite klic metode, ki za parameter
        /// dobi število n, ki naj ga poda uporabnik.                               [5 točk]
        /// </summary>
        public static void Postevanka(int stevilo)
        {
            for (int i = 1; i <= stevilo; i++)
            {
                for (int j = 1; j <= stevilo; j++)
                {
                    int zmnozek = i * j;
                    int vsota = i  + j -1;
                    if (vsota % 2 != 0 && i!=1 && j!=1 && i!=stevilo && j!=stevilo) Console.Write(" * ");
                    else Console.Write(" " + zmnozek + " ");
                }
                Console.WriteLine();
            }
        }

        public static void ResitevNaloge()
        {
            Console.Write("Vpiši naravno celo število: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Postevanka(n);
        }
    }
}
