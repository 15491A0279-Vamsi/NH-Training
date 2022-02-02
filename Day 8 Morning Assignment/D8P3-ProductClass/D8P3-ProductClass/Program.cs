using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8P3_ProductClass
{
    class Product
    {
        public int id;
        public string name;
        public string brand;
        public int price;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> pro = new List<Product>()
            {
                new Product() {id = 01, name = "Mobile", brand = "Vivo", price = 30000},
                new Product() {id = 02, name = "Laptop", brand = "HP", price= 50000},
                new Product() {id = 03, name = "Mouse", brand = "HP", price = 200},
                new Product() {id = 04, name = "Friz", brand = "LG", price = 40000},
                new Product() {id = 05, name = "TV", brand = "Samsung", price = 20000}
            };

            //for loop
            for (int i = 0; i < pro.Count; i++)
            {
                if (pro[i].price > 500)
                {
                    Console.WriteLine($"name = {pro[i].name}, brand = {pro[i].brand}");
                }
            }

            //foreach loop
            foreach (var d in pro)
            {
                if (d.price > 500)
                {
                    Console.WriteLine($"name = {d.name}, brand = {d.brand}");
                }
            }

            //lambda expression
            pro.ToList().Where(d => d.price > 500).ToList().ForEach(d => Console.WriteLine($"name = {d.name}, brand = {d.brand}"));

            //Linq Query
            var result = from d in pro
                         where d.price > 500
                         select d;
            result.ToList().ForEach(d => Console.WriteLine($"name = {d.name}, brand = {d.brand}"));



            Console.ReadLine();
        }
    }
}
