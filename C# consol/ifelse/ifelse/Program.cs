using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            double sonuc;
            Console.WriteLine("Vize notunuzu giriniz");
            sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final Notunuzu Giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            sonuc = (sayi1 * 0.2) + (sayi2 * 0.8);
            if  
                (sonuc>=50 && sayi2>=40)
                {
                Console.WriteLine("Tebrikler Dersi Geçtiniz Ortalamanız:"+" "+sonuc);
            }
            else
            {
                Console.WriteLine("Üzgünüm dersten kaldınız Ortalamanız:"+" "+sonuc);
            }
            Console.ReadKey();
            
        }
    }
}
