namespace Izpit_2024_03_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// NALOGA 1:
            /// Napišite metodo RezultatiIzpita, ki ne prejme nobenega parametra,
            /// vrača pa decimalno število. 
            /// V njej od uporabnika zahtevajte vnos podatkov (preko ukazne vrstice) 
            /// o študentih, ki so pisali izpit. Za vsakega študenta naj 
            /// vpiše vpisno številko in število doseženih točk.
            /// Podatke naj vnaša, dokler ne vnese vrednosti "X", 
            /// ki naj pomeni izhod iz vnosa podatkov.                          [10 točk]
            /// 
            /// Pridobljeni podatki za vsakega študenta naj se zapišejo
            /// kot lastnost v instanco razreda StudentData 
            /// (ta razred bo torej imel dve lastnosti).
            /// Vse instance shranite v seznam.                                 [5 točk]
            /// 
            /// V metodi v ukazno vrstico izpišite največje število doseženih točk
            /// ter najmanjše število doseženih točk.                           [5 točk]
            /// 
            /// Na koncu naj metoda RezultatiIzpita vrne povprečno število doseženih točk.
            /// Metodo še pokličite v metodi ResitevNaloge in izpišite dobljeni rezultat 
            /// v ukazno vrstico.                                               [5 točk]
            /// </summary>

            /// <summary>
            /// NALOGA 2:
            /// 
            /// Pripravite razreda Prostor in Zgradba.
            /// Prostor naj ima kot lastnosti površino in ime prostora, Zgradba pa
            /// naj ima za lastnost seznam prostorov.                   [3 točke]
            /// 
            /// Pripravite razreda StanovanjskiBlok in Hisa,
            /// ki naj dedujeta iz razreda Zgradba.
            /// Vsakemu od teh dveh razredov določite še po eno specifično lastnost.
            ///                                                         [5 točk]
            /// 
            /// V razredu Zgradba povozite metodo ToString, da bo vračala zapis
            /// vseh prostorov v zgradbi skupaj z njihovo površino.
            /// Metodo ToString dopolnite v obeh podrazredih, da bo ustrezno 
            /// izpisovala tudi njuni posebni lastnosti.                [5 točk]
            /// 
            /// V razredu Zgradba napišite metodo ŠteviloProstorov, 
            /// ki bo vrnila število vseh prostorov,
            /// katerih površina je večja od danega parametra.          [7 točk]
            ///                                                         
            /// V metodi ResitevNaloge ustvarite tri instance razreda Hisa 
            /// in dve instanci razreda StanovanjskiBlok. 
            /// Vsaki od instanc dodajte na seznam prostorov vsaj dva prostora.
            /// Na koncu za dve od instanc izpišite število prostorov 
            /// večjih od 10 kvadratnih metrov.                         [5 točk]
            /// </summary>

            /// <summary>
            /// NALOGA 3:
            /// Pripravite razreda Izpit in IzpitnaNaloga.
            /// 
            /// Razred IzpitnaNaloga naj vsebuje:
            /// -   Lastnosti ZaporednaStevilka, Tezavnost (od 1 do 5), SteviloTock, Besedilo.
            /// -   Natanko en konstruktor, ki nastavi vsaj dve lastnosti.                      
            /// -   Povozite metodo ToString, ki naj izpiše vse podatke o nalogi.               [8 točk]
            /// 
            /// Razred Izpit naj vsebuje: 
            /// -   Lastnosti ImePredmeta, ZaporednaStevilka (prvi, drugi, ...), Datum, 
            ///     CasPisanja (tej lastnosti lahko vrednost nastavimo samo v konstruktorju!),
            ///     Naloge (seznam nalog).
            /// -   En konstruktor, ki omogoča določitev natanko dveh lastnosti, 
            ///     in en prazen konstruktor, ki naj vseeno določi čas pisanja.
            ///     V obeh konstruktorjih inicializirajte seznam nalog.
            /// -   Povozite metodo ToString, ki naj izpiše vse podatke o izpitu.               
            /// -   Napišite metodo, ki izpiše vse izpitne naloge, 
            ///     katerih besedilo vsebuje vsaj 300 znakov.                                   [12 točk]
            /// 
            /// V metodi ResitevNaloge kreirajte instanco razreda Izpit, ki naj vsebuje vsaj pet izpitnih nalog
            /// in izpišite podatke o vseh nalogah, pri katerih lahko dosežemo vsaj 10 točk 
            /// in katerih težavnost je nižja od 4.                                             [5 točk]
            /// </summary>

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
        }
    }
}
