using System;
class MainClass
{
    public static void Main(string[] args)
    {

        DateTime dgunu = Console.ReadLine.Pars();
        DateTime simdi = DateTime.Today;
        int yas = simdi.Year - dgunu.Year;
        if (dgunu > simdi.AddYears(-yas))
            yas--;

        Console.WriteLine(yas);
    }
}
