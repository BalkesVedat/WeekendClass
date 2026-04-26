using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Ucak : Tasit
    {
        private int yolcuSayisi;

        public int _yolcuSayisi
        {
            get { return yolcuSayisi; }
            set
            {
                if (value < 0)
                    yolcuSayisi = 0;
                else if (value > 500)
                    yolcuSayisi = 500;
                else
                    yolcuSayisi = value;
            }
        }






        public double kanatGenisligi;

        public void Kirala()
        {
            Console.WriteLine("Uçak kiralandı");
        }

    }
}
