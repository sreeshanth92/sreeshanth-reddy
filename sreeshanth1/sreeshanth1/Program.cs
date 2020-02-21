using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sreeshanth1
{
    class Program
    {
        static void Main(string[] args)
        {
            classsri();

            //NewMethod();

        }

        private static void NewMethod()
        {
            classnani1 tr1 = new classnani1();
            tr1.Getdata("uzmakinaruto", "123", "leaf", 800);
            tr1.ShowData();
        }

        private static void classsri()
        {
            classnani1 tr = new classnani1();
            tr.Getdata("sreeshanth", "EMp5039", "chennai", 21);
            tr.ShowData();
        }
    }
}
