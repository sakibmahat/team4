using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.EFCore.Models;
using EmployeeManagement.Entities;

using EmployeeManagement.DAL;



namespace EmployeeManagement.DAL
{
    public class GradeMasterDAL
    {
        EmployeeManagementContext objEmployeeManagementContext = new EmployeeManagementContext();

        public void CreateGradeMaster(GradeMaster objGradeMaster)
        {
            objEmployeeManagementContext.Add(objGradeMaster);
            objEmployeeManagementContext.SaveChanges();
        }


        public void UpdateGradeMaster(GradeMaster objGradeMaster)
        {
            objEmployeeManagementContext.Entry(objGradeMaster).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            objEmployeeManagementContext.SaveChanges();
        }

        public void DeleteGradeMaster(int? id)
        {
            GradeMaster objGradeMaster = objEmployeeManagementContext.Find( id);
            objEmployeeManagementContext.Remove(objGradeMaster);
            objEmployeeManagementContext.SaveChanges();
        }
        public GradeMaster GetGradeMaster(int id)
        {
            GradeMaster objGradeMaster = objEmployeeManagementContext.GradeMasters.Find(id);
            return objGradeMaster;
        }
        public IEnumerable<GradeMaster> GetGradeMaster()
        {
            return objEmployeeManagementContext.GradeMasters;
        }
    }
}
