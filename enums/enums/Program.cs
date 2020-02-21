using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    public enum shippingmethods
    {
        RegularAirMail = 1,
        RegisterAirMail = 2,
        Express= 3


    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = shippingmethods.Express;
            Console.WriteLine((int)method);

            var methodID = 3;
            Console.WriteLine((shippingmethods)methodID);


        

        }
        }
    }

