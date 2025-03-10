namespace Izpit_2024_04_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// NALOGA 1:
            /// 
            /// Napišite metodo Frekvenca, ki kot parameter prejme seznam besed in znak. 
            /// Naloga metode je prešteti število besed na seznamu, 
            /// ki vsebujejo vsaj eno črko enako danemu znaku 
            /// (med velikimi in malimi črkami ne razlikujemo). 
            /// Število takih besed naj metoda vrne.                                [12 točk]
            /// 
            /// Dodatno naj ob pregledu besed iz seznama metoda v ukazno vrstico izpiše 
            /// vsako besedo, ki dani znak vsebuje vsaj dvakrat.                    [8 točk]
            /// 
            /// V metodi ResitevNaloge pripravite seznam z vsaj petimi besedami,
            /// pokličite metodo Frekvenca in izpišite število besed s seznama, 
            /// ki vsebujejo znak 'a'.                                              [5 točk]
            /// </summary>
            /// 

            /// <summary>
            /// NALOGA 2:
            /// 
            /// Pripravite razreda PostnaPoslovalnica in Posiljka.
            /// Posiljka predstavlja posamezno pošiljko, ki jo poštna poslovalnica 
            /// prejme v obravnavo. Vsaka pošiljka naj ima lastnosti datum pošiljanja,
            /// naslov prejemnika in ali naj se obravnava prednostno ali ne.
            /// Razred Posiljka naj vsebuje še konstruktor, 
            /// ki kot parameter prejme naslov prejemnika.
            /// Razred PostnaPoslovalnica naj ima lastnosti, 
            /// ki določajo naslov poslovalnice, 
            /// seznam pošiljk in ime direktorja poslovalnice.                  [10 točk]
            /// 
            /// Za razred Posiljka definirajte še tri ustrezne podrazrede,
            /// ki bodo predstavljali bolj specifične tipe poštnih pošiljk 
            /// (en takšen tip je npr. razglednica) in za vsakega od razredov 
            /// določite po eno ustrezno (specifično) lastnost.                 [5 točk]
            /// 
            /// V razredu Posiljka povozite metodo ToString, da bo vračala 
            /// opis pošiljke.
            /// Metodo ToString dopolnite tudi v vseh podrazredih, 
            /// da bo ustrezno izpisovala tudi njihove posebne lastnosti.       [5 točk]
            /// 
            /// V metodi ResitevNaloge ustvarite eno instanco razreda PostnaPoslovalnica 
            /// in na njen seznam dodajte tri pošiljke različnih tipov.         [5 točk]
            /// </summary>
            /// 

            /// <summary>
            /// NALOGA 3:
            /// Pripravite razrede Kviz, Vprasanje in Odgovor.
            /// 
            /// Razred Odgovor naj vsebuje:
            /// -   Lastnosti Besedilo in Oznaka (oznaka je črka, ki označuje odgovor, 
            ///     ko imamo na vprašanja na voljo nekaj odgovorov).
            /// -   Konstruktor, ki omogoča določitev obeh lastnosti.                   [3 točke]
            /// 
            /// Razred Vprasanje naj vsebuje:
            /// -   Lastnosti Besedilo (tu bo besedilo vprašanja), 
            ///     MozniOdgovori (to bo seznam možnih odgovorov) in SteviloTock.
            /// -   Natanko en konstruktor, ki nastavi vsaj dve lastnosti.                      
            /// -   Povozite metodo ToString, ki izpiše vprašanje skupaj z možnimi odgovori 
            ///     in številom točk za pravilen odgovor.               
            /// -   Napišite objektno metodo PodajVprasanje, ki izpiše vprašanje 
            ///     in od uporabnika pričakuje odgovor - črko oznake odgovora - 
            ///     ter to črko vrne.                                                   [12 točk]
            /// 
            /// Razred Kviz naj vsebuje: 
            /// -   Lastnosti Naziv, Datum, 
            ///     CasResevanja (tej lastnosti lahko vrednost nastavimo samo v konstruktorju!),
            ///     Vprasanja (seznam vprasanj).
            /// -   En konstruktor, ki omogoča določitev natanko ene lastnosti, 
            ///     in en prazen konstruktor, v katerem določimo čas reševanja.
            /// -   Povozite metodo ToString, ki naj izpiše kviz z vsemi vprašanji.     [5 točk]
            /// 
            /// V metodi ResitevNaloge kreirajte instanco razreda Kviz, 
            /// ki naj vsebuje vsaj pet vprašanj, vsako vprašanje pa naj ima 
            /// vsaj dva možna odgovora. 
            /// Za vsa vprašanja na kvizu pokličite metodo PodajVprasanje.              [5 točk]
            /// </summary>
            /// 

            /// <summary>
            /// NALOGA 4:
            /// 
            /// V mapi Viri imate pripravljeni dve datoteki s tabelama števil. 
            /// Števila so v posamezni vrstici ločena s tabulatorjem.
            /// 
            /// Napišite metodo, ki kot parameter prejme pot do datoteke s tabelo števil.   [2 točki]
            /// Metoda naj v vsaki vrstici poišče največje in najmanjše število 
            /// ter ju shrani v ustrezno podatkovno strukturo.                              [10 točk]
            /// Na koncu naj izračuna vsoto vseh največjih števil po vrsticah in 
            /// vsoto vseh najmanjših števil po vrsticah ter ti vsoti odšteje.              [8 točk]
            /// Rezultat odštevanja naj metoda vrne.                                        [2 točki]
            /// 
            /// V metodi ResitevNaloge že imate pripravljeni dve spremenljivki 
            /// s potema do datotek s primeroma tabel.
            /// V tej metodi pokličite pripravljeno metodo za obe datoteki 
            /// in izpišite rezultat v ukazno vrstico.                                      [3 točke]
            /// </summary>
            /// 


        }
    }
}
