namespace Izpit_2024_04_06
{
    internal class Naloga1
    {
        /// <summary>
        /// NALOGA 1:
        /// 
        /// Napišite metodo Frekvenca, ki kot parameter prejme seznam besed in znak. 
        /// Naloga metode je prešteti število besed na seznamu, 
        /// ki vsebujejo vsaj eno črko enako danemu znaku 
        /// (med velikimi in malimi črkami ne razlikujemo). 
        /// Število takih besed naj metoda vrne.                                [12 točk]
        /// 
        /// Dodatno naj ob pregledu besed iz seznama metoda v ukazno vrstico izpiše 
        /// vsako besedo, ki dani znak vsebuje vsaj dvakrat.                    [8 točk]
        /// 
        /// V metodi ResitevNaloge pripravite seznam z vsaj petimi besedami,
        /// pokličite metodo Frekvenca in izpišite število besed s seznama, 
        /// ki vsebujejo znak 'a'.                                              [5 točk]
        /// </summary>
        /// 
        public static void ResitevNaloge()
        {
            List<string> seznam = new List<string>() { "banAna", "Ananas", "Bo", "Lučka", "LimonA", "KoLO" };
            char znak = 'a';
            int steviloBesed = Frekvenca(seznam, znak);
            Console.WriteLine($"Število besed ki vsebujejo znak {znak} je : {steviloBesed}");
        }

        public static int Frekvenca(List<string> seznam, char znak)
        {
            int steviloBesed = 0;
            foreach (var beseda in seznam)
            {
                int stevecCrk = 0;
                if (beseda.ToLower().Contains(znak.ToString().ToLower()))
                {
                    steviloBesed++;
                }
                string manjsaBeseda = beseda.ToLower();
                int stevecZnaka = 0;
                for (int i = 0; i < manjsaBeseda.Length; i++)
                {
                    if (manjsaBeseda[i].ToString() == znak.ToString().ToLower()) stevecZnaka++;
                }
                //če dani znak vsebuje vsaj dvakrat
                if (stevecZnaka > 1) Console.WriteLine(beseda);
            }

            return steviloBesed;
        }
    }

}
