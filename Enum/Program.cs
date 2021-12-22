using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        public enum OdemeYontemleri
        {
            KrediKarti = 1,
            Havale = 2,
            KapidaOdeme = 3
        }

        static void Main(string[] args)
        {
            var krediKartı = OdemeYontemleri.KrediKarti;

            Console.WriteLine((int)krediKartı);
        }
    }
}
