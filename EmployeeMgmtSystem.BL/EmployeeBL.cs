using EmployeeMgmtSystem.DAL;
using EmployeeMgmtSystem.EFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgmtSystem.BL
{
    public class EmployeeBL
    {
        EmployeeDAL objEmployeeDAL = new EmployeeDAL();

        public void CreateEmployee(Employee objEmployee)
        {
            objEmployeeDAL.CreateEmployee(objEmployee);
        }

        public void UpdateEmployee(Employee objEmployee)
        {
            objEmployeeDAL.UpdateEmployee(objEmployee);
        }

        public void DeleteEmployee(string empId)
        {
            objEmployeeDAL.DeleteEmployee(empId);
        }

        public Employee GetEmployee(string empId)
        {
            Employee objEmployee = objEmployeeDAL.GetEmployee(empId);
            return objEmployee;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return objEmployeeDAL.GetEmployees();
        }

        //public object GetEmployee(string empId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
