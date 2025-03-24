namespace Izpit_1_2023_04_08
{
    internal class Naloga3
    {
        /// <summary>
        /// NALOGA 3:
        /// Pripravite razreda Igralec in NogometniKlub.
        /// 
        /// Razred Igralec naj vsebuje: 
        /// -   Lastnosti Ime, CenaIgralca, Položaj (napadalec, vezni, vratar,...), Starost (tej lastnosti lahko vrednost nastavimo samo v konstruktorju!).
        /// -   En konstruktor, ki omogoča določitev natanko dveh lastnosti, 
        ///     in en konstruktor, ki omogoča določitev vsaj treh lastnosti.
        /// -   Povozite metodo ToString, ki naj izpiše vse podatke o igralcu.              [10 točk]
        /// 
        /// Razred NogometniKlub naj vsebuje:
        /// -   Lastnosti SeznamIgralcev in VišinaProračuna.
        /// -   Konstruktor, ki inicializira seznam igralcev in nastavi višino proračuna.
        /// -   Metodo, ki izpiše vse igralce, ki imajo ceno višjo od danega maksimuma.     [10 točk]
        /// 
        /// V metodi ResitevNaloge kreirajte instanco razreda NogometniKlub, ki naj vsebuje vsaj pet igralcev
        /// in izpišite podatke o vseh igralcih, ki imajo ceno vsaj 100_000 evrov 
        /// in so mlajši od 30 let.          [5 točk]
        /// </summary>

        public static void ResitevNaloge()
        {
            Igralec Aljosa = new Igralec("Aljosa", 100000, "Vratar", 29);
            Igralec Nik = new Igralec("Nik", 120000, "Vratar", 21);
            Igralec Zan = new Igralec("Zan", 70000, "Vratar", 30);
            Igralec Anze = new Igralec("Anze", 95000, "Vratar", 28);
            Igralec Nikola = new Igralec("Nikola", 130000, "Vratar", 29);
            List<Igralec> igralci = new List<Igralec>();
            igralci.Add(Aljosa);
            igralci.Add(Nik);
            igralci.Add(Zan);
            igralci.Add(Anze);
            igralci.Add(Nikola);
            NogometniKlub klub = new NogometniKlub(1000000, igralci);
            /// in izpišite podatke o vseh igralcih, ki imajo ceno vsaj 100_000 evrov 
            /// in so mlajši od 30 let.          [5 točk]

            for (int i = 0; i < igralci.Count; i++)
            {
                if (igralci[i].CenaIgralca > 10000 && igralci[i].Starost < 30)
                {
                    Console.WriteLine(igralci[i].ToString());
                }
            }
            
        }
    }

    /// Razred Igralec naj vsebuje: 
    /// -   Lastnosti Ime, CenaIgralca, Položaj (napadalec, vezni, vratar,...), Starost (tej lastnosti lahko vrednost nastavimo samo v konstruktorju!). da
    /// -   En konstruktor, ki omogoča določitev natanko dveh lastnosti, 
    ///     in en konstruktor, ki omogoča določitev vsaj treh lastnosti.
    /// -   Povozite metodo ToString, ki naj izpiše vse podatke o igralcu.              [10 točk]

    public class Igralec
    {
        public Igralec(string ime, string polozaj)
        {
            Ime = ime;
            CenaIgralca = 100000;
            Polozaj = polozaj;
            Starost = 29;
        }

        public Igralec(string ime, int cenaIgralca, string polozaj, int starost)
        {
            Ime = ime;
            CenaIgralca = cenaIgralca;
            Polozaj = polozaj;
            Starost = starost;
        }
        public string Ime { get; set; }
        public int CenaIgralca { get; set; }
        public string Polozaj { get; set; }
        public int Starost { get; set; }

        public override string ToString()
        {
            return $"Podatki o igralcu:\nIme: {Ime}\nCena igralca: {CenaIgralca}\nPolozaj: {Polozaj}\nStarost: {Starost}";
        }
    }

    /// Razred NogometniKlub naj vsebuje:
    /// -   Lastnosti SeznamIgralcev in VišinaProračuna. da
    /// -   Konstruktor, ki inicializira seznam igralcev in nastavi višino proračuna. da
    /// -   Metodo, ki izpiše vse igralce, ki imajo ceno višjo od danega maksimuma.     [10 točk]

    public class NogometniKlub
    {
        public NogometniKlub(int proracun, List<Igralec> igralci)
        {
            VisinaProracuna = proracun;
            SeznamIgralcev = new List<Igralec>();
            foreach (var igralec in igralci)
            {
                SeznamIgralcev.Add(igralec);
            }
        }
        
        public List<Igralec> SeznamIgralcev { get; set; }
        public int VisinaProracuna { get; set; }

        public void SeznamDragihIgralcev(int maksimum)
        {
            foreach (var igralec in SeznamIgralcev)
            {
                if (igralec.CenaIgralca > maksimum) Console.WriteLine(igralec.ToString());
            }
        }
    }
}
