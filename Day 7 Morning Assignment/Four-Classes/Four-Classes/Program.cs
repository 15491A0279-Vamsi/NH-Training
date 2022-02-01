using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Classes
{
    class Customer
    {
        private int customerId;
        private string customerName;
        private string customerMobile;

        public void ReadCustomer()
        {
            Console.WriteLine("Enter CustomerId:");
            customerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter customername:");
            customerName = Console.ReadLine();

            Console.WriteLine("Enter customerMobile:");
            customerMobile = Console.ReadLine();

        }

        public void WriteCustomer()
        {
            Console.WriteLine($"Id = {customerId}, Name = {customerName}, customerMobile = {customerMobile}");
        }
    }

    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cum = new Customer();
            cum.ReadCustomer();
            cum.WriteCustomer();

            Product pro = new Product();
            pro.ReadProduct();
            pro.WriteProduct();

            Seller sel = new Seller();
            sel.ReadSeller();
            sel.WriteSeller();

            Department depart = new Department();
            depart.ReadDepartment();
            depart.WriteDepartment();

            Console.ReadLine();
        }
    }
}
