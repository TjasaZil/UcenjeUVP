namespace RazrediInObjekti
{
    internal class Banka
    {


        // 8.3 Banka
        public static void Naloga16()
        {
            /* Naloga 8.3.0.1. Ustvarite objekt Stranka s polji: ime (string), naslov (string), starost (int) in spol (char). Dodajte mu konstruktor za poljubno dolocitev vrednosti vseh polj. */
        }
        public static void Naloga17()
        {
            /* Naloga 8.3.0.2. Ustvarite objekt BancniRacun s polji: stevilka bancnega racuna (int),stranka (Stranka), stanje na racunu (double), seznam transakcij (List<double>) in mudodajte konstruktor, ki nastavi zacetno vrednost za stevilko racuna in stranko. Dodajte mu se funkcionalnosti za polog in izplacilo, ki naj se dodajo v seznam transakcij, ter za
                  prikaz financnega stanja stranke na racunu. Vsebuje naj tudi izpis vseh transakcij na racunu. */
        }
        public static void Naloga18()
        {
            /* Naloga 8.3.0.3. Objektu Stranka dodajte polje denarnica (double) in popravite funkcionalnosti za polog in izplacilo razreda BancniRacun, da popravite tudi stanje v denarnici stranke (najprej morate preveriti, ali je podana vrednost za polog oz. izplacilo sploh mogoca). */
        }
        public static void Naloga19()
        {
            /* Naloga 8.3.0.4. Ustvarite objekt Banka, ki shranjuje seznam strank in bancnih racunov. Vsebovati mora tudi funkcionalnost za izpis stevilke racuna in stanja za vse bancne racune glede na ime stranke. Ob tem naj vsebuje tudi funkcionalnosti za ustvariti racun stranke, ter za izbris racuna stranke po stevilki racuna. V kolikor stranka nima vec nobenega racuna na banki, naj se izbrise iz seznama strank. */
        }
        public static void Naloga20()
        {
            /* Naloga 8.3.0.5. Ustvarite razred UporabniskiVmesnik za upravljanje banke. Uporabnik naj ima na voljo kreiranje novega bancnega racuna, brisanje obstojecega bancnega racuna in vpogled v stanje svojih bancnih racunov. Ob tem naj ima moznost tudi upravljanja z dolocenim bancnim racunom, kjer lahko opravi polog, izplacilo ali pa izpis transakcij na
                bancnem racunu. */
        }

        public static void Naloga21()
        {
            /* Naloga 8.3.0.6. Programu za upravljanje z banko dodajte moznost za shranjevanje podatkov v datoteko in branje iz nje tako, da boste lahko vsakic, ko ponovno poˇzenete program ponovno upravljali z enakim stanjem, kot ste program zakljucili. */
        }
        public static void Naloga22()
        {
            /* Naloga 8.3.0.7 (Dodatno). V program za upravljanje banke v celoti vkljucite moznost za nakazilo sredstev na poljuben obstojeci bancni racun glede na stevilo racuna. */
        }
    }
}
