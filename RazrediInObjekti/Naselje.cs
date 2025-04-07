namespace RazrediInObjekti
{
    internal class Naselje
    {
        
        // 8.2 Naselje

    }

    /* Naloga 8.2.0.1. Ustvarite razred Zgradba, ki shranjuje nekaj lastnosti o zgradbi. Vsebuje naj tudi staticno metodo Zgradi, ki uporabnika vprasa po podatkih o zgradbi in vrne objekt tipa Zgradba. Objektu dodajte tudi metodo Porusi, ki objekt unici. Vsebuje naj tudi metodo, ki kreira niz podatkov za izpis. */

    public class Zgradba
    {
        public Zgradba(string fasada, int stOken, int velikost, string barvaStrehe, string vrstaZgradbe, bool vrt)
        {
            BarvaFasade = fasada;
            SteviloOken = stOken;
            Velikost = velikost;
            BarvaStrehe = barvaStrehe;
            VrstaZgradbe = vrstaZgradbe;
            ImaVrt = vrt;
        }
        private string BarvaFasade { get; set; }
        private int SteviloOken { get; set; }
        private int Velikost { get; set; }
        private string BarvaStrehe { get; set; }
        private string VrstaZgradbe { get; set; }
        private bool ImaVrt { get; set; }

        private Zgradba Zgradi()
        {
            Console.Write("Kakšne barve je fasada? ");
            string barvaFasade = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Koliko ima oken? ");
            int steviloOken = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Kako velika je hisa? ");
            int velikost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Kakšne barve je streha? ");
            string barvaStrehe = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Kakšne vrste zgradba je to? ");
            string vrsta = Console.ReadLine();
            Console.WriteLine();
            Console.Write("ima hiša vrt? (true/false) ");
            bool vrt = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine();

            return new Zgradba(barvaFasade, steviloOken, velikost, barvaStrehe, vrsta, vrt);
        }

        private Zgradba Porusi()
        {
//resetira vse na prazno, nulo ali false
            return new Zgradba(" ", 0, 0, " ", "", false);
        }

        private string Izpisi()
        {

            return $"Podatki o zgradbi:\n Barva fasade: {BarvaFasade}\n Stevilo oken: {SteviloOken}\n Velikost: {Velikost}\n Barva Strehe: {BarvaStrehe}\n Vrsta Zgradbe: {VrstaZgradbe}\n Ima vrt: {ImaVrt}\n";
        }
    }

    /* Naloga 8.2.0.2. Ustvarite razred Parcela, ki shranjuje podatek o stevilki parcele, o tem ali je na parceli zgradba ali ne, ter ali je zazidljiva ali ne. Dodajte ji metodo za spremembo namembnosti, ter za kreiranje niza podatkov za izpis. */

    public class Parcela
    {
        public Parcela(int stParcele, bool zgradba, bool zazidljivost)
        {
            StevilkaParcele = stParcele;
            ImaZgradbo = zgradba;
            JeZazidljiva = zazidljivost;

        }
        
        public int StevilkaParcele { get; set; }
        public bool ImaZgradbo { get; set; }
        public bool JeZazidljiva { get; set; }

        public string Izpis()
        {
            return $"Podatki o parceli stevilka: {StevilkaParcele}\nIma zgradbo: {ImaZgradbo}\nJe zazidljiva: {JeZazidljiva}";
        }

        public Parcela spremeniNamembnost(int StevilkaParcele)
        {
            Izpis();
            Console.WriteLine("Spremenite namembnost (true/false)");
            bool namembnost = Convert.ToBoolean(Console.ReadLine());
            return new Parcela(StevilkaParcele, ImaZgradbo, namembnost);
        }
        
        
    }

    /* Naloga 8.2.0.3. Ustvarite razred Naselje, ki shranjuje tabelo parcel. Vse parcele so na zacetku nezazidljive. V razred dodajte se uporabniski vmesnik, ki bo omogocal gradnjo in rusenje zgradb ter spremembo namembnosti parcel glede na stevilko parcele. */

    public class Naselj
    {
        public Naselj()
        {
            TabelaParcel = new List<Parcela>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                TabelaParcel.Add(new Parcela(random.Next(0, 1000), false, false));
            }
        }

        public List<Parcela> TabelaParcel { get; set; }

        public void UpravljanjeNaselja()
        {
            Console.Write("Kaj zelite narediti?:");
        }
        
    }

    /* Naloga 8.2.0.4. Razrede Zgradba, Parcela in Naselje ustrezno popravite tako, da boste med izvajanjem programa lahko vse podatke zapisali v datoteko, da bi lahko v prihodnje nadaljevali z delom tam, kjer smo ostali.*/
}
