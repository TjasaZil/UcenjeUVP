namespace Izpit_2024_09_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// NALOGA 1:
            /// 
            /// Napišite metodo PovprecjeVeljavnih, ki kot parameter prejme tabelo nizov (spremenljivk tipa string). 
            /// Za vsak element tabele naj preveri, če predstavlja celo število ali ne.
            /// V ukazno vrstico naj metoda izpiše število elementov, ki predstavljajo cela števila,
            /// vrne pa naj povprečje njihovih vrednosti.                               [20 točk]
            /// 
            /// V metodi ResitevNaloge pripravite tabelo z vsaj desetimi nizi, 
            /// od katerih naj jih vsaj pet predstavlja celo število. 
            /// Pokličite metodo PovprecjeVeljavnih in izpišite vrednost, 
            /// ki jo metoda vrne, v ukazno vrstico.                                    [5 točk]
            /// </summary>
            /// 

            /// <summary>
            /// NALOGA 2:
            /// 
            /// Večina večjih podjetij ima tudi svoj vozni park, za katerega je treba ustrezno skrbeti. 
            /// Vsako vozilo mora imeti redno servisiranje, registracijo ipd. 
            /// Pripravite razreda Podjetje in Vozilo. 
            /// Vsako podjetje ima seznam vozil, ki predstavljajo vozni park podjetja.
            /// 
            /// Razred Vozilo naj vsebuje: 
            /// - Lastnosti RegistrskaStevilka, Znamka, Letnik, Tip (kombi, avto, kamion) in DatumRegistracije.
            /// - Natanko en konstruktor, ki nastavi lastnost RegistrskaStevilka.
            /// - Metodo ToString, ki izpiše vse lastnosti vozila.                              [5 točk]
            /// 
            /// Razred Podjetje naj vsebuje: 
            /// - Lastnosti Naziv, Naslov, Dejavnost in VozniPark.
            ///   Vse lastnosti naj imajo ustrezen tip.
            /// - En prazen konstruktor.
            /// - Metodo ToString, ki naj izpiše vse podrobnosti o podjetju.
            /// - Metodo, ki vrne skupno število vozil letnika manjšega od danega parametra.
            /// - Metodo, ki vrne vozilo, katero ima najbližji datum registracije.              [15 točk]
            /// 
            /// V metodi ResitevNaloge kreirajte tri instance razreda Vozilo in 
            /// eno instanco razreda Podjetje. 
            /// Nato v ukazno vrstico izpišite podatke o podjetju 
            /// ter katero vozilo iz voznega parka podjetja ima najbližji datum registracije.   [5 točk]
            /// </summary>
            /// 

            /// <summary>
            /// NALOGA 3:
            /// Za potrebe društva tabornikov pripravljamo aplikacijo za evidentiranje dreves v gozdovih.
            /// 
            /// Napišite razred Drevo, ki ima lastnosti Vrsta, Višina, Volumen in Starost. 
            /// V razredu pripravite še natanko en konstruktor, 
            /// ki kot parameter dobi vrsto drevesa. 
            /// Povozite tudi metodo ToString.                                          [6 točk]
            /// 
            /// Za razred Drevo pripravite dva podrazreda: Listavec in Iglavec. 
            /// Za vsakega od podrazredov si zamislite po eno ustrezno 
            /// specifično lastnost in jo implementirajte. 
            /// V vsakem od podrazredov ustrezno popravite še metodo ToString.          [7 točk]
            ///     
            /// Napišite še razred Gozd, ki naj ima lastnosti Lokacija in Drevesa.
            /// Dodajte še metodo, ki vrne skupen volumen iglavcev v gozdu, 
            /// in metodo, ki vrne povprečno starost dreves, 
            /// katera imajo višino višjo od danega parametra.                          [7 točk]
            /// 
            /// V metodi ResitevNaloge ustvarite eno instanco razreda Gozd 
            /// in na njegov seznam dreves dodajte štiri drevesa različnih tipov. 
            /// V ukazno vrstico s pomočjo klica ustrezne metode 
            /// izpišite skupen volumen vseh iglavcev v gozdu.                          [5 točk]
            /// </summary>
            /// 

            /// <summary>
            /// NALOGA 4:
            /// 
            /// V mapi Viri imate pripravljeni dve datoteki s tabelama števil. 
            /// Števila so v posamezni vrstici ločena s tabulatorjem.
            /// 
            /// Pripravite metodo AnalizaZadnjih, ki kot parameter dobi 
            /// pot do datoteke s tabelo števil. 
            /// Prebere naj zadnje število v vsaki vrstici, 
            /// poišče najmanjše med vsemi in ga prišteje prvemu številu vsake vrstice. 
            /// Tako popravljeno tabelo zapišite v novo datoteko, 
            /// katere ime prav tako prejmete kot parameter metode.                         [20 točk]
            /// 
            /// V metodi ResitevNaloge že imate pripravljeni dve spremenljivki 
            /// s potema do datotek s primeroma tabel.
            /// V tej metodi pokličite pripravljeno metodo za obe datoteki. 
            /// Rezultat bosta dve novi datoteki.                                           [5 točke]
            /// </summary>
            /// 


        }
    }
}
