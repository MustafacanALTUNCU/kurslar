// See https://aka.ms/new-console-template for more information
using System;

namespace methods // Note: actual namespace depends on the project name.
{
     internal class Program
    {
        static void Main(string[] args)
        {
           
     Products Urun1 = new Products();
            Urun1.Adi = "elma";
            Urun1.Fiyati = 15;
            Urun1.Aciklama = "amasya elması";
            Products Urun2 = new Products();
            Urun2.Adi = "karpuz";
            Urun2.Fiyati = 80;
            Urun2.Aciklama = "dıyarbakır karpuzu";
            Products[] urunler = new Products[] { Urun1, Urun2 };
            foreach (Products urun in  urunler)
            {
                Console.WriteLine("ürünün adi =" + urun.Adi);
                Console.WriteLine("urunun fiyatı =" + urun.Fiyati);
                Console.WriteLine("ürünün açıklaması = " + urun.Aciklama);
                Console.WriteLine("--------------");

            }
            Console.WriteLine("---------metotlar----------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.ekle(Urun1);
            sepetManager.ekle(Urun2);
            sepetManager.ekle2("armut","yeşil",20);
        }
        
    }
}
