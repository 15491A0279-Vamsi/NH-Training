using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Project3
{
    class Employee
    {
       
        public int Id{ get; set; }

        public string Name { get; set; }
        
        public string Designation { get; set; }

        public int Salary
        {
            get
            {
                if(Designation == "M")
                {
                    return 30000;
                }
                else
                {
                    return 60000;
                }
                    
                
            }

        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Designation = "M";
            Console.WriteLine(emp.Salary);



            Console.ReadLine();
        }
    }
}
