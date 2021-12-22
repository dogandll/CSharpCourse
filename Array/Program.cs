using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Ogrenci
    {
        public string Ad { get; set; }
        public int OgrenciNo { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int[] ogrNo = new int[5];
            //ogrNo[0] = 100;
            //ogrNo[1] = 200;
            //ogrNo[2] = 300;
            //ogrNo[3] = 400;
            //ogrNo[4] = 500;

            //for (int i = 0; i < ogrNo.Length; i++)
            //{
            //    Console.WriteLine(ogrNo[i]);
            //}
            //Console.WriteLine("***********************");

            //foreach (var ogr in ogrNo)
            //{
            //    Console.WriteLine(ogr);
            //}
            //Console.WriteLine("***********************");

            //string[] ogrenciler = new string[5];
            //ogrenciler[0] = "Ahmet";
            //ogrenciler[1] = "Ali";
            //ogrenciler[2] = "Hasan";
            //ogrenciler[3] = "Mehmet";
            //ogrenciler[4] = "Çınar";

            //foreach (var ogr in ogrenciler)
            //{
            //    Console.WriteLine(ogr);
            //}
            //Console.ReadLine();

            Ogrenci[] ogrenciler = new Ogrenci[5];
            ogrenciler[0] = new Ogrenci { Ad = "Ahmet", OgrenciNo = 100 };
            ogrenciler[1] = new Ogrenci { Ad = "Ali", OgrenciNo = 200 };
            ogrenciler[2] = new Ogrenci { Ad = "Hasan", OgrenciNo = 300 };
            ogrenciler[3] = new Ogrenci { Ad = "Mehmet", OgrenciNo = 400 };
            ogrenciler[4] = new Ogrenci { Ad = "Çınar", OgrenciNo = 500 };

            foreach (var ogr in ogrenciler)
            {
                Console.WriteLine("Öğrenci Adı : {0} | Öğrenci No :{1}", ogr.Ad, ogr.OgrenciNo);
            }

            Console.WriteLine("----------------------------");

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine("Öğrenci Adı : {0} | Öğrenci No :{1}", ogrenciler[i].Ad, ogrenciler[i].OgrenciNo);
            }
            Console.ReadLine();
        }
    }
}
