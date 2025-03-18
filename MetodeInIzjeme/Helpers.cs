namespace MetodeInIzjeme
{
    internal class Helpers
    {
        public static void preveriPrastevilo(int stevka)
        {
            bool jePrastevilo = true;
            for (int i = 2; i < stevka; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0 && j != i)
                    {
                        jePrastevilo = false;
                        break;
                    }
                }

                if (jePrastevilo)
                {
                    Console.WriteLine($"{i} je prastevilo manjse od {stevka}");
                }
                jePrastevilo = true;
            }
        }
    }
}
