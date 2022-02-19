using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter id:");
            int id = Convert.ToInt32(Console.ReadLine());

            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\NB HealthCare Training\\DotNet Projects\\Day 19 Morning Assignment\\Employees.xml.xml");

            //XmlNode node = doc.DocumentElement.SelectSingleNode("/Employees/Employee");

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                bool isMatch = false;
                foreach (XmlNode cnode in node.ChildNodes)
                {
                   
                    if(cnode.Name == "ID")
                    {
                        if(cnode.InnerText == id.ToString())
                        {
                            isMatch = true;
                        }
                        
                    }
                    if (cnode.Name == "Name" && isMatch)
                    {
                        Console.WriteLine(cnode.InnerText);
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
