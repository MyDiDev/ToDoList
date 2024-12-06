using Logic.Clases;

namespace ToDoList_Form.Interfaz
{
	public partial class AddForm : Form
	{
		public AddForm()
		{
			InitializeComponent();
		}

		private void addTask_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(descriptionBox.Text))
			{
				MessageBox.Show("Llena la entrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Tarea task = new Tarea(descriptionBox.Text);

			if (task.addTask() == true)
			{
				MessageBox.Show("Tarea agregada Exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
				return;
			}

		}

		private void iconButton2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
