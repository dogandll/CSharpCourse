using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsignArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sehirler = new string[3];
            //sehirler[0] = "Ankara";
            //sehirler[1] = "İstanbul";
            //sehirler[2] = "İzmir";

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}

            Console.WriteLine("Kaç adet sayı girmek istiyorsunuz :");
            var adet = int.Parse(Console.ReadLine());
            byte[] sayilar = new byte[adet];
            Console.WriteLine("");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("{0}.sayıyı giriniz :", i + 1);
                sayilar[i] = byte.Parse(Console.ReadLine());
            }
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Girilen sayılar sırasıyla :{0}", sayilar[i]);
                toplam += sayilar[i];
            }
            double ortalama = toplam / sayilar.Length;
            Console.WriteLine("Sayıların Toplamı :{0} Sayıların Ortalaması :{1}", toplam, ortalama);
            Console.ReadKey();
        }
    }
}
