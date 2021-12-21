using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 10;
            var c = 25;
            var d = 30;

            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);

            var sonuc = (c > b) ?
                                 (c > d) ?
                                         "c'den büyük"
                                         :
                                         "c d'den küçük"
                               : "b c'den büyük";

            Console.WriteLine(sonuc);

            Console.ReadLine();

        }
    }
}
