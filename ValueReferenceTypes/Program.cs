using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 50;
            //int b = a;

            //Console.WriteLine("a :{0}", a);
            //Console.WriteLine("b :{0}", b);

            //Console.WriteLine("*******************");
            //b = 100;
            //Console.WriteLine("a :{0}", a);
            //Console.WriteLine("b :{0}", b);

            int[] sayi1 = new int[3] { 10, 20, 30 };
            int[] sayi2 = sayi1;

            Console.WriteLine("Sayi 1: {0}", sayi1[0]);
            Console.WriteLine("Sayi 2: {0}", sayi1[0]);
            Console.WriteLine("*****************************");

            sayi2[0] = 100;
            Console.WriteLine("Sayi 1: {0}", sayi1[0]);
            Console.WriteLine("Sayi 2: {0}", sayi1[0]);
        }
    }
}
