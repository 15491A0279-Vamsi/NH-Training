using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Classes
{
    internal class Seller
    {
        private int sellerId;
        private string sellerName;
        private string sellerProduct;


        public void ReadSeller()
        {
            Console.WriteLine("Enter Seller id:");
            sellerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Seller name:");
            sellerName = Console.ReadLine();

            Console.WriteLine("enter seller product");
            sellerProduct = Console.ReadLine();
        }

        public void WriteSeller()
        {
            Console.WriteLine($"seller id = {sellerId}, seller name = {sellerName}, sellerProduct = {sellerProduct}");
        }

    }
}
