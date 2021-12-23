using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimentionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sayilar = new int[2, 3];
            //sayilar[0, 0] = 10;
            //sayilar[0, 1] = 20;
            //sayilar[0, 2] = 30;

            //sayilar[1, 0] = 40;
            //sayilar[1, 1] = 50;
            //sayilar[1, 2] = 60;

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        //i satır
            //        //j kolon

            //        Console.WriteLine("Ulaşılan dizi elamanı : [{0},{1}] {2}", i, j, sayilar[i, j]);
            //    }
            //}

            //var ogrenciler = new string[2, 4];
            //ogrenciler[0, 0] = "Ahmet";
            //ogrenciler[0, 1] = "Turan";
            //ogrenciler[0, 2] = "123";
            //ogrenciler[0, 3] = "11/A";

            //ogrenciler[1, 0] = "Mehmet";
            //ogrenciler[1, 1] = "Turan";
            //ogrenciler[1, 2] = "110";
            //ogrenciler[1, 3] = "12/A";

            //for (int i = 0; i < 2; i++)
            //{

            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.WriteLine("Öğrenci :[{0},{1}]:{2}", i, j, ogrenciler[i, j]);
            //    }
            //    Console.WriteLine("------------------------------");
            //}

            var ogrenciler = new string[2][];

            ogrenciler[0] = new string[2];
            ogrenciler[1] = new string[3];

            ogrenciler[0][0] = "Ahmet";
            ogrenciler[0][1] = "Ali";

            ogrenciler[1][0] = "Çınar";
            ogrenciler[1][1] = "Hasan";
            ogrenciler[1][2] = "Doğu";

            foreach (var satir in ogrenciler)
            {
                foreach (var sutun in satir)
                {
                    Console.WriteLine(sutun);
                }
                Console.WriteLine(" ");
            }

            Console.ReadKey();

        }
    }
}
