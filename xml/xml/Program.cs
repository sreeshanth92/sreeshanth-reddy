using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xml
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmld = new XmlDocument();
            xmld.Load(@"C:\Users\Admin\source\repos\xml\xml\XMLFile1.xml");
            XmlNode currentnode = xmld.DocumentElement.FirstChild;
            Console.WriteLine(currentnode.InnerText);
            XmlNode nextnode = currentnode.NextSibling;
            Console.WriteLine(nextnode.InnerText);
            XmlNode node3 = nextnode.NextSibling;
            Console.WriteLine(node3.InnerText);


        }
    }
}
