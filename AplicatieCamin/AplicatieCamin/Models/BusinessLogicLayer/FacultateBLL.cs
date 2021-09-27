using AplicatieCamin.Models.DataAccessLayer;
using AplicatieCamin.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCamin.Models.BusinessLogicLayer
{
    class FacultateBLL
    {
        FacultateDAL facultateDAL = new FacultateDAL();

        internal List<Facultate> ToateFacultatile()
        {
            return facultateDAL.ToateFacultatile();
        }

        internal void AdaugareFacultate(Facultate facultate)
        {
            facultateDAL.AdaugareFacultate(facultate);
        }

        internal void ModificareFacultate(Facultate facultate)
        {
            facultateDAL.ModificareFacultate(facultate);
        }

        internal void StergeFacultate(Facultate facultate)
        {
            facultateDAL.StergeFacultate(facultate);
        }
    }
}
