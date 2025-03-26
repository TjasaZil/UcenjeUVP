namespace Izpit_2024_03_23
{
    internal class Naloga4
    {
        /// <summary>
        /// NALOGA 4:
        /// 
        /// Med viri imate datoteko words_alpha.txt s seznamom angleških besed
        /// (ena beseda v vsaki vrstici). 
        /// V metodi imate že pripravljeno instanco razreda StreamReader,
        /// ki odpre omenjeno datoteko.
        /// 
        /// Poiščite vse besede v datoteki, ki vsebujejo črko 'x' 
        /// (veliko ali malo) in jih dodajte v seznam.                              [5 točk]
        /// 
        /// Med najdenimi besedami poiščite vse palindrome 
        /// (to so besede, ki se berejo enako naprej in nazaj, npr. kisik)
        /// in jih izpišite.                                                        [12 točk]
        /// 
        /// Na koncu izpišite število vseh besed, ki vsebujejo 'x' in 
        /// ne vsebujejo 'i' ali 'a'.                                               [8 točk]
        /// </summary>
        /// 
        public static void ResitevNaloge()
        {
            StreamReader srWords = new StreamReader("words_alpha.txt");
            List<string> seznamBesed = new List<string>();
            while (srWords.EndOfStream == false)
            {
                string niz = srWords.ReadLine();
                if (niz.Contains("x") || niz.Contains("X")) seznamBesed.Add(niz);
            }
            srWords.Close();
            //poišče palindrome in izpiše
            int stevec = 0;
            /// Na koncu izpišite število vseh besed, ki vsebujejo 'x' in 
            /// ne vsebujejo 'i' ali 'a'.
            Console.WriteLine("Te besede so palindromi: ");
            for (int i = 0; i < seznamBesed.Count; i++)
            {
                string beseda = seznamBesed[i];
                int k = beseda.Length - 1;
                bool niPalindrom = false;
                if (!beseda.Contains("i") && !beseda.Contains('a') && beseda.Contains("x")) stevec++;

                for (int j = 0; j < beseda.Length; j++)
                {
                    if (beseda[k] == beseda[j]) k--;
                    else
                    {
                        niPalindrom = true;
                        break;
                    }

                }
                if (!niPalindrom) Console.WriteLine(beseda);
            }
            Console.WriteLine("Število besed, ki vsebujejo x, vendar ne vsebujejo i ali a:" + stevec);


        }
    }
}
