using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlstructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            if (a > 10)
                Console.WriteLine("Good Morning");
            else if (a < 10)
                Console.WriteLine("Good evening");
            else
                Console.WriteLine("uzumaki naruto");




            int b = 2;
            switch (b)
            {
                case 1: Console.WriteLine("hi... how are you?");
                    break;
                case 2: Console.WriteLine("hopw you are doing good");
                    break;
                default: Console.WriteLine("it seems that you are not good");
                    break;
            }

                    int n = 10;
                    while(n<100)
            {
                Console.WriteLine("{0} is less than 100",n);
                n = n + 10;
            }

            Console.WriteLine("enter your number");
            int m = int.Parse(Console.ReadLine());

            for(int i = 0;i < 10;i++)
            {
                Console.WriteLine("{1} * {2} = {3}" , m , i , m * i);
            }
        }
        
    }
}
