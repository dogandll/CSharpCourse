using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = 15;
            var b = 4;
            var c = 2;

            Console.WriteLine("****** Toplama ******");
            Console.WriteLine(a + b);
            Console.WriteLine("****** Çıkartma ******");
            Console.WriteLine(a - b);
            Console.WriteLine("****** Çarpma ******");
            Console.WriteLine(a * b);
            Console.WriteLine("****** Bölme ******");
            Console.WriteLine((double)a / b);
            Console.WriteLine("****** İşlen önceliği ******");
            Console.WriteLine((a + b) * c);
            Console.WriteLine("****** A Sayısının mod 2 7*2 :14-15=1 ******");
            Console.WriteLine(a % 2);
            Console.WriteLine("****** B Sayısının mod 2 ******");
            Console.WriteLine(b % 2);
            Console.WriteLine("****** C Sayısının mod 2 ******");
            Console.WriteLine(c % 2);
            Console.WriteLine("****** Sayının Karesi ******");
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine("****** A Sayısının 1 attırma  a++ ******");
            Console.WriteLine(a++);
            Console.WriteLine("****** B Sayısının 1 attırma  a++ ******");
            Console.WriteLine(b++);
            Console.WriteLine("****** B Sayısının 1 artma durumu ******");
            Console.WriteLine(b);

            var d = 3;
            var e = 5;
            d = ++e;
            Console.WriteLine(d);

            Console.ReadLine();
        }
    }
}
