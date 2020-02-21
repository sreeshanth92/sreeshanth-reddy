using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bke
{
     
    
    interface Idrone
    {
        void show();

    }
    interface bikedrone
    {
        void mshow();
    }
    class Myclass : Idrone,bikedrone
    {
        public void show()
        {
            Console.WriteLine("leonardo");

        }
        public void mshow()
        {
            Console.WriteLine("dicaprio");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass m = new Myclass();
            m.show();
            m.mshow();
        }
    }
}
