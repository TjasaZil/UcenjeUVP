namespace Izpit_2025_03_22;

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
public class Naloga4
{
    /// <summary>
    /// V tej metodi se začne izvajati program za reševanje Naloge 4
    /// </summary>
    public static void ResitevNaloge()
    {
        string filePath1 = "Viri/matrix.txt";
        string filePath2 = "Viri/matrixBig.txt";

        AnalizaZadnjih(filePath1, "Viri/novaMatrix.txt");
        AnalizaZadnjih(filePath2, "Viri/novaMatrixBig.txt");

    }


    public static void AnalizaZadnjih(string pot, string novaDatoteka)
    {
        StreamReader srFile = new StreamReader(pot);
        StreamWriter swFile = new StreamWriter(novaDatoteka);
        List<int> zadnjeStevke = new List<int>();
        
        
        while (srFile.EndOfStream == false)
        {
            string line = srFile.ReadLine();
            string[] tabela = line.Split("\t");
            int zadnjaStevka = int.Parse(tabela[tabela.Length - 1]); //prebere zadnjo stevko ampak kaj z njo nrdi?
            zadnjeStevke.Add(zadnjaStevka);
           
        }
        int min = zadnjeStevke[0];
        foreach (int stevka in zadnjeStevke)
        {
            if (stevka < min) min = stevka;
        }
        
        //tole ni najbolj idealno ampak vseeno sem naredila tako ker se mi je zdela najbolj hitra rešitev brez dvojnih list.
        srFile.Close();
        srFile = new StreamReader(pot);
            
        while (srFile.EndOfStream == false)
        {
            string line = srFile.ReadLine();
            string[] tabela = line.Split("\t");
            int prvaStevka = int.Parse(tabela[0]);
           
           int Vsota = prvaStevka + min;
           tabela[0] = Vsota.ToString();
           string niz = "";
           //spremenimo nazaj iz tabele v niz ki loči s tabulatorjem preden zapišemo
           foreach (var el in tabela)
           {
               niz += el + "\t";
           }
           
           swFile.WriteLine(niz);
           
        }
        swFile.Flush();
        srFile.Close();
        swFile.Close();
    }
}