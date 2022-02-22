using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessesLibrary
{
    public  static  class EmployeeDal
    {
        public static   string Filepath = "C:\\Final project data\\Employee Data.txt";

        public  static bool AddEmployee(int empid, string empname, int empsalary, int empage)
        {
            try
            {
                string textcontent = string.Concat(empid, ",", empname, ",", empsalary, ",", empage, ",");
                File.AppendAllText(Filepath, textcontent +Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public  static List<string> GetEmployesById(int id)
        {
            var allEmployees = File.ReadAllLines(Filepath);
            bool isFound = false;
    
            List<String> employeeFound = new List<String>();

            foreach (string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (Convert.ToInt32(empDetails[0]) == id)
                {
                    isFound = true;
                    employeeFound.Add(employee);
                    break;
                }
            }
            return employeeFound;
        }
        public static  List<string> GetEmployesByName(String name)
        {
            var allEmployees = File.ReadAllLines(Filepath);
            
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
        public  static string[]   GetAllEmployees()
        {
            var allEmployees = File.ReadAllLines(Filepath);
            return allEmployees;
        }

    }
}           


          
   

    

