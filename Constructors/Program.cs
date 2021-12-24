using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Product
    {
        public int ProductNumber { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<Comment> comments { get; set; }

        public Product()
        {
            this.comments = new List<Comment>();
            this.ProductNumber = (new Random().Next(111111 - 99999));
        }
        public Product(int ProductNumber) : this()
        {
            this.ProductNumber = ProductNumber;
        }
        public Product(int productNumber, string name) : this(productNumber)
        {
            this.ProductNumber = productNumber;
            this.Name = name;
        }
    }

    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var comment = new Comment();
            comment.Id = 1;
            comment.Text = "Yorum yazısı çok iyi ";

            var p1 = new Product();

            p1.comments.Add(comment);

            Console.WriteLine(p1.ProductNumber);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Price);

            Console.WriteLine("-----------------------");

            var p2 = new Product(123141223);

            p2.comments.Add(comment);

            Console.WriteLine(p2.ProductNumber);
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.Price);
            Console.WriteLine("-----------------------");

            var p3 = new Product(151231243, "Iphone 5s");

            p3.comments.Add(comment);

            foreach (var item in p3.comments)
            {
                Console.WriteLine(item.Text);
            }

            Console.WriteLine(p3.ProductNumber);
            Console.WriteLine(p3.Name);
            Console.WriteLine(p3.Price);


            Console.ReadKey();
        }
    }
}
