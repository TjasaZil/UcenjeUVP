namespace Izpit_2025_04_05
{
    /// <summary>
    /// NALOGA 4:
    /// 
    /// V mapi Viri imate pripravljeni dve datoteki z nizi (ki vsebujejo črke ali številke). 
    /// Nizi so v posamezni vrstici ločeni s tabulatorjem.
    /// 
    /// Pripravite funkcijo SteviloStevil, ki kot parameter dobi pot do datoteke. 
    /// V datoteki naj poišče vse nize, ki vsebujejo le številke (od 0 do 9) 
    /// in vsakega posebej izpiše na zaslon.
    /// Funkcija naj sešteje dolžine teh nizov in vsoto vrne.           [20 točk]
    /// 
    /// V funkciji ResitevNaloge že imate pripravljeni dve spremenljivki 
    /// s potema do obeh datotek.
    /// V tej funkciji pokličite pripravljeno funkcijo za vsako datoteko posebej
    /// in zanju izpišite rezultat.                                     [5 točk]
    ///
    /// Namig: za datoteko besede.txt je rezultat enak 8.
    /// </summary>
    public class Naloga4
    {
        /// <summary>
        /// V tej metodi se začne izvajati program za reševanje Naloge 4
        /// </summary>
        public static void ResitevNaloge()
        {
            string filePath1 = "Viri/besede.txt";
            string filePath2 = "Viri/besedeBig.txt";
            int vsotaBesede = SteviloStevil(filePath1);
            int vsotaBesedeBig = SteviloStevil(filePath2);

            Console.WriteLine("Rezultat za datoteko besede.txt: " + vsotaBesede);
            Console.WriteLine("Rezultat za datoteko besedeBig.txt: " + vsotaBesedeBig);

        }

        public static int SteviloStevil(string pot)
        {
            int vsota = 0;
            List<string> samoStevke = new List<string>();
            StreamReader sr = new StreamReader(pot);

            while (sr.EndOfStream == false)
            {
                string line = sr.ReadLine();
                string[] table = line.Split("\t", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < table.Length; i++)
                {
                    bool vsebujeSamoStevke = true;
                    string beseda = table[i];
                    for (int j = 0; j < beseda.Length; j++)
                    {
                        char znak = beseda[j];
                        bool preveriZnak = PreveriZnak(znak);
                        if (!preveriZnak)
                        {
                            vsebujeSamoStevke = false;
                            break;
                        }
                    }

                    if (vsebujeSamoStevke)
                    {
                        vsota += table[i].Length;
                        samoStevke.Add(beseda);
                    }
                    else continue;
                }
            }
            Console.WriteLine("Nizi kateri vsebujejo samo števke:");
            foreach (string el in samoStevke)
            {
                Console.WriteLine(el);
            }
            sr.Close();
            return vsota;
        }

        public static bool PreveriZnak(char znak)
        {
            bool jeStevilka = false;
            switch (znak)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    jeStevilka = true;
                    break;
                default:
                    jeStevilka = false;
                    break;
            }

            return jeStevilka;
        }
    }
}