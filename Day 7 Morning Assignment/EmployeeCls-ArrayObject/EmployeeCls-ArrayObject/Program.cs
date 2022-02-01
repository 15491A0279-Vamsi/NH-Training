using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCls_ArrayObject
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
            Employee[] emp = new Employee[]
            {
                new Employee() {id = 1, name = "Sai", salary = 5000},
                new Employee() {id = 2, name = "Vamsi", salary = 5000},
                new Employee() {id = 3, name = "Krishna", salary = 5000},
                new Employee() {id = 4, name = "Pavan", salary = 5000},
                new Employee() {id = 5, name = "Manoj", salary = 5000}
            };

            //for loop
            for(int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine($"id = {emp[i].id}, name = {emp[i].name}, salary = {emp[i].salary}");
            }

            //foreach
            foreach(var e in emp)
            {
                Console.WriteLine($"id = {e.id}, name = {e.name}, salary = {e.salary}");
            }

            //lamda
            emp.ToList().ForEach(e => Console.WriteLine($"id = {e.id}, name = {e.name}, salary = {e.salary}"));

            Console.ReadLine();
        }
    }
}
