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
    class CaminDAL
    {
        internal List<Camin> ToateCaminele()
        {
            using (SqlConnection connection = DALHelper.Connection)
            {
                string sql = @"select ID, Numar, Taxa from dbo.Camin;";
                return connection.Query<Camin>(sql).ToList();
            }
        }

        internal int AdaugareCamin(Camin camin)
        {
            string sql = @"insert into dbo.Camin (Numar, Taxa)
                            values (@Numar, @Taxa);";
            using (SqlConnection connection = DALHelper.Connection)
            {
                return connection.Execute(sql, camin);
            }
        }


        internal int ModificareCamin(Camin camin)
        {
            string sql = @"update dbo.Camin
                            set Numar = @Numar, Taxa = @Taxa
                            where ID = @ID;";

            using (SqlConnection connection = DALHelper.Connection)
            {
                return connection.Execute(sql, camin);
            }
        }

        internal void StergeCamin(Camin camin)
        {
            using (SqlConnection sc = DALHelper.Connection)
            using (var cmd = sc.CreateCommand())
            {
                sc.Open();
                cmd.CommandText = "DELETE FROM dbo.Camin WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", camin.ID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
