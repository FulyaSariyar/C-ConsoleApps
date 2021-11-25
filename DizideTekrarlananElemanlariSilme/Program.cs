public class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[100];
        int num; // Dizide toplam kaç eleman olacağını tutacak değişken 
        int i, j, k;


        Console.Write("Dizi Eleman Sayısını Girin: ");
        num = Convert.ToInt32(Console.ReadLine());

        //Dizi elemanlarını gir

        for (i = 0; i < num; i++)
        {
            Console.Write("Diziye Değer Gir: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }


        // Tkrarlayan elemanları bul

        for (i = 0; i < num; i++)
        {
            for (j = i + 1; j < num; j++)
            {
                //Tekrarlı eleman varsa */
                if (arr[i] == arr[j])
                {
                    // Tekrarlı elemanı sil
                    for (k = j; k < num; k++)
                    {
                        arr[k] = arr[k + 1];
                    }

                    //Yinelenen öğeyi kaldırdıktan sonra boyutu azalt
                    num--;


                    j--;
                }
            }
        }

        // Yinelenen öğeleri sildikten sonra diziyi yazdır
        Console.WriteLine("\nYinelenen değerler silindikten sonra dizi içeriği : ");
        for (i = 0; i < num; i++)
        {
            Console.WriteLine(arr[i]);
        }

        Console.ReadLine();
    }
}