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
    class FacultateDAL
    {
        internal List<Facultate> ToateFacultatile()
        {
            using (SqlConnection connection = DALHelper.Connection)
            {
                string sql = @"select ID, Nume from dbo.Facultate;";
                return connection.Query<Facultate>(sql).ToList();
            }
        }

        internal int AdaugareFacultate(Facultate facultate)
        {
            string sql = @"insert into dbo.Facultate (Nume)
                            values (@Nume);";
            using (SqlConnection connection = DALHelper.Connection)
            {
                return connection.Execute(sql, facultate);
            }
        }


        internal int ModificareFacultate(Facultate facultate)
        {
            string sql = @"update dbo.Facultate
                            set Nume = @Nume
                            where ID = @ID);";

            using (SqlConnection connection = DALHelper.Connection)
            {
                return connection.Execute(sql, facultate);
            }
        }

        internal void StergeFacultate(Facultate facultate)
        {
            using (SqlConnection sc = DALHelper.Connection)
            using (var cmd = sc.CreateCommand())
            {
                sc.Open();
                cmd.CommandText = "DELETE FROM dbo.Facultate WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", facultate.ID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
