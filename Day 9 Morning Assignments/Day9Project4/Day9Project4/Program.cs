using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Project4
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public static string company = "NationsBenefits";

        public Employee()
        {
            this.id = 0;
            this.name = null;
            this.salary = 0;
        }

        public Employee(int eid, string ename, int esalary)
        {
            this.id = eid;
            this.name = ename;
            this.salary = esalary;
        }

        public void PrintData()
        {
            Console.WriteLine($"id = {id}, name = {name}, salary = {salary}, company = {company}");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(01, "Vamsi", 9000);
            emp1.PrintData();

            Employee emp2 = new Employee();
            emp2.PrintData();

            Console.ReadLine();

        }

    }
}
