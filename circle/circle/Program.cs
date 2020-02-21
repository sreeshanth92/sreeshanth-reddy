using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    interface Ilirborne
    {
        void fly();

    }
    class helicopter : Ilirborne
    {
        public void fly()
        {
            Console.WriteLine("Helicopter flies in air");
        }
    }
    class Aeroplanes : Ilirborne
    {
        public void fly()
        {
            Console.WriteLine("Aeroplane flies in air");
        }

        //class program

        static void Main(string[] args)
        {
            helicopter h = new helicopter();
            h.fly();
            Aeroplanes a = new Aeroplanes();
            a.fly();
        }

           // circle c = new circle(3);
           // double r = c.area();
           // Console.WriteLine("area:{0}", r);
    }
}

