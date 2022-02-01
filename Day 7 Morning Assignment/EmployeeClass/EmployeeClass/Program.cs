using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    class Employee
    {
        private int id;
        private string name;
        private int salary;

        public void ReadEmployee()
        {
            Console.WriteLine("Enter id:");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter salary:");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public void WriteEmployee()
        {
            Console.WriteLine($"Id = {id}, Name = {name}, Salary = {salary}");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.ReadEmployee();
            emp.WriteEmployee();

            Console.ReadLine();
        }
    }
}
