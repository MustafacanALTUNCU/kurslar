// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {Kurs kurs1 = new Kurs();
            kurs1.egitmen = " Mustafa Altuncu";
            kurs1.kursAdi = "C#";
            kurs1.izlenmeOrani = 75;
            Kurs kurs2 = new Kurs();
            kurs2.egitmen = "Emre Köse";
            kurs2.kursAdi = "Java";
            kurs2.izlenmeOrani = 63;
            Kurs kurs3 = new Kurs();
            kurs3.egitmen = "Doğuş Günaçtı";
            kurs3.kursAdi = "python";
            kurs3.izlenmeOrani = 78;
            Kurs[] kurslar = new Kurs[3] { kurs1, kurs2, kurs3, };
            foreach (var goster in kurslar)
            {
                Console.WriteLine("eğitmen =" + goster.egitmen);
                Console.WriteLine( " kurslar =" + goster.kursAdi);
                Console.WriteLine("izlenme oranlrı =" + goster.izlenmeOrani);
            }


           

        }
    }
}
class Kurs { 
    
    public string kursAdi { get; set; }
    public string egitmen { get; set; }
    public int izlenmeOrani { get; set; }
}

