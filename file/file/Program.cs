using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\csharp\sree.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("enter your name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter your id");
                    string id = Console.ReadLine();
                    Console.WriteLine("enter yout city");
                    string city = Console.ReadLine();
                    sw.WriteLine("name:" + name);
                    sw.WriteLine("city:" + city);
                    sw.WriteLine("Id:" + id);

                }


            }
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);

                }

            }

            using (StreamWriter sw = File.AppendText(path))
            {
                Console.WriteLine("enter some text");
                string s = Console.ReadLine();
                sw.WriteLine(s);
            }
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) ! = null)
                    {
                    Console.WriteLine(s);

                }

            }
            Console.WriteLine("deleting file");
            File.Delete(path);
        }





    }        
                


                
            
    }

