namespace Izpit_1_2023_04_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// NALOGA 1:
            /// Napišite metodo za igro ugibanja besed.
            /// Metoda naj od prvega uporabnika (skrbnika) zahteva vnos neke besede s petimi črkami.
            /// Če je vnešena beseda z drugim številom črk, metoda zahteva ponoven vnos,
            /// dokler ni vnešena beseda s petimi črkami.                       [5 točk]
            /// 
            /// Igro nato nadaljuje drug uporabnik (igralec).
            /// Igralcu se izpiše prva črka izbrane besede, 
            /// igralec pa poskuša uganiti besedo.
            /// Za vsako vnešeno besedo mu metoda izpiše, 
            /// katere črke so v izbrani besedi in katere so na pravih mestih.  [15 točk]
            /// 
            /// Ko igralec ugane besedo, se mu izpiše čestitka in število
            /// poskusov, ki jih je porabil.                                    [5 točk]
            /// </summary>
            /// 

            /// <summary>
            /// NALOGA 2:
            /// V tej datoteki sta definirana razreda Menu in Jed.
            /// Menu predstavlja dnevni menu v restavraciji (glede na dan),
            /// ki ima kot lastnost tudi seznam jedi.
            /// Posamezna jed ima lastnosti naziv in cena.
            /// 
            /// Za razred Jed naredite podrazred Sladica, 
            /// ki bo imel dodatno lastnost Kalorije.                   [3 točke]
            /// 
            /// V razredih Jed in Sladica povozite metodo ToString, 
            /// da bo ustrezno vračala vse lastnosti instanc.           [5 točk]
            /// 
            /// Metodo ToString povozite tudi v razredu Menu,
            /// vrne naj niz z dnevom in vsemi jedmi, ki so na menuju, 
            /// med seboj pa naj bodo ločene s prazno vrstico.          [5 točk]
            /// 
            /// V razredu Menu napišite še metodo, ki bo izpisala skupno ceno menuja.
            /// Metoda naj ima vhodni parameter tipa bool, ki bo določal, 
            /// ali želite ob ceni plačati še 10% napitnine ali ne.
            /// Če je vrednost parametra true, naj se skupna cena primerno izračuna.
            ///                                                         [7 točk]
            ///                                                         
            /// Za vsaj dva dni v tednu pripravite instanci razreda Menu,
            /// ki bosta imeli na seznamu jedi vsaj po tri jedi, 
            /// od tega vsak natanko eno jed tipa Sladica. 
            /// Na koncu oba menuja tudi izpišite                       [5 točk]
            /// </summary>

            /// <summary>
            /// NALOGA 3:
            /// Pripravite razreda Igralec in NogometniKlub.
            /// 
            /// Razred Igralec naj vsebuje: 
            /// -   Lastnosti Ime, CenaIgralca, Položaj (napadalec, vezni, vratar,...), Starost (tej lastnosti lahko vrednost nastavimo samo v konstruktorju!).
            /// -   En konstruktor, ki omogoča določitev natanko dveh lastnosti, 
            ///     in en konstruktor, ki omogoča določitev vsaj treh lastnosti.
            /// -   Povozite metodo ToString, ki naj izpiše vse podatke o igralcu.              [10 točk]
            /// 
            /// Razred NogometniKlub naj vsebuje:
            /// -   Lastnosti SeznamIgralcev in VišinaProračuna.
            /// -   Konstruktor, ki inicializira seznam igralcev in nastavi višino proračuna.
            /// -   Metodo, ki izpiše vse igralce, ki imajo ceno višjo od danega maksimuma.     [10 točk]
            /// 
            /// V metodi ResitevNaloge kreirajte instanco razreda NogometniKlub, ki naj vsebuje vsaj pet igralcev
            /// in izpišite podatke o vseh igralcih, ki imajo ceno vsaj 100_000 evrov 
            /// in so mlajši od 30 let.          [5 točk]
            /// </summary>

            /// <summary>
            /// NALOGA 4:
            /// Napišite metodo Poštevanka, ki za dan parameter n 
            /// izpiše poštevanko od 1 do števila n tako,
            /// da so v vsaki vrstici izpisani večkratniki enega števila.
            /// Pri tem števila, ki so na pozicijah, 
            /// katerih vsota stolpca in vrstice je liha (če jih štejemo od 0 dalje), 
            /// nadomestimo z zvezdicami (razen v primeru začetnih in končnih stolpcev in vrstic!).
            /// 
            /// Za vrednost n=5 bi bil izris kot na spodnjem primeru:                   [20 točk]
            /// 
            /// 1   2   3   4   5
            /// 2   *   6   *  10
            /// 3   6   *  12  15
            /// 4   *  12   *  20
            /// 5  10  15  20  25
            /// 
            /// V metodi ResitevNaloge pripravite klic metode, ki za parameter
            /// dobi število n, ki naj ga poda uporabnik.                               [5 točk]
            /// </summary>
        }
    }
}
