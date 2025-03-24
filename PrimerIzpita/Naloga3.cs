namespace PrimerIzpita
{
    internal class Naloga3
    {
        /// <summary>
        /// NALOGA 3:
        /// Pripravite razreda Pisalo in Peresnica.
        /// 
        /// Razred Pisalo naj vsebuje: 
        /// -   Lastnosti VrstaPisala (svinčnik, kemični svinčnik, nalivno pero...),
        ///     CenaPisala, DolžinaPisala, Proizvajalec (tej lastnosti lahko vrednost nastavimo samo v konstruktorju!). da
        /// -   Konstruktor, ki omogoča določitev vsaj dveh lastnosti. da
        /// -   Povozite metodo ToString, ki naj izpiše vse podatke o pisalu. [10 točk] da
        /// 
        /// Razred Peresnica naj vsebuje:
        /// -   Lastnosti SeznamPisal in Kapaciteta (t.j., maksimalno število pisal v peresnici). da
        /// -   Konstruktor, ki inicializira seznam pisal. da
        /// -   Metodo, ki izpiše vsa pisala, ki imajo ceno vsaj 3 evre. [10 točk] da
        /// 
        /// V metodi ResitevNaloge kreirajte instanco razreda Peresnica, ki naj vsebuje vsaj štiri pisala
        /// in izpišite podatke o vseh pisalih, ki imajo ceno vsaj 3 evre. [5 točk]
        /// </summary>
        ///

        public static void ResitevNaloge()
        {
            Peresnica peresnica = new Peresnica();

            // Ustvarimo še štiri pisala in jih sproti dodamo v peresnico
            Pisalo pisalo1 = new Pisalo("svinčnik", "Pelikan");
            pisalo1.DolzinaPisala = 0.08;
            pisalo1.CenaPisala = 3.15;
            peresnica.SeznamPisal.Add(pisalo1);

            Pisalo pisalo2 = new Pisalo("kemični svinčnik", "Pelikan");
            pisalo2.DolzinaPisala = 0.78;
            pisalo1.CenaPisala = 1.15;
            peresnica.SeznamPisal.Add(pisalo2);

            Pisalo pisalo3 = new Pisalo("nalivno pero", "Pelikan");
            pisalo3.DolzinaPisala = 0.08;
            pisalo1.CenaPisala = 3.95;
            peresnica.SeznamPisal.Add(pisalo3);

            Pisalo pisalo4 = new Pisalo("gosje pero", "Pelikan");
            pisalo4.DolzinaPisala = 0.20;
            pisalo1.CenaPisala = 3.45;
            peresnica.SeznamPisal.Add(pisalo4);

            List<Pisalo> filtrirani = peresnica.filtrirajPisala(3);
            foreach (Pisalo pisalo in filtrirani)
            {
                Console.WriteLine(pisalo.ToString());
            }
        }


    }

    public class Pisalo
    {

        public Pisalo(string vrstaPisala, string proizvajalec)
        {
            VrstaPisala = vrstaPisala;
            Proizvajalec = proizvajalec;
        }
        public string VrstaPisala { get; set; }
        public double CenaPisala { get; set; }
        public double DolzinaPisala { get; set; }
        public string Proizvajalec { get; set; }

        public override string ToString()
        {
            return $"Podatki o pisalu:\nVrsta: {VrstaPisala}\nCena: {CenaPisala}\nDolzina: {DolzinaPisala}\nProizvajalec: {Proizvajalec}";
        }

    }
    public class Peresnica
    {

        public Peresnica()
        {
            SeznamPisal = new List<Pisalo>();
        }
        public List<Pisalo> SeznamPisal { get; set; }
        public int Kapaciteta { get; set; }

        public List<Pisalo> filtrirajPisala(double cena)
        {
            List<Pisalo> filtriranaPisala = new List<Pisalo>();

            foreach (var el in SeznamPisal)
            {
                if (el.CenaPisala > cena)
                {
                    filtriranaPisala.Add(el);
                }
            }

            return filtriranaPisala;
        }
    }

}
