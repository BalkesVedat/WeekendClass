using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    struct Student
    {
        public int StudentID;
        public string NameSurname;
        public double Grade;
    }

    struct Car
    {
        public int CarID;
        public string Producer;
        public string Model;
        public int ProduceYear;
        public Colors Color;
        public double Price;
    }

    enum Colors
    {
        Black = 0,
        Red = 5,
        Yellow = 17,
        Green = 4,
        Gray = 6,
        White = 1
    }

    enum Gender
    {
        Erkek,
        Kadın
    }



    class Program
    {



        static void Main(string[] args)
        {
            char karakter = 'a';
            string k = "abcde";

            k = "aaaaa";

            char eleman = k[0];
            char cr = (char)169;

            Console.WriteLine(cr);

            bool status = false;

            Student s1;

            s1.StudentID = 1;
            s1.NameSurname = "Ali Ak";
            s1.Grade = 2.88;

            Car car1;

            car1.CarID = 1;
            car1.Producer = "Mercedes";
            car1.Price = 11500000.50;
            car1.Color = Colors.Black;
            // car1.Color = (Colors)5;
            car1.Model = "S600";
            car1.ProduceYear = 2020;


            Console.WriteLine(s1.NameSurname);
           // Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(car1.Producer + " " + car1.Price);


            // Array : Dizi - İçerisinde aynı tipten birden fazla değeri taşıyabilen yapılardır.

            int[] ogrNotlar = new int[4];
            string[] ogrenciAdlari = { "Zeynep", "Ayşe", "Turgut", "Murat" };
            char[] karakterler = new char[15];
            double fiyat = 125.58;
            double[] fiyatlar = new double[3];
            fiyatlar[0] = 555.55;
            fiyatlar[1] = 125.69;
            fiyatlar[2] = 35.0;


            Student[] ogrenciler = new Student[8];

            ogrNotlar[0] = 77;
            ogrNotlar[1] = 44;
            ogrNotlar[2] = 35;
            ogrNotlar[3] = 100;

            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            int[] ogrnumaralari = {458,35,258,14};

            //int[] ogrnumaralari = new int[4];
           
            //ogrnumaralari[0] = 458;
            //ogrnumaralari[1] = 35;
            //ogrnumaralari[2] = 258;
            //ogrnumaralari[3] = 14;


            int sayac = 0;

            Array.Sort(ogrenciAdlari);
            Array.Reverse(ogrenciAdlari);
            Array.Resize(ref ogrenciAdlari, 10);


        tekrar:
          Console.WriteLine( (sayac+1) + ". öğrencinin ismi:" + ogrenciAdlari[sayac]);
            sayac++;
            if (sayac < ogrenciAdlari.Length)
                goto tekrar;


            Console.WriteLine("-------------------"  );

            Console.WriteLine(Array.IndexOf(ogrenciAdlari, "Mehmet"));

            if (Array.IndexOf(ogrenciAdlari, "Mehmet") == -1)
            {
                ogrenciAdlari.SetValue("Mehmet", 4);
            }

            sayac = 0;

            string[] isimler = new string[10];

            isimler = ogrenciAdlari;

            ogrenciAdlari[0] = "Cemil";

            Array.Clear(isimler,0,isimler.Length); 


        tekrar2:
            Console.WriteLine((sayac + 1) + ". öğrencinin ismi:" + isimler[sayac]);
            sayac++;
            if (sayac < isimler.Length)
                goto tekrar2;

            Console.WriteLine("-------------------------------------");

            sayac = 0;

        tekrar3:
            Console.WriteLine((sayac + 1) + ". öğrencinin ismi:" + ogrenciAdlari[sayac]);
            sayac++;
            if (sayac < ogrenciAdlari.Length)
                goto tekrar3;


            // Değer tipli değişkenler içlerinde doğrudan veriyi tutarlar. Birbirlerine atandıklarınd da içlerindeki verinin kopyasını aktarırlar. Referans tipli değişkenler ise içlerinde veri değil, verinin bulunduğu bellek adresini tutarlar. Dolayısıyla birbirlerine atandıklarında, içlerinde tuttukları bellek bölgesinin adresini kopyalamış olurlar. Böylece her 2 referans tipli değişken de aynı bellek adresini işaret eder ve değerini yönetir.

            int sayi1 = 100;
            int sayi2 = 250;

            sayi1 = sayi2;
            sayi2 = 500;

            Console.WriteLine("Sayı1:" + sayi1 + " Sayı2:"+ sayi2);

            //-----------------------------------------------------------

            // Kolleksiyonlar 


            Console.ReadKey();



        }
    }
}
