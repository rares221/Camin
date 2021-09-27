using AplicatieCamin.Models.BusinessLogicLayer;
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
	class StudentDAL
	{
		internal List<Student> TotiStudentii()
		{
			using (SqlConnection connection = DALHelper.Connection)
			{
				string sql = @"select s.ID, s.Nume, s.Prenume, s.CNP, f.Nume as Facultate, t.Nume as TipTaxa, ca.Numar as Camin, c.Numar as Camera  from dbo.Student s
								inner join Facultate f on f.ID = s.IDFacultate
								inner join TipTaxa t on t.ID = s.IDTipTaxa
								inner join Camera c on c.ID = s.IDCamera
								inner join Camin ca on ca.ID = c.IDCamin

							union

								select s.ID, s.Nume, s.Prenume, s.CNP, f.Nume as Facultate, t.Nume as TipTaxa, NULL as Camin, NULL as Camera  from dbo.Student s
								inner join Facultate f on f.ID = s.IDFacultate
								inner join TipTaxa t on t.ID = s.IDTipTaxa
								where s.IDCamera IS NULL;";
				return connection.Query<Student>(sql).ToList();
			}
		}

		internal List<Student> TotiStudentiiUneiCamere(Camera camera)
		{
			List<Student> studenti = new List<Student>();
			using (SqlConnection sc = DALHelper.Connection)
			using (var cmd = sc.CreateCommand())
			{
				sc.Open();
				cmd.CommandText = @"select s.ID as ID, s.Nume as Nume, s.Prenume as Prenume, s.CNP as CNP, f.Nume as Facultate, t.Nume as TipTaxa, ca.Numar as Camin, c.Numar as Camera  from dbo.Student s 
								inner join Facultate f on f.ID = s.IDFacultate
								inner join TipTaxa t on t.ID = s.IDTipTaxa
								inner join Camera c on c.ID = s.IDCamera
								inner join Camin ca on ca.ID = c.IDCamin 
								where c.ID = @ID";
				cmd.Parameters.AddWithValue("@ID", camera.ID);

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						Student student = new Student()
						{
							ID = Convert.ToInt32(reader["ID"]),
							Nume = Convert.ToString(reader["Nume"]),
							Prenume = Convert.ToString(reader["Prenume"]),
							CNP = Convert.ToString(reader["CNP"]),
							Facultate = Convert.ToString(reader["Facultate"]),
							TipTaxa = Convert.ToString(reader["TipTaxa"]),
							Camera = Convert.ToInt32(reader["Camera"]),
							Camin = Convert.ToInt32(reader["Camin"])
						};
						studenti.Add(student);
					}
				}
			}

			return studenti;
		}

		internal List<Student> TotiStudentiiFaraCamera()
		{
			List<Student> studenti = new List<Student>();
			string sql = @"select s.ID, s.Nume, s.Prenume, s.CNP, f.Nume as Facultate, t.Nume as TipTaxa, NULL as Camin, NULL as Camera  from dbo.Student s
								inner join Facultate f on f.ID = s.IDFacultate
								inner join TipTaxa t on t.ID = s.IDTipTaxa
								where s.IDCamera IS NULL";
			using (SqlConnection connection = DALHelper.Connection)
			{
				return connection.Query<Student>(sql).ToList();
			}
			
		}

		internal void AdaugaStudent(Student student)
		{
			int idFacultate=0;
			int idTipTaxa=0;

			using (SqlConnection sc = DALHelper.Connection)
			using (var cmd = sc.CreateCommand())
			{
				sc.Open();
				cmd.CommandText = "select ID from dbo.Facultate where Nume = @Facultate";
				cmd.Parameters.AddWithValue("@Facultate", student.Facultate);

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						idFacultate = Convert.ToInt32(reader["ID"]);
					}
				}
			}

			using (SqlConnection sc = DALHelper.Connection)
			using (var cmd = sc.CreateCommand())
			{
				sc.Open();
				cmd.CommandText = "select ID from dbo.TipTaxa where Nume = @TipTaxa";
				cmd.Parameters.AddWithValue("@TipTaxa", student.TipTaxa);

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						idTipTaxa = Convert.ToInt32(reader["ID"]);
					}
				}
			}

			using (SqlConnection sc = DALHelper.Connection)
			using (var cmd = sc.CreateCommand())
			{
				sc.Open();
				cmd.CommandText = @"insert into dbo.Student (Nume, Prenume, CNP, IDFacultate, IDTipTaxa)
							values (@Nume, @Prenume, @CNP, @IDFacultate, @IDTipTaxa);";
				cmd.Parameters.AddWithValue("@Nume", student.Nume);
				cmd.Parameters.AddWithValue("@Prenume", student.Prenume);
				cmd.Parameters.AddWithValue("@CNP", student.CNP);
				cmd.Parameters.AddWithValue("@IDFacultate", idFacultate);
				cmd.Parameters.AddWithValue("@IDTipTaxa", idTipTaxa);

				cmd.ExecuteNonQuery();
			}
		}


		internal void ModificareStudent(Student student)
		{
			int idFacultate = 0;
			int idTipTaxa = 0;

			using (SqlConnection sc = DALHelper.Connection)
			using (var cmd = sc.CreateCommand())
			{
				sc.Open();
				cmd.CommandText = "select ID from dbo.Facultate where Nume = @Facultate";
				cmd.Parameters.AddWithValue("@Facultate", student.Facultate);

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						idFacultate = Convert.ToInt32(reader["ID"]);
					}
				}
			}

			using (SqlConnection sc = DALHelper.Connection)
			using (var cmd = sc.CreateCommand())
			{
				sc.Open();
				cmd.CommandText = "select ID from dbo.TipTaxa where Nume = @TipTaxa";
				cmd.Parameters.AddWithValue("@TipTaxa", student.TipTaxa);

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						idTipTaxa = Convert.ToInt32(reader["ID"]);
					}
				}
			}

			using (SqlConnection sc = DALHelper.Connection)
			using (var cmd = sc.CreateCommand())
			{
				sc.Open();
				cmd.CommandText = @"update dbo.Student
							set Nume = @Nume, Prenume = @Prenume, CNP = @CNP, IDFacultate = @IDFacultate, IDTipTaxa = @IDTipTaxa, IDCamera = @IDCamera
							where ID = @ID";
				cmd.Parameters.AddWithValue("@ID", student.ID);
				cmd.Parameters.AddWithValue("@Nume", student.Nume);
				cmd.Parameters.AddWithValue("@Prenume", student.Prenume);
				cmd.Parameters.AddWithValue("@CNP", student.CNP);
				cmd.Parameters.AddWithValue("@IDFacultate", idFacultate);
				cmd.Parameters.AddWithValue("@IDTipTaxa", idTipTaxa);

				if(student.Camin == null)
				{
					cmd.Parameters.AddWithValue("@IDCamera", DBNull.Value);
				}
				else
				{
					Camin caminulStudentului = new Camin();
					Camera cameraStudentului = new Camera();
					CaminBLL caminBLL = new CaminBLL();
					CameraBLL cameraBLL = new CameraBLL();
					List<Camin> camine = caminBLL.ToateCaminele();
					foreach (Camin camin in camine)
					{
						if(camin.Numar == student.Camin)
						{
							caminulStudentului = camin;

						}
					}
					List<Camera> camere = cameraBLL.ToateCamereleUnuiCamin(caminulStudentului);
					foreach (Camera camera in camere)
					{
						if (camera.Numar == student.Camera)
						{
							cameraStudentului = camera;
							cmd.Parameters.AddWithValue("@IDCamera", camera.ID);

						}
					}
				}

				cmd.ExecuteNonQuery();
			}
		}

		internal void StergeStudent(Student student)
		{
			using (SqlConnection sc = DALHelper.Connection)
			using (var cmd = sc.CreateCommand())
			{
				sc.Open();
				cmd.CommandText = "DELETE FROM dbo.Student WHERE ID = @ID";
				cmd.Parameters.AddWithValue("@ID", student.ID);
				cmd.ExecuteNonQuery();
			}
		}
	}
}
