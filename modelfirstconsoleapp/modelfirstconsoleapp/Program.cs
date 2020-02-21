using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelfirstconsoleapp
{
    class Program
    {
        static modelfirstContainer af = new modelfirstContainer();
        static void Main(string[] args)

        {
             insertmethod();
            Console.WriteLine("enter Pid");
            int Pid = int.Parse(Console.ReadLine());

            Console.WriteLine("enter Ptitle");
            string Ptitle = Console.ReadLine();

            Console.WriteLine("enter Price");
            double Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter Id");
            int Id = int.Parse(Console.ReadLine());



            var pro = new Product
            {
                Pid = Pid,
                Ptitle = Ptitle,
                Price = Price,
                Id = Id



            };
            af.Products.Add(pro);
            af.SaveChanges();

        }

        private static void insertmethod()
        {
            Console.WriteLine("enter Id");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("enter CatTitle");
            string CatTitle = Console.ReadLine();

            var cat = new Category
            {
                Id = id,
                CatTitle = CatTitle,



            };
            af.Categories.Add(cat);
            af.SaveChanges();
        }
    }
    }

