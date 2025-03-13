using Newtonsoft.Json;

namespace todolist
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			try
			{
				List<ToDoListTask> tasks = JsonConvert.DeserializeObject<List<ToDoListTask>>(File.ReadAllText("tasks.json"));

				for (int i = 0; i < tasks.Count; i++)
				{
					checkedListBox1.Items.Add(tasks[i].task, tasks[i].isChecked);
				}
			}
			catch { }
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
			{
				checkedListBox1.Items.Add(textBox1.Text);
				textBox1.Text = "";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (checkedListBox1.SelectedIndex != -1)
			{
				checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
			}
		}

		private void tableLayoutPanel1_Click(object sender, EventArgs e)
		{
			checkedListBox1.ClearSelected();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			List<ToDoListTask> tasks = new List<ToDoListTask>();

			for (int i = 0; i < checkedListBox1.Items.Count; i++)
			{
				string task = checkedListBox1.Items[i].ToString();
				bool isChecked = checkedListBox1.CheckedItems.Contains(task);
				tasks.Add(new ToDoListTask { task = task, isChecked = isChecked });
			}

			File.WriteAllText("tasks.json", JsonConvert.SerializeObject(tasks));
		}
	}
}

class ToDoListTask
{
	public string task = "";
	public bool isChecked = false;
}