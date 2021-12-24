using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class KrediHesabi
    {
        public string MusteriAdi { get; set; }
        public string HesapNo { get; set; }
        public double Limit { get; set; }

        public string KrediKullan()
        {
            return string.Format("{0} miktarında kredi hesabınıza yatırıldı", Limit);
        }
        public string KrediKullan(double miktar)
        {
            if (miktar > Limit)
            {
                return string.Format("Maksimum kullanabileceğiniz kredi mkitarı : {0}", Limit);
            }
            return string.Format("{0} miktarında kredi hesabınıza yatırıldı", miktar);
        }
    }

    public class Islem
    {
        public int Toplam(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //KrediHesabi krediHesabi = new KrediHesabi();
            //krediHesabi.MusteriAdi = "Ahmet";
            //krediHesabi.HesapNo = "123";
            //krediHesabi.Limit = 20000;

            //Console.WriteLine(krediHesabi.KrediKullan());

            //var KrediHesabi2 = new KrediHesabi();
            //KrediHesabi2.MusteriAdi = "Mehmet";
            //KrediHesabi2.HesapNo = "124123";
            //KrediHesabi2.Limit = 30000;

            //Console.WriteLine(KrediHesabi2.KrediKullan());

            var islem = new Islem();
            var result = islem.Toplam(10, 20, 30, 40);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
