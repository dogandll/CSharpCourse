using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSearching
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Lorem ipsum test ediyoruz";

            int index = str.LastIndexOf('u');

            string str2 = str.Substring(index);
            Console.WriteLine(str2);

            //string site = "www.dogandellal.com";
            //string email = "dogan.dellal@gmail.com";

            //if (email.Contains("@"))
            //{
            //    Console.WriteLine("Düzgün bir mail adresi girildi");
            //}
            //else
            //{
            //    Console.WriteLine("Eposta adresini düzgün giriniz.");
            //}

            //if (site.StartsWith("www") == false)
            //{
            //    Console.WriteLine("Geçerli bir site adresi giriniz.");
            //}
            //else
            //{
            //    Console.WriteLine("Site adresi doğru girildi");

            //}

            Console.ReadKey();

        }
    }
}
