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

        public void CreateDepartment(Department objDepartment)
        {
            objDepartmentDAL.CreateDepartment(objDepartment);
        }

        public void UpdateDepartment(Department objDepartment)
        {
            objDepartmentDAL.UpdateDepartment(objDepartment);
        }

        public void DeleteDepartment(int id)
        {
            objDepartmentDAL.DeleteDepartment(id);
        }

        public Department GetDepartment(int id)
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
