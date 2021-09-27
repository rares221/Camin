using AplicatieCamin.Models.EntityLayer;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCamin.Models.DataAccessLayer
{
    class TipTaxaDAL
    {
        internal List<TipTaxa> ToateTipurileDeTaxa()
        {
            using (SqlConnection connection = DALHelper.Connection)
            {
                string sql = @"select ID, Nume from dbo.TipTaxa;";
                return connection.Query<TipTaxa>(sql).ToList();
            }
        }

        
    }
}
