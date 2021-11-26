public class Program
{
   static void Main(string[] args)
    {

        Random rastgele = new Random();
        string harfler = "qwertyuıopğüasdfghjklşizxcvbnmöçQWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ";
        string uret = "";
        for (int i = 0; i < 10; i++)
        {
            uret += harfler[rastgele.Next(harfler.Length)];
        }
        Console.WriteLine(uret);
        Console.ReadKey();

    }



}
