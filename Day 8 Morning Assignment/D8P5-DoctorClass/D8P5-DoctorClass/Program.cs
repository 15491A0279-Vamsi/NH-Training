using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8P5_DoctorClass
{
    class Doctor
    {
        public string name;
        public string specialization;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Doctor> doc = new List<Doctor>()
            {
                new Doctor() {name = "Dr.Harsha", specialization = "Gynecology", salary = 90000},
                new Doctor() {name = "Dr.Aravind", specialization = "Orthopedics", salary = 97000},
                new Doctor() {name = "Dr.Krishna", specialization = "Dermotology", salary = 55000},
                new Doctor() {name = "Dr.Pavan", specialization = "General Surgery", salary = 85000},
                new Doctor() {name = "Dr.Manoj", specialization = "Ophthamology",salary = 95000}
            };

            //for loop 
            for (int i = 0; i < doc.Count; i++)
            {
                Console.WriteLine($"name = {doc[i].name}, specialization = {doc[i].specialization}, salary = {doc[i].salary}");
            }

            //foreach 
            foreach (var d in doc)
            {
                Console.WriteLine($"name = {d.name}, specialization = {d.specialization}, salary = { d.salary}");
            }

            //lamda 
            doc.ToList().ForEach(d => Console.WriteLine($"name = {d.name}, specialization = { d.specialization}, salary = { d.salary}"));

            //Ling Query
            var result = from d in doc
                         select d;
            result.ToList().ForEach(d => Console.WriteLine($"name = {d.name}, specialization = {d.specialization}, salary = {d.salary}"));


            Console.ReadLine();
        }
    }
}
