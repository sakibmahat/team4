using EmployeeMgmtSystem.DAL;
using EmployeeMgmtSystem.EFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgmtSystem.BL
{
    public class EmployeeBAL
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

        public void DeleteEmployee(int id)
        {
            objEmployeeDAL.DeleteEmployee(id);
        }

        public Employee GetEmployee(int id)
        {
            Employee objEmployee = objEmployeeDAL.GetEmployee(id);
            return objEmployee;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return objEmployeeDAL.GetEmployees();
        }
    }
}
