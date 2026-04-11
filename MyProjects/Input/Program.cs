using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bu programda kullanıcıdan 2 tane sayı istenecek ve toplanıp sonucu ekrana yansıtılacak.

            /* 
             
            Çok 
            satırlı
            not yazma alanı
             
             */

            int sayi1 = 0;
            int sayi2 = 0;
            int toplam = 0;

            try
            {
                Console.Write("1. Sayıyı giriniz:");
                sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("2. sayıyı giriniz:");
                sayi2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bir hata oluştu. Lütfen tekrar deneyin.");
            }  

            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);

            Console.WriteLine("Programı sonlandırmak için herhangi bir tuşa basınız...");

           Console.ReadKey();
        }
    }
}
