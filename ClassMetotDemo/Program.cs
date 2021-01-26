using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.MusteriAd = "Sumayya";
            musteri1.MusteriSoyad = "Uygur";
            musteri1.MusteriId = 1;
            musteri1.MusteriTCNo = 11111111111;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAd = "Senanur";
            musteri2.MusteriSoyad = "Erkul";
            musteri2.MusteriId = 2;
            musteri2.MusteriTCNo = 10000000000;

            //döngüde kullanmak lazım bir şekilde dahil et
            //Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            //küçük harfle yapınca hatası gitti neden anlamadım
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriListele(musteri2);
        }
    }
}
