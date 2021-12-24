using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsignDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Altklasor";
            //var path2 = @"C:\deneme";
            //var path3 = @"C:\deneme2";
            //Console.WriteLine("Şuan çalışan klasör :{0}", Directory.GetCurrentDirectory());

            //Console.WriteLine("C sürücüsündeki klasörler");
            //Console.WriteLine("---------------------");
            //string[] klasorler = Directory.GetDirectories(path);

            //foreach (var klasor in klasorler)
            //{
            //    Console.WriteLine(klasor);
            //}
            //if (!Directory.Exists(path2))
            //{
            //    Directory.CreateDirectory(path2);
            //}

            //Directory.Move(path2, path3);
            //Directory.Delete(path3);

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            directoryInfo.CreateSubdirectory("Altklasor");

         
            Console.ReadKey();
        }
    }
}
