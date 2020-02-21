using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public enum shippingmethod
    {
        regularairmail = 1,
        registerairmail = 2,
        express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var methodID = 3;
            Console.WriteLine((shippingmethod)methodID);

            var methodname = "express";
            var shippingmethod = (shippingmethod)Enum.Parse(typeof(shippingmethod), methodname);

            


        }
    }
}
