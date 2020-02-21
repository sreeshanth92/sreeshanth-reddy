using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnani2
{
    class car
    { 
        string regno;
        string model;
        string color;
        double price;

        public car() { }

        public car(string reg)//default constructor
        {
            regno = reg;//overloaded
        }
        public car(string reg, string mod)
        {
            regno = reg;
            model = mod;
        }

        public car(string reg, string mod, string colr, double pr)
        {
            regno = reg;
            model = mod;
            color = colr;
            price = pr;
        }
        public void showcar()
        {
            Console.WriteLine("reg no is" + regno);
            Console.WriteLine("model is {0}" + model);
            Console.WriteLine("color is {0} and price is {1}",color,price);
        

        }
        



        

    }
}
