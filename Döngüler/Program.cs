using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Döngü : Birden fazla kere çalışması gereken kodları tekrar tekrar yazmak yerine, bu kodu istediğimiz kadar çalıştırmayı sağlayan yapılara döngü denir. Bir döngü ya belli bir adette ya da belli bir şartın sağlanması durumunda çalışacak şekilde programlanabilir.

            // Yanlış yöntem
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //*********** 1 CUSTOM ITERATION *****************************
            int sayac = 0;
        tekrar:
            if (sayac % 3 == 0)
                Console.WriteLine(sayac);
           
            sayac++;
            if (sayac < 100)
                goto tekrar;
            //************************************************************

            // ***************  FOR  DÖNGÜSÜ *****************************
            // İşlemin belli bir adette yapılması istenildiğinde tercih edilen yöntemdir.

            Console.WriteLine("------------ for ------------------------");

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                Console.WriteLine(i);
            }

            Console.WriteLine("----------------------------");
            Console.Write("İsminizi Girin :");
            string name = Console.ReadLine();

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]) ;          
            }

            Console.WriteLine("----------------------------------------------");

            string[] iller = {"İstanbul","Ankara","İzmir","Adana","Mersin","Hakkari","Trabzon"};

            for (int i = 0; i < iller.Length; i++)
            {
                Console.WriteLine(iller[i]);
            }

            Console.WriteLine("-----------------------------------------");

            int j = 0;

            for ( ; ; ) // FOR parantezine yazılan ifadeler zorunlu değildir. Farklı şekilde tanımlanabilir.
            {
                if (j < iller.Length)
                {
                    Console.WriteLine(iller[j]);
                    j++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("------------- foreach ----------------");

            //foreach : Bir koleksiyondaki elemanların her biri için ayrı ayrı tek tek çalışması gereken bir işlem olduğunda tercih ettiğimiz döngü yapısıdır.

            foreach (var item in iller)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------- sözlük ----------------");

            Dictionary<string, string> enTrsozluk = new Dictionary<string, string>();

            enTrsozluk.Add("mouse", "fare");
            enTrsozluk.Add("pen", "tükenmez kalem");
            enTrsozluk.Add("cup", "bardak");
            enTrsozluk.Add("car", "araba");
            enTrsozluk.Add("phone", "telefon");
            enTrsozluk.Add("class", "sınıf");
            enTrsozluk.Add("dictionary", "sözlük");

            foreach (string item in enTrsozluk.Keys)
            {
                Console.WriteLine($"{item} : {enTrsozluk[item]}");
            }

            Console.WriteLine("------------ while ------------------");

            // WHILE döngüsü : Eğer döngünün çalışması ya da durması bir koşula bağlı ise WHILE yapısını tercih ederiz.

            string cevap ="E";

            while (cevap == "E")
            {
                //TODO:Hesap makinası buraya monte edilecek.

                Console.Write("Devam Etmek istiyor musunuz? (E/H)");
                cevap = Console.ReadLine().ToUpper();
            }

            int adet = 0;

            while (adet < iller.Length)
            {
                Console.WriteLine(iller[adet]);
                adet++;
            }

            Console.WriteLine("----------- do while -----------");

            //do
            //{

            //} while (koşul);

            string cevap2="";

            do
            {
                //TODO:Hesap makinası buraya monte edilecek.

                Console.Write("Devam Etmek istiyor musunuz? (E/H) ");
                cevap2 = Console.ReadLine().ToUpper();
            } while (cevap2 == "E");


        }
    }
}
