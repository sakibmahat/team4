using EmployeeMgmtSystem.DAL;
using EmployeeMgmtSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgmtSystem.BL
{
    public class GradeMasterBL
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

        public void DeleteGradeMaster(int id)
        {
            objGradeMasterDAL.DeleteGradeMaster(id);
        }

        public GradeMaster GetGradeMaster(int id)
        {
            GradeMaster objGradeMaster = objGradeMasterDAL.GetGradeMaster(id);
            return objGradeMaster;
        }

        public IEnumerable<GradeMaster> GetGradeMasters()
        {
            return objGradeMasterDAL.GetGradeMaster();
        }
    }
}
