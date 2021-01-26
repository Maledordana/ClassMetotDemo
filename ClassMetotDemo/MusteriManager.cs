using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        //müşteri ekle, listele ve silme
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd+ " " + musteri.MusteriSoyad
                + " isimli müşterimiz eklenmiştir.");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad
                + " isimli müşterimiz silinmiştir.");
        }


        public void MusteriListele(Musteri musteri)
        {
            //foreach (Musteri[] musteris in musteri[])
            //{
            //    Console.WriteLine(musteri[i]);
            //}
            //tekrar bakmam lazım

            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad
                + " isimli müşterimiz listenelenmektedir.");
        }

    }
}
