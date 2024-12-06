namespace ToDoList_Form
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			panel1 = new Panel();
			label1 = new Label();
			panel2 = new Panel();
			iconButton4 = new FontAwesome.Sharp.IconButton();
			iconButton3 = new FontAwesome.Sharp.IconButton();
			iconButton2 = new FontAwesome.Sharp.IconButton();
			iconButton1 = new FontAwesome.Sharp.IconButton();
			dataGridTarea = new DataGridView();
			label2 = new Label();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridTarea).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(37, 37, 37);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(181, 681);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Variable Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.ControlLightLight;
			label1.Location = new Point(12, 297);
			label1.Name = "label1";
			label1.Size = new Size(152, 37);
			label1.TabIndex = 0;
			label1.Text = "To-Do-List";
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(31, 31, 31);
			panel2.Controls.Add(iconButton4);
			panel2.Controls.Add(iconButton3);
			panel2.Controls.Add(iconButton2);
			panel2.Controls.Add(iconButton1);
			panel2.Controls.Add(dataGridTarea);
			panel2.Controls.Add(label2);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(181, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(1042, 681);
			panel2.TabIndex = 1;
			// 
			// iconButton4
			// 
			iconButton4.Anchor = AnchorStyles.None;
			iconButton4.BackColor = Color.FromArgb(37, 37, 37);
			iconButton4.Cursor = Cursors.Hand;
			iconButton4.FlatAppearance.BorderSize = 0;
			iconButton4.FlatStyle = FlatStyle.Flat;
			iconButton4.Font = new Font("Segoe UI Variable Text Semibold", 10.2F, FontStyle.Bold);
			iconButton4.ForeColor = SystemColors.Control;
			iconButton4.IconChar = FontAwesome.Sharp.IconChar.Refresh;
			iconButton4.IconColor = Color.White;
			iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconButton4.IconSize = 35;
			iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
			iconButton4.Location = new Point(831, 594);
			iconButton4.Name = "iconButton4";
			iconButton4.Size = new Size(188, 53);
			iconButton4.TabIndex = 6;
			iconButton4.Text = "Refrescar";
			iconButton4.UseVisualStyleBackColor = false;
			iconButton4.Click += iconButton4_Click;
			// 
			// iconButton3
			// 
			iconButton3.Anchor = AnchorStyles.None;
			iconButton3.BackColor = Color.FromArgb(37, 37, 37);
			iconButton3.Cursor = Cursors.Hand;
			iconButton3.FlatAppearance.BorderSize = 0;
			iconButton3.FlatStyle = FlatStyle.Flat;
			iconButton3.Font = new Font("Segoe UI Variable Text Semibold", 10.2F, FontStyle.Bold);
			iconButton3.ForeColor = SystemColors.Control;
			iconButton3.IconChar = FontAwesome.Sharp.IconChar.Edit;
			iconButton3.IconColor = Color.White;
			iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconButton3.IconSize = 35;
			iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
			iconButton3.Location = new Point(573, 594);
			iconButton3.Name = "iconButton3";
			iconButton3.Size = new Size(188, 53);
			iconButton3.TabIndex = 5;
			iconButton3.Text = "Editar";
			iconButton3.UseVisualStyleBackColor = false;
			iconButton3.Click += iconButton3_Click;
			// 
			// iconButton2
			// 
			iconButton2.Anchor = AnchorStyles.None;
			iconButton2.BackColor = Color.FromArgb(37, 37, 37);
			iconButton2.Cursor = Cursors.Hand;
			iconButton2.FlatAppearance.BorderSize = 0;
			iconButton2.FlatStyle = FlatStyle.Flat;
			iconButton2.Font = new Font("Segoe UI Variable Text Semibold", 10.2F, FontStyle.Bold);
			iconButton2.ForeColor = SystemColors.Control;
			iconButton2.IconChar = FontAwesome.Sharp.IconChar.X;
			iconButton2.IconColor = Color.White;
			iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconButton2.IconSize = 35;
			iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
			iconButton2.Location = new Point(299, 594);
			iconButton2.Name = "iconButton2";
			iconButton2.Size = new Size(188, 53);
			iconButton2.TabIndex = 4;
			iconButton2.Text = "Eliminar";
			iconButton2.UseVisualStyleBackColor = false;
			iconButton2.Click += iconButton2_Click;
			// 
			// iconButton1
			// 
			iconButton1.Anchor = AnchorStyles.None;
			iconButton1.BackColor = Color.FromArgb(37, 37, 37);
			iconButton1.Cursor = Cursors.Hand;
			iconButton1.FlatAppearance.BorderSize = 0;
			iconButton1.FlatStyle = FlatStyle.Flat;
			iconButton1.Font = new Font("Segoe UI Variable Text Semibold", 10.2F, FontStyle.Bold);
			iconButton1.ForeColor = SystemColors.Control;
			iconButton1.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
			iconButton1.IconColor = Color.White;
			iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconButton1.IconSize = 35;
			iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
			iconButton1.Location = new Point(26, 594);
			iconButton1.Name = "iconButton1";
			iconButton1.Size = new Size(188, 53);
			iconButton1.TabIndex = 3;
			iconButton1.Text = "Agregar";
			iconButton1.UseVisualStyleBackColor = false;
			iconButton1.Click += iconButton1_Click;
			// 
			// dataGridTarea
			// 
			dataGridViewCellStyle1.BackColor = SystemColors.Desktop;
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDarkDark;
			dataGridViewCellStyle1.SelectionForeColor = Color.White;
			dataGridTarea.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridTarea.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			dataGridTarea.BackgroundColor = Color.FromArgb(31, 31, 31);
			dataGridTarea.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Desktop;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle2.ForeColor = SystemColors.Window;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDarkDark;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			dataGridTarea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridTarea.ColumnHeadersHeight = 30;
			dataGridTarea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 37, 37);
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle3.ForeColor = Color.White;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(31, 31, 31);
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			dataGridTarea.DefaultCellStyle = dataGridViewCellStyle3;
			dataGridTarea.EnableHeadersVisualStyles = false;
			dataGridTarea.GridColor = Color.FromArgb(37, 37, 37);
			dataGridTarea.Location = new Point(34, 144);
			dataGridTarea.Name = "dataGridTarea";
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 37, 37);
			dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle4.ForeColor = SystemColors.Window;
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(40, 40, 40);
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			dataGridTarea.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridTarea.RowHeadersWidth = 51;
			dataGridViewCellStyle5.BackColor = Color.FromArgb(37, 37, 37);
			dataGridViewCellStyle5.ForeColor = Color.White;
			dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(30, 30, 30);
			dataGridViewCellStyle5.SelectionForeColor = Color.White;
			dataGridTarea.RowsDefaultCellStyle = dataGridViewCellStyle5;
			dataGridTarea.Size = new Size(985, 423);
			dataGridTarea.TabIndex = 2;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Variable Display", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = SystemColors.ControlLightLight;
			label2.Location = new Point(228, 0);
			label2.Name = "label2";
			label2.Size = new Size(583, 106);
			label2.TabIndex = 1;
			label2.Text = "Lista de Tareas";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1223, 681);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "Form1";
			Text = "MANEJO DE TAREAS";
			Load += Form1_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridTarea).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Label label1;
		private FontAwesome.Sharp.IconButton iconButton3;
		private FontAwesome.Sharp.IconButton iconButton2;
		private FontAwesome.Sharp.IconButton iconButton1;
		private DataGridView dataGridTarea;
		private Label label2;
		private FontAwesome.Sharp.IconButton iconButton4;
	}
}
