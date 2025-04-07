namespace Izpit_2024_06_18
{
    internal class Naloga3
    {
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


        public static void ResitevNaloge()
        {
            Zaposleni zaposleni = new Zaposleni();
            Telefon telefon = new Telefon(2025, "Črna", false);
            telefon.Cena = 1100.13M;
            Tablica tablica = new Tablica(2024, 87, true);
            tablica.Cena = 1300.13M;
            Prenosnik prenosnik = new Prenosnik(2022, 15, true);
            prenosnik.Cena = 3200.26M;
            zaposleni.Naprave.Add(telefon);
            zaposleni.Naprave.Add(tablica);
            zaposleni.Naprave.Add(prenosnik);
            MobilnaNaprava najdrazja = zaposleni.NajdrazjaNaprava();
            Console.WriteLine("Cena najdražje naprave zaposlenega: " + najdrazja.Cena);
        }
    }


    public class MobilnaNaprava
    {
        public MobilnaNaprava(int leto)
        {
            LetoIzdelave = leto;
        }

        public int LetoIzdelave { get; set; }
        public decimal Cena;
        public bool Ima5GModul;
        public string TipProcesorja;

        public override string ToString()
        {

            return $"LetoIzdelave:{LetoIzdelave}\nCena:{Cena}\nIma5GModul:{Ima5GModul}\nTipProcesorja:{TipProcesorja}\n";
        }
    }

    public class Telefon : MobilnaNaprava
    {

        public Telefon(int leto, string barva, bool brezzicnoPolnjenje) : base(leto)
        {
            Barva = barva;
            BrezzicnoPolnjenje = brezzicnoPolnjenje;
        }
        public string Barva { get; set; }
        public bool BrezzicnoPolnjenje { get; set; }
        public override string ToString()
        {

            return base.ToString() + $"Barva:{Barva}\nBrezzicnoPolnjenje:{BrezzicnoPolnjenje}\n";
        }
    }
    public class Tablica : MobilnaNaprava
    {

        public Tablica(int leto, int zmogljivostBaterije, bool dela) : base(leto)
        {
            ZmogljivostBaterije = zmogljivostBaterije;
            Dela = dela;
        }
        public int ZmogljivostBaterije { get; set; }
        public bool Dela { get; set; }
        public override string ToString()
        {

            return base.ToString() + $"ZmogljivostBaterije:{ZmogljivostBaterije}\nDela:{Dela}\n";
        }
    }
    public class Prenosnik : MobilnaNaprava
    {

        public Prenosnik(int leto, double velikostEkrana, bool vecEkranov) : base(leto)
        {
            VelikostEkrana = velikostEkrana;
            VecEkranov = vecEkranov;
        }
        public double VelikostEkrana { get; set; }
        public bool VecEkranov { get; set; }
        public override string ToString()
        {

            return base.ToString() + $"VelikostEkrana:{VelikostEkrana}\nVecEkranov:{VecEkranov}\n";
        }
    }

    public class Zaposleni
    {
        public Zaposleni()
        {
            Naprave = new List<MobilnaNaprava>();
        }
        public List<MobilnaNaprava> Naprave;
        public decimal SkupnaVrednost;

        public MobilnaNaprava NajdrazjaNaprava()
        {
            MobilnaNaprava naprava = Naprave[0]; ;
            for (int i = 0; i < Naprave.Count; i++)
            {
                if (Naprave[i].Cena > naprava.Cena) naprava = Naprave[i];
            }

            return naprava;
        }
        public MobilnaNaprava NajstarejsaNaprava()
        {
            MobilnaNaprava naprava = Naprave[0]; ;
            for (int i = 0; i < Naprave.Count; i++)
            {
                if (Naprave[i].LetoIzdelave < naprava.LetoIzdelave) naprava = Naprave[i];
            }

            return naprava;
        }
    }
}
