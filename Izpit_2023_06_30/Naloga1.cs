namespace Izpit_2023_06_30
{
    internal class Naloga1
    {
        /// <summary>
        /// NALOGA 1:
        /// Napišite metodo, ki uporabniku ponudi možnost 
        /// vnosa artikla na nakupovalni seznam skupaj 
        /// s številom kosov teh artiklov (npr. jogurt, 2).
        /// Glede poziva uporabniku se lahko odločite sami
        /// (npr. najprej ga pozovete, naj vnese naziv artikla, 
        /// in nato še, naj vnese število kosov oziroma količino).
        /// 
        /// Uporabnik naj artikle vnaša, dokler se ne odloči, 
        /// da je vnesel vse, in zaključi (tudi za to naj ima na voljo ukaz). [15 točk]
        /// 
        /// Da boste lahko artikle kar najbolj enostavno shranjevali, 
        /// si pripravite razred Artikel z ustreznimi lastnostmi. [5 točk]
        /// 
        /// Na koncu izpišite vse artikle na seznamu uporabnika in skupno število kosov. [5 točk]
        /// </summary>
        /// 

        public static void ResitevNaloge()
        {
            List<Artikel> nakupovalniSeznam = new List<Artikel>();
            while (true)
            {
                Console.Write("Napišite ime artikla ali zaključite vnos (X): ");
                string imeArtikla = Console.ReadLine();
                Console.WriteLine();
                if (imeArtikla == "X") break;
                Console.Write("Napišite število kosov: ");
                int stKosov = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();


                nakupovalniSeznam.Add(new Artikel(imeArtikla, stKosov));
            }
            int kosi = 0;
            foreach (var el in nakupovalniSeznam)
            {
                Console.WriteLine($"Ime artikla: {el.Ime}\nKolicina artikla: {el.Kolicina}");
                Console.WriteLine();
                kosi += el.Kolicina;
            }
            Console.WriteLine("Skupno število kosov: " + kosi);
        }

        public class Artikel
        {
            public Artikel(string ime, int kolicina)
            {
                Ime = ime;
                Kolicina = kolicina;
            }
            public string Ime { get; set; }
            public int Kolicina { get; set; }
        }
    }


}
