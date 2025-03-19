namespace DedovanjeInPolimorfizmi
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // PREDAVANJA

            Naloga1();
            Naloga2();
            Naloga3();

            // VAJE
            Naloga4();
            Naloga5();
            Naloga6();
            Naloga7();
            Naloga8();
            Naloga9();
            Naloga10();
            Console.ReadKey();

        }

        public static void Naloga1()
        {

            /* Naloga 9.1.1.1. Napisite razred Panoga, ki predstavlja atletsko panogo. Dodajte ji lastnost Opis in povozite metodo ToString. Zanjo naredite pet podrazredov za pet razlicnih specificnih panog in vsaki dodajte nekaj dodatnih lastnosti ter povozite metodo ToString.*/

        }
        public static void Naloga2()
        {

            /* Naloga 9.1.1.2. Definirajte razreda Menu in Jed. Menu naj predstavlja dnevni menu v restavraciji (glede na dan), ki ima kot lastnost tudi seznam jedi. Posamezna jed ima lastnosti naziv in cena.*/
        }
        public static void Naloga3()
        {
            /* Naloga 9.2.1.1. Zapisite razred Produkt in mu smiselno doloˇcite dve virtualni metodi in dve lastnosti. Nato pripravite se tri podrazrede, npr. Oblacilo, Obutev, Pripomocek in razmislite, katere lastnosti bi jim definirali (vsakemu od njih vsaj dve). Razmislite tudi ali potrebujemo nadaljnjo vejitev na podrazrede. Ce je odgovor da, naredite se vejitev  na naslednji nivo. Na koncu ustvarite nekaj razlicnih produktov, jih dodajte na skupen seznam in glede na njihov tip izpiˇsite eno od njihovih kljuˇcnih lastnosti. */
        }
        public static void Naloga4()
        {
            /*  Naloga 9.0.0.1. Ustvarite razreda Hisa in Blok, ki dedujeta iz razreda Zgradba (razred Zgradba se navezuje na nalogo 8.2.0.1). Pri tem je potrebno povoziti metodi za gradnjo in rusenje. */
        }
        public static void Naloga5()
        {
            /* Naloga 9.0.0.2. Ustvarite razred Tocka z lastnostmi za oznako in barvo. Dodajte mu se konstruktor za dolocitev poljubne vrednosti vseh polj in povozite metodo ToString, da izpisete lastnosti tocke. */
        }
        public static void Naloga6()
        {
            /* Naloga 9.0.0.3. Ustvarite razred Tocka2D, ki deduje iz razreda Tocka. Dodajte mu lastnosti za koordinato X in koordinato Y. Dodajte mu se konstruktor, ki obe koordinate nastavi na 0 in konstruktor za dolocitev poljubne vrednosti vseh polj. Povozite tudi metodo ToString, da izpisete lastnosti tocke in njene koordinate. */
        }
        public static void Naloga7()
        {
            /* Naloga 9.0.0.4. Ustvarite razred Tocka3D, ki deduje iz razreda Tocka2D. Dodajte mu lastnost za koordinato Z. Dodajte mu se konstruktor, ki vse koordinate nastavi na 0 in konstruktor za dolocitev poljubne vrednosti vseh polj. Povozite tudi metodo ToString, da izpisete lastnosti tocke in njene koordinate (izpis naj bo lepo sestavljen). */
        }
        public static void Naloga8()
        {
            /* Naloga 9.0.0.5. V programu ustvarite seznam nekaj tock razlicnih tipov (Tocka, Tocka2D, Tocka3D). Nato prestejte koliko tock tipa Tocka2D ali tipa Tocka3D je v vasem seznamu. */
        }
        public static void Naloga9()
        {
            /* Naloga 9.0.0.6. Iz seznama, ki ste ga ustvarili v prejsnji nalogi izpisite podatke vseh tock, ki so tipa Tocka2D, niso pa tipa Tocka oz. Tocka3D. */
        }
        public static void Naloga10()
        {
            /* Naloga 9.0.0.7. V razredih Tocka2D in Tocka3D napisite metodo za sestevek vseh koordinat. Nato za seznam iz prejsnjih dveh nalog ugotovite koliksen je skupni sestevek vseh koordinat, ki jih imamo zapisane. */
        }
    }
}
