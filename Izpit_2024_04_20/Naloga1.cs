namespace Izpit_2024_04_20
{
    internal class Naloga1
    {
        /// <summary>
        /// NALOGA 1:
        /// 
        /// Napišite metodo VelikeMale, ki kot parameter prejme besedilo. 
        /// Naloga metode je zapisati prvo črko vsake besede v besedilu z veliko začetnico
        /// (pri tem upoštevajte, da so besede med seboj ločene s presledki ali tabulatorji). 
        /// Z veliko začetnico naj zapiše tudi vse samoglasnike (to so a, e, i, o in u) .
        /// Ostale črke naj bodo zapisane z malimi črkami.                          
        /// Popravljeno besedilo naj metoda vrne.                                   [20 točk]
        /// 
        /// V metodi ResitevNaloge pripravite neko besedilo z vsaj petimi besedami,
        /// pokličite metodo VelikeMale in izpišite popravljeno besedilo, 
        /// ki ga metoda vrne, v ukazno vrstico.                                    [5 točk]
        /// </summary>
        /// 

        public static void ResitevNaloge()
        {
            string niz = "to je nek niz    Katerega je potrebno    spremeniti.";


            string spremenjeniNiz = VelikeMale(niz);
            Console.WriteLine(spremenjeniNiz);
        }

        public static string VelikeMale(string niz)
        {
            string novNiz = "";
            string[] tabela = niz.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tabela.Length; i++)
            {
                string beseda = tabela[i];
                string novaBeseda = "";
                for (int j = 0; j < tabela[i].Length; j++)
                {

                    if (j == 0 || beseda[j] == 'a' || beseda[j] == 'e' || beseda[j] == 'i' || beseda[j] == 'o' || beseda[j] == 'u')
                    {
                        novaBeseda += SpremeniCrko(beseda[j]).ToString();
                        continue;
                    }
                    else novaBeseda += beseda[j].ToString();

                }
                novNiz += novaBeseda + " ";
            }
            return novNiz;
        }

        public static char SpremeniCrko(char crka)
        {
            switch (crka)
            {
                case 'a':
                    crka = 'A';
                    break;
                case 'b':
                    crka = 'B';
                    break;
                case 'c':
                    crka = 'C';
                    break;
                case 'd':
                    crka = 'D';
                    break;
                case 'e':
                    crka = 'E';
                    break;
                case 'f':
                    crka = 'F';
                    break;
                case 'g':
                    crka = 'G';
                    break;
                case 'h':
                    crka = 'H';
                    break;
                case 'i':
                    crka = 'I';
                    break;
                case 'j':
                    crka = 'J';
                    break;
                case 'k':
                    crka = 'K';
                    break;
                case 'l':
                    crka = 'L';
                    break;
                case 'm':
                    crka = 'M';
                    break;
                case 'n':
                    crka = 'N';
                    break;
                case 'o':
                    crka = 'O';
                    break;
                case 'p':
                    crka = 'P';
                    break;
                case 'q':
                    crka = 'Q';
                    break;
                case 'r':
                    crka = 'R';
                    break;
                case 's':
                    crka = 'S';
                    break;
                case 't':
                    crka = 'T';
                    break;
                case 'u':
                    crka = 'U';
                    break;
                case 'v':
                    crka = 'V';
                    break;
                case 'w':
                    crka = 'W';
                    break;
                case 'x':
                    crka = 'X';
                    break;
                case 'y':
                    crka = 'Y';
                    break;
                case 'z':
                    crka = 'Z';
                    break;
                default:
                    break;

            }


            return crka;
        }

    }
}
