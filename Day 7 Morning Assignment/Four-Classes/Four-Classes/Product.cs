using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Classes
{
    internal class Product
    {
        private int productId;
        private string productName;
        private string productDescription;


        public void ReadProduct()
        {
            Console.WriteLine("Enter Product id:");
            productId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter product name:");
            productName = Console.ReadLine();

            Console.WriteLine("enter product description");
            productDescription = Console.ReadLine();
        }

        public void WriteProduct()
        {
            Console.WriteLine($"procuct id = {productId}, product name = {productName}, product description = {productDescription}");
        }

        
    }
}
