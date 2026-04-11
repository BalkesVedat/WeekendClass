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
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(car1.Producer + " " + car1.Price);


            // Array : Dizi - İçerisinde aynı tipten birden fazla değeri taşıyabilen yapılardır.

            int[] ogrNotlar = new int[4];
            string[] ogrenciAdlari = { "Ali", "Ayşe", "Murat", "Turgut" };
            char[] karakterler = new char[15];

            Student[] ogrenciler = new Student[8];

            ogrNotlar[0] = 25;
            ogrNotlar[1] = 44;
            ogrNotlar[2] = 50;
            ogrNotlar[3] = 100;

            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            int sayac = 0;

        tekrar:
          Console.WriteLine( (sayac+1) + ". öğrencinin ismi:" + ogrenciAdlari[sayac]);
            sayac++;
            if (sayac < ogrenciAdlari.Length)
                goto tekrar;

            
            Console.ReadKey();



        }
    }
}
