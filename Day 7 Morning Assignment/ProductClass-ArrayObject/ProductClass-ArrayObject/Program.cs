using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClass_ArrayObject
{
    class Product
    {
        public int id;
        public string name;
        public int price;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] pro = new Product[]
            {
                new Product() {id = 1, name = "Sai", price = 100},
                new Product() {id = 2, name = "Vamsi", price = 99},
                new Product() {id = 3, name = "Krishna", price = 88},
                new Product() {id = 4, name = "Pavan", price = 77},
                new Product() {id = 5, name = "Manoj", price = 66}
            };

            //for loop
            for (int i = 0; i < pro.Length; i++)
            {
                Console.WriteLine($"id = {pro[i].id}, name = {pro[i].name},  price= {pro[i].price}");
            }

            //foreach
            foreach (var p in pro)
            {
                Console.WriteLine($"id = {p.id}, name = {p.name}, price = {p.price}");
            }

            //lamda
            pro.ToList().ForEach(p => Console.WriteLine($"id = {p.id}, name = {p.name}, price = {p.price}"));

            Console.ReadLine();
        }
    }
}
