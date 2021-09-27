using AplicatieCamin.Models.DataAccessLayer;
using AplicatieCamin.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCamin.Models.BusinessLogicLayer
{
    class AdminBLL
    {
        AdminDAL adminDAL;
        public AdminBLL()
        {
            adminDAL = new AdminDAL();
        }

        internal List<Admin> ToatiAdministratorii()
        {
            return adminDAL.ToatiAdministratorii();
        }
    }
}
