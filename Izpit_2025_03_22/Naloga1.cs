namespace Izpit_2025_03_22;

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
public class Naloga1
{
    /// <summary>
    /// V tej funkciji se začne izvajati program za reševanje Naloge 1
    /// </summary>
    public static void ResitevNaloge()
    {
        List<double> seznam = new List<double>() { 1.23, 5.6, 9.18, 13.2, 10.7, 12.4, 1.53, 5.4, 10.18, 14.2, 10.17, 13.4 };
        Zaokrozevanje(seznam);
    }

    public static void Zaokrozevanje(List<double> seznamDecimalk)
    {
        double povprecjeZaokrozenih = 0;
        int zaokrozeneNavzgor = 0;
        for (int i = 0; i < seznamDecimalk.Count; i++)
        {
            double decimalka = seznamDecimalk[i] % 1;
            if (decimalka < 0.5) seznamDecimalk[i] = seznamDecimalk[i] - decimalka;
            else
            {
                //Console.WriteLine(seznamDecimalk[i]);
                seznamDecimalk[i] = (seznamDecimalk[i] - decimalka + 1);
                //Console.WriteLine(seznamDecimalk[i] + "*");
                zaokrozeneNavzgor++;
            }
            povprecjeZaokrozenih += seznamDecimalk[i];
        }

        double povprecje = povprecjeZaokrozenih / seznamDecimalk.Count;
        Console.WriteLine($"Na gor smo zaokrožili {zaokrozeneNavzgor} številk v seznamu");
        Console.WriteLine($"Povprečna vrednost zaokroženih števil je: {povprecje:0.00}");
    }
}