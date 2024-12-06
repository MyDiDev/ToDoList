using System.Data;
using Npgsql;

namespace Datos.datos
{
    public class connection
    {
        public connection() {}


        public DataTable getTaskData()
        {
			DataTable dataTable = new DataTable();

			try
			{
				string connectionString = "Host=localhost;Username=postgres;Password=yiqZS(i;Database=Tareas";

				using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
				{
					conn.Open();
					using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM tareas;", conn))
					{
						using (NpgsqlDataReader reader = cmd.ExecuteReader())
						{
							dataTable.Load(reader);	
						}
					}
				}

			}
			catch (Exception ex)
			{
				throw ex;
			}

			return dataTable;
		}

		public bool addNewTask(string description)
		{
			try
			{
				string connectionString = "Host=localhost;Username=postgres;Password=yiqZS(i;Database=Tareas";

				using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
				{
					conn.Open();
					NpgsqlCommand cmd = new NpgsqlCommand($"INSERT INTO tareas (DESCRIPCION) VALUES('{description}');", conn);
					cmd.ExecuteNonQuery();
					return true;
				}

			}
			catch (Exception ex)
			{
				throw ex;
			}

		}

		public bool editTask(int id, string descripcion)
		{
			try
			{
				string connectionString = "Host=localhost;Username=postgres;Password=yiqZS(i;Database=Tareas";

				using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
				{
					conn.Open();
					NpgsqlCommand cmd = new NpgsqlCommand($"UPDATE tareas SET DESCRIPCION='{descripcion}' WHERE ID_TAREA={id};", conn);
					cmd.ExecuteNonQuery();
					return true;
				}

			}
			catch (Exception ex)
			{
				throw ex;
			}

		}

		public bool DeleteTask(int id)
		{
			try
			{
				string connectionString = "Host=localhost;Username=postgres;Password=yiqZS(i;Database=Tareas";

				using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
				{
					conn.Open();
					NpgsqlCommand cmd = new NpgsqlCommand($"DELETE FROM tareas WHERE ID_TAREA={id};", conn);
					cmd.ExecuteNonQuery();
					return true;
				}

			}
			catch (Exception ex)
			{
				throw ex;
			}

		}
	}

	public class TaskInfo()
	{
		public int Id;
		public string Description;
		public string Date;
	}
}
