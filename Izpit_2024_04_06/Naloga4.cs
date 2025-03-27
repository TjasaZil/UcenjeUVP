namespace Izpit_2024_04_06
{
    internal class Naloga4
    {
        /// <summary>
        /// NALOGA 4:
        /// 
        /// V mapi Viri imate pripravljeni dve datoteki s tabelama števil. 
        /// Števila so v posamezni vrstici ločena s tabulatorjem.
        /// 
        /// Napišite metodo, ki kot parameter prejme pot do datoteke s tabelo števil.   [2 točki]
        /// Metoda naj v vsaki vrstici poišče največje in najmanjše število 
        /// ter ju shrani v ustrezno podatkovno strukturo.                              [10 točk]
        /// Na koncu naj izračuna vsoto vseh največjih števil po vrsticah in 
        /// vsoto vseh najmanjših števil po vrsticah ter ti vsoti odšteje.              [8 točk]
        /// Rezultat odštevanja naj metoda vrne.                                        [2 točki]
        /// 
        /// V metodi ResitevNaloge že imate pripravljeni dve spremenljivki 
        /// s potema do datotek s primeroma tabel.
        /// V tej metodi pokličite pripravljeno metodo za obe datoteki 
        /// in izpišite rezultat v ukazno vrstico.                                      [3 točke]
        /// </summary>
        /// 

        public static void ResitevNaloge()
        {
            string filePath1 = "Viri/matrix.txt";
            string filePath2 = "Viri/matrixBig.txt";

            Console.WriteLine($"Rezultat za manjšo datoteko: {ManipulacijaDatotek(filePath1)}");
            Console.WriteLine($"Rezultat za večjo datoteko: {ManipulacijaDatotek(filePath2)}");

        }

        public static int ManipulacijaDatotek(string pot)
        {
            StreamReader srFile = new StreamReader(pot);
            List<int> najvecjeStevilke = new List<int>();
            List<int> najmanjseStevilke = new List<int>();
            while (srFile.EndOfStream == false)
            {
                string line = srFile.ReadLine();
                string[] tabela = line.Split("\t");
                int min = int.Parse(tabela[0]);
                int max = int.Parse(tabela[0]);
                for (int i = 0; i < tabela.Length; i++)
                {
                    if (min > int.Parse(tabela[i])) min = int.Parse(tabela[i]);
                    else if (max < int.Parse(tabela[i])) max = int.Parse(tabela[i]);
                }
                najvecjeStevilke.Add(max);
                najmanjseStevilke.Add(min);
            }
            int vsotaNajvecjih = VsotaStevk(najvecjeStevilke);
            int vsotaNajmanjsih = VsotaStevk(najmanjseStevilke);

            return vsotaNajvecjih - vsotaNajmanjsih;
        }

        public static int VsotaStevk(List<int> stevilke)
        {
            int vsota = 0;
            foreach (var el in stevilke)
            {

                vsota += el;
            }
            return vsota;

        }
    }


}
