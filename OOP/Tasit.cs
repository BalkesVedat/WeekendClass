using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Tasit
    {
        public int id;
        public string plaka;
        public string marka;
        public string model;
        public int uretimYili;
        private double fiyat; // Kapsülleme - Encapsulation 
        public bool stoktaMi;
        public DateTime stokGirisTarihi;
        //private int maximumHiz;

        private int maximumHiz;

        public int _maximumHiz
        {
            get { return maximumHiz; }
            set
            {
                if (value < 0)
                    maximumHiz = 0;
                else if (value > 1000000)
                    maximumHiz = 1000000;
                else
                    maximumHiz = value;
            }
        }






        public void SetFiyat(double deger)
        {
            if (deger < 0)
                fiyat = 0;
            else if (deger > 1000000)
                fiyat = 1000000;
            else
                fiyat = deger;
        }

        public double GetFiyat()
        {
            return fiyat;
        }



        public void Listele()
        {
            Console.WriteLine("Taşıt Listelendi");
        }
        public void Al()
        {
            Console.WriteLine("Taşıt Alındı");
        }
        public void Sat()
        {
            Console.WriteLine("Taşıt Satıldı");
        }

    }
}
