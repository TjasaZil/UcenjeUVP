namespace SpremenljivkeInTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //PREDAVANJA

            /* Naloga 2.2.1.1. Definirajte pet spremenljivk razlicnih tipov, dolocite jim poljubne vrednosti in na zaslon izpisite njihovo ime ter vrednost. 
              Pred vsako od spremenljivk dodajte
                se komentar z njenim opisom. */


            char znak = 'A';
            Console.WriteLine($"To je spremenljivka tipa char, imena {nameof(znak)} in vrednosti {znak}.");

            int stevka = 2;
            Console.WriteLine($"To je spremenljivka tipa int, imena {nameof(stevka)} in vrednosti {stevka}.");

            ulong dolgaStevka = 12345678900987654321;
            Console.WriteLine($"To je spremenljivka tipa ulong, imena {nameof(dolgaStevka)} in vrednosti {dolgaStevka}.");

            short kratkaStevka = 123;
            Console.WriteLine($"To je spremenljivka tipa short, imena {nameof(kratkaStevka)} in vrednosti {kratkaStevka}.");

            string besedilo = "abcdefg";
            Console.WriteLine($"To je spremenljivka tipa string, imena {nameof(besedilo)} in vrednosti {besedilo}.");

            bool trueAliFalse = true;
            Console.WriteLine($"To je spremenljivka tipa bool, imena {nameof(trueAliFalse)} in vrednosti {trueAliFalse}.");


            /* Naloga 2.2.1.2. Za vsako izmed naslednjih vrednosti ustvarite spremenljivko ustreznega
            tipa in vanjo shranite eno vrednost:
             naslov priljubljenega filma,
             stevilo igralcev na kosarkarski tekmi,
             ali je partija saha zakljucena,
             cena izdelka v trgovini,
             zacetnica priimka avtorja knjige. */


            string naslovFilma = "Gladiator";
            int steviloKosarkasev = 10;
            bool sahZakljucen = true;
            double cenaIzdelka = 3.75D;
            char zacetnicaImena = 'J';


            /* Naloga 2.2.1.3. Zapisite priblizek stevila π s tremi razlicnimi tipi na vsaj stiri decimalna
            mesta natancno. */


            float floaty = 3.1415F;
            double doubly = 3.1415D;
            decimal decimalka = 3.1415M;
            Console.WriteLine($"float spremenljivka za pi vrne {floaty}, double vrne {doubly}, decimal pa {decimalka}.");


            /* Naloga 2.2.1.4. Ustvarite dve spremenljivki, v eno shranite svoje ime in v drugo svoj
            priimek. Nato na zaslon v eni vrstici izpisite “Jaz sem IME PRIIMEK”. */


            string ime = "Tjasa";
            string priimek = "Zilavec";
            Console.WriteLine($"Jaz sem {ime} {priimek}");


            /* Naloga 2.2.1.5. Na zaslon izpisite svoj naslov v treh vrsticah s pomocjo treh spremenljivk,
            ki shranjujejo: ime in priimek, ulica in hisna stevilka, postna stevilka in posta. Kako bi to
            storili, ce bi lahko uporabili le eno spremenljivko? */


            string imeInPriimek = "Tjasa Zilavec \n";
            string naslov = "Ulica 123 \n";
            string posta = "1000 Ljubljana";
            Console.WriteLine($"Uporabila sem le več spremenljivk:\n {imeInPriimek} {naslov} {posta}");

            string jaz = "Tjasa Zilavec \n Ulica 123 \n 1000 Ljubljana";
            Console.WriteLine($"Uporabila sem le eno spremenljivko:\n {jaz}");


            /* Naloga 2.2.1.6. V ukazno vrstico izpisite svoje ime samo z uporabo spremenljivk tipa
            char. Pri tem uporabite ukaz Console.Write(), ki deluje podobno kot Console.WriteLine(),
            le da ob izpisu vrednosti ne skoci v naslednjo vrstico. */


            char t = 'T';
            char j = 'j';
            char a = 'a';
            char s = 's';
            Console.Write($"ime: {t}{j}{a}{s}{a}");


            /* Naloga 2.2.1.7. S kombinacijo ukazov Console.Write() in Console.WriteLine() izpisite
            seznam predmetov, ki ste jih oziroma jih obiskujete in pricakovano oceno za vsakega od
            njih. */


            Console.Write("predmet: Uvod v Informatiko -> ");
            Console.WriteLine("pricakovana ocena: 10");
            Console.Write("predmet: Uvod v Algoritme -> ");
            Console.WriteLine("pricakovana ocena: 10");
            Console.Write("predmet: Uvod v Programiranje -> ");
            Console.WriteLine("pricakovana ocena: 10");
            Console.Write("predmet: Baze podatkov in modeliranje podatkov -> ");
            Console.WriteLine("pricakovana ocena: 10");
            Console.Write("predmet: Spletno programiranje -> ");
            Console.WriteLine("pricakovana ocena: 10");
            Console.Write("predmet: Projekt razvoja spletne programske rešitve -> ");
            Console.WriteLine("pricakovana ocena: 10");


            /* Naloga 2.2.1.8. Deklarirajte tri celostevilske spremenljivke in jim dolocite poljubne vrednosti. Vse tri spremenljivke nato sestejte in shranite v spremenljivko, ki jo na koncu
            program izpise na zaslon. Uporabite lahko le tri spremenljivke, ki ste jih deklarirali. */


            int stevilka1 = 1;
            short stevilka2 = -2;
            ushort stevilka3 = 3;
            long vsota = stevilka1 + stevilka2 + stevilka3;

            Console.WriteLine($"Vsota števk {stevilka1}, {stevilka2} in {stevilka3} je {vsota}");


            /* Naloga 2.2.1.9. Deklarirajte dve spremenljivki enakega tipa, dolocite jima poljubno vrednost in ju izpisite na zaslon. Nato spremenljivkama v programu zamenjajte vrednosti in
            na zaslon izpisite njune nove vrednosti. */

            int prvaSpremenljivka = 3;
            char drugaSpremenljivka = 'b';
            Console.WriteLine($"Spremenljivke pred spremembo: {prvaSpremenljivka}, {drugaSpremenljivka}");

            prvaSpremenljivka = 2;
            drugaSpremenljivka = 'c';
            Console.WriteLine($"Spremenljivke po spremembi: {prvaSpremenljivka}, {drugaSpremenljivka}");

            Console.ReadKey();
        }
    }
}
