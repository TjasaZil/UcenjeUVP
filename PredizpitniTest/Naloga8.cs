namespace PredizpitniTest
{
    /// <summary>
    /// NALOGA 1:
    /// 
    /// Napišite funkcijo Zaokrozevanje, ki kot parameter prejme seznam decimalnih števil. 
    /// Funkcija naj vsak število iz seznama zaokroži navzgor, 
    /// če je njegov decimalni del večji od 0.4, sicer pa naj ga zaokroži navzdol. 
    /// V ukazno vrstico naj nato funkcija izpiše število tistih števil, ki jih je zaokrožila navzgor, 
    /// vrne pa naj povprečje zaokroženih vrednosti.                            [20 točk]
    /// 
    /// V funkciji ResitevNaloge pripravite seznam z vsaj desetimi števili. 
    /// Pokličite funkcijo Zaokrozevanje in izpišite vrednost, ki jo funkcija vrne, 
    /// v ukazno vrstico. V funkciji ResitevNaloge pripravite seznam z vsaj desetimi števili. 
    /// Pokličite funkcijo Zaokrozevanje in izpišite vrednost, 
    /// ki jo funkcija vrne, v ukazno vrstico.                                  [5 točk]
    /// </summary>
    internal class Naloga8
    {
        public static void ResitevNaloge()
        { //11
            List<double> seznam = new List<double>() { 1.2, 2.3, 3.4, 4.5, 5.6, 6.7, 7.8, 8.9, 9.1, 0.9, 1.9, 2.8, 3.7, 9.1, 8.7, 6.5, 4.2 };

            double zaokrozeno = Zaokrozevanje(seznam);
            Console.WriteLine($"Povprecje zaokrozenih: {zaokrozeno:0.00}");
        }

        public static double Zaokrozevanje(List<double> seznam)
        {

            int navzgor = 0;
            double vsota = 0;
            foreach (double el in seznam)
            {
                double stevilo = 0;
                double ostanek = el % 1;
                if (ostanek < 0.5)
                {
                    stevilo = el / 1;
                }
                else
                {
                    stevilo = (el / 1) + 1;
                    navzgor++;
                }

                vsota += stevilo;
            }

            Console.WriteLine("zaokrozeni navzgor: " + navzgor);

            return vsota / seznam.Count;
        }
    }
}
