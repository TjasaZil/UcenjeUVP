namespace PersonalDiary.Metode;

internal class PreberiZapis
{
    public static void Preberi()
    {
        Console.Write("Kateri zapis želite prebrati?: ");
        string fileName = Console.ReadLine();
        Console.WriteLine();
        string pravaPot = "C:/Users/tjasa/RiderProjects/UcenjeUVP/PersonalDiary/bin/Debug/net8.0/" + fileName +".txt";
        if (File.Exists(pravaPot))
        {
            StreamReader srFile = new StreamReader(pravaPot);
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