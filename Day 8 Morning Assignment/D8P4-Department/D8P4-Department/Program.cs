using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8P4_Department
{
    class Department
    {
        public int id;
        public string name;
        public int empcount;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> dpt = new List<Department>()
            {
                new Department() {id = 01, name = "EEE", empcount = 60},
                new Department() {id = 02, name = "ECE", empcount = 40},
                new Department() {id = 03, name = "CSE", empcount = 70},
                new Department() {id = 04, name = "MECH", empcount = 30},
                new Department() {id = 05, name = "IT", empcount = 900},
            };
        
            //for loop
            for(int i = 0; i < dpt.Count; i++)
            {
                if(dpt[i].empcount > 50)
                {
                    Console.WriteLine($"id = {dpt[i].id}, name = {dpt[i].name}");
                }
            }

            //foreach loop
            foreach(var d in dpt)
            {
                if(d.empcount > 50)
                {
                    Console.WriteLine($"id = {d.id}, name = {d.name}");
                }
            }

            //lambda expression
            dpt.ToList().Where(d=>d.empcount > 50).ToList().ForEach(d => Console.WriteLine($"id = {d.id}, name = {d.name}"));

            //Linq Query
            var result = from d in dpt
                         where d.empcount > 50
                         select d;
            result.ToList().ForEach(d => Console.WriteLine($"id = {d.id}, name = {d.name}"));



            Console.ReadLine();
        }
    }
}
