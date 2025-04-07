namespace Izpit_2024_03_23
{
    internal class Naloga1
    {
        /// <summary>
        /// NALOGA 1:
        /// Napišite metodo RezultatiIzpita, ki ne prejme nobenega parametra,
        /// vrača pa decimalno število. 
        /// V njej od uporabnika zahtevajte vnos podatkov (preko ukazne vrstice) 
        /// o študentih, ki so pisali izpit. Za vsakega študenta naj 
        /// vpiše vpisno številko in število doseženih točk.
        /// Podatke naj vnaša, dokler ne vnese vrednosti "X", 
        /// ki naj pomeni izhod iz vnosa podatkov.                          [10 točk]
        /// 
        /// Pridobljeni podatki za vsakega študenta naj se zapišejo
        /// kot lastnost v instanco razreda StudentData 
        /// (ta razred bo torej imel dve lastnosti).
        /// Vse instance shranite v seznam.                                 [5 točk]
        /// 
        /// V metodi v ukazno vrstico izpišite največje število doseženih točk
        /// ter najmanjše število doseženih točk.                           [5 točk]
        /// 
        /// Na koncu naj metoda RezultatiIzpita vrne povprečno število doseženih točk.
        /// Metodo še pokličite v metodi ResitevNaloge in izpišite dobljeni rezultat 
        /// v ukazno vrstico.                                               [5 točk]
        /// </summary>

        public static void ResitevNaloge()
        {
            decimal povprecje = RezultatiIzpita();
            Console.WriteLine($"To je povprečje točk: {povprecje:0.00}");
        }
        public static decimal RezultatiIzpita()
        {

            List<StudentData> seznamStudentov = new List<StudentData>();
            while (true)
            {
                Console.Write("Vpišite vpisno številko študenta in število doseženih točk na izpitu. Podatka prosim ločite z enim presledkom: ");
                string niz = Console.ReadLine();

                if (niz == "X") break;

                string[] tabela = niz.Split(" ");
                StudentData student = new StudentData(tabela[0], int.Parse(tabela[1]));

                seznamStudentov.Add(student);
            }

            int max = seznamStudentov[0].SteviloTock;
            int min = seznamStudentov[0].SteviloTock;
            int vsota = 0;
            for (int i = 0; i < seznamStudentov.Count; i++)
            {
                vsota += seznamStudentov[i].SteviloTock;
                if (seznamStudentov[i].SteviloTock > max) max = seznamStudentov[i].SteviloTock;
                else if (seznamStudentov[i].SteviloTock < min) min = seznamStudentov[i].SteviloTock;
            }

            Console.WriteLine($"Največje število doseženih točk je {max}, najmanjše pa {min}");

            return (decimal)vsota / seznamStudentov.Count;
        }
    }

    public class StudentData
    {
        public StudentData(string vpisnaStevilka, int steviloTock)
        {
            VpisnaStevilka = vpisnaStevilka;
            SteviloTock = steviloTock;
        }

        public string VpisnaStevilka { get; set; }
        public int SteviloTock { get; set; }
    }
}
