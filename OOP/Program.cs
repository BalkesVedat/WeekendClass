using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public enum Renkler
    {
        None,
        Black,
        Gray,
        Red,
        Green,
        Blue,
        Yellow,
        White
    }

    public class Product
    {
        public int Productid;
        public string ProductName;
        public string ProductDescription;
        public string ProductCategory;
        public double Price;
        public Renkler Colour;
        public string Size;

        public void KDVHesapla()
        {
            Console.WriteLine($"KDV Tutarı : {Price * 0.2}");
        }

        public void KDVHesapla(double oran)
        {
            Console.WriteLine($"KDV Tutarı : {Price * oran}");      
        }

    }

    class Ogrenci
    {
        public int Ogrid;
        public string SinifSube;
        public string AdSoyad;
        public double NotOrtalamasi;
        public DateTime KayitTarihi;
        public double vizeNotu;
        public double finalNotu;

        public void OrtalamaHesapla()
        {
            Console.WriteLine($"vize:{vizeNotu} final:{finalNotu} = ortalama:{(vizeNotu+finalNotu)/2}");
        }

        public void OrtalamaHesapla(double vize, double final)
        {
            Console.WriteLine($"vize:{vize} final:{final} = ortalama:{(vize + final) / 2}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;

            Product ürün = new Product();

            ürün.Productid = 1;
            ürün.ProductName = "Tükenmez Kalem";
            ürün.ProductDescription = " kjhgkjdhfgkdfjg kjkjhkdf hgkdhgkjd hkfg hdkgjhd kfg";
            ürün.Price = 50;
            ürün.Colour = Renkler.Blue;
            ürün.Size = "gfdgfdgfdg dfg dfg";
            ürün.ProductCategory = "Kırtasiye";

            Console.WriteLine(ürün.ProductName);
            ürün.KDVHesapla();
            ürün.KDVHesapla(0.15);

            Product ürün2 = new Product();

            ürün2.Productid = ürün.Productid + 1;

            Console.Write("Ürün Adı : ");
            ürün2.ProductName = Console.ReadLine();
            Console.Write("Ürün Fiyatı : ");
            ürün2.Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("----------------");
            Console.WriteLine($"Girdiğiniz ürün: {ürün2.ProductName} - {ürün2.Price}");

            Console.WriteLine("---------------------------------");

            Ogrenci o1 = new Ogrenci();

            o1.Ogrid = 12312;
            o1.AdSoyad = "Ali Ak";
            o1.SinifSube = "11B";
            o1.KayitTarihi = DateTime.Now;
            //o1.NotOrtalamasi = 75;
            o1.vizeNotu = 45;
            o1.finalNotu = 80;

            o1.OrtalamaHesapla();

            o1.OrtalamaHesapla(75, 50);

            Console.WriteLine("-------------------");

            Kamyon k1 = new Kamyon();
            k1.SetFiyat(-100000);
            k1._maximumHiz = 1080000000;
            k1.Sat();
            Console.WriteLine(k1.GetFiyat());  

            Otobus otobus1 = new Otobus();

            otobus1.SetFiyat(4565666);
            otobus1.Sat();
            Console.WriteLine(otobus1.GetFiyat());

            Motorsiklet m1 = new Motorsiklet();
            m1.marka = "Honda";
            m1.Sat();

            Otomobil oto1 = new Otomobil();

            oto1.marka = "Mercedes";
            oto1.SetFiyat(-5000);
            oto1.Sat();

            Ucak u1 = new Ucak();
            u1.marka = "Boeing";
            u1._yolcuSayisi = 1500;
            Console.WriteLine(u1._yolcuSayisi);
            u1.Kirala();

        }
    }
}
