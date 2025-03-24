namespace RazrediInObjekti
{
    internal class Knjiga
    {
        // 8.1 Knjiga



    }

    /* Naloga 8.1.0.1. Ustvarite razred Avtor s polji za ime, priimek, spol, starost in email naslov. Dodajte mu konstruktor, ki omogoca dolocitev vrednosti vseh polj in metodo za izpis njegovih podatkov, ki vrne niz. */
    public class Avtor
    {
        public Avtor() { }
        public Avtor(string ime, string priimek, string spol, int starost, string email)
        {
            Ime = ime;
            Priimek = priimek;
            Spol = spol;
            Starost = starost;
            Email = email;
        }

        public string Ime { get; set; }
        public string Priimek { get; set; }
        public string Spol { get; set; }
        public int Starost { get; set; }
        public string Email { get; set; }

        public string izpisAvtorja()
        {
            return $"Podatki o avtorju: \nIme: {Ime}\nPriimek: {Priimek}\nSpol: {Spol}\nStarost: {Starost}\nEmail: {Email}";
        }
    }

    /* Naloga 8.1.0.2. Ustvarite razred Knjiga s polji za naslov knjige, avtorja (iz prejsnje  naloge), zalozbo in stevilo strani. Dodajte mu tudi konstruktor, ki doloci avtorja. Ob tem naj vsebuje tudi metodo za izpis, ki izpise podatke o knjigi skupaj s podatki o avtorju. */

    public class Knjig //ne more biti "Knjiga" zaradi taglavnega classa
    {

        public Knjig(string ime, string priimek, string spol, int starost, string email, string naslov, string zalozba, int steviloStrani)
        {
            Naslov = naslov;
            Zalozba = zalozba;
            SteviloStrani = steviloStrani;
            Avtor = new Avtor(ime, priimek, spol, starost, email);
        }

        public string Naslov { get; set; }
        public Avtor Avtor { get; set; }
        public string Zalozba { get; set; }
        public int SteviloStrani { get; set; }

        public void izpisPodatkov()
        {

            Console.WriteLine("Podatki o knjigi: ");
            Console.WriteLine($"Naslov: {Naslov} \nZalozba: {Zalozba} \nStevilo strani: {SteviloStrani} \nIme avtorja: {Avtor.Ime} \nPriimek avtorja: {Avtor.Priimek}\nSpol avtorja: {Avtor.Spol} \nStarost avtorja: {Avtor.Starost}\nEmail avtorja: {Avtor.Email}\n");
        }
    }
}
