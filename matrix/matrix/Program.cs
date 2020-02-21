using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[4, 4] { { 1, 2, 3, 4 }, { 4, 5, 6, 8 }, { 7, 8, 9, 6 },{ 3, 4, 5, 6 } };
            for(int i=0;i<4;i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
           
                    
                }
                
                                   }
            
        }
    }

