using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operatorler : 
            //1.Aritmetik Operatörler : +, -, *, /, % (mod) , ( , )
            /*
            Sayıların arasına konan ve matematiksel işlem yapılmasını sağlayan operatörlerdir.  
                         */

            //double kdvTutarı = 175 + 0.2 * 175;

            //int urun1adet = 5;
            //int urun2adet = 27;

            //int fiyat = 500;

            //double tutar = (urun1adet + urun2adet) * fiyat;

            //2. Mantıksal karşılaştırma Operatörleri: <, >, <=, >=, ==, !=

            // bool sonuc = x != y ;  bool kontrol = x == 0;
            // karşılaştırma sonucu olumlu ise geriye true değilse false dönerler.

            //3. Atama Operatörü:  =  
            //sağındaki bilgiyi, sol tarafa aktarır.   örn: x = 5; sonuc = a+b;

            //4. Birleşik operatörler :  ++, --, += , -=, *= , /=
            // Bazı işlemlerin kısa tanımı için kullanılırlar.

            // örnek:
            int sayac = 0;

            sayac = sayac + 1;

            sayac += 1; // 1 arttırır.

            sayac += 3; // eşittir in sağındaki değer kadar arttırır.

            sayac++; // 1 arttıran operatör.

            sayac--; // 1 eksiltir.

            sayac -= 2; // eşittir in sağındaki değer kadar eksiltir.

            sayac *= 2;

            sayac /= 3;

            //5. metin birleştirme operatörü:  +  
            //  +  işaretinin sağındaki ya da solundaki veri string ise o zaman metin birleştirme işlemi yapar ve string değer üretir. her iki değer sayısal ise aritmetik toplama yapar ve toplama sonucunu geriye uygun tipte döndür. 

            string kod = "ABC" + 123;

            Random rnd = new Random();

            string password = "P" + rnd.Next(1000000, 9999999) + "!";

            string ss = "ali" + (5 + 3);


            Console.WriteLine(ss);


        }
    }
}
