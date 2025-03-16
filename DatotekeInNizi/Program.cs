namespace DatotekeInNizi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PREDAVANJA

            //Naloga1();
            //Naloga2("niziziziz", "i");
            //Naloga3();
            //Naloga4();
            //Naloga5();
            //Naloga6();
            //Naloga7();
            //Naloga8();
            //Naloga9();
            //Naloga10();

            // VAJE
            //Naloga11();
            //Naloga12();
            //Naloga13();
            //Naloga14();
            //Naloga15();
            Console.ReadKey();

        }

        public static void Naloga1()
        {
            /* Naloga 7.1.1.1. Zgoraj smo delali z EMSO stevilko in prebrali letnico rojstva osebe.  Pridobite se ostale podatke o osebi, ki jih lahko prepoznate iz EMSO stevilke. */

            string emso = "1403999505001";
            string dan = emso.Substring(0, 2);
            string spol = Helpers.izracunajSpol(emso.Substring(7, 3));
            int leto = Helpers.izracunajLetnico(emso.Substring(4, 3));
            string mesec = Helpers.izracunajMesec(emso.Substring(2, 2));

            Console.WriteLine("dan: " + dan + " mesec: " + mesec + " leto " + leto + " spol: " + spol);
        }


        public static void Naloga2(string niz, string znak)
        {
            /* Naloga 7.1.1.2. Zapisite metodo, ki kot vhodna podatka dobi niz in znak, vrne pa stevilo pojavitev znaka v nizu.*/
            int stevec = 0;
            for (int i = 0; i < niz.Length; i++)
            {
                string temp = niz.Substring(i, 1);
                if (temp == znak) stevec++;
            }

            Console.WriteLine($"Število znakov {znak} v nizu {niz} je: {stevec}");
        }
        public static void Naloga3()
        {
            /* Naloga 7.1.1.3. Zgornji primer s podatki o osebi smo zapisali precej naivno. V realnih aplikacijah moramo preveriti in precistiti vnose. Na primer, vrednosti za visino, tezo in starost morajo biti stevilske in iz primernih intervalov (npr. starost med 0 in (recimo) 120). Prav tako obicajno statuse izbiramo iz sifrantov, da nimamo nekaj razlicnih zapisov istega statusa ipd. Dopolnite zgornjo kodo s preverjanjem, da spremenljivke res dobijo ustrezne vrednosti in v primeru napak izpisite obvestilo, s sporocilom, kaj je slo narobe.*/

            //TO DO
        }
        public static void Naloga4()
        {
            /* Naloga 7.1.1.4. Napisite metodo, ki uporabniku naroci vpis besede z dano zacetno crko in danim (slucajno izbranim) stevilom znakov med 4 in 8. Nato preverite, ce je odgovor pravilen. Nalogo lahko popestrite tako, da namesto prve crke nakljucno izberete mesto crke, ki jo mora uporabiti.*/
            Random randomStevka = new Random();
            int steviloZnakov = randomStevka.Next(4, 9);
            string zacetnaCrka = Helpers.izracunajZacetnoCrko(randomStevka.Next(1, 26));
            Console.Write($"Zapiši besedo, ki se začne na črko {zacetnaCrka} in je dolga {steviloZnakov} znakov: ");
            string vnesenaBeseda = Console.ReadLine();
            bool pravilenOdgovor = Helpers.preveriOdgovor(vnesenaBeseda, steviloZnakov, zacetnaCrka);

            if (pravilenOdgovor) Console.WriteLine("Beseda ustreza kriterijem");
            else Console.WriteLine("Beseda ne ustreza kriterijem");

        }


        public static void Naloga5()
        {
            /* Naloga 7.1.1.5. Napisite metodo, ki za dani niz vrne stevilo razlicnih znakov v njem. */

            string niz = "nizizizi";
            List<char> unikatniZnaki = new List<char>();

            foreach (char znak in niz)
            {
                if (!unikatniZnaki.Contains(znak))
                {
                    unikatniZnaki.Add(znak);
                }
            }
            Console.WriteLine($"Niz {niz} ima {unikatniZnaki.Count} različnih znakov");
        }
        public static void Naloga6()
        {
            /* Naloga 7.2.1.1. Ustvarite datoteko, ki ima enako ime kot vi in koncnico txt. Uporabite metode iz prejˇsnjih poglavij in v datoteko zapisite prvih sto prastevil, vsako v svojo vrstico.*/
        }
        public static void Naloga7()
        {
            /* Naloga 7.2.1.2. Nalogo 7.1.1.4 popravite tako, da bo metoda vprasanja in odgovore uporabnika zapisala tudi v datoteko.*/
        }
        public static void Naloga8()
        {
            /* Naloga 7.3.1.1. Nase programe pisemo v datoteke, ki so na disku shranjene v datotekah s koncnico cs. Izberite si dve in na zaslon izpisite njuno vsebino. */
        }
        public static void Naloga9()
        {
            /* Naloga 7.3.1.2. Na svojem disku poiscite neko tekstovno datoteko in napisite program, ki bo iz datoteke izpisal vse vrstice, ki vsebujejo enega od treh sumnikov (c, s, z). */

        }
        public static void Naloga10()
        {
            /* Naloga 7.3.1.3. Kodo poljubne spletne strani, ki jo berete v brskalniku, lahko tudi shranite. V brskalniku Chrome to na primer storite s pritiskom tipk CTRL + S. V kodi spletne strani povezavo (angl. hyperlink) najdemo kot vrednost atributa href, zapisano med dvema narekovajema. Primer je npr. href="https://www.example.com". Poiscite vse povezave na spletni strani, ki ste si jo shranili, in jih zapisite v novo datoteko. */
        }
        public static void Naloga11()
        {
            /* Naloga 7.0.0.1. Deklarirajte poljuben seznam nizov in ga zapisite v tekstovno datoteko katere ime izberete sami. */
        }
        public static void Naloga12()
        {
            /* Naloga 7.0.0.2. Vsebino datoteke iz prejsnje naloge znova preberite in jo shranite v nov seznam nizov. */
        }
        public static void Naloga13()
        {
            /* Naloga 7.0.0.3. Prejsnji dve nalogi spremenite v metodi. Prva naj deluje tako, da v primeru obstoja datoteke vsebino le doda v datoteko. */
        }
        public static void Naloga14()
        {
            /* Naloga 7.0.0.4. Napisite program, ki bo uporabniku omogocal shranjevanje podatkov o letni porabi financ. Pri tem naj ima uporabnik na voljo za vnos cene racuna in datuma placila (dan, mesec, leto). Premislite kako bi zeleli lociti posamezne stroske glede na namen porabe (hrana, gospodinjstvo, oblacila, voda, elektrika, potovanje, razno ...), kar naj bo razvidno pri zapisu v datoteko. Vsi podatki naj se ustrezno shranijo v eno datoteko. Ime datoteke za vnos naj se prebere ob delovanju programa. */
        }
        public static void Naloga15()
        {
            /* Naloga 7.0.0.5. Program iz prejsnje naloge ustrezno razsirite tako, se ob zagonu vsebina datoteke, katere ime poda uporabnik, najprej prebere. Nato naj ima uporabnik moznost dodajanja novih porab financ ali moznosti hitre analize stroskov. Na primer: vsota po mesecih, vsota po namenu, letna vsota, itd. */
        }
    }
}
