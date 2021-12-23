using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tarih = new DateTime(2017, 5, 9);
            DateTime now = DateTime.Now;

            Console.WriteLine("Saat {0}", now.Hour);
            Console.WriteLine("Saat {0}", now.Day);
            Console.WriteLine("Dakika :{0}", now.Minute);
            Console.WriteLine("Dakika :{0}", now.Year);

            DateTime tomorrow = now.AddDays(-5);

            Console.WriteLine("Gün {0}", tomorrow.Day);

            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MMMM-dd HH m"));
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.ReadKey();
        }
    }
}
