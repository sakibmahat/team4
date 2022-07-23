using EmployeeMgmtSystem.DAL;
using EmployeeMgmtSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgmtSystem.BL
{
    public class gradeMasterBL
    {
        GradeMasterDAL objGradeMasterDAL = new GradeMasterDAL();

        public void CreateGradeMaster(GradeMaster objGradeMaster)
        {
            objGradeMasterDAL.CreateGradeMaster(objGradeMaster);
        }

        public void UpdateGradeMaster(GradeMaster objGradeMaster)
        {
            objGradeMasterDAL.UpdateGradeMaster(objGradeMaster);
        }

        public void DeleteGradeMaster(string gradeCode)
        {
            objGradeMasterDAL.DeleteGradeMaster(gradeCode);
        }

        public GradeMaster GetGradeMaster(string gradeCode)
        {
            GradeMaster objGradeMaster = objGradeMasterDAL.GetGradeMaster(gradeCode);
            return objGradeMaster;
        }

        public IEnumerable<GradeMaster> GetGradeMasters()
        {
            return objGradeMasterDAL.GetGradeMasters();
        }
    }
}
