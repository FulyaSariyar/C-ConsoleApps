public class Program
{
    static void Main(string[] args)
    {
        Console.Write("2' lik sistemdeki sayıyı Giriniz : ");
        string s = Console.ReadLine();
        int dec = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[s.Length - i - 1] == '0') continue;
            dec += (int)Math.Pow(2, i);
        }
        Console.WriteLine(dec);
        Console.ReadKey();
    }

}
