namespace PrimerIzpita
{
    internal class Naloga4
    {

        /// <summary>
        /// NALOGA 4:
        /// Napišite metodo Metuljcek, ki za dan parameter n 
        /// izrise metuljčka. Za vrednost n=5 bi bil izris kot
        /// na spodnjem primeru:                        [20 točk]
        /// 
        /// *       *
        /// * *   * *
        /// *   *   *
        /// * *   * *
        /// *       *
        /// 
        /// V metodi ResitevNaloge pripravite klic metode, ki za parameter
        /// dobi število n, ki naj ga poda uporabnik.   [5 točk]
        /// </summary>
        ///

        public static void Metuljcek(int n)
        {
            //int n = 5;
            int m = 2 * n - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j == 0 || j == m - 1) Console.Write("*");
                    else if (i == j - i) Console.Write("*");
                    else if (j == m - 1 - 2 * i) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
