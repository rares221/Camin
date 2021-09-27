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
    class PlataDAL
    {
        internal List<Plata> ToatePlatileUnuiStudent(Student student)
        {
            List<Plata> plati = new List<Plata>();
            using (SqlConnection sc = DALHelper.Connection)
            using (var cmd = sc.CreateCommand())
            {
                sc.Open();
                cmd.CommandText = "select ID, Suma, Luna, IDStudent, Platita from dbo.Plata where IDStudent = @IDStudent";
                cmd.Parameters.AddWithValue("@IDStudent", student.ID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Plata plata = new Plata()
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Suma = (float)Convert.ToDouble(reader["Suma"]),
                            Luna = Convert.ToString(reader["Luna"]),
                            IDStudent = Convert.ToInt32(reader["IDStudent"]),
                            Platita = Convert.ToBoolean(reader["Platita"])
                        };
                        

                        plati.Add(plata);
                    }
                }
            }

            return plati;
        }

        internal int ModificaPlata(Plata plata)
        {
            string sql = @"update dbo.Plata
                            set Suma = @Suma, Luna = @Luna, IDStudent = @IDStudent, Platita = @Platita
                            where ID = @ID;";

            using (SqlConnection connection = DALHelper.Connection)
            {
                return connection.Execute(sql, plata);
            }
        }

    }
}
