namespace PredizpitniTest
{
    internal class Naloga6
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

        public static void ResitevNaloge()
        {
            Console.Write("Kako velikega metuljcka zelite? ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Metuljcek(x);
        }

        public static void Metuljcek(int n)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || j == 0 || j == n - 1 || j == n - 1 - i) Console.Write("*");
                    else Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
