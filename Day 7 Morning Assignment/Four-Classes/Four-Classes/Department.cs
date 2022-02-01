using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Classes
{
    internal class Department
    {
        private int departmentCode;
        private string departmentName;
        


        public void ReadDepartment()
        {
            Console.WriteLine("Enter department code:");
            departmentCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter department name:");
            departmentName = Console.ReadLine();

            
        }

        public void WriteDepartment()
        {
            Console.WriteLine($"department code = {departmentCode}, department name = {departmentName}");
        }
    }
}
