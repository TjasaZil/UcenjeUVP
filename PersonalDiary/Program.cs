namespace PersonalDiary;

class Program
{
    static void Main(string[] args)
    {
       /*
         * Aplikacija kjer lahko user vpisuje notri različne stvari in se te potem shranijo v datotelko
         * lahko dodajamo ali beremo zapise.
         */
      ZazeniAplikacijo();
    }
    public static void ZazeniAplikacijo()
    {
        while (true)
        {
            try
            {
                Console.WriteLine(
                    "Kaj želite storiti?:\n1 - Ustvari nov zapis\n2 - preberi obstoječi zapis\n3 - popravi obstoječi zapis\nX - zapri aplikacijo");
                string userInput = Console.ReadLine();
                if (userInput == "X" || userInput == "x") break;
                if (userInput == "1") Metode.UstvariZapis.Ustvari();
                else if (userInput == "2") Metode.PreberiZapis.Preberi();
                else if (userInput == "3") Metode.PopraviZapis.Popravi();
                else throw new ArgumentOutOfRangeException("Invalid input");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }

   }