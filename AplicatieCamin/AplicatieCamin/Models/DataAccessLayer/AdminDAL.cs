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
    class AdminDAL
    {
        internal List<Admin> ToatiAdministratorii()
        {
            using (SqlConnection connection = DALHelper.Connection)
            {
                string sql = @"select ID, NumeUtilizator, Parola from dbo.Admin;";
                return connection.Query<Admin>(sql).ToList();
            }
        }
    }
}
