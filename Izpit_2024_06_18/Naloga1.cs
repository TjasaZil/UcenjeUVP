namespace Izpit_2024_06_18
{
    internal class Naloga1
    {
        /// <summary>
        /// NALOGA 1:
        /// 
        /// Napišite metodo VsoteStevk, ki kot parameter prejme seznam celih števil. 
        /// Za vsako število iz seznama naj izračuna vsoto njegovih števk 
        /// (npr.vsota števk števila 23 je 5) in na zaslon izpiše tista
        /// (originalna) števila, katerih vsota je manjša od 10.                    [15 točk]
        /// 
        /// Metoda naj vsote števk vseh števil iz danega seznama sešteje 
        /// in ta seštevek vrne.                                                    [5 točk]
        /// 
        /// V metodi ResitevNaloge pripravite seznam z vsaj petimi celimi števili, 
        /// pokličite metodo VsoteStevk in izpišite skupno vsoto vseh števk, 
        /// ki jo metoda vrne, v ukazno vrstico.                                    [5 točk]
        /// </summary>
        /// 


        public static void ResitevNaloge()
        {
            List<int> seznam = new List<int> { 1, 25, 197, 13, 56, 12, 98, 123 };

            int vsota = VsotaStevk(seznam);
            Console.WriteLine($"Celotna vsota vseh števk je : {vsota}");

        }

        public static int VsotaStevk(List<int> seznamStevil)
        {
            Console.WriteLine("Seznam števk katerih vsota je manjša od 10:");
            int celotnaVsota = 0;
            for (int i = 0; i < seznamStevil.Count; i++)
            {
                int stevilo = seznamStevil[i];
                int vsota = 0;
                int temp;
                while (stevilo != 0)
                {
                    temp = stevilo % 10;
                    vsota += temp;
                    stevilo = stevilo / 10;

                }
                if (vsota < 10) Console.WriteLine(seznamStevil[i]);

                celotnaVsota += vsota;
            }

            return celotnaVsota;
        }
    }
}
