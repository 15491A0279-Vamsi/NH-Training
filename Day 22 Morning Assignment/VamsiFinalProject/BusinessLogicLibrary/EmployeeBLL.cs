using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLibrary
{
    public class EmployeeBLL
    {
        public static bool AddEmployee(int empId, string empName, int empSalary, int empAge)
        {
            //To Do Add Validations

            //If all validations are successful then call DAL

            var result = EmployeeDAL.AddEmployee(empId, empName, empSalary, empAge);
            return result;
        }
        public static List<String> GetEmployeesById(int id)
        {
            var result = EmployeeDAL.GetEmployeesById(id);
            return result;
        }

        public static List<String> GetEmployeesByName(string name)
        {
            var result = EmployeeDAL.GetEmployeesByName(name);
            return result;
        }

        public static string[] GetAllEmployees()
        {
            var result = EmployeeDAL.GetAllEmployees();
            return result;
        }


    }
}
