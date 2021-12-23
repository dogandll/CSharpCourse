using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsignStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder str = new StringBuilder();
            //str.Append("Kapasite arttırımını kontrol ediyoruz");
            //str.Replace("ediyoruz", "ettik");
            //str.Insert(0, " StringBuilder ");
            //str.Remove(0, 14);
            //Console.WriteLine(str);
            //Console.WriteLine(str.Capacity);

            string str1 = string.Empty;

            DateTime baslangic = DateTime.Now;

            for (int i = 0; i < 50000; i++)
            {
                str1 += 1;
            }
            DateTime bitis = DateTime.Now;
            double sure = (bitis - baslangic).TotalSeconds;

            Console.WriteLine("String işlemi {0} sürdü", sure);

            StringBuilder str2 = new StringBuilder();
            baslangic = DateTime.Now;

            for (int i = 0; i < 50000; i++)
            {
                str2.Append(i);
            }
            bitis = DateTime.Now;
            sure = (bitis - baslangic).TotalSeconds;
            Console.WriteLine("StringBuilder işlemi {0} sürdü", sure);

            Console.ReadKey();
        }
    }
}
