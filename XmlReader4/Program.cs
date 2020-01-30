using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlReader4
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlReader reader = XmlReader.Create("orderData.xml");

            while (reader.Read())
            {
                if (reader.HasAttributes)
                {
                    Console.WriteLine("Attributes of <" + reader.Name + ">");
                    while (reader.MoveToNextAttribute())
                    {
                        Console.WriteLine(" {0}={1}", reader.Name, reader.Value);
                    }
                    // Move the reader back to the element node.
                    reader.MoveToElement();
                }
            }
        }
    }
}
