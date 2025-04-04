namespace Izpit_2024_09_26
{
    internal class Naloga4
    {
        /// <summary>
        /// NALOGA 4:
        /// 
        /// V mapi Viri imate pripravljeni dve datoteki s tabelama števil. 
        /// Števila so v posamezni vrstici ločena s tabulatorjem.
        /// 
        /// Pripravite metodo AnalizaZadnjih, ki kot parameter dobi 
        /// pot do datoteke s tabelo števil. 
        /// Prebere naj zadnje število v vsaki vrstici, 
        /// poišče najmanjše med vsemi in ga prišteje prvemu številu vsake vrstice. 
        /// Tako popravljeno tabelo zapišite v novo datoteko, 
        /// katere ime prav tako prejmete kot parameter metode.                         [20 točk]
        /// 
        /// V metodi ResitevNaloge že imate pripravljeni dve spremenljivki 
        /// s potema do datotek s primeroma tabel.
        /// V tej metodi pokličite pripravljeno metodo za obe datoteki. 
        /// Rezultat bosta dve novi datoteki.                                           [5 točke]
        /// </summary>
        /// 

        public static void ResitevNaloge()
        {
            string filePath1 = "Viri/matrix.txt";
            string filePath2 = "Viri/matrixBig.txt";
            AnalizaZadnjih(filePath1, "Viri/matrixNEW.txt");
            AnalizaZadnjih(filePath2, "Viri/matrixBigNEW.txt");

        }

        public static void AnalizaZadnjih(string pot, string novaDatoteka)
        {

            StreamReader sr = new StreamReader(pot);
            List<string> seznamZadnjih = new List<string>();

            while (sr.EndOfStream == false)
            {
                string line = sr.ReadLine();
                string[] tabela = line.Split("\t");
                seznamZadnjih.Add(tabela[tabela.Length - 1]);
            }
            sr.Close();
            int min = int.Parse(seznamZadnjih[0]);
            foreach (string el in seznamZadnjih)
            {
                if (int.Parse(el) < min) min = int.Parse(el);
            }
            sr = new StreamReader(pot);
            StreamWriter sw = new StreamWriter(novaDatoteka);
            while (sr.EndOfStream == false)
            {
                string line = sr.ReadLine();
                string[] tabela = line.Split("\t");
                tabela[0] = (int.Parse(tabela[0]) + min).ToString();
                string niz = "";
                foreach (string el in tabela)
                {
                    niz += el + "\t";
                }
                sw.WriteLine(niz);
            }
            sw.Flush();
            sr.Close();
            sw.Close();
        }
    }


}
