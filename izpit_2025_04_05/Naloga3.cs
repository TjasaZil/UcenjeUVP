namespace Izpit_2025_04_05
{
    /// <summary>
    /// NALOGA 3:
    /// Za znano založbo pripravljamo aplikacijo za spremljanje njihovih izdaj.
    /// 
    /// Napišite razred Publikacija, ki ima lastnosti Avtor, Naslov in LetoIzdaje. 
    /// V razredu pripravite še natanko en konstruktor, 
    /// ki kot parameter dobi LetoIzdaje. 
    /// Povozite tudi funkcijo ToString.                                    [5 točk]
    /// 
    /// Za razred Publikacija pripravite tri podrazrede: Knjiga, Revija in Brosura. 
    /// Za vsakega od podrazredov si zamislite po eno ustrezno 
    /// specifično lastnost in jo implementirajte. 
    /// V vsakem od podrazredov ustrezno popravite še funkcijo ToString.    [8 točk]
    ///     
    /// Napišite še razred Zalozba, ki naj ima lastnosti Lokacija, Direktor 
    /// in Publikacije (seznam izdanih publikacij).
    /// Dodajte še funkcijo, ki vrne število publikacij izdanih po danem letu. 
    /// Povozite funkcijo ToString, ki poleg osnovnih lastnosti založbe 
    /// vrne tudi seznam vseh izdanih publikacij.                              [7 točk]
    /// 
    /// V funkciji ResitevNaloge ustvarite eno instanco razreda Zalozba 
    /// in na njegov seznam publikacij dodajte štiri publikacije različnih tipov. 
    /// V ukazno vrstico s pomočjo klica ustrezne funkcije 
    /// izpišite število vseh publikacij izdanih po letu 2020.              [5 točk]
    /// </summary>
    public class Naloga3
    {
        /// <summary>
        /// V tej funkciji se začne izvajati program za reševanje Naloge 3
        /// </summary>
        public static void ResitevNaloge()
        {
            Zalozba zalozba = new Zalozba();
            zalozba.Lokacija = "Ljubljana";
            zalozba.Direktor = "Rozle";

            Publikacija publikacija = new Publikacija(2002);
            publikacija.Naslov = "Pehtine rožice";
            publikacija.Avtor = "Pehta";
            Brosura brosura = new Brosura(2025);
            brosura.Tiskarna = "Na gricu";
            brosura.Naslov = "Najnovejse smernice hribolazenja 2025";
            publikacija.Avtor = "Kosobrin";
            Knjiga knjiga = new Knjiga(2022);
            knjiga.Zvrst = "potopis";
            knjiga.Naslov = "Po Kekcevih stopinjah";
            knjiga.Avtor = "Rozle";
            Revija revija = new Revija(2021);
            revija.SteviloStrani = 50;
            revija.Naslov = "Za vsak bol roz'ca raste";
            revija.Avtor = "Pehta";
            zalozba.Publikacije.Add(publikacija);
            zalozba.Publikacije.Add(knjiga);
            zalozba.Publikacije.Add(revija);
            zalozba.Publikacije.Add(brosura);



            Console.WriteLine("Stevilo publikacij izdane po letu 2020: " + zalozba.SteviloPublikacij(2020));
            //Console.WriteLine(zalozba.ToString());
        }

        public class Publikacija
        {
            public Publikacija(int letoIzdaje)
            {
                LetoIzdaje = letoIzdaje;
            }
            public string Naslov { get; set; }
            public string Avtor { get; set; }
            public int LetoIzdaje { get; set; }

            public override string ToString()
            {
                return $"\nPublikacija:\nNaslov: {Naslov}\nAvtor: {Avtor}\nLeto Izdaje: {LetoIzdaje}\n";
            }
        }

        public class Knjiga : Publikacija
        {
            public Knjiga(int letoIzdaje) : base(letoIzdaje)
            {

            }
            public string Zvrst { get; set; }

            public override string ToString()
            {
                return base.ToString() + $"Zvrst: {Zvrst}\n";
            }
        }

        public class Revija : Publikacija
        {
            public Revija(int letoIzdaje) : base(letoIzdaje)
            {

            }
            public int SteviloStrani { get; set; }


            public override string ToString()
            {
                return base.ToString() + $"Stevilo Strani: {SteviloStrani}\n";
            }
        }

        public class Brosura : Publikacija
        {
            public Brosura(int letoIzdaje) : base(letoIzdaje)
            {

            }
            public string Tiskarna { get; set; }


            public override string ToString()
            {
                return base.ToString() + $"Tiskarna: {Tiskarna}\n";
            }
        }
        public class Zalozba
        {

            public string Lokacija { get; set; }
            public string Direktor { get; set; }
            public List<Publikacija> Publikacije { get; set; } = new List<Publikacija>();

            public override string ToString()
            {
                string niz = $"ZALOZBA:\nLokacija: {Lokacija}\nDirektor: {Direktor}\n";
                foreach (Publikacija publikacija in Publikacije)
                {
                    niz += publikacija.ToString();
                }
                return niz;
            }

            public int SteviloPublikacij(int leto)
            {
                int stevec = 0;
                foreach (Publikacija publikacija in Publikacije)
                {
                    if (publikacija.LetoIzdaje > leto) stevec++;
                }

                return stevec;
            }
        }
    }
}