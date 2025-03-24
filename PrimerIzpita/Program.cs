namespace PrimerIzpita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Naloga1.Gostje();
            Naloga2.ResitevNaloge();
            Naloga3.ResitevNaloge();
            Console.Write("Kako velik naj bo metuljček?: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Naloga4.Metuljcek(n);

            Console.ReadLine();
        }
    }
}
