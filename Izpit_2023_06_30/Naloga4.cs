namespace Izpit_2023_06_30
{
    internal class Naloga4
    {
        /// <summary>
        /// NALOGA 4:
        /// Napišite metodo Šahovnica, ki za dan parameter n 
        /// izriše šahovnico dimenzije  n x n, 
        /// za vrednosti n med 1 in 10. 
        /// Črna polja naj bodo predstavljena z X, bela pa z O.
        /// Nad in pod šahovnico naj bodo oznake stolpcev z velikimi tiskanimi črkami 
        /// angleške abecede, ob obeh straneh pa številke vrstic z arabskimi številkami.
        /// Levo spodnje polje naj bo vedno črno.
        /// 
        /// Za vrednost n=5 bi bil izris kot na spodnjem primeru:                   [20 točk]
        /// 
        ///    A  B  C  D  E
        /// 5  X  O  X  O  X  5 
        /// 4  O  X  O  X  O  4
        /// 3  X  O  X  O  X  3
        /// 2  O  X  O  X  O  2
        /// 1  X  O  X  O  X  1
        ///    A  B  C  D  E
        /// 
        /// V metodi ResitevNaloge pripravite klic metode, ki za parameter
        /// dobi število n, ki naj ga poda uporabnik.                               [5 točk]
        /// </summary>
        /// 


        public static void ResitevNaloge()
        {
            Console.Write("Vpišite velikost šahovnice: ");
            int velikost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Sahovnica(velikost);

        }

        public static void Sahovnica(int n)
        {
            int velikostSahovnice = n + 2;
            for (int i = 0; i < velikostSahovnice; i++)
            {
                for (int j = 0; j < velikostSahovnice; j++)
                {

                    if (i == 0 && (j == 0 || j == velikostSahovnice - 1)) Console.Write("  ");
                    else if (i == velikostSahovnice - 1 && (j == 0 || j == velikostSahovnice - 1)) Console.Write("  ");
                    else if (j == 0 || j == velikostSahovnice - 1) Console.Write(n - i + 1 + " ");
                    else if (i == 0 || i == velikostSahovnice - 1) Console.Write(vrniCrko(j).ToString() + " ");

                    else
                    {
                        if (i % 2 != 0 && j % 2 != 0 || i % 2 == 0 && j % 2 == 0) Console.Write("X ");
                        else Console.Write("O ");
                    }

                    //Console.Write("X ");
                }
                Console.WriteLine();
            }
        }

        public static char vrniCrko(int i)
        {
            char crka = ' ';
            switch (i)
            {
                case 1:
                    crka = 'A';
                    break;
                case 2:
                    crka = 'B';
                    break;
                case 3:
                    crka = 'C';
                    break;
                case 4:
                    crka = 'D';
                    break;
                case 5:
                    crka = 'E';
                    break;
                case 6:
                    crka = 'F';
                    break;
                case 7:
                    crka = 'G';
                    break;
                case 8:
                    crka = 'H';
                    break;
                case 9:
                    crka = 'I';
                    break;
                case 10:
                    crka = 'J';
                    break;
                case 11:
                    crka = 'K';
                    break;
                case 12:
                    crka = 'L';
                    break;
                case 13:
                    crka = 'M';
                    break;
                case 14:
                    crka = 'N';
                    break;
                case 15:
                    crka = 'O';
                    break;
                case 16:
                    crka = 'P';
                    break;
                case 17:
                    crka = 'Q';
                    break;
                case 18:
                    crka = 'R';
                    break;
                case 19:
                    crka = 'S';
                    break;
                case 20:
                    crka = 'T';
                    break;
                case 21:
                    crka = 'U';
                    break;
                case 22:
                    crka = 'V';
                    break;
                case 23:
                    crka = 'W';
                    break;
                case 24:
                    crka = 'X';
                    break;
                case 25:
                    crka = 'Y';
                    break;
                case 26:
                    crka = 'Z';
                    break;
                default:
                    break;

            }
            return crka;
        }
    }
}
