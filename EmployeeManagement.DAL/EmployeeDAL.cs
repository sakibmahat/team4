using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.EFCore.Models;
using EmployeeManagement.Entities;
using Microsoft.EntityFrameworkCore;



namespace EmployeeManagement.DAL
{
    public class EmployeeDAL
    {
        EmployeeManagementContext objEmployeeManagementContext = new EmployeeManagementContext();

        public void CreateEmployee(Employee objEmployee)
        {
            objEmployeeManagementContext.Add(objEmployee);
            objEmployeeManagementContext.SaveChanges();
        }


        public void UpdateEmployee(Employee objEmployee)
        {
            objEmployeeManagementContext.Entry(objEmployee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            objEmployeeManagementContext.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            Employee objEmployee = objEmployeeManagementContext.Find(id);
            objEmployeeManagementContext.Remove(objEmployee);
            objEmployeeManagementContext.SaveChanges();
        }
        public Employee GetEmployee(int id)
        {
            Employee objEmployee = objEmployeeManagementContext.Employees.Find(id);
            return objEmployee;
        }
        public IEnumerable<Employee> GetEmployee()
        {
            return objEmployeeManagementContext.Employees;
        }
    }
}
