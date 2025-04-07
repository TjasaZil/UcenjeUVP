namespace PrimerIzpita
{
    internal class Naloga2
    {

        /// <summary>
        /// NALOGA 2:
        /// V metodi ResitevNaloge imate pripravljena dva seznama.
        /// Prvi je seznam predmetov, drugi pa seznam vpisnih številk študentov.
        /// 
        /// Definirana sta tudi razreda Student in Predmet.
        /// 
        /// Za vsako vpisno številko pripravite instanco razreda Student,
        /// ki bo imel dano vpisno številko in seznam vseh šestih predmetov,
        /// pri čemer za vsak predmet oceno izberete slučajno med ocenami
        /// od 6 do 10. [10 točk]
        /// 
        /// V razred Student dodajte metodo, ki izračuna in vrne povprečno oceno študenta. [5 točk]
        /// 
        /// Na koncu izpišite povprečno oceno študentov pri vsakem od predmetov. [10 točk]
        /// </summary>
        /// 
        public static void ResitevNaloge()
        {
            // *** KODE OD TUKAJ DO SPODNJE MEJE NE SPREMINJAJTE!

            // Seznam predmetov
            List<string> lstImenaPredmetov = new List<string>()
            {
                "Osnove programiranja",
                "Informacijski sistemi",
                "Internet stvari",
                "Industrijska avtomatizacija",
                "Kibernetska varnost"
            };

            // Seznam vpisnih številk študentov
            List<int> lstVpisneStevilke = new List<int>();
            for (int i = 3530_001; i <= 3530_100; i++)
            {
                lstVpisneStevilke.Add(i);
            }
            // *** KODE DO TUKAJ OD ZGORNJE MEJE NE SPREMINJAJTE!

            /// Za vsako vpisno številko pripravite instanco razreda Student,
            /// ki bo imel dano vpisno številko in seznam vseh šestih predmetov,
            /// pri čemer za vsak predmet oceno izberete slučajno med ocenami
            /// od 6 do 10. [10 točk]

            List<Student> lstStudentov = new List<Student>();
            Random random = new Random();
            for (int i = 0; i < lstVpisneStevilke.Count; i++)
            {
                Student student = new Student(lstVpisneStevilke[i]);

                for (int j = 0; j < lstImenaPredmetov.Count; j++)
                {
                    int ocena = random.Next(6, 11);
                    Predmet predmet = new Predmet(lstImenaPredmetov[j], ocena);
                    student.Ocene.Add(predmet);
                }

                lstStudentov.Add(student);
            }
            
            /// povprecna ocena pri vsakem od predmetov

            for (int i = 0; i < lstImenaPredmetov.Count; i++)
            {
                double vsota=0;
                foreach (var student in lstStudentov)
                {
                    vsota += student.Ocene[i].Ocena;
                }

                double povprecje = vsota / lstStudentov.Count;
                Console.WriteLine($"Povprečje pri predmetu {lstImenaPredmetov[i]} je {povprecje}");

            }
            

        }


    }

    public class Student
    {
        public Student(int vpSt)
        {
            VpisnaStevilka = vpSt;
            Ocene = new List<Predmet>();
        }

        public int VpisnaStevilka { get; set; }

        public List<Predmet> Ocene { get; set; }

        /// V razred Student dodajte metodo, ki izračuna in vrne povprečno oceno študenta.

        public double PovprecnaOcena()
        {
            double vsota = 0;
            foreach (var predmet in Ocene)
            {
                vsota += predmet.Ocena;
            }

            return vsota / Ocene.Count;
        }
    }


    //Predmeti so zdefinirani
    public class Predmet
    {
        public Predmet(string naziv, int ocena)
        {
            Naziv = naziv;
            Ocena = ocena;
        }

        public string Naziv { get; set; }
        public int Ocena { get; set; }

        public override string ToString()
        {
            return $"Predmet: {Naziv}; Ocena: {Ocena}";
        }
    }
}
