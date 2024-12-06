using Datos.datos;
using System.Data;

namespace Logic.Clases
{
    public class Tarea
    {
        public string Descripcion;

        public Tarea(string descripcion)
        {
            Descripcion = descripcion;
        }

        public connection connection = new connection();

        public DataTable getData() {
            return connection.getTaskData();
        }
        
        public bool addTask() {
            return connection.addNewTask(Descripcion);
        }

		public bool EditTask(int Id, string description)
		{
			return connection.editTask(Id, Descripcion);
		}

		public bool deleteTask(int Id)
		{
			return connection.DeleteTask(Id);
		}
	}
}
