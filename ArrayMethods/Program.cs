using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var ogrenci = new string[2] { "Doğan", "Cem" };
            var aranacakkelime = Array.BinarySearch(ogrenci, "Ali");

            ogrenci.SetValue("Ali", 0);
            Console.WriteLine(ogrenci.GetValue(0));
            Console.WriteLine("Dizi boyutu :{0}", ogrenci.Rank);
            Console.WriteLine("Dizi elemansayısı :{0}", ogrenci.Length);
            Console.WriteLine("Dizi elemansayısı :{0}", ogrenci.GetLength(0));
            Console.WriteLine("Aranacak kelime {0}", aranacakkelime);

            var ogrenciler = new string[2, 3]
            {
                {"Doğan","Baran","Yusuf"},
                { "Doğan","Burak","Uğur"}
            };
            ogrenciler.SetValue("Can", 0, 1);
            Console.WriteLine(ogrenciler[0, 1]);
            Console.WriteLine("Dizi boyutu :{0}", ogrenciler.Rank);
            Console.WriteLine("Dizi elemansayısı :{0}", ogrenciler.Length);
            Console.WriteLine("Dizi satır sayısı :{0}", ogrenciler.GetLength(0));
            Console.WriteLine("Dizi sütun sayısı :{0}", ogrenciler.GetLength(1));
            Console.ReadKey();
        }
    }
}
