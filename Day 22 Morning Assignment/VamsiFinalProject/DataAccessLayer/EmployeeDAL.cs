using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataAccessLayer
{
    public static class EmployeeDAL
    {
        public static string filePath = "E:\\Files\\Employees.txt";
        public static bool AddEmployee(int empId,string empName,int empSalary, int empAge)
        {
            try
            {
                string textContent = string.Concat(empId, ",", empName, ",", empSalary, ",", empAge);
                File.AppendAllText(filePath, textContent + Environment.NewLine);
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public static List<String> GetEmployeesById(int id)
        {
            var allEmployees = File.ReadAllLines(filePath);
            bool isFound = false;
            List<String> employeeFound = new List<String>();

            foreach(string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if(Convert.ToInt32(empDetails[0]) == id)
                {
                    isFound = true;
                    employeeFound .Add(employee);
                    break;
                }
            }
            return employeeFound;
        }

        public static List<String> GetEmployeesByName(string name)
        {
            var allEmployees = File.ReadAllLines(filePath);
            bool isFound = false;
            List<String> employeeFound = new List<String>();

            foreach (string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (empDetails[1].Contains(name))
                {
                    employeeFound.Add(employee);
                }
            }
            return employeeFound;
        }

        public static string[] GetAllEmployees()
        {
            var allEmployees = File.ReadAllLines(filePath);
            return allEmployees;
        }

        

    }
}
