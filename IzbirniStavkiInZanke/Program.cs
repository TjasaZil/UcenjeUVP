﻿namespace IzbirniStavkiInZanke
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //PREDAVANJA
            /* Naloga 4.1.3.1. Definirajte spremenljivko ocena in ji kot vrednost podajte stevilsko oceno, ki jo pricakujete pri tem predmetu. Nato s pomocjo stavka if - else if izpisite opisno ime vase pricakovane ocene (6 - zadostno, 7 - dobro, 8 in 9 - prav dobro, 10 - odlicno).*/

            int ocena = 8;

            if (ocena == 10)
            {
                Console.WriteLine("odlično");
            }
            else if (ocena == 9 || ocena == 8)
            {
                Console.WriteLine("prav dobro");
            }
            else if (ocena == 7)
            {
                Console.WriteLine("dobro");
            }
            else if (ocena == 6)
            {
                Console.WriteLine("zadostno");
            }
            else
            {
                Console.WriteLine("nezadostno");
            }

            /* Naloga 4.1.3.2. Definirajte spremenljivko, ki kot vrednost prejme stevilko meseca (1 za
            januar, 2 za februar itd.). Pripravite izpis, ki bo povedal, ce ima mesec 31 dni ali ne. */


            int mesec = 6;

            if (mesec == 1 || mesec == 3 || mesec == 5 || mesec == 7 || mesec == 8 || mesec == 10 || mesec == 12)
            {
                Console.WriteLine("mesec ima 31 dni");
            }
            else
            {
                Console.WriteLine("mesec nima 31 dni");
            }

            /* Naloga 4.1.3.3. V programiranju se izogibamo pisanju enake kode veckrat, kot je nujno
            potrebno. Nalogo 4.1.3.2 resite s stavkom switch, ki bo imel le dve jedri, pa vseeno 12
            stavkov case. */
            /* Naloga 4.1.3.4. Se enkrat resite Nalogo 4.1.3.2 s stavkom switch, ki bo imel le dve jedri,
            vendar tokrat z uporabo primerjalnih vzorcev v dveh stavkih case. */


            switch (mesec)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("mesec ima 31 dni");
                    break;
                default:
                    Console.WriteLine("mesec nima 31 dni");
                    break;
            }


            /* Naloga 4.2.1.1. Za dano stevilo n izracunajte in izpisite vsoto vseh stevil od 1 do n. */


            int n = 10;
            int vsota = 0;
            for (int i = 0; i <= n; i++)
            {
                vsota += i;
            }

            Console.WriteLine($"vsota vseh števil do {n} je {vsota}");


            /* Naloga 4.2.1.2. Za dano stevilo n izracunajte in izpisite vsoto vseh stevil od 1 do n, ki so deljiva s 7. */


            vsota = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 7 == 0) { vsota += i; }

            }
            Console.WriteLine($"vsota vseh števil do {n}, ki so deljiva s 7, je {vsota}");


            /*  Naloga 4.2.1.3. Za dano stevilo n zapisite njegovo vrednost v petiskem sistemu.  */

            n = 643;
            string petiskiZapis = "";
            int ost;
            int stevilo = n;

            while (stevilo > 0)
            {
                ost = stevilo % 5;
                petiskiZapis = ost.ToString() + petiskiZapis;
                stevilo /= 5;
            }

            Console.WriteLine($"Število {n} v petiškem sistemu je: {petiskiZapis}");


            /* Naloga 4.2.1.4. Fibonaccijevo zaporedje je definirano z rekurzivno zvezo an = an−1+an−2, kjer sta a1 = 1 in a2 = 1. Izpisite prvih 20 clenov zaporedja. Poskusite nalogo resiti se z uporabo zgolj dveh spremenljivk (poleg iteratorja zanke). */

            int a = 1, b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 3; i <= 20; i++)
            {
                b = a + b;
                Console.WriteLine(b);
                a = b - a;
            }


            /* Naloga 4.2.1.5. Uporabite dve gnezdeni zanki in ustrezne stavke if za izris diamanta, ki ima eno stranico dolzine n, s pomocjo zvezdic. Rezultat za n = 4 mora biti kot spodaj.

               *
              * *
             *   *
            *     *
             *   *
              * *
               *
               
               */


            /* Naloga 4.3.1.1. Razmislite, kako bi primer z odgovarjanjem, dokler ne podate pravilnega odgovora, resili brez stavka break. */


            /* Naloga 4.3.1.2. Z uporabo stavka break izpisite zaporedje stevil od 1 do n, tako da bo v prvi vrstici samo stevilo 1, v drugi 1 in 2 in tako dalje do zadnje vrstice, kjer bodo izpisana vsa stevila. */


            //VAJE

            /* Naloga 2.1.0.1. Napisite program, ki za dano celo stevilo preveri ali je sodo ali liho. */

            int celoStevilo = 5;
            if (celoStevilo % 2 == 0)
            {
                Console.WriteLine("Stevilo je sodo");
            }
            else
            {
                Console.WriteLine("Stevilo je liho");

            }

            /* Naloga 2.1.0.2. Napisite program, ki za dve dani realni stevili izpise vecjega izmed njiju. */

            int x = 5;
            int y = 10;
            if (x > y)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(y);

            }

            /* Naloga 2.1.0.3. Napisite program, ki izpise najvecje stevilo izmed treh danih celih stevil. */


            /* Naloga 2.1.0.4. Napiˇsite program, ki izpise absolutno vrednost danega stevila (brez uporabe knjiznice Math). */


            /* Naloga 2.1.0.5. Napisite program, ki za dano stevilo preveri ali je pozitivno, negativno, ali enako 0. */

            x = -5;
            if (x > 0)
            {
                Console.WriteLine("Pozitivno");
            }
            else if (x < 0)
            {
                Console.WriteLine("Negativno");

            }
            else
            {
                Console.WriteLine("Enako je 0");
            }

            /* Naloga 2.1.0.6. Napisite program, ki preveri ali je dano celo stevilo deljivo s 3, s 5, obema ali pa ni deljivo z nobenim od teh dveh stevil. Odgovor naj se izpise na zaslonu. */

            x = 12;
            if (x % 3 == 0 && x % 5 == 0)
            {
                Console.WriteLine("Deljivo je s 3 in 5");
            }
            else if (x % 5 == 0)
            {
                Console.WriteLine("Deljivo je s 5");
            }
            else if (x % 3 == 0)
            {
                Console.WriteLine("Deljivo je s 3 ");
            }
            else
            {
                Console.WriteLine("Deljivo ni z nobenim");
            }

            /* Naloga 2.1.0.7. Napisite program, ki za dana tri stevila izpise ali obstaja trikotnik s temi dolzinami stranic. Tak trikotnik obstaja, ce dolzine stranic ustrezajo tako imenovani trikotniski neenakosti, ki pravi, da je vsota dolzin poljubnih dveh stranic vedno vecja od dolzine tretje stranice. */


            /* Naloga 2.1.0.8. Napisite program, ki za dano crko crko na zaslon izpise ali je crka soglasnik ali samoglasnik. Pri tem upostevajte tako male, kot velike crke. */


            /* Naloga 2.1.0.9. Napisite program, ki za dano celo stevilo n med 1 in 7 izpise ime n-tega dneva v tednu. */


            /* Naloga 2.1.0.10. Napisite program, ki za dano pozitivno celo stevilo leto izpise ali je leto prestopno ali ne. Leto je prestopno, ce je deljivo s 4, razen v primeru, ko je deljivo s 100 in ni deljivo s 400. */


            /* Naloga 2.1.0.11. Napisite program, ki za dan datum sestavljen iz treh danih celostevilskih vrednosti (dan, mesec, leto) preveri ali je datum veljaven (to je, stevilka meseca in stevilo dni v mesecu je ustrezno) in, ce je, izpisete datum na zaslon in ali je leto prestopno. */


            /* Naloga 2.2.0.1. Deklarirajte poljubno celostevilsko spremenljivko. Nato uporabite ternarni operator (pogojni izraz), da v spremenljivko za nize shranite vrednost “sodo”, ce je stevilo sodo in “liho”, sicer. Rezultat izpiˇsite na zaslon. */

            //pogoj ? izraz1 : izraz2
            x = 5;
            string sodoLiho = x % 2 == 0 ? "sodo" : "liho";
            Console.WriteLine(sodoLiho);


            /* Naloga 2.2.0.2. Deklarirajte dve celostevilski spremenljivki in uporabite ternarni operator, da v novi spremenljivki z imenom min in max shranite manjse, oziroma vecje izmed njiju. Oba rezultata izpisite na zaslon. */

            x = 10;
            y = -3;
            int min = x < y ? x : y;
            int max = x < y ? y : x;

            Console.WriteLine($"min: {min}, max: {max}");

            /* Naloga 2.2.0.3. S pomocjo ternarnega operatorja na zaslon izpisite absolutno vrednost danega stevila. */


            /* Naloga 2.2.0.4. Deklarirajte poljuben znak in z uporabo ternarnega operatorja shranite v novo spremenljivko za nize vrednost “crka”, ce je znak crka angleske abecede in prazen niz, sicer. */


            /* Naloga 2.3.0.1. Z uporabo stavka switch za dano starost osebe preverite ali se lahko udelezi volitev ali ne. */

            int starost = 17;

            switch (starost)
            {
                case <= 17:
                    Console.WriteLine("Ne");
                    break;
                default:
                    Console.WriteLine("Da");
                    break;
            }

            /* Naloga 2.3.0.2. Z uporabo stavka switch na zaslon izpisite ali je dano stevilo sodo ali liho. */

            x = 11;
            int ostanek = x % 2;
            switch (x % 2 == 0)
            {
                case true:
                    Console.WriteLine("Sodo");
                    break;
                default:
                    Console.WriteLine("liho");
                    break;
            }

            /* Naloga 2.3.0.3. Z uporabo stavka switch preverite ali je dana crka samoglasnik ali soglasnik. Nalogo resite tako, da uporabite le dva jedrna dela. */



            /* Naloga 2.3.0.4. Z uporabo stavka switch za dano celo stevilo n med 1 in 7 izpisite ime n-tega dneva v tednu. */


            /* Naloga 2.3.0.5. Uporabite stavek switch, da ustvarite preprost kalkulator, to je, da sestejete, odˇstejete, pomnozite, delite ali pa izracunate ostanek pri deljenju za dve poljubno izbrani celi stevili glede na moˇzne znake (+, −, ∗, /, %). */

            double stevilo1 = 5.1;
            double stevilo2 = 1.2;
            char operacija = '*';

            switch (operacija)
            {
                case '+':
                    Console.WriteLine(stevilo1 + stevilo2);
                    break;
                case '-':
                    Console.WriteLine(stevilo1 - stevilo2);
                    break;
                case '/':
                    Console.WriteLine(stevilo1 / stevilo2);
                    break;
                case '*':
                    Console.WriteLine(stevilo1 * stevilo2);
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }

            /* Naloga 2.3.0.6. Deklarirajte spremenljivko ocena in ji kot vrednost podajte celostevilsko oceno, ki jo priˇcakujete pri tem predmetu. Nato s pomocjo stavka switch izpisite opisno ime vase pricakovane ocene (≤ 5 - nezadostno, 6 - zadostno, 7 - dobro, 8 in 9 - prav dobro in 10 - odlicno). V programu uporabite primerjalni vzorec. */

            /* Naloga 3.0.0.1. Izracunajte vsoto prvih desetih naravnih stevil z uporabo vseh treh zank.*/

            /* Naloga 3.0.0.2. Izpisite vsa soda stevila manjsa od 100 z uporabo zanke for. */

            /* Naloga 3.0.0.3. Za dano pozitivno celo stevilo izracunajte vsoto njegovih stevk z uporabo
            zanke while. */

            /* Naloga 3.0.0.4. Generator nakljucnih stevil deklariramo z ukazom
            Random <imeSpremenljivke> = new Random();.
            Nakljucno vrednost lahko zgeneriramo z ukazom
            <imeSpremenljivke>.Next(<min>,<max>),
            ki vzame nakljucno vrednost med vkljucno z min in izkljucno z max. Z uporabo zanke
            do-while napisite kodo, ki bo nakljucno generirala stevila od 0 do 100 in jih izpisovala na
            zaslon. Izpisovanje naj se zakljuci, ko je zgenerirana vrednost vecja od 90. Na koncu naj
            se izpise stevilo vseh zgeneriranih nakljucnih vrednosti. */

            /* Naloga 3.0.0.5. Izpisite vsa pozitivna cela stevila manjsa od 200, ki so deljiva z 2 in niso deljiva s 5. */

            /* Naloga 3.0.0.6. Deklarirajte celostevilsko spremenljivko n in izracunajte vsoto vseh stevil manjsih ali enakih n, ki so deljiva s 3 ali s 5. */

            /* Naloga 3.0.0.7. Napisite program, ki stevke danega celega stevila zapise v obratnem vrstnem redu. */

            /* Naloga 3.0.0.8. Napisite program, ki za dano celo stevilo preveri ali je palindrom. Palindrom je zaporedje znakov, ki je enako, ce ga beremo iz leve proti desni ali iz desne proti levi. */

            /* Naloga 3.0.0.9. Izpisite vsa razlicna 4-mestna naravna stevila sestavljena iz stevk 1, 2, 3, 4
            in 5. Izpisite tudi stevilo takih stevil. */

            /* Naloga 3.0.0.10. Za dano pozitivno celo stevilo n izpisite vsa Fibonaccijeva stevila, ki so manjsa od n. */

            /* Naloga 3.0.0.11. Izracunajte vsoto vseh trimestnih stevil, ki vsebujejo stevko 1. Nato izracunajte vsoto vseh trimestnih stevil, ki vsebujejo natanko eno stevko 1. */

            /* Naloga 3.0.0.12. Za pozitivno celo stevilo, ki ga vnese uporabnik, izpisite vse lihe stevke in vsoto sodih stevk, do prve pojavitve stevke 0. Pri tem lahko uporabite samo if stavke in nobenega else ali else if stavka. */

            /* Naloga 3.0.0.13. Za dano pozitivno celo stevilo n, ki ga vnese uporabnik, na zaslon izpisite vsa soda stevila manjsa ali enaka n, ter stevilo vseh lihih stevil od 1 do vkljucno z n. Pri tem lahko uporabite le if stavek in nobenega else ali else if stavka. */

            /* Naloga 3.0.0.14. V vsaki od vrstic 1 do 9 izpiˇsite vse stevke z izjemo i-te stevke, kjer je i zaporedna stevilka vrstice. V 3. vrstici bi se tako izpisalo 012456789. Uporabite lahko le if stavek in nobenega else ali else if stavka. */

            /*Naloga 3.0.0.15. Izpisite vsa stevila manjsa od 1000, za katera so vsi delitelji razlicni od 1 sodi. Uporabite lahko le if stavek in nobenega else ali else if stavka. */

            /* Naloga 3.1.0.1. Na zaslon z zvezdicami izriˇsite kvadrat viˇsine n, kjer ˇstevilo n vnese
            uporabnik.
            Primer za n = 5:
            *****
            *****
            *****
            *****
            *****
            */

            /* Naloga 3.1.0.2. Na zaslon z zvezdicami izrisite okvir kvadrata visine n, kjer stevilo n
            vnese uporabnik.
            Primer za n = 5:
            *****
            *   *
            *   *
            *   *
            *****
            */

            /* Naloga 3.1.0.3. Na zaslon z zvezdicami izrisite velik X visine n, kjer stevilo n vnese
            uporabnik. Program naj deluje vsaj za lihe vrednosti n.
            Primer za n = 5:
            8
            * *
            * *
            *
            * *
            * *
            */

            /* Naloga 3.1.0.4. Na zaslon z zvezdicami izriˇsite zgornji levi trikotnik visine n, kjer stevilo
            n vnese uporabnik.
            Primer za n = 5:
            *****
            ****
            ***
            **
            *
            */

            /* Naloga 3.1.0.5. Na zaslon z zvezdicami izrisite spodnji levi trikotnik visine n, kjer stevilo
            n vnese uporabnik.
            Primer za n = 5:
            *
            **
            ***
            ****
            *****
            */

            /* Naloga 3.1.0.6. Na zaslon z zvezdicami izrisite zgornji desni trikotnik visine n, kjer stevilo n vnese uporabnik.
            Primer za n = 5:
            *****
            ****
            ***
            **
            *
            */

            /* Naloga 3.1.0.7. Na zaslon z zvezdicami izrisite spodnji desni trikotnik visine n, kjer stevilo n vnese uporabnik.
            Primer za n = 5:
            9
            *
            **
            ***
            ****
            *****
            */

            /* Naloga 3.1.0.8. Na zaslon z zvezdicami izrisite piramido visine n, kjer stevilo n vnese uporabnik. Program naj deluje vsaj za lihe vrednosti n.
            Primer za n = 5:
            *
            ***
            *****
            *******
            *********
            */

            /* Naloga 3.1.0.9. Na zaslon z zvezdicami izrisite obrnjeno piramido visine n, kjer stevilo n vnese uporabnik. Program naj deluje vsaj za lihe vrednosti n.
            Primer za n = 5:
            *********
            *******
            *****
            ***
            *
            */

            /* Naloga 3.1.0.10. Na zaslon z zvezdicami izrisite diamant visine n, kjer stevilo n vnese uporabnik. Program naj deluje vsaj za lihe vrednosti n.
            Primer za n = 7:
            *
            ***
            *****
            *******
            *****
            ***
            *
            */

            /* Naloga 3.1.0.11. Na zaslon z zvezdicami izrisite pesceno uro visine n, kjer stevilo n vnese
            uporabnik. Program naj deluje vsaj za lihe vrednosti n.
            Primer za n = 7:
            10
            *******
             *****
              ***
               *
              ***
             *****
            *******
            */

            /* Naloga 3.1.0.12. Na zaslon z zvezdicami izriˇsite rob diamanta visine n, kjer stevilo n vnese uporabnik. Program naj deluje vsaj za lihe vrednosti n.
            Primer za n = 7:
               *
              * *
             *   *
            *     *
             *   *
              * *
               *
            */

            /* Naloga 3.1.0.13. Na zaslon z zvezdicami izrisite metuljcka visine n, kjer stevilo n vnese uporabnik. Program naj deluje vsaj za lihe vrednosti n.
            Primer za n = 7:

            *     *
            **   **
            *** ***
            *******
            *** ***
            **   **
            *     *
            
             */

            /* Naloga 3.1.0.14. Na zaslon izrisite vzorec sahovnice sestavljen iz 2 × 2 praznih crnih kvadratkov in 2 × 2 belih kvadratkov sestavljenih iz zvezdic.Velikost sahovnice naj vnese uporabnik.
            Primer za ˇsahovnico velikosti 4 × 4:
            **  **
            **  **
              **  **
              **  **
            **  **
            **  **
              **  **
              **  **
            */

            /* Naloga 3.2.0.1. Napisite program za igranje igre ugibanja stevila. Stevilo naj se zgenerira samodejno z uporabo generatorja Random (glej nalogo 3.0.0.4), kjer uporabnik sam odloci najvecje mozno stevilo. Nato naj uporabnik vnasa stevila dokler ne ugane iskanega stevila. Ob vsakem ugibanju mora program uporabniku povedati ali je iskano stevilo vecje ali manjse od vnesenega stevila, ce pa je uporabnik uganil iskano stevilo, mu program izpise koliko poskusov je potreboval, da je stevilo uganil. 
            */

            Console.ReadKey();

        }
    }
}
