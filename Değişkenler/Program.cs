using System;


namespace Değişkenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Değişken Ders Notları:
             * Değişken, bazı verileri bilgisayarın belleğinde (RAM) geçici bir süre bekletmek için kullandığımız yapılardır. İçlerinde bilgiyi program boyunca saklarlar, program sonlandığında bellekten atılırlar. Değişkenler içlerinde değişik türde bilgiler taşıyabilirler. Bir değişkeni tanımlarken, içinde ne tür bir bilgi saklayacağımızı belirtmemiz gerekir.
            Değişken tipleri:
            1- Değer Tipli Değişkenler: byte, int, double, char, bool, struct, enum
            2- Referans Tipli Değişkenler: string, array, class, delegate, interface

            1- Değer Tipli Değişkenler: Bu tip değişkenleriçlerinde veri taşırlar. Belleğin "Stack" bölgesinde yaratılırlar.
                a) Tam sayı tipler:  byte, short, int, long en çok kullanılan tam sayı tiplerdir.           

            /*
             Referans tipli değişkenler içinde doğrudan veriyi tutmazlar. Verinin heap bellekteki adresini tutarlar. Yani verinin yerini işaret ederler. Bu nedenle bunlara pointer (işaretçi) de denir.

            Değişkenin kendisi stack bölgesinde verisi ise heap bölgesindedir.
             
             
             
             */

            //////tam sayı tipler
            ////byte notu = 35; // 1 byte
            ////short notu2 = 200; // 2 byte
            ////int maas = 2; // 4 byte
            ////long büyükSayı = 3232132132131; // 8 byte

            //////ondalıklı sayı tipleri;
            ////double ondalıklıSayı = 25000000.2;
            ////double kdvOrani = 0.2;

            ////notu2 = notu; // bilinçsiz (implicit) tip dönüşümü
            ////notu = (byte)notu2; //type casting 1 (bilinçli - explicit) tip dönüşümü

            //////  maas = Convert.ToInt32("50000");



            ////Console.WriteLine("---- Girilen 2 sayının toplamını veren program ------------");

            ////double sayi1;
            ////double sayi2;
            ////double toplam;

            //////double sayi1, sayi2, toplam; // alternatif

            ////Console.Write("1. Sayıyı giriniz:");
            ////sayi1 = Convert.ToDouble(Console.ReadLine());

            ////Console.Write("2. Sayıyı giriniz:");
            ////sayi2 = Convert.ToDouble(Console.ReadLine());

            ////toplam = sayi1 + sayi2;

            ////Console.WriteLine("Toplam " + toplam + " dır.");

            ////Console.WriteLine("---- Girilen 1 sayının tek mi, çift mi olduğunu veren program ----");

            ////int s1;
            ////int sonuc;

            ////Console.Write("1 sayı giriniz: ");
            ////s1 = Convert.ToInt32(Console.ReadLine());

            ////sonuc = s1 % 2;

            ////if (sonuc==1)
            ////{
            ////    Console.WriteLine("Sayı Tekdir.");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Sayı Çifttir.");
            ////}

            ////Console.WriteLine("-- Girilen 2 notun ortalamasını hesaplayıp ekrana yazan program   --");

            ////double not1;
            ////double not2;
            ////double ortalama;


            ////Console.Write("Öğrencinin 1. sınav notunu giriniz:");
            ////not1 = Convert.ToDouble(Console.ReadLine());

            ////Console.Write("Öğrencinin 2. sınav notunu giriniz:");
            ////not2 = Convert.ToDouble(Console.ReadLine());

            ////ortalama = (not1+not2)/2;

            ////if (ortalama >= 70)
            ////{
            ////    Console.WriteLine("Geçtiniz. Ortalamanız: " + ortalama);
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Kaldınız. Ortalamanız: " + ortalama);
            ////}

            //////char ve string --------------------------------
            //////-------------------------------------------------

            ////Console.WriteLine("--- char ve string -----------------------------");

            ////// char tek karakterlik bilgi tutan değişken tipidir.
            ////char karakter = 'A';
            ////char harf = (char)65;


            //////string ise birden fazla karakter tutabilen değişken tipidir.

            ////string ögrencininAdıSoyadı = "Ali Muzaffer Kılıç";
            ////string ürünMarkası = "Mercedes";

            ////Console.WriteLine(ögrencininAdıSoyadı);
            ////Console.WriteLine(harf);


            ////Console.WriteLine("-- Girilen kullanıcı adı ve şifresini kontrol eden program ----");

            ////string kullanıcı, şifre;

            ////Console.Write("Kullanıcı adınızı giriniz:");
            ////kullanıcı = Console.ReadLine();

            ////Console.Write("Şifrenizi giriniz:");
            ////şifre = Console.ReadLine();

            ////if (kullanıcı == "vedat" && şifre == "12345")
            ////{
            ////    Console.WriteLine(kullanıcı + " Hoşgeldin");
            ////}
            ////else 
            ////{
            ////    Console.WriteLine("Kullanıcı adı ya da şifresi hatalı");     
            ////}

            // Ekrandan alınan n tane sayının ortalamasını veren program

            //    Console.WriteLine("-------------------------");
            //    Console.WriteLine("Ekrandan alınan n tane sayının ortalamasını veren program");
            //    Console.WriteLine("--------------------------");

            //    double yeniToplam = 0, yeniOrtalama = 0;
            //    int sayac = 0;
            //    string girilenBilgi="";

            //tekrar:
            //    Console.Write("Bir sayı giriniz:");

            //    girilenBilgi = Console.ReadLine();

            //    if (girilenBilgi.Length > 0) // girilenBilgi != string.Empty
            //    {
            //        yeniToplam += Convert.ToDouble(girilenBilgi);
            //        sayac += 1;
            //        goto tekrar;
            //    }

            //    yeniOrtalama = yeniToplam / sayac;

            //    Console.WriteLine("Ortalama: " + yeniOrtalama);

            //-------------------------------------------------------------
            //--------------   REFERANS TİPLİ DEĞİŞKENLER -----------------
            //-------------------------------------------------------------

            /*
             Referans tipli değişkenler içinde doğrudan veriyi tutmazlar. Verinin heap bellekteki adresini tutarlar. Yani verinin yerini işaret ederler. Bu nedenle bunlara pointer (işaretçi) de denir.

            Değişkenin kendisi stack bölgesinde verisi ise heap bölgesindedir.


             
             
             
             */

            string aracModeli = "Sedan";

            Console.WriteLine(aracModeli.Length);

            string metin = aracModeli[0].ToString();

            string ilk2Karakter = aracModeli.Substring(0, 2);

            int urunAdedi;

            urunAdedi = 48;

            double urunFiyati;

            urunFiyati = 175.50;

            string urunAdi = "Hotwheels oyuncak araba";


            Console.WriteLine("Ürün: " + urunAdi + 
                               " - Fiyatı: " +  urunFiyati + 
                               " - Adedi: " +  urunAdedi);



            Console.ReadKey();








        }
    }
}
