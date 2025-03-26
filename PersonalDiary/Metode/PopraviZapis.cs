using System.Data;

namespace PersonalDiary.Metode;

internal class PopraviZapis
{
    public static void Popravi()
    {
        Console.Write("Kateri zapis želite popraviti?: ");
        string fileName = Console.ReadLine();
        Console.WriteLine();
        string pravaPot = "C:/Users/tjasa/RiderProjects/UcenjeUVP/PersonalDiary/bin/Debug/net8.0/" + fileName +".txt";
       
       
        if (File.Exists(pravaPot))
        {
            Zapis zapis = new Zapis();
            List<ToDo> seznamOpravil = new List<ToDo>();
            StreamReader srFile = new StreamReader(pravaPot);
            //rada bi nrdila tko da ni treba vsega spremenit ampak da se uporabnik odloči kateri dev bo dpremenil. Tko da je treba file prebrat in spravt v spremenljivko, dat na izbiro kaj bi šlovek spremenil, spremeniti tisto z read.Linom, potem pa pushniti nazaj v datoteko vse skupaj -> verjetno si bo potrebno pomagati s parsingom
            while (srFile.EndOfStream==false)
            {
                string line = srFile.ReadLine();
                Console.WriteLine(line);
            }
            srFile.Close();
        }
        else Console.WriteLine("Ker zapis ne obstaja se vračam na začetek.");
        
    }
}
