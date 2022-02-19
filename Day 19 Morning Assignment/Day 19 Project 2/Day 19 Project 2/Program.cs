using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day_19_Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\NB HealthCare Training\\DotNet Projects\\Day 19 Morning Assignment\\Employees.xml.xml");

            //XmlNode node = doc.DocumentElement.SelectSingleNode("/Employees/Employee");

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach(XmlNode cnode in node.ChildNodes)
                {
                    if (cnode.Name == "Name")
                    {
                        Console.WriteLine(cnode.InnerText);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
