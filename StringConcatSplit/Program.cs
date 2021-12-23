using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ad = "Doğan";
            //string soyad = "Dellal";
            //string adsoyad = string.Concat(ad, soyad," İstanbul da yaşar.");
            //Console.WriteLine(adsoyad);

            //string[] kisiler = { "ahmet", "ali", "hasan" };
            //string adlar = string.Join("-", kisiler);
            //Console.WriteLine(adlar);

            //string adlar = "ahmet-hasan-mehmet";
            //string[] isimler = adlar.Split('-');
            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("Ürün kodunu giriniz :");
            string urunKodu = Console.ReadLine();
            int basamak = urunKodu.Length;
            if (basamak < 8)
            {
                urunKodu = urunKodu.PadRight(8, '0');
            }

            Console.WriteLine(urunKodu);

            Console.ReadKey();
        }
    }
}
