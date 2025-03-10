namespace Izpit_2024_04_20
{
    internal class Program
    {
        static void Main(string[] args)
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

            /// <summary>
            /// NALOGA 2:
            /// 
            /// Člani atletskega kluba se z avtobusom odpravljajo na tekmovanje.
            /// S seboj imajo kup atletske prtljage.
            /// Da svoje opreme ne bi izgubili, si želijo pripraviti evidenco.
            /// Pomagajte jim tako, da pripravite naslednje razrede.
            /// 
            /// Razred AtletskoOrodje, ki ima lastnosti Proizvajalec in LetnicaProizvodnje.
            /// V razredu pripravite še natanko en konstruktor, 
            /// ki kot parameter dobi proizvajalca orodja. 
            /// Povozite tudi metodo ToString.                                  [6 točk]
            /// 
            /// Za razred AtletskoOrodje pripravite tri podrazrede, 
            /// ki vsak predstavlja eno od atletskih orodij 
            /// (npr. kroglo, kopje, disk, kladivo).
            /// V vsakem razredu določite eno primerno specifično lastnost,
            /// konstruktor in povozite metodo ToString.                        [10 točk]
            /// 
            /// Pripravite še razred AtletskiKlub, ki ima lastnosti
            /// Naziv, Naslov in SeznamOrodij.
            /// V njem povozite metodo ToString, ki naj vrača opis kluba.       [4 točk]
            /// 
            /// V metodi ResitevNaloge ustvarite eno instanco razreda AtletskiKlub 
            /// in na njegov seznam dodajte tri atletska orodja različnih tipov.
            ///                                                                 [5 točk]
            /// </summary>
            /// 

            /// <summary>
            /// NALOGA 3:
            /// Pripravite razreda Predstava in Gledalisce.
            /// 
            /// Razred Predstava naj vsebuje:
            /// -   Lastnosti Naslov, Avtor, Datum, UraPricetka (kot celo število), 
            ///     CasTrajanja (v urah, ki so lahko decimalno število).
            /// -   Natanko en konstruktor, ki nastavi samo lastnost UraPricetka.                      
            /// -   Metodo ToString, ki izpiše vse podrobnosti o predstavi.           [6 točk]
            /// 
            /// Razred Gledalisce naj vsebuje: 
            /// -   Lastnosti Naziv, Naslov, Direktor, SeznamPredstav.
            /// -   En konstruktor, ki omogoča določitev natanko dveh lastnosti, 
            ///     in en prazen konstruktor, v katerem inicializirate seznam predstav.
            /// -   Metodo ToString, ki naj izpiše vse podrobnosti o gledališču,
            ///     vključno z vsemi predstavami.                                       [8 točk]
            ///     
            /// V razredu Gledalisce napišite še metodo IzpišiPredstave, 
            /// ki v ukazno vrstico izpiše vse predstave, ki se končajo 
            /// (pozor - končajo, ne začnejo!) do dane ure.
            /// Število takih predstav pa metoda vrne.                                  [6 točk]
            /// 
            /// V metodi ResitevNaloge kreirajte instanco razreda Gledalisce, 
            /// ki naj vsebuje vsaj tri predstave. 
            /// Pokličite še metodo IzpišiPredstave.                                    [5 točk]
            /// </summary>
            /// 

            /// <summary>
            /// NALOGA 4:
            /// 
            /// V mapi Viri imate pripravljeni dve datoteki s tabelama števil. 
            /// Števila so v posamezni vrstici ločena s tabulatorjem.
            /// 
            /// Napišite metodo, ki kot parameter prejme pot do datoteke s tabelo števil.   
            /// Metoda naj v vsaki vrstici preveri, če je v njej več sodih ali lihih števil.
            /// Število vrstic, v katerih je (strogo) več lihih števil, naj metoda vrne.     [20 točk]
            /// 
            /// V metodi ResitevNaloge že imate pripravljeni dve spremenljivki 
            /// s potema do datotek s primeroma tabel.
            /// V tej metodi pokličite pripravljeno metodo za obe datoteki 
            /// in izpišite rezultat v ukazno vrstico.                                      [5 točke]
            /// </summary>
            /// 


        }
    }
}
