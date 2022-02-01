using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass_ObjectIntialisation
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { id = 23, name = "Vamsi", salary = 56000 };

            Console.WriteLine($" Id = {emp.id}, Name = {emp.name}, Salary = {emp.salary}");

            Console.ReadLine();
        }
    }
}
