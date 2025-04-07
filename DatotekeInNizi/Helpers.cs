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

        public static string izracunajZacetnoCrko(int stevilo)
        {
            string crka;
            switch (stevilo)
            {
                case 1:
                    crka = "A";
                    break;
                case 2:
                    crka = "B";
                    break;
                case 3:
                    crka = "C";
                    break;
                case 4:
                    crka = "Č";
                    break;
                case 5:
                    crka = "D";
                    break;
                case 6:
                    crka = "E";
                    break;
                case 7:
                    crka = "F";
                    break;
                case 8:
                    crka = "G";
                    break;
                case 9:
                    crka = "H";
                    break;
                case 10:
                    crka = "I";
                    break;
                case 11:
                    crka = "J";
                    break;
                case 12:
                    crka = "K";
                    break;
                case 13:
                    crka = "L";
                    break;
                case 14:
                    crka = "M";
                    break;
                case 15:
                    crka = "N";
                    break;
                case 16:
                    crka = "O";
                    break;
                case 17:
                    crka = "P";
                    break;
                case 18:
                    crka = "R";
                    break;
                case 19:
                    crka = "S";
                    break;
                case 20:
                    crka = "Š";
                    break;
                case 21:
                    crka = "T";
                    break;
                case 22:
                    crka = "U";
                    break;
                case 23:
                    crka = "V";
                    break;
                case 24:
                    crka = "Z";
                    break;
                case 25:
                    crka = "Ž";
                    break;
                default:
                    crka = " ";
                    break;
            }
            return crka;
        }
        public static bool preveriOdgovor(string vnesenaBeseda, int steviloZnakov, string zacetnaCrka)
        {
            bool pravilenOdgovor;
            if (vnesenaBeseda.Substring(0, 1) == zacetnaCrka && vnesenaBeseda.Length == steviloZnakov)
                pravilenOdgovor = true;
            else pravilenOdgovor = false;

            return pravilenOdgovor;
        }


    }
}
