using AplicatieCamin.Models.DataAccessLayer;
using AplicatieCamin.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCamin.Models.BusinessLogicLayer
{
    class PlataBLL
    {
        PlataDAL plataDAL = new PlataDAL();

        internal List<Plata> ToatePlatileUnuiStudent(Student student)
        {
            return plataDAL.ToatePlatileUnuiStudent(student);
        }

        internal void ModificaPlata(Plata plata)
        {
            plataDAL.ModificaPlata(plata);
        }
    }
}
