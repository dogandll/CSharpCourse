using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var ad = "Doğan";

            var soyad = "Dellal";

            //var adsoyad = "Adınız :" + ad + " Soyadınız :" + soyad;
            //var adsoyad = string.Format("Adınız: {0}  Soyadınız:  {1} ", ad, soyad);
            var adsoyad = $"Adınız: {ad} soyadınız: {soyad}";

            string[] adlar = { "Doğan", "Uğur", "Emrah" };

            var tumadlar = string.Join("-", adlar);

            Console.WriteLine(tumadlar);
        }
    }
}
