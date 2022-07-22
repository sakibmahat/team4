using EmployeeMgmtSystem.DAL;
using EmployeeMgmtSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgmtSystem.BL
{
    public class DepartmentBL
    {
        DepartmentDAL objDepartmentDAL = new DepartmentDAL();

        public void CreateEmployee(Department objEmployee)
        {
            objDepartmentDAL.CreateDepartment(objEmployee);
        }

        public void UpdateEmployee(Department objEmployee)
        {
            objDepartmentDAL.UpdateDepartment(objEmployee);
        }

        public void DeleteEmployee(int id)
        {
            objDepartmentDAL.DeleteDepartment(id);
        }

        public Department GetEmployee(int id)
        {
            Department objDepartment = objDepartmentDAL.GetDepartment(id);
            return objDepartment;
        }

        public IEnumerable<Department> GetDepartments()
        {
            return objDepartmentDAL.GetDepartment();
        }
    }
}
