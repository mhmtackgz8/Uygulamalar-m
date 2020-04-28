using System;

namespace Uygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("1.Sayı Giriniz:");
            sayi = Convert.ToInt32((Console.ReadLine()));
            if(sayi%2==0 && sayi%3==0)
            {
                Console.WriteLine("Girilen sayı 2 ve 3 sayıların katıdır");
            }
            else
            {
                Console.WriteLine("Girilen sayı 2 ve 3 sayıların katı değildir");
            }
            Console.ReadKey();
        }
    }
}
