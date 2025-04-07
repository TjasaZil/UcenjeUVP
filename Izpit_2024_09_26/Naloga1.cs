namespace Izpit_2024_09_26
{
    internal class Naloga1
    {
        /// <summary>
        /// NALOGA 1:
        /// 
        /// Napišite metodo PovprecjeVeljavnih, ki kot parameter prejme tabelo nizov (spremenljivk tipa string). 
        /// Za vsak element tabele naj preveri, če predstavlja celo število ali ne.
        /// V ukazno vrstico naj metoda izpiše število elementov, ki predstavljajo cela števila,
        /// vrne pa naj povprečje njihovih vrednosti.                               [20 točk]
        /// 
        /// V metodi ResitevNaloge pripravite tabelo z vsaj desetimi nizi, 
        /// od katerih naj jih vsaj pet predstavlja celo število. 
        /// Pokličite metodo PovprecjeVeljavnih in izpišite vrednost, 
        /// ki jo metoda vrne, v ukazno vrstico.                                    [5 točk]
        /// </summary>
        /// 

        public static void ResitevNaloge()
        {
            string[] tabelaNizov = ["123", "abs", "1q", "14", "ABC", "345", "5", "16", "10pk", "1a3", "ab1", "15q", "134", "A1BC", "34b", "q5", "16r", "10"];

            Console.WriteLine($"Povprečje vrednosti stevil v tabeli nizov: {PovprecjeVeljavnih(tabelaNizov):0.00}");

        }

        public static double PovprecjeVeljavnih(string[] tabela)
        {
            List<int> tabelaStevil = new List<int>();
            bool jeStevilo = false;
            int stevecStevk = 0;
            for (int i = 0; i < tabela.Length; i++)
            {
                for (int j = 0; j < tabela[i].Length; j++)
                {
                    if (PreveriZnak(tabela[i][j]))
                    {
                        jeStevilo = true;
                        continue;
                    }
                    else
                    {
                        jeStevilo = false;
                        break;
                    }
                }
                if (jeStevilo)
                {
                    tabelaStevil.Add(int.Parse(tabela[i]));
                    stevecStevk++;
                }
                jeStevilo = false;
            }
            Console.WriteLine("Stevilo elementov v tabeli ki predstavljajo celo število: " + stevecStevk);
            int vsota = 0;
            foreach (int el in tabelaStevil)
            {
                vsota += el;
            }
            return (double)vsota / tabelaStevil.Count;

        }

        public static bool PreveriZnak(char znak)
        {
            bool jeZnak = false;
            switch (znak)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    jeZnak = true;
                    break;
                default:
                    jeZnak = false;
                    break;
            }
            return jeZnak;
        }
    }
}

