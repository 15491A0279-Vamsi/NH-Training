using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day_19_Project3
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
                foreach (XmlNode cnode in node.ChildNodes)
                {
                    if (cnode.Name == "ID")
                        Console.Write($"{cnode.InnerText},");
                    if (cnode.Name == "Name")
                        Console.Write($"{cnode.InnerText},");
                    if (cnode.Name == "Salary")
                        Console.Write($"{cnode.InnerText}\n");

                }
            }
            Console.ReadLine();
        }
    }
}
