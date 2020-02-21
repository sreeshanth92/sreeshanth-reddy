using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threads
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart tsd = new ThreadStart(getNumbers);
            tsd += new ThreadStart(geteven);
            Thread th = new Thread(tsd);
            th.Start();
            //ThreadStart td = new ThreadStart(getNumbers);
            //Thread t = new Thread(td);
            //t.Start();
            //tsd += new ThreadStart(geteven);
            
            
        }
        public static void getNumbers()
        {
            for(int i=1;i<=10;i++)
            {
                Console.Write("{0}\t",i);
                Thread.Sleep(400);
                
            }
        }
        public static void geteven()
        {
            for(int i=2;i<=20;i+=2)
            {
                Console.Write("{0}\t",i);
                Thread.Sleep(400);
            }

        }
    }
}
