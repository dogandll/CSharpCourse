using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kutu kutu1 = new Kutu();
            //kutu1.En = 10;
            //kutu1.Derinlik = 10;
            //kutu1.Boy = 10;
            //Console.WriteLine(kutu1.Yazdir());
            //Console.WriteLine(kutu1.Hacim());

            //UrunManager urunManager = new UrunManager();
            var urunler = UrunManager.UrunleriGetir();

            foreach (var urun in urunler)
            {
                Console.WriteLine($"Ürün Adı :{urun.UrunAdi} Fiyat:{urun.Fiyat}");
            }


            Console.ReadKey();
        }

        public class Kutu
        {
            public int En { get; set; }
            public int Boy { get; set; }
            public int Derinlik { get; set; }

            public string Yazdir()
            {
                return string.Format("En {0} Boy {1} Derinlik {2}", En, Boy, Derinlik);
            }

            public string Hacim()
            {
                return string.Format("Hacim {0}", En * Boy * Derinlik);
            }
        }

        public class Urun
        {
            public string UrunAdi { get; set; }
            public double Fiyat { get; set; }
        }
        public class UrunManager
        {
            public static List<Urun> UrunleriGetir()
            {
                //Veritabanından ürünleri getirir

                List<Urun> urunler = new List<Urun>()
                {
                    new Urun{UrunAdi="Samsung s3",Fiyat=1000 },
                     new Urun{UrunAdi="Samsung s4",Fiyat=2000 },
                      new Urun{UrunAdi="Samsung s5",Fiyat=3000 },
                       new Urun{UrunAdi="Samsung s6",Fiyat=4000 },
                        new Urun{UrunAdi="Iphone 7s",Fiyat=5000 },
                         new Urun{UrunAdi="Iphone 8",Fiyat=6000 }
                };
                return urunler;
            }

        }
    }
}
