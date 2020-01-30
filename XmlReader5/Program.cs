﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlReader5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a validating XmlReader object. The schema 
            // provides the necessary type information.
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas.Add("urn:empl-hire", "hireDate.xsd");
            using (XmlReader reader = XmlReader.Create("hireDate.xml", settings))
            {

                // Move to the hire-date element.
                reader.MoveToContent();
                reader.ReadToDescendant("hire-date");

                // Return the hire-date as a DateTime object.
                DateTime hireDate = reader.ReadElementContentAsDateTime();
                Console.WriteLine("Six Month Review Date: {0}", hireDate.AddMonths(6));
            }
        }
    }
}
