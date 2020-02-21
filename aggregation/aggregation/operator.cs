using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregation
{
    struct @operator
    {
        int no;
        int no1;

        public @operator(int a, int b)
        {
            no = a;
            no1 = b;
        }
        public void showData()
        {
            Console.WriteLine("{0}\t{1}", no, no1);

        }
        public static @operator operator +(@operator x, @operator y)
        {
            @operator t = new @operator();
            t.no = x.no + y.no;
            t.no1 = x.no1 + y.no1;
            return t;
        }
        public static @operator operator -(@operator x, @operator y)
        {
            @operator t = new @operator();
            t.no = x.no - y.no;
            t.no1 = x.no1 - y.no1;
            return t;

        }
            




       
       }   
        
    }

