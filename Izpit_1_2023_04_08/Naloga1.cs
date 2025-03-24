namespace Izpit_1_2023_04_08
{
    internal class Naloga1
    {
        /// <summary>
        /// NALOGA 1:
        /// Napišite metodo za igro ugibanja besed.
        /// Metoda naj od prvega uporabnika (skrbnika) zahteva vnos neke besede s petimi črkami.
        /// Če je vnešena beseda z drugim številom črk, metoda zahteva ponoven vnos,
        /// dokler ni vnešena beseda s petimi črkami.       da                [5 točk]
        /// 
        /// Igro nato nadaljuje drug uporabnik (igralec).
        /// Igralcu se izpiše prva črka izbrane besede, da
        /// igralec pa poskuša uganiti besedo.
        /// Za vsako vnešeno besedo mu metoda izpiše, 
        /// katere črke so v izbrani besedi in katere so na pravih mestih.  [15 točk]
        /// 
        /// Ko igralec ugane besedo, se mu izpiše čestitka in število
        /// poskusov, ki jih je porabil.   da                                 [5 točk]
        /// </summary>
        ///

        public static void UganiBesedo()
        {
            string beseda = " ";
            //skrbnik
            while (true)
            {
                Console.Write("Zapišite besedo, ki je dolga pet črk: ");
                beseda = Console.ReadLine();

                if (beseda.Length == 5) break;
            }
            Console.WriteLine();
            //igralec
            int stevec = 0;
            
            while (true)
            {
                Console.Write($"Uganite besedo! Začne se s črko: {beseda[0]}");
                Console.WriteLine();
                string igralcevaBeseda = Console.ReadLine();
                Console.WriteLine();
              
                if (igralcevaBeseda == beseda)
                {
                    stevec++;
                    Console.WriteLine($"Bravo! Uganili ste besedo!. Porabili ste {stevec} pozkusov. Igra je koncana");
                    break;
                }
                else
                {
                    for (int i = 0; i < beseda.Length; i++)
                    {
                        for (int j = 0; j < igralcevaBeseda.Length; j++)
                        {
                            if (beseda[i] == igralcevaBeseda[j])
                            {
                                if(i!=j) {
                                    Console.WriteLine($"Črka {igralcevaBeseda[i]} ni na pravem mestu vendar je v besedi");
                                    continue;
                                }
                                   else if(i==j) {
                                    Console.WriteLine($"Črka {igralcevaBeseda[i]} je na pravem mestu");
                                    continue;
                                   }
                            }
                        }
                      
                    }

                    stevec++;

                }
            }
            
        }
    }
}
