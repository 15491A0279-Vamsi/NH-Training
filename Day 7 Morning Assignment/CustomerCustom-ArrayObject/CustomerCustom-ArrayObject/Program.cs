using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCustom_ArrayObject
{
    class Customer
    {
        public int id;
        public string name;
        public string mobile;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer[] cust = new Customer[]
            {
                new Customer() {id = 1, name = "Sai", mobile = "999999999"},
                new Customer() {id = 2, name = "Vamsi", mobile = "888888888"},
                new Customer() {id = 3, name = "Krishna", mobile = "77777777"},
                new Customer() {id = 4, name = "Pavan", mobile = "66666666666"},
                new Customer() {id = 5, name = "Vamsi", mobile = "555555555"}
            };

            //for loop
            for (int i = 0; i < cust.Length; i++)
            {
                if(cust[i].name == "Vamsi")
                {
                    Console.WriteLine($"id = {cust[i].id}, name = {cust[i].name}, mobile = {cust[i].mobile}");

                }
                
            }

            //foreach
            foreach (var c in cust)
            {
                if(c.name == "Vamsi")
                {
                    Console.WriteLine($"id = {c.id}, name = {c.name}, mobile = {c.mobile}");

                }
                
            }

            //lamda
            cust.ToList().Where(c => c.name == "Vamsi").ToList().ForEach(c => Console.WriteLine($"id = {c.id}, name = {c.name}, mobile = {c.mobile}"));

            Console.ReadLine();
        }
    }
}
