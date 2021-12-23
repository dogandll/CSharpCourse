using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingList
{
    class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sayilar = new List<int>() { 10, 20, 30 };

            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.WriteLine("--------------------------------");
            var isimler = new List<string>() { "Yusuf", "Eray" };
            isimler.Add("Doğan");
            isimler.Add("Uğur");
            isimler.Add("Baran");

            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine("--------------------------------");
            var ogrenciler = new List<Ogrenci>()
            {
            new Ogrenci{Ad="Hamdullah",Soyad="Aksak" }
            };
            ogrenciler.Add(new Ogrenci { Ad = "Doğan", Soyad = "Dellal" });
            ogrenciler.Add(new Ogrenci { Ad = "Baran", Soyad = "Sezgin" });
            ogrenciler.Add(new Ogrenci { Ad = "Uğur", Soyad = "Dellal" });

            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine($"Öğrenci Ad : {ogrenci.Ad}  Ögrenci Soyad : {ogrenci.Soyad}");
            }

            Console.ReadKey();
        }
    }
}
