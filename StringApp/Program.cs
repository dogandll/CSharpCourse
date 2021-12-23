using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cümle özetleme uygulaması
            //Eğer bir cümlenin toplam karakter sayısı belirtilen
            //bir karakter sayısından fazla ise cümleyi kesmemiz gerekiyor
            //ancak kesilen nokta bir kelime olmalıdır


            var cumle = "Eğer bir cümlenin toplam karakter sayısı belirtilen bir karakter sayısı";

            var ozet = HelperMethods.Ozetle(cumle, 20);
            Console.WriteLine(ozet);
            Console.ReadKey();


        }


    }
}
