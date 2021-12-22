using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen _dikdortgen = new Dikdortgen();
            _dikdortgen.kisa = 50;
            _dikdortgen.uzun = 50;
            int result = _dikdortgen.Alan();
            Console.WriteLine(result);
        }

        public struct Dikdortgen
        {
            public int kisa;
            public int uzun;

            public int Alan()
            {
                return kisa * uzun;
            }
        }
    }
}
