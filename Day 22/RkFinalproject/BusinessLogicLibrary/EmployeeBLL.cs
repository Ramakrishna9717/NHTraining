using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessesLibrary;

namespace BusinessLogicLibrary
{
    public  class EmployeeBLL
    {
        public static bool AddEmployee(int empid, string empname, int empsalary, int empage)
        {
            // to Do validations

            //iF all validations are sucessful then call DAL
            var result = EmployeeDal.AddEmployee(empid, empname, empsalary, empage);
            return result;
        }

        public static List<string> GetEmployesById(int id)
        {
            var result = EmployeeDal.GetEmployesById(id);
            return result;
        }

        public static List<string> GetEmployesByName(String name)
        {
            var result = EmployeeDal.GetEmployesByName(name);
            return result;
        }

        public static String[] GetAllEmployees( )
        {
            var result = EmployeeDal.GetAllEmployees();
            return result;
               
        }

    }
}
