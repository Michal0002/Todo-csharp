using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class Form1 : Form
    {
        private int selectedTaskId = -1;
        public Form1()
        {
            InitializeComponent();
            DatabaseManager.CreateDatabase();

            DataTable dtTasks = DatabaseManager.GetAllTasks();
            dataGridViewData.DataSource = dtTasks;
            comboBoxPriority.DataSource = Enum.GetValues(typeof(Priority));
            RefreshDataGridView();
        }

        private void button_addTask_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string description = textBoxDescription.Text;
            Priority priority;

            if (Enum.TryParse(comboBoxPriority.SelectedItem.ToString(), out priority))
            {
                DateTime deadline = DateTime.Now;

                try
                {
                    DatabaseManager.InsertTask(name, description, priority, deadline);
                    MessageBox.Show("Zadanie dodane pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAddTaskFields();
                    RefreshTaskList(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd podczas dodawania zadania: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano prawidłowego priorytetu zadania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      private void RefreshTaskList()
        {
            DataTable dtTasks = DatabaseManager.GetAllTasks();

            dataGridViewData.DataSource = dtTasks;
        }

        private void ClearAddTaskFields()
        {
            textBoxName.Text = "";
            textBoxDescription.Text = "";
        }

        private void RefreshDataGridView()
        {
            switch (tabControl.SelectedTab.Name)
            {
                case "tabPageAllData":
                    dataGridViewData.DataSource = DatabaseManager.GetAllTasks();
                    break;
                case "tabPageLow":
                    dataGridViewData.DataSource = DatabaseManager.GetLowPriorityTasks();
                    break;
                case "tabPageMedium":
                    dataGridViewData.DataSource = DatabaseManager.GetMediumPriorityTasks();
                    break;
                case "tabPageHigh":
                    dataGridViewData.DataSource = DatabaseManager.GetHighPriorityTasks();
                    break;
                case "tabPageCompleted":
                    dataGridViewData.DataSource = DatabaseManager.GetCompletedTasks();
                    break;
                case "tabPageUncompleted":
                    dataGridViewData.DataSource = DatabaseManager.GetUncompletedTasks();
                    break;
                default:
                    break;
            }

            dataGridViewData.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewData.Refresh();
        }

        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewData.SelectedRows[0];
                selectedTaskId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                labelTaskID.Text = selectedTaskId.ToString();
                //data fill 
                textBoxName.Text = selectedRow.Cells["name"].Value.ToString();
                textBoxDescription.Text = selectedRow.Cells["description"].Value.ToString();
                comboBoxPriority.SelectedItem = selectedRow.Cells["priority"].Value.ToString();
                dateTimePickerDeadline.Value = Convert.ToDateTime(selectedRow.Cells["deadline"].Value);
            }
        }

        private void buttonEditTask_Click(object sender, EventArgs e)
        {
            if (selectedTaskId != -1)
            {
                int selectedTaskId = Convert.ToInt32(dataGridViewData.CurrentRow.Cells[0].Value);
                string name = textBoxName.Text;
                string description = textBoxDescription.Text;
                Priority priority = (Priority)Enum.Parse(typeof(Priority), comboBoxPriority.SelectedItem.ToString());
                DateTime deadline = dateTimePickerDeadline.Value;

                DatabaseManager.UpdateTask(selectedTaskId, name, description, priority, deadline);

                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a task to edit.");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTask addTaskForm = new AddTask();

            addTaskForm.ShowDialog();
        }
    }
}
