namespace Izpit_2024_09_26
{
    internal class Naloga2
    {
        /// <summary>
        /// NALOGA 2:
        /// 
        /// Večina večjih podjetij ima tudi svoj vozni park, za katerega je treba ustrezno skrbeti. 
        /// Vsako vozilo mora imeti redno servisiranje, registracijo ipd. 
        /// Pripravite razreda Podjetje in Vozilo. 
        /// Vsako podjetje ima seznam vozil, ki predstavljajo vozni park podjetja.

        /// Razred Vozilo naj vsebuje: 
        /// - Lastnosti RegistrskaStevilka, Znamka, Letnik, Tip (kombi, avto, kamion) in DatumRegistracije.
        /// - Natanko en konstruktor, ki nastavi lastnost RegistrskaStevilka.
        /// - Metodo ToString, ki izpiše vse lastnosti vozila.                              [5 točk]

        /// Razred Podjetje naj vsebuje: 
        /// - Lastnosti Naziv, Naslov, Dejavnost in VozniPark.
        ///   Vse lastnosti naj imajo ustrezen tip.
        /// - En prazen konstruktor.
        /// - Metodo ToString, ki naj izpiše vse podrobnosti o podjetju.
        /// - Metodo, ki vrne skupno število vozil letnika manjšega od danega parametra.
        /// - Metodo, ki vrne vozilo, katero ima najbližji datum registracije.              [15 točk]

        /// V metodi ResitevNaloge kreirajte tri instance razreda Vozilo in 
        /// eno instanco razreda Podjetje. 
        /// Nato v ukazno vrstico izpišite podatke o podjetju 
        /// ter katero vozilo iz voznega parka podjetja ima najbližji datum registracije.   [5 točk]
        /// </summary>


        public static void ResitevNaloge()
        {
            //DateOnly today = DateOnly.FromDateTime(DateTime.Now)
            /// V metodi ResitevNaloge kreirajte tri instance razreda Vozilo in 
            /// eno instanco razreda Podjetje. 
            /// Nato v ukazno vrstico izpišite podatke o podjetju 
            /// ter katero vozilo iz voznega parka podjetja ima najbližji datum registracije. 
            /// </summary>
        }
    }

    public class Vozilo
    {
        public Vozilo(int registrskaStevilka)
        {
            RegistrskaStevilka = registrskaStevilka;
        }

        public int RegistrskaStevilka { get; set; }
        public string Znamka { get; set; }
        public int Letnik { get; set; }
        public string Tip { get; set; }
        public DateOnly DatumRegistracije { get; set; }

        public override string ToString()
        {
            return $"VOZILO:\nRegistrska stevilka: {RegistrskaStevilka}\nZnamka: {Znamka}\nLetnik: {Letnik}\nTip: {Tip}\nDatum Registracije: {DatumRegistracije}\n";
        }

    }



    public class Podjetje
    {
        public Podjetje() { }
        public string Naziv { get; set; }
        public string Naslov { get; set; }
        public string Dejavnost { get; set; }
        public List<Vozilo> VozniPark { get; set; }

        public override string ToString()
        {
            string niz = $"PODJETJE:\nNaziv: {Naziv}\nNaslov: {Naslov}\nDejavnost: {Dejavnost}\n\nSEZNAM VOZIL:\n";
            foreach (Vozilo el in VozniPark)
            {
                niz += el.ToString();
            }
            return niz;
        }

        public int SteviloVozilGledeNaLetnico(int letnica)
        {
            int stevec = 0;
            foreach (Vozilo el in VozniPark)
            {
                if (el.Letnik > letnica) stevec++;
            }
            return stevec;
        }

        public Vozilo NaslednjaRegistracija()
        {
            Vozilo vozilo = VozniPark[0];
            foreach (Vozilo el in VozniPark)
            {
                if (el.DatumRegistracije >= DateOnly.FromDateTime(DateTime.Now) && vozilo.DatumRegistracije >= DateOnly.FromDateTime(DateTime.Now) && el.DatumRegistracije < vozilo.DatumRegistracije) vozilo = el;
            }

            return vozilo;
        }
    }
}
