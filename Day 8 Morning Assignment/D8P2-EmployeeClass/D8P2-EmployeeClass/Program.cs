using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8P2_EmployeeClass
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
            List<Employee> emp = new List<Employee>()
            { 
                new Employee() {id = 01, name = "Vamsi", salary = 28000},
                new Employee() {id = 02, name = "Sai", salary = 9000},
                new Employee() {id = 03, name = "Krishna", salary = 5000},
                new Employee() {id = 04, name = "Pavan", salary = 25000},
                new Employee() {id = 05, name = "Manoj", salary = 35000}
            };

            //for loop 
            for (int i = 0; i < emp.Count; i++)
            {
                Console.WriteLine($"id = {emp[i].id}, name = {emp[i].name}, salary = {emp[i].salary}");
            }

            //foreach 
            foreach (var e in emp)
            {
                Console.WriteLine($"id = {e.id}, name = {e.name}, salary = { e.salary}"); 
            }

            //lamda 
            emp.ToList().ForEach(e => Console.WriteLine($"id = {e.id}, name = { e.name}, salary = { e.salary}"));

            //Ling Query
            var result = from e in emp
                         select e;
            result.ToList().ForEach(e => Console.WriteLine($"id = {e.id}, name = {e.name}, salary = {e.salary}"));


            Console.ReadLine();
        }
    }
}
