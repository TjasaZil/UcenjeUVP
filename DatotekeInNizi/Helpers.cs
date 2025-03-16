namespace DatotekeInNizi
{
    internal class Helpers
    {

        public static string izracunajSpol(string spolInt)
        {
            string spol;
            if (spolInt == "500")
                spol = "moški";
            else
                spol = "ženski";

            return spol;
        }
        public static int izracunajLetnico(string leto)
        {
            int letnica;
            int letoInt = int.Parse(leto);
            string prvaCifra = leto.Substring(0, 1);

            if (prvaCifra == "9") letnica = 1000 + letoInt;
            else letnica = 2000 + letoInt;

            return letnica;
        }

        public static string izracunajMesec(string mesecInt)
        {
            string mesec;
            switch (mesecInt)
            {
                case "01":
                    mesec = "Januar";
                    break;
                case "02":
                    mesec = "Februar";
                    break;
                case "03":
                    mesec = "Marec";
                    break;
                case "04":
                    mesec = "April";
                    break;
                case "05":
                    mesec = "Maj";
                    break;
                case "06":
                    mesec = "Junij";
                    break;
                case "07":
                    mesec = "Julij";
                    break;
                case "08":
                    mesec = "Avgust";
                    break;
                case "09":
                    mesec = "September";
                    break;
                case "10":
                    mesec = "Oktober";
                    break;
                case "11":
                    mesec = "November";
                    break;
                case "12":
                    mesec = "December";
                    break;
                default:
                    mesec = "Mesec ne obstaja";
                    break;

            }

            return mesec;
        }

    }
}
