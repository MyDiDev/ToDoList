using Logic.Clases;
using System.Security.Cryptography;
using ToDoList_Form.Interfaz;

namespace ToDoList_Form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			MinimumSize = new Size(1241, 728);
		}

		public Form activeForm = null;
		private void OpenForm(Form form)
		{
			if (activeForm != null)
			{
				activeForm.Close();
				panel2.Controls.Remove(activeForm);
				activeForm.Dispose();
			}

			activeForm = form;
			form.TopLevel = false;
			form.FormBorderStyle = FormBorderStyle.None;
			form.Dock = DockStyle.Fill;
			panel1.Dock = DockStyle.Left;
			panel2.Controls.Add(form);
			panel2.Tag = form;
			form.BringToFront();
			form.Show();
		}

		private void Refresh()
		{
			Tarea task = new Tarea("");
			dataGridTarea.DataSource = task.getData();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Refresh();
		}

		private void iconButton1_Click(object sender, EventArgs e)
		{
			AddForm addForm = new AddForm();
			OpenForm(addForm);
			Refresh();
		}

		private void iconButton4_Click(object sender, EventArgs e)
		{
			Refresh();
		}

		private void iconButton3_Click(object sender, EventArgs e)
		{
			EditForm editForm = new EditForm();
			if (dataGridTarea.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dataGridTarea.SelectedRows[0];

				editForm.Id = Convert.ToInt32(selectedRow.Cells["id_tarea"].Value);
				editForm.descriptionBox.Text = Convert.ToString(selectedRow.Cells["descripcion"].Value);
			}
			else
			{
				MessageBox.Show("Seleccione un Identificador para editar la tarea", "ELIGA ID VALIDO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			OpenForm(editForm);
			Refresh();
		}

		private void iconButton2_Click(object sender, EventArgs e)
		{
			int Id = -1;

			if (dataGridTarea.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dataGridTarea.SelectedRows[0];

				Id = Convert.ToInt32(selectedRow.Cells["id_tarea"].Value);
			}
			else{
				MessageBox.Show("Seleccione un Identificador para editar la tarea", "ELIGA ID VALIDO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Tarea task = new Tarea("");
			DialogResult result = MessageBox.Show($"Seguro quieres eliminar el siguiente registro?: {Id}", "ELIGA ID VALIDO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			
			if (result == DialogResult.Yes)
			{
				if (task.deleteTask(Id) == true){
					MessageBox.Show("Tarea eliminada", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Refresh();
				}
				else{
					MessageBox.Show("No se pudo eliminar, itente nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
		}
	}
}
