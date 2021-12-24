using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsignPath
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\drive";
            string[] files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                Console.WriteLine("Dosya adı:{0}", Path.GetFileName(file));
                Console.WriteLine("Dosya uzantısı :{0}", Path.GetExtension(file));
                Console.WriteLine("Sadece Dosya :{0}", Path.GetFileNameWithoutExtension(file));

                Console.WriteLine(file);
            }
        }
    }
}
