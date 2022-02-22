using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;

namespace VamsiClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            string choice;
            do
            {
                Console.WriteLine("************************************************");
                Console.WriteLine("Employee Management Application");
                Console.WriteLine("*************************************************");

                Console.WriteLine("1.Add Employee:");
                Console.WriteLine("2.Search EmployeeById:");
                Console.WriteLine("3.Search EmployeeByName:");
                Console.WriteLine("4.Display AllEmployees");
                Console.WriteLine("Enter Your Choice:");

                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        AddEmployee();
                        break;

                    case 2:
                        SearchEmployeeById();
                        break;

                    case 3:
                        SearchEmployeeByName();
                        break;
                    case 4:
                        DisplayAllEmployees();
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;

                }

                Console.WriteLine("Do You Want To Continue(Y/N):");
                choice = Console.ReadLine();

            } while (choice.Equals("Y"));
        }
        public static void AddEmployee()
        {
            int id, salary, age;
            string name;
            Console.WriteLine("Enter id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter salary:");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();

            //Call By Method
            var result = EmployeeBLL.AddEmployee(id, name, salary, age);
            if(result)
            {
                Console.WriteLine("Employee deatils saved successfully");
            }
            else
            {
                Console.WriteLine("Some error occured");
            }
        }

        public static void SearchEmployeeById()
        {
            int id;
            Console.WriteLine("Enter id:");
            id = Convert.ToInt32(Console.ReadLine());

            var result = EmployeeBLL.GetEmployeesById(id);
            if(result.Count == 0)
            {
                Console.WriteLine("No records exit with this id");
            }
            else
            {
                result.ForEach(p => Console.WriteLine(p));
            }
        }

        public static void SearchEmployeeByName()
        {
            string name;
            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();
            var result = EmployeeBLL.GetEmployeesByName(name);
            if (result.Count == 0)
            {
                Console.WriteLine("No records exit with this name");
            }
            else
            {
                result.ForEach(p => Console.WriteLine(p)); 
            }
        }

        public static void DisplayAllEmployees()
        {
            var employees = EmployeeBLL.GetAllEmployees();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
