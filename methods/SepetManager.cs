using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
     class SepetManager
    {
        public void ekle(Products urun)
        { Console.WriteLine("sepete eklendi : " + urun.Adi + " " + urun.Fiyati); }
        public void ekle2(string urunAdi, string aciklama, double fiyat) { Console.WriteLine("sepete eklendi : " + urunAdi + " " + fiyat); }
    }
}
