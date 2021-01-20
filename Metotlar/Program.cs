using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adı = "Elma";
            urun1.Fİyat = 20;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun1.Adı = "Karpuz";
            urun1.Fİyat = 80;
            urun1.Aciklama = "Diyarbakır karpuzu";

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
        }
    }
}
