using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            roadway rv = new roadway();
            rv.showVehicle();
            rv.show();
            train tr = new train();
            tr.showtrain();
            tr.show();
            tr.showVehicle();
            ship sp = new ship();
            sp.showship();
            sp.showVehicle();

        }
    }
}
