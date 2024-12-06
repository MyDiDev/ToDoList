using Logic.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList_Form.Interfaz
{
	public partial class EditForm : Form
	{
		public EditForm()
		{
			InitializeComponent();
		}

		public int Id;
		public string descripcion;

		private void iconButton1_Click(object sender, EventArgs e)
		{
			Tarea task = new Tarea(descriptionBox.Text);

			if (string.IsNullOrEmpty(descriptionBox.Text))
			{
				MessageBox.Show("Llena la entrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (descriptionBox.Text == descripcion)
			{
				Close();
				return;
			}

			if (task.EditTask(Id, descripcion) == true)
			{
				MessageBox.Show("Tarea editada Exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
				return;
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void EditForm_Load(object sender, EventArgs e)
		{
			descriptionBox.Text = descripcion;
		}

		private void iconButton2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
