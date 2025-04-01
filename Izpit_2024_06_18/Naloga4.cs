namespace Izpit_2024_06_18
{
    internal class Naloga4
    {
        /// <summary>
        /// NALOGA 4:
        /// 
        /// V mapi Viri imate pripravljeni dve datoteki s tabelama števil. 
        /// Števila so v posamezni vrstici ločena s tabulatorjem.
        /// 
        /// Pripravite metodo VsotaSodih, v kateri za dano pot do datoteke s tabelo števil 
        /// vsa števila po vrsti združite v en niz (brez presledkov ali tabulatorjev), 
        /// nato v eno spremenljivko seštejte vse števke na sodih mestih v tem nizu 
        /// in v drugo spremenljivko seštejte vse števke na lihih mestih 
        /// (pri tem je prva števka na sodem mestu, saj je na indeksu 0). 
        /// Metoda naj vrne razliko obeh dobljenih vsot.                                [20 točk]
        /// 
        /// V metodi ResitevNaloge že imate pripravljeni dve spremenljivki 
        /// s potema do datotek s primeroma tabel.
        /// V tej metodi pokličite pripravljeno metodo za obe datoteki 
        /// in izpišite rezultata v ukazno vrstico.                                     [5 točke]
        /// </summary>
        /// 

        public static void ResitevNaloge()
        {
            string filePath1 = "Viri/matrix.txt";
            string filePath2 = "Viri/matrixBig.txt";
            int razlika1 = VsotaSodih(filePath1);
            int razlika2 = VsotaSodih(filePath2);

            Console.WriteLine("razlika med sodimi in lihimi za prvo datoteko: " + razlika1);
            Console.WriteLine("razlika med sodimi in lihimi za drugo datoteko: " + razlika2);
        }

        public static int VsotaSodih(string pot)
        {
            string niz = "";

            StreamReader srFile = new StreamReader(pot);

            while (srFile.EndOfStream == false)
            {
                string line = srFile.ReadLine();
                string[] table = line.Split("\t");
                foreach (var el in table)
                {
                    niz += el;
                }
            }

            int vsotaSoda = 0;
            int vsotaLiha = 0;
            for (int i = 0; i < niz.Length; i++)
            {
                if (i % 2 == 0) vsotaSoda += Convert.ToInt32(niz[i]);
                else vsotaLiha += Convert.ToInt32(niz[i]);

            }


            return vsotaSoda - vsotaLiha;

        }

    }
}
