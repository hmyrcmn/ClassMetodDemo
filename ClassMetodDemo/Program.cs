using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Musteri musteri1 = new Musteri();
            musteri1.musteriId = 1;
            musteri1.musteriAd = "hümeyra";
            musteri1.musteriSoyad = "çimen";
            musteri1.parası = 100;

            Musteri musteri2 = new Musteri();
            musteri2.musteriId = 2;
            musteri2.musteriAd = "sümmeyye";
            musteri2.musteriSoyad = "çimen";
            musteri2.parası = 200;

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Add(musteri1);
            musterimanager.Add(musteri2);
            musterimanager.Delete(musteri2);



            

        }
    }
}
