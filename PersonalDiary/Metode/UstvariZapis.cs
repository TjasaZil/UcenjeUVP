namespace PersonalDiary.Metode;

internal class UstvariZapis
{
    public static void Ustvari()
    {
        Console.Write("Prosim zapišite naslov datoteke: ");
        string fileName = Console.ReadLine();
        Console.WriteLine();
        //Preveri če file mogoče že obstaja. Če že obstaja potem lahko samo popraviš zapis ali ga ustvariš
        string pravaPot = "C:/Users/tjasa/RiderProjects/UcenjeUVP/PersonalDiary/bin/Debug/net8.0/" + fileName +".txt";
        StreamWriter swFile = new StreamWriter(fileName+"txt");
        Zapis zapis = new Zapis();
        //podatki za zapis
        zapis.Cas=DateTime.Now;
        Console.Write("Kakšno je vaše počutje?");
        zapis.Pocutje = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Želite vpisati seznam današnjih opravil? (DA/NE)");
        string odlocitev = Console.ReadLine().ToLower();
        List<ToDo> seznamOpravil = new List<ToDo>();
        if (odlocitev == "da")
        {
            while (true)
            {
               Console.WriteLine("Ime opravila: ");
               string imeOpravila = Console.ReadLine();
               Console.WriteLine("Je opravilo opravljeno? (DA/NE) ");
               string opravljenoString = Console.ReadLine().ToLower();
               bool opravljeno = opravljenoString == "da" ? true : false;
               ToDo opravilo = new ToDo(opravljeno, imeOpravila);
               seznamOpravil.Add(opravilo);
               
               Console.WriteLine("Dodamo novo opravilo? (DA/NE)");
               string novoOpravilo = Console.ReadLine().ToLower();
               if (novoOpravilo != "da")
               {
                   Console.WriteLine("Z zapisovanjem opravil si zaključil");
                   break;
               }
            }
        }
        zapis.ToDoList.AddRange(seznamOpravil);
        Console.WriteLine("Napišite še kratek tekst zase: ");
        zapis.Tekst = Console.ReadLine();
        
        swFile.WriteLine(fileName);
        swFile.Write(zapis.ToString());   
        swFile.Flush();
        swFile.Close();
        
        Console.WriteLine($"Datoteka {fileName} je ustvarjena");

    }
  
}