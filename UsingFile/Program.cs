using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\deneme\1.txt";
            var path2 = @"C:\deneme2\1.txt";

            if (File.Exists(path2))
            {
                Console.WriteLine("Aynı dosya mevcut");
            }
            else
            {
                File.Copy(path, path2, true);
            }

            var text = File.ReadAllText(path);
            Console.WriteLine(text);

            Console.ReadKey();
        }
    }
}
