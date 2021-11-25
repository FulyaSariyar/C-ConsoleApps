using System.Text.RegularExpressions;
    public static class TelefonNumara
    {
        //Telefon numarasını ayrıştırmak için regex kullanıyoruz.
        public const string motif = @"^(0(\d{3})-(\d{3})-(\d{2})-(\d{2}))$";

        public static bool TelefonKontrol(string numara)
        {
            if (numara != null) return Regex.IsMatch(numara, motif);
            else return false;
        }
    }
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(TelefonNumara.TelefonKontrol("0505-255-55-55")); //TRUE;
            Console.WriteLine(TelefonNumara.TelefonKontrol("05-255-55-55")); //FALSE;
            Console.ReadLine();
        }
    }
