using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethods
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
            //var sayilar = new List<int>() { 10, 20, 30, 40 };
            //sayilar.Add(50);
            //sayilar.Add(60);
            //sayilar.Add(70);
            //sayilar.Add(80);

            //var sayilar2 = new int[3] { 1000, 2000, 3000 };
            //sayilar.AddRange(sayilar2);
            //sayilar.Insert(2, 4000);
            //sayilar.InsertRange(0, sayilar2);

            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}


            //Console.WriteLine("-------------------------");

            //var isimler = new List<string>() { "Ayşe", "Pınar", "Cengiz" };


            //int index = isimler.IndexOf("Cengiz");

            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}

            //if (isimler.Contains("Sadık"))
            //{
            //    Console.WriteLine("Listede eleman zaten mevcut");
            //}
            //else
            //{
            //    isimler.Add("Sadık");
            //}

            //isimler.RemoveAt(0);
            //isimler.Clear();


            //isimler.Sort();
            //Console.WriteLine("-------------------------");

            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}


            var ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci{Ad="Doğan",Soyad="Dellal"},
                 new Ogrenci{Ad="Uğur",Soyad="Dellal"},
                  new Ogrenci{Ad="Fatma",Soyad="Dellal"},
                      new Ogrenci{Ad="Şeref",Soyad="Dellal"},
                          new Ogrenci{Ad="Sabahat",Soyad="Dellal"},
            };
            ogrenciler.Add(new Ogrenci { Ad = "Zehra", Soyad = "Dellal" });

            ogrenciler.RemoveAt(0);

            var cengiz = ogrenciler.Find(p => p.Ad == "Cengiz");

            if (ogrenciler.Contains(cengiz))
            {
                Console.WriteLine("Aynı eleman mevcut");
            }
            else
            {
                ogrenciler.Add(cengiz);
            }

            for (int i = 0; i < ogrenciler.Count; i++)
            {
                if (ogrenciler[i].Ad == "Cengiz")
                {
                    ogrenciler.Remove(ogrenciler[i]);
                }
            }

            Console.WriteLine("-------------------------");
            Console.ReadKey();
        }
    }
}
