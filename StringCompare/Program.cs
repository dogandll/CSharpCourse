using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str1 = "b";
            //string str2 = "a";
            //var sonuc = string.Compare(str1, str2);
            //if (sonuc == 0)
            //{
            //    Console.WriteLine("Değerler eşit");
            //}
            //else if (sonuc == 1)
            //{
            //    Console.WriteLine("str 2 str1'den önce gelir");
            //}
            //else if (sonuc == -1)
            //{
            //    Console.WriteLine("str 1 str2'den önce gelir");
            //}
            string _email = "dogan.dellal@gmail.com";
            string _parola = "123";


            Console.WriteLine("Mail giriniz");
            string mail = Console.ReadLine();
            Console.WriteLine("Parola giriniz");
            string parola = Console.ReadLine();

            if (_email.Equals(mail) && _parola.Equals(parola))
            {
                Console.WriteLine("Sisteme giriş yaptınız");
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız");
            }
            Console.ReadKey();
        }
    }
}
