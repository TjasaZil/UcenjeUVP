namespace Izpit_2024_06_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// NALOGA 1:
            /// 
            /// Napišite metodo VsoteStevk, ki kot parameter prejme seznam celih števil. 
            /// Za vsako število iz seznama naj izračuna vsoto njegovih števk 
            /// (npr.vsota števk števila 23 je 5) in na zaslon izpiše tista
            /// (originalna) števila, katerih vsota je manjša od 10.                    [15 točk]
            /// 
            /// Metoda naj vsote števk vseh števil iz danega seznama sešteje 
            /// in ta seštevek vrne.                                                    [5 točk]
            /// 
            /// V metodi ResitevNaloge pripravite seznam z vsaj petimi celimi števili, 
            /// pokličite metodo VsoteStevk in izpišite skupno vsoto vseh števk, 
            /// ki jo metoda vrne, v ukazno vrstico.                                    [5 točk]
            /// </summary>
            /// 

            /// <summary>
            /// NALOGA 2:
            /// 
            /// V Nemčiji ravno poteka evropsko	nogometno prvenstvo, 
            /// mi pa želimo pripraviti razredni model za beleženje 
            /// statistik tekem na klubskem svetovnem prvenstvu. 
            /// V ta namen pripravite razrede Ekipa, Statistika in Tekma.
            /// 
            /// Razred Ekipa naj vsebuje: 
            /// - Lastnosti Ime, Klub in Igralci.
            /// - Natanko en konstruktor, ki nastavi lastnosti Ime in Klub.
            /// - Metodo ToString, ki izpiše vse lastnosti ekipe.               [4 točk]
            /// 
            /// Razred Statistika naj vsebuje: 
            /// - Lastnosti Goli, PosestZoge, Prekrski, RumeniKartoni in RdečiKartoni.
            /// - Metodo ToString, ki naj izpiše vse statistične enote.         [4 točk]
            /// 
            /// Razred Tekma naj vsebuje: 
            /// - Lastnosti Domači, Gosti, Datum, StatistikaDomači in StatistikaGosti. 
            ///   Vse lastnosti naj imajo ustrezen tip.
            /// - En konstruktor, ki omogoča zgolj določitev lastnosti Domači in Gosti.
            /// - Metodo ToString, ki naj izpiše vse podrobnosti o tekmi.
            /// - Metodo, ki vrne skupno število rumenih kartonov na tekmi.
            /// - Metodo, ki vrne rezultat tekme.                               [12 točk]
            /// 
            /// V metodi ResitevNaloge kreirajte dve instanci razreda Ekipa, 
            /// instanco razreda Tekma, instanci za statistiko obeh ekip na tekmi 
            /// in na koncu na zaslon izpišite rezultat ter podatke o tekmi.    [5 točk]
            /// </summary>
            /// 

            /// <summary>
            /// NALOGA 3:
            /// V podjetju ima vsak zaposleni nekaj različnih prenosnih naprav. 
            /// Da bi imel IT oddelek nadzor nad inventarjem, pripravlja aplikacijo, 
            /// za katero pa potrebuje vašo pomoč.
            /// 
            /// Napišite razred MobilnaNaprava, ki ima lastnosti LetoIzdelave, 
            /// Cena, Ima5GModul in TipProcesorja. 
            /// V razredu pripravite še natanko en konstruktor,  
            /// ki kot parameter dobi leto izdelave. 
            /// Povozite tudi metodo ToString.                                          [6 točk]
            /// 
            /// Za razred MobilnaNaprava pripravite tri podrazrede: 
            /// Telefon, Tablica in Prenosnik. 
            /// Za vsako od naprav si zamislite po dve ustrezni specifični lastnosti 
            /// in ju implementirajte. 
            /// V vsakem od podrazredov ustrezno popravite še metodo ToString.          [7 točk]
            ///     
            /// Napišite še razred Zaposleni, 
            /// ki naj ima lastnosti Naprave (seznam naprav, ki jih ima zaposleni) 
            /// in SkupnaVrednost (vsota cen vseh naprav zaposlenega). 
            /// Dodajte še metodo, ki vrne najdražjo napravo zaposlenega, 
            /// in metodo, ki vrne najstarejšo napravo zaposlenega.                     [7 točk]
            /// 
            /// V metodi ResitevNaloge ustvarite eno instanco razreda Zaposleni 
            /// in na njegov seznam dodajte tri naprave različnih tipov. 
            /// Na zaslon s pomočjo klica ustrezne metode izpišite 
            /// ceno najdražje naprave tega zaposlenega.                                [5 točk]
            /// </summary>
            /// 

            /// <summary>
            /// NALOGA 4:
            /// 
            /// V mapi Viri imate pripravljeni dve datoteki s tabelama števil. 
            /// Števila so v posamezni vrstici ločena s tabulatorjem.
            /// 
            /// Pripravite metodo VsotaSodih, v kateri za dano pot do datoteke s tabelo števil 
            /// vsa števila po vrsti združite v en niz (brez presledkov ali tabulatorjev), 
            /// nato v eno spremenljivko seštejte vse števke na sodih mestih v tem nizu 
            /// in v drugo spremenljivko seštejte vse števke na lihih mestih 
            /// (pri tem je prva števka na sodem mestu, saj je na indeksu 0). 
            /// Metoda naj vrne razliko obeh dobljenih vsot.                                [20 točk]
            /// 
            /// V metodi ResitevNaloge že imate pripravljeni dve spremenljivki 
            /// s potema do datotek s primeroma tabel.
            /// V tej metodi pokličite pripravljeno metodo za obe datoteki 
            /// in izpišite rezultata v ukazno vrstico.                                     [5 točke]
            /// </summary>
            /// 


        }
    }
}
