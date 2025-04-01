namespace Izpit_2024_04_20
{
    internal class Naloga4
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

        public static void ResitevNaloge()
        {
            string filePath1 = "Viri/matrix.txt";
            string filePath2 = "Viri/matrixBig.txt";

            Console.WriteLine(ManupulacijaDatoteke(filePath1));
            Console.WriteLine(ManupulacijaDatoteke(filePath2));
        }

        public static int ManupulacijaDatoteke(string pot)
        {
            int stevec = 0;
            int stevecLihi = 0;
            int stevecSodi = 0;
            StreamReader srFile = new StreamReader(pot);
            while (srFile.EndOfStream == false)
            {
                string line = srFile.ReadLine();
                string[] table = line.Split("\t");
                foreach (var el in table)
                {
                    if (int.Parse(el) % 2 != 0) stevecLihi++;
                    else stevecSodi++;
                }
                if (stevecLihi > stevecSodi) stevec++;
                stevecLihi = 0;
                stevecSodi = 0;
            }

            srFile.Close();
            return stevec;
        }
    }
}
