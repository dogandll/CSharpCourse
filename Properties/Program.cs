using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Product
    {
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _Name = value;
                }
                else
                {
                    Console.WriteLine("Name alanı gerekli");
                }
            }
        }
        public double Price { get; set; }

        private string _ShortName;
        public string ShortName
        {
            get
            {
                _ShortName = Name.Length > 10 ? Name.Substring(0, 10) + "......" : Name;
                return _ShortName;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Product();
            p1.Name = "Iphone 8";
            p1.Price = -2000;
            Console.WriteLine(p1.Price);

            var p2 = new Product();
            p2.Name = "";


            Console.ReadKey();

        }
    }
}
