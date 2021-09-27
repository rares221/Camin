using AplicatieCamin.Models.DataAccessLayer;
using AplicatieCamin.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCamin.Models.BusinessLogicLayer
{
    class TipTaxaBLL
    {
        TipTaxaDAL tipTaxaDAL;

        public TipTaxaBLL()
        {
            tipTaxaDAL = new TipTaxaDAL();
        }

        internal List<TipTaxa> ToateTipurileDeTaxa()
        {
            return tipTaxaDAL.ToateTipurileDeTaxa();
        }
    }
}
