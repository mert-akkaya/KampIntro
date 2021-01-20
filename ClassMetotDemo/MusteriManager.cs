using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.Adı);
        }

        public void Listele(Musteri[] musteriler)
        {

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri {0}  : {1} {2} ", musteri.Id, musteri.Adı, musteri.Soyadı);
            }
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.Adı);
        }
    }
}
