namespace ToDoList_Form.Interfaz
{
	partial class AddForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label2 = new Label();
			descriptionBox = new TextBox();
			label1 = new Label();
			addTask = new FontAwesome.Sharp.IconButton();
			panel1 = new Panel();
			iconButton2 = new FontAwesome.Sharp.IconButton();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Variable Display", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = SystemColors.ControlLightLight;
			label2.Location = new Point(153, 36);
			label2.Name = "label2";
			label2.Size = new Size(699, 106);
			label2.TabIndex = 2;
			label2.Text = "Agrega Una Tarea";
			// 
			// descriptionBox
			// 
			descriptionBox.Anchor = AnchorStyles.None;
			descriptionBox.BackColor = Color.FromArgb(35, 35, 35);
			descriptionBox.BorderStyle = BorderStyle.None;
			descriptionBox.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			descriptionBox.ForeColor = Color.White;
			descriptionBox.Location = new Point(180, 266);
			descriptionBox.Multiline = true;
			descriptionBox.Name = "descriptionBox";
			descriptionBox.Size = new Size(672, 227);
			descriptionBox.TabIndex = 3;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Variable Text Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(180, 191);
			label1.Name = "label1";
			label1.Size = new Size(365, 31);
			label1.TabIndex = 4;
			label1.Text = "Ingresa la descripcion de tu tarea:";
			// 
			// addTask
			// 
			addTask.Anchor = AnchorStyles.None;
			addTask.BackColor = Color.Green;
			addTask.Cursor = Cursors.Hand;
			addTask.FlatAppearance.BorderSize = 0;
			addTask.FlatStyle = FlatStyle.Flat;
			addTask.Font = new Font("Segoe UI Variable Text Semibold", 10.2F, FontStyle.Bold);
			addTask.ForeColor = SystemColors.Control;
			addTask.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
			addTask.IconColor = Color.White;
			addTask.IconFont = FontAwesome.Sharp.IconFont.Auto;
			addTask.IconSize = 35;
			addTask.ImageAlign = ContentAlignment.MiddleLeft;
			addTask.Location = new Point(189, 557);
			addTask.Name = "addTask";
			addTask.Size = new Size(317, 53);
			addTask.TabIndex = 5;
			addTask.Text = "Agregar";
			addTask.UseVisualStyleBackColor = false;
			addTask.Click += addTask_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(31, 31, 31);
			panel1.Controls.Add(iconButton2);
			panel1.Controls.Add(addTask);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(descriptionBox);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1024, 634);
			panel1.TabIndex = 6;
			// 
			// iconButton2
			// 
			iconButton2.Anchor = AnchorStyles.None;
			iconButton2.BackColor = Color.Red;
			iconButton2.Cursor = Cursors.Hand;
			iconButton2.FlatAppearance.BorderSize = 0;
			iconButton2.FlatStyle = FlatStyle.Flat;
			iconButton2.Font = new Font("Segoe UI Variable Text Semibold", 10.2F, FontStyle.Bold);
			iconButton2.ForeColor = SystemColors.Control;
			iconButton2.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
			iconButton2.IconColor = Color.White;
			iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconButton2.IconSize = 35;
			iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
			iconButton2.Location = new Point(527, 557);
			iconButton2.Name = "iconButton2";
			iconButton2.Size = new Size(325, 53);
			iconButton2.TabIndex = 8;
			iconButton2.Text = "Cancelar";
			iconButton2.UseVisualStyleBackColor = false;
			iconButton2.Click += iconButton2_Click;
			// 
			// AddForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(37, 37, 37);
			ClientSize = new Size(1024, 634);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "AddForm";
			Text = "AddForm";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label2;
		private TextBox descriptionBox;
		private Label label1;
		private FontAwesome.Sharp.IconButton addTask;
		private Panel panel1;
		private FontAwesome.Sharp.IconButton iconButton2;
	}
}