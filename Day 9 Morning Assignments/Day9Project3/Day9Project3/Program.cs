using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Project3
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public static string company = "NationsBenefits";

        public Employee(int eid, string ename, int esalary)
        {
            id = eid;
            name = ename;
            salary = esalary;
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
            Employee emp = new Employee(01, "Vamsi", 9000);
            emp.PrintData();

            Console.ReadLine();

        }
    }
}
