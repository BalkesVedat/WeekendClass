using System;
using System.Collections;
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

        //public override string ToString()
        //{
        //    return StudentID + "-" + NameSurname;
        //}
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

            //    //bool kontrol;
            //    //int karakterSayisi = 0;
            //    //string kullanıcı = Console.ReadLine();

            //    //kontrol = kullanıcı.Length > 0;
            //    //karakterSayisi = kullanıcı.Length;

            //    //if (kontrol)
            //    //{

            //    //}
            //    //else { 

            //    //}

            //    //if (karakterSayisi>0)
            //    //{

            //    //}
            //    //else
            //    //{

            //    //}


            //    char karakter = 'a';
            //    string k = "abcde";

            //    k = "aaaaa";

            //    char eleman = k[0];
            //    char cr = (char)169;

            //    Console.WriteLine(cr);

            //    bool status = false;

            //    Student s1;

            //    s1.StudentID = 1;
            //    s1.NameSurname = "Ali Ak";
            //    s1.Grade = 2.88;

            //    Car car1;

            //    car1.CarID = 1;
            //    car1.Producer = "Mercedes";
            //    car1.Price = 11500000.50;
            //    car1.Color = Colors.Black;
            //    // car1.Color = (Colors)5;
            //    car1.Model = "S600";
            //    car1.ProduceYear = 2020;


            //    Console.WriteLine(s1.NameSurname);
            //    // Console.BackgroundColor = ConsoleColor.Blue;
            //    Console.WriteLine(car1.Producer + " " + car1.Price);


            //    // Array : Dizi - İçerisinde aynı tipten birden fazla değeri taşıyabilen yapılardır.

            //    int[] ogrNotlar = new int[4];
            //    string[] ogrenciAdlari = { "Zeynep", "Ayşe", "Turgut", "Murat" };
            //    char[] karakterler = new char[15];
            //    double fiyat = 125.58;
            //    double[] fiyatlar = new double[3];
            //    fiyatlar[0] = 555.55;
            //    fiyatlar[1] = 125.69;
            //    fiyatlar[2] = 35.0;


            //    Student[] ogrenciler = new Student[8];

            //    ogrNotlar[0] = 77;
            //    ogrNotlar[1] = 44;
            //    ogrNotlar[2] = 35;
            //    ogrNotlar[3] = 100;

            //    string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            //    int[] ogrnumaralari = { 458, 35, 258, 14 };

            //    //int[] ogrnumaralari = new int[4];

            //    //ogrnumaralari[0] = 458;
            //    //ogrnumaralari[1] = 35;
            //    //ogrnumaralari[2] = 258;
            //    //ogrnumaralari[3] = 14;


            //    int sayac = 0;

            //    Array.Sort(ogrenciAdlari);
            //    Array.Reverse(ogrenciAdlari);
            //    Array.Resize(ref ogrenciAdlari, 10);


            //tekrar:
            //    Console.WriteLine((sayac + 1) + ". öğrencinin ismi:" + ogrenciAdlari[sayac]);
            //    sayac++;
            //    if (sayac < ogrenciAdlari.Length)
            //        goto tekrar;


            //    Console.WriteLine("-------------------");

            //    Console.WriteLine(Array.IndexOf(ogrenciAdlari, "Mehmet"));

            //    if (Array.IndexOf(ogrenciAdlari, "Mehmet") == -1)
            //    {
            //        ogrenciAdlari.SetValue("Mehmet", 4);
            //    }

            //    sayac = 0;

            //    string[] isimler = new string[10];

            //    isimler = ogrenciAdlari;

            //    ogrenciAdlari[0] = "Cemil";

            //    Array.Clear(isimler, 0, isimler.Length);


            //tekrar2:
            //    Console.WriteLine((sayac + 1) + ". öğrencinin ismi:" + isimler[sayac]);
            //    sayac++;
            //    if (sayac < isimler.Length)
            //        goto tekrar2;

            //    Console.WriteLine("-------------------------------------");

            //    sayac = 0;

            //tekrar3:
            //    Console.WriteLine((sayac + 1) + ". öğrencinin ismi:" + ogrenciAdlari[sayac]);
            //    sayac++;
            //    if (sayac < ogrenciAdlari.Length)
            //        goto tekrar3;


            //    // Değer tipli değişkenler içlerinde doğrudan veriyi tutarlar. Birbirlerine atandıklarınd da içlerindeki verinin kopyasını aktarırlar. Referans tipli değişkenler ise içlerinde veri değil, verinin bulunduğu bellek adresini tutarlar. Dolayısıyla birbirlerine atandıklarında, içlerinde tuttukları bellek bölgesinin adresini kopyalamış olurlar. Böylece her 2 referans tipli değişken de aynı bellek adresini işaret eder ve değerini yönetir.

            //    int sayi1 = 100;
            //    int sayi2 = 250;

            //    sayi1 = sayi2;
            //    sayi2 = 500;

            //    Console.WriteLine("Sayı1:" + sayi1 + " Sayı2:" + sayi2);

            //    //-----------------------------------------------------------

            //    Console.Clear();

            //    Console.WriteLine("------ ArrayList ----------");

            //    // Kolleksiyonlar 

            //    //ArrayList 

            //    ArrayList demirbasListesi = new ArrayList();

            //    //demirbasListesi.Add(new Student() {StudentID=5,NameSurname="Ali",Grade=75.8 });


            //    demirbasListesi.Add("Sandalye");
            //    demirbasListesi.Add("Telefon");
            //    demirbasListesi.Add("Televizyon");
            //    demirbasListesi.Add(23123);

            //    int elemanSayisi = demirbasListesi.Count;

            //    for (int counter = 0; counter < elemanSayisi; counter++)
            //    {
            //        Console.WriteLine(demirbasListesi[counter].ToString());
            //    }


            //    //  demirbasListesi.Remove("Telefon");

            //    //demirbasListesi.RemoveAt(0);

            //    //demirbasListesi.RemoveRange(0,3);

            //    //demirbasListesi.Clear();


            //    bool varMi = demirbasListesi.Contains("Kumanda");

            //    if (!varMi)
            //    {
            //        demirbasListesi.Add("Kumanda");
            //    }

            //    Console.WriteLine("-----------------------------");

            //    for (int i = 0; i < demirbasListesi.Count; i++)
            //    {
            //        Console.WriteLine(demirbasListesi[i].ToString());
            //    }

            //    varMi = demirbasListesi.Contains("Kumanda");

            //    if (!varMi)
            //    {
            //        demirbasListesi.Add("Kumanda");
            //    }

            //    Console.WriteLine("-----------------------------");

            //    for (int i = 0; i < demirbasListesi.Count; i++)
            //    {
            //        Console.WriteLine(demirbasListesi[i].ToString());
            //    }

            //    //-------------------------------------------------------------
            //    Console.WriteLine("----- HashTable -----------------------");
            //    //HashTable : 

            //    Hashtable aracListesi = new Hashtable();
            //    aracListesi.Add("34 ABC 34", 1500000);
            //    aracListesi.Add("35 AB 345", 2500000);
            //    aracListesi.Add("34 AAA 334", 800000);
            //    aracListesi.Add(123456789, "Mercedes");

            //    Console.WriteLine(aracListesi["34 AAA 334"].ToString());

            //    Console.WriteLine("----------------------------");
            //    foreach (var item in aracListesi.Keys)
            //    {
            //        Console.WriteLine(aracListesi[item]);
            //    }

            //    bool plakaMevcutMu = aracListesi.ContainsKey("34 XX 333");

            //    Console.WriteLine("---- Dictionary ----------------");
            //    //Dictionary - HashTable 'ın TypeSafe - Tip Güvenli versiyonudur.

            //    Dictionary<string, string> enTrsozluk = new Dictionary<string, string>();

            //    enTrsozluk.Add("mouse", "fare");
            //    enTrsozluk.Add("pen", "tükenmez kalem");
            //    enTrsozluk.Add("cup", "bardak");
            //    enTrsozluk.Add("car", "araba");
            //    enTrsozluk.Add("phone", "telefon");
            //    enTrsozluk.Add("class", "sınıf");
            //    enTrsozluk.Add("dictionary", "sözlük");


            //devam:
            //    Console.Write("İngilizce Kelime :");
            //    string arananKelime = Console.ReadLine();

            //    bool arananEnKelimeVarMi = enTrsozluk.ContainsKey(arananKelime);

            //    if (arananEnKelimeVarMi)
            //        Console.WriteLine(enTrsozluk[arananKelime]);
            //    else
            //       Console.WriteLine("Aranan Kelime Sözlükte Yok");

            //soru:
            //    Console.Write("Devam etmek istiyor musunuz?(E/H) : ");
            //    string cevap = Console.ReadLine().ToUpper();

            //    if (cevap == "E")
            //        goto devam;
            //    else if (cevap == "H")
            //    {
            //        Console.WriteLine("Program Sonlandı. Yine bekleriz.");
            //        goto bitir;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Lütfen E ya da H giriniz.");
            //        goto soru;
            //    }

            //bitir:

            //    //-------- Generic List ---------------------
            //    Console.WriteLine("---------- Generic List ----------------");

            //    List<string> malzemeListesi = new List<string>();

            //    malzemeListesi.Add("Matkap");
            //    malzemeListesi.Add("Tornavida");
            //    malzemeListesi.Add("Çekiç");
            //    malzemeListesi.Add("El Feneri");
            //    malzemeListesi.Add("555");
            //    malzemeListesi.Add("55555");

            //    List<int> numberList = new List<int>();
            //    numberList.Add(546);
            //    numberList.Add(12312);

            //    List<Student> ogrenciListesi = new List<Student>();

            //    Student student1 = new Student();
            //    student1.StudentID = 1;
            //    student1.NameSurname = "Osman";
            //    student1.Grade = 3.49;

            //    ogrenciListesi.Add(student1);

            //    ogrenciListesi.Add(new Student() { StudentID = 2, NameSurname = "Mustafa", Grade = 2.75 });
            //    ogrenciListesi.Add(new Student() { StudentID = 3, NameSurname = "Esra", Grade = 3.2 });
            //    ogrenciListesi.Add(new Student() { StudentID = 4, NameSurname = "Cemile", Grade = 1.92 });
            //    ogrenciListesi.Add(new Student() { StudentID = 5, NameSurname = "Hüsrev", Grade = 4.75 });

            string urunAd="";
            int satilanAdet=0;
            double fiyat=0.0;

            Console.Write("Ürün Adı: ");
            urunAd = Console.ReadLine();

            Console.Write("Satılan Adet Giriniz: ");
            satilanAdet = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ürün fiyatını Giriniz: ");
            fiyat = Convert.ToDouble(Console.ReadLine());

            double toplamTutar = satilanAdet * fiyat;
 
 Console.WriteLine(urunAd + " ürününün satış fiyatı: " + toplamTutar + " TL dir.");

 Console.WriteLine("{0} ürününün satış fiyatı: {1} TL dir.",urunAd,toplamTutar);
 
 Console.WriteLine($"{urunAd} ürününün satış fiyatı: {toplamTutar} TL dir.");



            Console.ReadKey();

        }
    }
}
