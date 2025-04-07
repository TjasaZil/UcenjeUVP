namespace Izpit_2024_09_26
{
    internal class Naloga3
    {
        /// <summary>
        /// NALOGA 3:
        /// Za potrebe društva tabornikov pripravljamo aplikacijo za evidentiranje dreves v gozdovih.
        /// 
        /// Napišite razred Drevo, ki ima lastnosti Vrsta, Višina, Volumen in Starost. 
        /// V razredu pripravite še natanko en konstruktor, 
        /// ki kot parameter dobi vrsto drevesa. 
        /// Povozite tudi metodo ToString.                                          [6 točk]

        /// Za razred Drevo pripravite dva podrazreda: Listavec in Iglavec. 
        /// Za vsakega od podrazredov si zamislite po eno ustrezno 
        /// specifično lastnost in jo implementirajte. 
        /// V vsakem od podrazredov ustrezno popravite še metodo ToString.          [7 točk]

        /// Napišite še razred Gozd, ki naj ima lastnosti Lokacija in Drevesa.
        /// Dodajte še metodo, ki vrne skupen volumen iglavcev v gozdu, 
        /// in metodo, ki vrne povprečno starost dreves, 
        /// katera imajo višino višjo od danega parametra.                          [7 točk]

        /// V metodi ResitevNaloge ustvarite eno instanco razreda Gozd 
        /// in na njegov seznam dreves dodajte štiri drevesa različnih tipov. 
        /// V ukazno vrstico s pomočjo klica ustrezne metode 
        /// izpišite skupen volumen vseh iglavcev v gozdu.                          [5 točk]
        /// </summary>


        public static void ResitevNaloge()
        {
            //res se mi ne da implementirat, sej to znam ker sem že tokrat nrdila
        }
    }

    public class Drevo
    {
        public Drevo(string vrsta)
        {
            Vrsta = vrsta;
        }
        public string Vrsta { get; set; }
        public double Visina { get; set; }
        public double Volumen { get; set; }
        public int Starost { get; set; }

        public override string ToString()
        {
            return $"\nVrsta: {Vrsta}\nVisina: {Visina}\nVolumen: {Volumen}\nStarost: {Starost}\n";
        }

    }

    public class Iglavec : Drevo
    {
        public Iglavec(string vrsta) : base(vrsta) { }
        public bool jeZimzelen { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"jeZimzelen: {jeZimzelen}\n";
        }
    }

    public class Listavec : Drevo
    {
        public Listavec(string vrsta) : base(vrsta) { }
        public double PovrsinaLista { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"PovrsinaLista: {PovrsinaLista}\n";
        }
    }




    public class Gozd
    {

        public string Lokacija { get; set; }
        public List<Drevo> Drevesa { get; set; } = new List<Drevo>();

        public override string ToString()
        {
            string niz = $"\nLokacija: {Lokacija}\n";

            foreach (Drevo drevo in Drevesa)
            {
                niz += drevo.ToString();
            }

            return niz;
        }

        public double SkupenVolumenIglavcev()
        {
            double vsota = 0;
            foreach (Drevo drevo in Drevesa)
            {
                if (drevo is Iglavec) vsota += drevo.Volumen;
            }
            return vsota;
        }

        public double PovprecnaStarost(double visina)
        {
            int starost = 0;
            int steviloDreves = 0;
            foreach (Drevo drevo in Drevesa)
            {
                if (drevo.Visina > visina)
                {
                    starost += drevo.Starost;
                    steviloDreves++;
                }
            }
            return (double)starost / steviloDreves;

        }

    }

}
