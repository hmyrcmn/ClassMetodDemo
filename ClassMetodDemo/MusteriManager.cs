using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriAd+musteri.musteriSoyad+"eklendi ");
        }
           
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriAd+musteri.musteriSoyad+"silindi");
        }
    }
}
