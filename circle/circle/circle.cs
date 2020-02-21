using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class circle:shape
    {
        public double radius;
        public circle(double r)
        {
            radius = r;
        }
        public override double area()
        {
            
                double rad;
                rad = radius;
                Console.WriteLine("circle area");
                return (rad * rad * Math.PI);

            
        }

    }
}
