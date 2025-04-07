namespace Izpit_2025_04_05
{
    /// <summary>
    /// NALOGA 2:
    /// 
    /// Odločili smo se, da bomo začeli z izdajanjem časopisa.
    /// Sestavljen bo iz nekaj rubrik, ki bodo lahko redne ali izredne.
    /// Za začetek bomo pripravili programsko rešitev za evidenco izdaj,
    /// zato pa potrebujemo razreda, ki bosta predstavljala rubriko in časopis.
    /// 
    /// Razred Rubrika naj vsebuje: 
    /// - Lastnosti Naslov, Besedilo, Avtor, SteviloStrani in JeRedna.
    /// - En konstruktor, ki nastavi lastnosti Avtor in SteviloStrani.
    /// - Funkcijo ToString, ki izpiše vse lastnosti rubrike.                           [5 točk]
    /// 
    /// Razred Casopis naj vsebuje: 
    /// - Lastnosti Naslov, DatumIzdaje, SeznamRubrik in Urednik.
    /// - Konstruktor, ki kot parameter dobi datum izdaje in urednika.
    /// - Funkcijo ToString, ki naj izpiše seznam rubrik v časopisu.
    /// - Funkcijo, ki izpiše vse rubrike avtorja, katerega funkciji podamo kot parameter.
    /// - Funkcijo, ki vrne skupno število strani rednih rubrik.                    [15 točk]
    /// 
    /// V funkciji ResitevNaloge kreirajte štiri instance razreda Rubrika,
    /// pri čemer naj vsaj ena ne bo redna, in eno instanco razreda Casopis 
    /// ter rubrike dodajte na seznam rubrik časopisa. 
    /// Nato v ukazno vrstico izpišite število strani rednih rubrik v časopisu.         [5 točk]
    /// </summary>
    public class Naloga2
    {
        /// <summary>
        /// V tej funkciji se začne izvajati program za reševanje Naloge 2
        /// </summary>
        public static void ResitevNaloge()
        {

            Rubrika rubrika1 = new Rubrika("Janez Novak", 10);
            rubrika1.Naslov = "Ena zelo dolga rubrika";
            rubrika1.Besedilo = "To je ena zelo dolga rubrika ki ni redna";
            rubrika1.JeRedna = false;
            Rubrika rubrika2 = new Rubrika("Stefan Novak", 100);
            rubrika2.Naslov = "Najdaljsa rubrika";
            rubrika2.Besedilo = "To je ena zelo dolga rubrika ki je redna";
            rubrika2.JeRedna = true;
            Rubrika rubrika3 = new Rubrika("Teta Pehta", 1);
            rubrika3.Naslov = "Kolumna Tete Pehte";
            rubrika3.Besedilo = "To je ena kratka redna kolumna o rožicah";
            rubrika3.JeRedna = true;
            Rubrika rubrika4 = new Rubrika("Kekec", 1);
            rubrika4.Naslov = "Ena zelo kratka rubrika";
            rubrika4.Besedilo = "Kekec nima veliko časa za pisanje";
            rubrika4.JeRedna = false;

            Casopis casopis = new Casopis(DateTime.Now, "G. Kosobrin");
            casopis.Naslov = "Kosobrinov obmesecnik";
            casopis.SeznamRubrik.Add(rubrika1);
            casopis.SeznamRubrik.Add(rubrika2);
            casopis.SeznamRubrik.Add(rubrika3);
            casopis.SeznamRubrik.Add(rubrika4);

            Console.WriteLine("Stevilo strani rednih rubrik je: " + casopis.SteviloStraniRednihRubrik());
            //casopis.RubrikeAvtorja("Teta Pehta");
            //Console.WriteLine(rubrika1.ToString());
            //Console.WriteLine(casopis.ToString());
        }
    }


    public class Rubrika
    {
        public Rubrika(string avtor, int strani)
        {
            Avtor = avtor;
            SteviloStrani = strani;
        }
        public string Naslov { get; set; }
        public string Besedilo { get; set; }
        public string Avtor { get; set; }
        public int SteviloStrani { get; set; }
        public bool JeRedna { get; set; }

        public override string ToString()
        {
            string rednost = JeRedna ? "da" : "ne";
            return $"\nRubrika:\nNaslov: {Naslov}\nBesedilo: {Besedilo}\nAvtor: {Avtor}\nSteviloStrani: {SteviloStrani}\nJeRedna: {rednost}\n";
        }
    }

    public class Casopis
    {
        public Casopis(DateTime datum, string urednik)
        {
            DatumIzdaje = datum;
            Urednik = urednik;
        }
        public string Naslov { get; set; }
        public DateTime DatumIzdaje { get; set; }
        public List<Rubrika> SeznamRubrik { get; set; } = new List<Rubrika>();
        public string Urednik { get; set; }

        public override string ToString()
        {
            string niz = "";
            foreach (Rubrika rubrika in SeznamRubrik)
            {
                niz += rubrika.ToString();
            }
            return niz;
        }

        public void RubrikeAvtorja(string avtor)
        {

            foreach (Rubrika rubrika in SeznamRubrik)
            {
                if (rubrika.Avtor == avtor) Console.WriteLine(rubrika.ToString());
            }

        }

        public int SteviloStraniRednihRubrik()
        {
            int stStrani = 0;
            foreach (Rubrika rubrika in SeznamRubrik)
            {
                if (rubrika.JeRedna) stStrani += rubrika.SteviloStrani;
            }

            return stStrani;
        }
    }

}