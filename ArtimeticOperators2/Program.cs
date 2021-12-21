using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtimeticOperators2
{
    class Program
    {
        static void Main(string[] args)
        {
            //a=10  b=20 c=50 ise (a+b)*c 'yi hesapla // 1500
            //int a = 10, b = 20, c = 50;
            //Console.WriteLine((a + b) * c);

            //int? a=50 int b=100 ise a+b yi hesapla.

            //int? a = null;
            //int b = 100;
            //int sonuc = (a ?? 0) + b;
            //Console.WriteLine(sonuc);
            

            //Klavyeden girilen bir sayının tek çift olup olmadığını bulun

            Console.WriteLine("Bir sayı giriniz :");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı Çift");
            }
            else
            {
                Console.WriteLine("Sayı Tek");
            }

            Console.ReadLine();
        }
    }
}
