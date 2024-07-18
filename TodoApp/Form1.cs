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
        public Form1()
        {
            InitializeComponent();
            DatabaseManager.CreateDatabase();

            DataTable dtTasks = DatabaseManager.GetAllTasks();
            dataGridViewData.DataSource = dtTasks;
            comboBox_priority.DataSource = Enum.GetValues(typeof(Priority));
            RefreshDataGridView();

        }

        private void button_addTask_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string description = textBox_description.Text;
            Priority priority;

            if (Enum.TryParse(comboBox_priority.SelectedItem.ToString(), out priority))
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
            textBox_name.Text = "";
            textBox_description.Text = "";
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
                default:
                    break;
            }

            dataGridViewData.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewData.Refresh();
        }


        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
