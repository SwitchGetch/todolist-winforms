namespace todolist
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
			tableLayoutPanel1 = new TableLayoutPanel();
			checkedListBox1 = new CheckedListBox();
			button1 = new Button();
			button2 = new Button();
			textBox1 = new TextBox();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 10;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.Controls.Add(checkedListBox1, 2, 1);
			tableLayoutPanel1.Controls.Add(button1, 2, 8);
			tableLayoutPanel1.Controls.Add(button2, 6, 8);
			tableLayoutPanel1.Controls.Add(textBox1, 2, 6);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 10;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.Size = new Size(800, 450);
			tableLayoutPanel1.TabIndex = 0;
			tableLayoutPanel1.Click += tableLayoutPanel1_Click;
			// 
			// checkedListBox1
			// 
			tableLayoutPanel1.SetColumnSpan(checkedListBox1, 6);
			checkedListBox1.Dock = DockStyle.Fill;
			checkedListBox1.FormattingEnabled = true;
			checkedListBox1.Location = new Point(163, 48);
			checkedListBox1.Name = "checkedListBox1";
			tableLayoutPanel1.SetRowSpan(checkedListBox1, 5);
			checkedListBox1.Size = new Size(474, 219);
			checkedListBox1.TabIndex = 0;
			// 
			// button1
			// 
			tableLayoutPanel1.SetColumnSpan(button1, 2);
			button1.Dock = DockStyle.Fill;
			button1.Location = new Point(163, 363);
			button1.Name = "button1";
			button1.Size = new Size(154, 39);
			button1.TabIndex = 1;
			button1.Text = "Добавить задачу";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			tableLayoutPanel1.SetColumnSpan(button2, 2);
			button2.Dock = DockStyle.Fill;
			button2.Location = new Point(483, 363);
			button2.Name = "button2";
			button2.Size = new Size(154, 39);
			button2.TabIndex = 2;
			button2.Text = "Удалить задачу";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// textBox1
			// 
			tableLayoutPanel1.SetColumnSpan(textBox1, 6);
			textBox1.Dock = DockStyle.Fill;
			textBox1.Location = new Point(163, 273);
			textBox1.Name = "textBox1";
			textBox1.PlaceholderText = "Введите название новой задачи";
			textBox1.Size = new Size(474, 27);
			textBox1.TabIndex = 3;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tableLayoutPanel1);
			Name = "Form1";
			Text = "To Do List";
			FormClosed += Form1_FormClosed;
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private CheckedListBox checkedListBox1;
		private Button button1;
		private Button button2;
		private TextBox textBox1;
	}
}
