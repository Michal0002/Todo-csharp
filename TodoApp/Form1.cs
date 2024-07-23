﻿using System;
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTask addTaskForm = new AddTask();

            addTaskForm.ShowDialog();
        }

        private void buttonEditTask_Click(object sender, EventArgs e)
        {
            if (selectedTaskId != -1)
            {
                try
                {
                    string name = textBoxName.Text.Trim();
                    string description = textBoxDescription.Text.Trim();

                    if (comboBoxPriority.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a priority.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string priorityText = comboBoxPriority.SelectedItem.ToString();
                    DateTime deadline = dateTimePickerDeadline.Value;

                    DatabaseManager.UpdateTask(selectedTaskId, name, description, priorityText, deadline);

                    RefreshDataGridView();
                    MessageBox.Show("Task updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the task: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a task to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                comboBoxPriority.Text = selectedRow.Cells["priority"].Value.ToString();
                dateTimePickerDeadline.Value = Convert.ToDateTime(selectedRow.Cells["deadline"].Value);
            }
        }

    }
}
