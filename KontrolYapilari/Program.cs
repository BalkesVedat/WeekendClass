using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KontrolYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;

            Console.Write("Bir sayi giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
                Console.WriteLine("Girilen Sayı Çift sayıdır.");
            else
                Console.WriteLine("Girilen Sayı Tek sayıdır.");

            Console.WriteLine("------------------------------------------------");

        tekrar:
            Console.Clear();
            Console.Write("Birinci Sayıyı Girin: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci Sayıyı Girin: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("(+) Toplama");
            Console.WriteLine("(-) Çıkartma");
            Console.WriteLine("(*) Çarpma");
            Console.WriteLine("(/) Bölme");

        oprt:
            Console.Write("İşlem seçin (+,-,*,/) ? : ");

            string islem = Console.ReadLine();
            double sonuc = 0;

            if (islem == "+")
                sonuc = sayi1 + sayi2;
            else if (islem == "-")
                sonuc = sayi1 - sayi2;
            else if (islem == "*")
                sonuc = sayi1 * sayi2;
            else if (islem == "/")
            {
                if (sayi2 != 0)
                    sonuc = sayi1 / sayi2;
            }
            else
            {
                Console.WriteLine("Geçersiz seçim");
                goto oprt;
            }


            if (sayi1>0 && sayi1 <50)
            {

            }


            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    if (sayi2 != 0)
                        sonuc = sayi1 / sayi2;
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim");
                    goto oprt;
            }



            Console.WriteLine($"{sayi1}{islem}{sayi2}={sonuc}");

        yenicevap:
            Console.Write("Yeni bir hesaplama yapacak mısınız (E/H) ? : ");
            string cevap = Console.ReadLine();

            if (cevap == "E" || cevap == "e")
                goto tekrar;
            else if (cevap == "H" || cevap == "h")
                goto bitir;
            else
            {
                Console.WriteLine("Hatalı Seçim");
                goto yenicevap;
            }


        bitir:
            Console.WriteLine("Program sonlandı");

            Console.ReadKey();

        }
    }
}
