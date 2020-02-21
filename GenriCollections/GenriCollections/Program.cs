using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenriCollections
{
    class Program
    {
        public delegate string Mydel(int x, int y);
        public delegate string delgate(int z);

        static void Main(string[] args)
        {
            delgate del = new delgate(area);
            Console.WriteLine(del(22));
           // delg();
        }

        private static void delg()
        {
            Mydel delg = new Mydel(subtract);
            Console.WriteLine(delg(34, 65));
            delg += new Mydel(Add);
            Console.WriteLine(delg(12, 25));
            delg += new Mydel(Add);
            Console.WriteLine(delg(20, 50));
        }

        static string Add(int x,int y)
        {
            int z = x + y;
            return String.Format("{0}+{1}={2}", x, y, z);
        }
        static string subtract(int x,int y)
        {
            int z = x - y;
            return String.Format("{0}-{1} = {2}", x, y, z);
        }
        static string area(int s)
        {
            int A = s * s;
            return String.Format("Area of square is {0}", A);
        }
        
        }
    }

