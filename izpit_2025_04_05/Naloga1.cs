namespace Izpit_2025_04_05
{
    /// <summary>
    /// NALOGA 1:
    /// 
    /// Napišite funkcijo Zamenjava, ki kot parameter prejme seznam nizov (stringov). 
    /// Vsak niz v seznamu naj predstavlja ime in priimek (v tem vrstnem redu) ločena s presledkom.
    /// Funkcija v vsakem nizu ime in priimek obrne, da bo rezultat priimek in ime, 
    /// za priimkom pa naj doda še vejico.
    /// Npr. niz "Borut Lužar" naj se preoblikuje v "Lužar, Borut".
    /// Tako preoblikovane nize naj funkcija doda v nov seznam in ga vrne.          [15 točk]
    /// 
    /// V funkciji ResitevNaloge pripravite seznam z vsaj osmimi nizi z imenom in priimkom. 
    /// Pokličite funkcijo Zamenjava s tem seznamom kot parametrom 
    /// in iz rezultata na zaslon izpišite vse priimke, ki so daljši od 5 znakov.   [10 točk]
    /// </summary>
    public class Naloga1
    {
        /// <summary>
        /// V tej funkciji se začne izvajati program za reševanje Naloge 1
        /// </summary>
        public static void ResitevNaloge()
        {
            List<string> seznam = new List<string>() { "Borut Luzar", "Katarina Cas", "Janez Novak", "Tjasa Zilavec", "Srecko Novak", "Janez Mali", "Alenka Kos", "Janko RabimdolgPriimek" };
            List<string> seznamObrnjen = Zamenjava(seznam);
            Console.WriteLine("Priimki daljši od petih znakov:");
            foreach (string el in seznamObrnjen)
            {
                string[] tabela = el.Split(", ");
                if (tabela[0].Length > 5) Console.WriteLine(tabela[0]);
            }
        }

        public static List<string> Zamenjava(List<string> seznam)
        {
            List<string> novSeznam = new List<string>();
            for (int i = 0; i < seznam.Count; i++)
            {
                string imePriimek = seznam[i];
                string[] tabela = imePriimek.Split(" ");
                string novNiz = tabela[1] + ", " + tabela[0];
                novSeznam.Add(novNiz);
            }

            return novSeznam;
        }
    }
}