using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");


            }
            Console.WriteLine("------------Metotlar-----------");
            SepetManeger sepetManager = new SepetManeger();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut ", "Yeşil Armut", 12,5);
            sepetManager.Ekle2("elma ", "Yeşil elma", 12,5);
            sepetManager.Ekle2("karpuz ", "Diyarbakır karpuzu", 12,9);

        }
    }
}
