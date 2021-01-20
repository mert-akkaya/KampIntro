using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri
            {
                Id=1,
                Adı = "Mert",
                Soyadı = "Akkaya",
                Yaş = 21,
                Cinsiyet = "Erkek"
            };
            Musteri musteri2 = new Musteri
            {
                Id = 2,
                Adı = "Engin",
                Soyadı = "Demirog",
                Yaş = 35,
                Cinsiyet = "Erkek"
            };

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("-------");
            musteriManager.Listele(musteriler);
            Console.WriteLine("-------");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);

        }
    }
}
