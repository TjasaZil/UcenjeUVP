namespace PrimerIzpita
{
    internal class Naloga1
    {
        // https://github.com/borutluzar/NOO-Programiranje-2024/tree/master/99-PrimerIzpita
        /// <summary>
        /// NALOGA 1:
        /// Pripravljate rojstnodnevno zabavo. Kot izkušeni programerji 
        /// boste pripravili aplikacijo za prijavo gostov.
        /// Vaša aplikacija (preprosta metoda, ki z uporabnikom komunicira preko ukazne vrstice)
        /// omogoča vnos imena in priimka (v tem vrstnem redu) vsakega gosta 
        /// in dodajanje teh podatkov v seznam. [8 točk]
        /// 
        /// Ker sumite, da se bo registriralo nekaj nepovabljenih gostov, 
        /// morate seznam na koncu prečistiti. 
        /// Iz njega odstranite vse vnose, v katerih ime vsebuje črko T (malo ali veliko),
        /// in vse vnose, v katerih priimek vsebuje črko N (malo ali veliko). [10 točk]
        /// 
        /// Na koncu še izpišite vse goste (iz prečiščenega seznama) in število takšnih,
        /// ki imajo ime ali priimek daljši od 6 črk. [7 točk]
        /// </summary> 
        /// 

        //vnos imena in priimka
        //dodajanje imena in priimka v seznam
        // odstrani vse goste katerih ime vsebuje črko t ali priimek črko n (malo ali veliko)
        // izpiši goste iz prečiščenega seznama
        // koliko gostov ima ime ali priimek daljše od 6 črk?
        public static void Gostje()
        {
            /// Pripravljate rojstnodnevno zabavo. Kot izkušeni programerji 
            /// boste pripravili aplikacijo za prijavo gostov.
            /// Vaša aplikacija (preprosta metoda, ki z uporabnikom komunicira preko ukazne vrstice)
            /// omogoča vnos imena in priimka (v tem vrstnem redu) vsakega gosta 
            /// in dodajanje teh podatkov v seznam. [8 točk]
            int stevec = 0;
            List<Gost> seznamGostov = new List<Gost>();
            while (stevec < 5)
            {
                string ime = " ";
                string priimek = " ";
                Console.Write("Napiši ime gosta: ");
                ime = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Napiši priimek gosta: ");
                priimek = Console.ReadLine();
                Console.WriteLine();
                
                seznamGostov.Add(new Gost(ime, priimek));
                stevec++;
            }
            
            /// Ker sumite, da se bo registriralo nekaj nepovabljenih gostov, 
            /// morate seznam na koncu prečistiti. 
            /// Iz njega odstranite vse vnose, v katerih ime vsebuje črko T (malo ali veliko),
            /// in vse vnose, v katerih priimek vsebuje črko N (malo ali veliko). [10 točk]

            List<Gost> preciscenSeznam = new List<Gost>();

            for (int i = 0; i < seznamGostov.Count; i++)
            {
                if (!seznamGostov[i].Ime.Contains("t") && !seznamGostov[i].Ime.Contains("T") &&
                    !seznamGostov[i].Priimek.Contains("n") && !seznamGostov[i].Priimek.Contains("N"))
                {
                    preciscenSeznam.Add(seznamGostov[i]);
                } 
            }
            
            /// Na koncu še izpišite vse goste (iz prečiščenega seznama) in število takšnih,
            /// ki imajo ime ali priimek daljši od 6 črk. [7 točk]

            int dolzina = 0;
            Console.WriteLine("Ti gostje so zaželjeni na zabavi: ");
            foreach (var gost in preciscenSeznam)
            {
                Console.WriteLine(gost.Ime + " " + gost.Priimek);
                if (gost.Ime.Length > 6 || gost.Priimek.Length > 6)
                {
                    dolzina++;
                }
            }
            
            Console.WriteLine($"Koliko gostov ima ime ali pšriimek daljši od 6 črk: {dolzina}");
        }
    }

    public class Gost
    {
        public Gost(string ime, string priimek)
        {
            Ime = ime;
            Priimek = priimek;
        }
        
        public string Ime { get; set; }
        public string Priimek { get; set; }
    }
}
