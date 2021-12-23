using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsignTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan ts1 = new TimeSpan(2, 10, 50);
            TimeSpan ts2 = new TimeSpan(1, 0, 0);
            TimeSpan ts3 = TimeSpan.FromHours(1);

            Console.WriteLine("Saniye : {0}", ts1.Seconds);
            Console.WriteLine("dakika : {0}", ts1.Minutes);
            Console.WriteLine("saat : {0}", ts1.Hours);

            Console.WriteLine("Toplam dakika {0}", ts1.TotalHours);
            //DateTime now1 = DateTime.Now;
            //DateTime now2 = DateTime.Now.AddHours(2);
            //TimeSpan timeSpan = now2 - now1;
            //Console.WriteLine("Geçen süre :{0}", timeSpan.TotalMilliseconds);

            Console.ReadKey();
        }
    }
}
