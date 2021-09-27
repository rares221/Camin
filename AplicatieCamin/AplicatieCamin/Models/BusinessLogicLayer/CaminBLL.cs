using AplicatieCamin.Models.DataAccessLayer;
using AplicatieCamin.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCamin.Models.BusinessLogicLayer
{
    class CaminBLL
    {
        CaminDAL caminDAL = new CaminDAL();

        internal List<Camin> ToateCaminele()
        {
            return caminDAL.ToateCaminele();
        }

        internal void AdaugareCamin(Camin camin)
        {
            caminDAL.AdaugareCamin(camin);
        }

        internal void ModificareCamin(Camin camin)
        {
            caminDAL.ModificareCamin(camin);
        }

        internal void StergeCamin(Camin camin)
        {
            caminDAL.StergeCamin(camin);
        }
    }
}
