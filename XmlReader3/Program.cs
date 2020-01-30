using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlReader3
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlReader reader = XmlReader.Create("orderData.xml");

            // Display all attributes.
            while (reader.Read())
            {
                if (reader.HasAttributes)
                {
                    Console.WriteLine("Attributes of <" + reader.Name + ">");
                    for (int i = 0; i < reader.AttributeCount; i++)
                    {
                        Console.WriteLine("  {0}", reader[i]);
                    }
                    // Move the reader back to the element node.
                    reader.MoveToElement();
                }
            }
        }
    }
}
