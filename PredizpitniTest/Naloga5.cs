namespace PredizpitniTest
{
    /// <summary>
    /// NALOGA 4:
    /// 
    /// V mapi Viri imate pripravljeni dve datoteki s tabelama števil. 
    /// Števila so v posamezni vrstici ločena s tabulatorjem.
    /// 
    /// Napišite metodo, ki kot parameter prejme pot do datoteke s tabelo števil.   
    /// Metoda naj v vsaki vrstici preveri, če je v njej več sodih ali lihih števil.
    /// Število vrstic, v katerih je (strogo) več lihih števil, naj metoda vrne.     [20 točk]
    /// 
    /// V metodi ResitevNaloge že imate pripravljeni dve spremenljivki 
    /// s potema do datotek s primeroma tabel.
    /// V tej metodi pokličite pripravljeno metodo za obe datoteki 
    /// in izpišite rezultat v ukazno vrstico.                                      [5 točke]
    /// </summary>
    /// 
    internal class Naloga5
    {
        public static void ResitevNaloge()
        {
            string filePath1 = "Viri/matrix.txt";
            string filePath2 = "Viri/matrixBig.txt";
            Console.WriteLine($"Stevilo vrstic kjer je vec lihih kot sodih stevil v vrstici, 1. datoteka:{ManipulacijaDatoteke(filePath1)}");
            Console.WriteLine($"Stevilo vrstic kjer je vec lihih kot sodih stevil v vrstici, 2. datoteka:{ManipulacijaDatoteke(filePath2)}");
        }

        public static int ManipulacijaDatoteke(string pot)
        {
            StreamReader sr = new StreamReader(pot);
            int stevec = 0;
            while (sr.EndOfStream == false)
            {
                string line = sr.ReadLine();
                string[] table = line.Split("\t");
                int stLihih = 0;
                int stSodih = 0;
                foreach (string el in table)
                {
                    if (int.Parse(el) % 2 == 0) stSodih++;
                    else stLihih++;
                }
                if (stLihih > stSodih) stevec++;
            }
            sr.Close();

            return stevec;
        }
    }
}
