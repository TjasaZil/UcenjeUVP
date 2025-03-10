namespace Izpit_2023_06_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// NALOGA 1:
            /// Napišite metodo, ki uporabniku ponudi možnost 
            /// vnosa artikla na nakupovalni seznam skupaj 
            /// s številom kosov teh artiklov (npr. jogurt, 2).
            /// Glede poziva uporabniku se lahko odločite sami
            /// (npr. najprej ga pozovete, naj vnese naziv artikla, 
            /// in nato še, naj vnese število kosov oziroma količino).
            /// 
            /// Uporabnik naj artikle vnaša, dokler se ne odloči, 
            /// da je vnesel vse, in zaključi (tudi za to naj ima na voljo ukaz). [15 točk]
            /// 
            /// Da boste lahko artikle kar najbolj enostavno shranjevali, 
            /// si pripravite razred Artikel z ustreznimi lastnostmi. [5 točk]
            /// 
            /// Na koncu izpišite vse artikle na seznamu uporabnika in skupno število kosov. [5 točk]
            /// </summary>
            /// 

            /// <summary>
            /// NALOGA 2:
            /// V tej datoteki sta definirana razreda Kuhinja in KuhinjskiElement.
            /// Kuhinja predstavlja kuhinjo v stanovanju,
            /// ki ima kot lastnost elemente (omarice, hladilnik, pečico...)
            /// in površino, ki jo ima na voljo.
            /// 
            /// Za razred KuhinjskiElement naredite podrazred Hladilnik, 
            /// ki bo imel dodatno lastnost EnergijskiRazred,
            /// in še en podrazred po lastni izbiri.                                    [3 točke]
            /// 
            /// V razredih KuhinjskiElement in Hladilnik povozite metodo ToString, 
            /// da bo ustrezno vračala vse lastnosti instanc.                           [5 točk]
            /// 
            /// Metodo ToString povozite tudi v razredu Kuhinja,
            /// vrne naj niz s površino in opisom vseh elementov kuhinje.               [5 točk]
            /// 
            /// V razredu Kuhinja napišite še metodo, ki bo izpisala skupno površino elementov.
            /// Metoda vrača površino, ki je v kuhinji še na voljo za nove elemente.    [7 točk]
            ///                                                         
            /// Pripravite instanco razreda Kuhinja,
            /// ki bo imela na seznamu vsaj štiri elemente 
            /// od tega natanko element tipa Hladilnik in eno instanco razreda, 
            /// ki ste ga definirali sami.
            /// Na koncu instanco kuhinje tudi izpišite.                                [5 točk]
            /// </summary>


            /// <summary>
            /// NALOGA 3:
            /// Pripravite razreda Dijak in Razred.
            /// 
            /// Razred Dijak naj vsebuje: 
            /// -   Lastnosti Ime, PredmetiNaMaturi, ŠteviloTočkNaMaturi, KončniUspeh (zadosten, dober, prav dober, odličen).
            /// -   En konstruktor, ki omogoča določitev natanko dveh lastnosti, 
            ///     in en konstruktor, ki omogoča določitev vseh štirih lastnosti.
            /// -   Povozite metodo ToString, ki naj izpiše vse podatke o dijaku.               [10 točk]
            /// 
            /// Razred Razred naj vsebuje:
            /// -   Lastnosti SeznamDijakov in Razrednik.
            /// -   Konstruktor, ki inicializira seznam dijakov in kot parameter dobi razrednika.
            /// -   Metodo, ki izpiše povprečno število točk dijakov razreda na maturi.         [10 točk]
            /// 
            /// V metodi ResitevNaloge kreirajte instanco razreda Razred, ki naj vsebuje vsaj pet dijakov
            /// in izpišite podatke o vseh dijakih, ki so na maturi dosegli vsaj 24 točk.       [5 točk]
            /// </summary>
            /// 

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


        }
    }
}
