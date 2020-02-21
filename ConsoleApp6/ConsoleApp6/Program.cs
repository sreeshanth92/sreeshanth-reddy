using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        public static double average(int[] marks)
        {
            double sum = 0;
            double avg;

                for(int i=0;i<marks.Length;i++)
            {
                sum = sum + marks[i];
            }
            avg = sum / marks.Length;
            return avg;
                
        }



        static void Main(string[] args)
        {
            string[] employee = new string[] { "sreeshanth", "pavan", "anirudh", "sreenidhi" };
            int[] marks = new int[] { 56, 78, 89, 76 };
            for(int i=0;i<marks.Length;i++)
            {
                Console.WriteLine("subject marks {0}", marks[i]);
            }


                for(int j=0;j<employee.Length;j++)
            {00
                Console.WriteLine("employee name {0}", employee[j]);
            }
            var avg = average(marks);
            Console.WriteLine("average is {0}", avg);
        }
    }
}
