namespace Izpit_2024_04_06
{
    internal class Naloga2
    {
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
        public static void ResitevNaloge()
        {
            PostnaPoslovalnica PostaLjubljana = new PostnaPoslovalnica();
            Paket paket = new Paket("Naslov 123", 5.3);
            paket.DatumPosiljanja = DateTime.Now;
            paket.Prednostna = true;
            Pismo pismo = new Pismo("Naslov 567", "23.1 x 5.6");
            pismo.DatumPosiljanja = DateTime.Now;
            pismo.Prednostna = false;
            Razglednica razglednica = new Razglednica("naslov 1", "Okrogla");
            razglednica.DatumPosiljanja = DateTime.Now;
            razglednica.Prednostna = false;
            Posiljka posiljka = new Posiljka("naslov 34");
            posiljka.DatumPosiljanja = DateTime.Now;
            posiljka.Prednostna = false;
            List<Posiljka> seznamPosiljk = new List<Posiljka>() { paket, pismo, razglednica, posiljka };

            PostaLjubljana.SeznamPosiljk.AddRange(seznamPosiljk);


            Console.WriteLine("Pošta ljubljana seznam pošiljk: \n");
            foreach (var el in PostaLjubljana.SeznamPosiljk)
            {
                Console.WriteLine(el.ToString());
            }
        }
    }


    public class PostnaPoslovalnica
    {

        public PostnaPoslovalnica()
        {
            SeznamPosiljk = new List<Posiljka>();
        }
        public string NaslovPoslovalnice;
        public List<Posiljka> SeznamPosiljk { get; set; }
        public string ImeDirektorja;
    }


    public class Posiljka
    {
        public Posiljka(string naslov)
        {
            NaslovPrejemnika = naslov;
        }
        public DateTime DatumPosiljanja { get; set; }
        public string NaslovPrejemnika { get; set; }
        public bool Prednostna { get; set; }

        public override string ToString()
        {
            return $"Datum Posiljanja: {DatumPosiljanja}\nNaslov Prejemnika: {NaslovPrejemnika}\nPrednostna: {Prednostna}\n";
        }
    }

    public class Razglednica : Posiljka
    {
        public Razglednica(string naslov, string oblika) : base(naslov)
        {
            Oblika = oblika;
        }
        public string Oblika { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"Oblika: {Oblika}\n";
        }
    }
    public class Pismo : Posiljka
    {
        public Pismo(string naslov, string dimenzije) : base(naslov)
        {
            Dimenzije = dimenzije;
        }
        public string Dimenzije { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"Dimenzije: {Dimenzije}\n";
        }
    }
    public class Paket : Posiljka
    {
        public Paket(string naslov, double teza) : base(naslov)
        {
            Teza = teza;
        }
        public double Teza { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"Teža: {Teza}\n";
        }
    }
}
