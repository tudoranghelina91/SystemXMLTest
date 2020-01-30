using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NameTableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            NameTable nt = new NameTable();
            object book = nt.Add("book");
            object price = nt.Add("price");

            // Create the reader.
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.NameTable = nt;
            XmlReader reader = XmlReader.Create("books.xml", settings);

            reader.MoveToContent();
            reader.ReadToDescendant("book");

            if (System.Object.ReferenceEquals(book, reader.Name))
            {
                // gets the list of books
                while(!reader.EOF)
                {
                    reader.Read();

                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        Console.Write($"{reader.Name}: ");
                    }

                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        Console.Write($"{reader.Value}");
                        
                    }

                    if (reader.NodeType == XmlNodeType.EndElement)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
