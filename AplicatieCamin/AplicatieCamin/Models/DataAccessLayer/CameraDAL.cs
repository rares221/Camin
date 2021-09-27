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
    class CameraDAL
    {
        internal List<Camera> ToateCamereleUnuiCamin(Camin camin)
        {
            List<Camera> camere = new List<Camera>();
            using (SqlConnection sc = DALHelper.Connection)
            using (var cmd = sc.CreateCommand())
            {
                sc.Open();
                cmd.CommandText = "select ID, Numar, IDCamin from dbo.Camera where IDCamin = @ID";
                cmd.Parameters.AddWithValue("@ID", camin.ID);
                //cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Camera camera = new Camera()
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Numar = Convert.ToInt32(reader["Numar"]),
                            IDCamin = Convert.ToInt32(reader["IDCamin"])
                        };

                        camere.Add(camera);
                    }
                }
            }

            return camere;
        }

        internal int AdaugareCamera(Camera camera)
        {
            string sql = @"insert into dbo.Camera (Numar, IDCamin)
                            values (@Numar, @IDCamin);";
            using (SqlConnection connection = DALHelper.Connection)
            {
                return connection.Execute(sql, camera);
            }
        }


        internal int ModificareCamera(Camera camera)
        {
            string sql = @"update dbo.Camera
                            set Numar = @Numar, IDCamin = @IDCamin
                            where ID = @ID;";

            using (SqlConnection connection = DALHelper.Connection)
            {
                return connection.Execute(sql, camera);
            }
        }

        internal void StergeCamera(Camera camera)
        {
            using (SqlConnection sc = DALHelper.Connection)
            using (var cmd = sc.CreateCommand())
            {
                sc.Open();
                cmd.CommandText = "DELETE FROM dbo.Camera WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", camera.ID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
