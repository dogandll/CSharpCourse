using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringChanging
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs = "C# Programlama";
            //string kurs2 = kurs.Insert(0, "Sıfırdan ");
            //int index = kurs2.IndexOf("Programlama") + "Programlama".Length;
            //string kurs3 = kurs2.Insert(index, " Eğitimi");
            //Console.WriteLine(kurs3);

            //string kurs = "C# Programlama Eğitimi";
            //string kurs2 = kurs.Replace("Eğitimi", "Kursu").Replace("#", "Sharp");
            //Console.WriteLine(kurs2.ToLower());

            //string kurs = "Sıfırdan C# Programlama Eğitimi Sıfırdan C# Programlama Eğitim";
            //string kurs2 = kurs.Length > 26 ? kurs.Substring(0, 24) + "..." : kurs;
            //Console.WriteLine(kurs2);

            //string kurs = " Sıfırdan C# Programlama Eğitimi ";
            //string kurs2 = kurs.Trim();
            //Console.WriteLine(kurs2);

            Console.WriteLine("Adınızı giriniz :");
            string ad = Console.ReadLine().Trim();
            Console.WriteLine(ad.Length);

            Console.ReadKey();
        }
    }
}
