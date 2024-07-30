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
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
            comboBoxPriority.DataSource = Enum.GetValues(typeof(Priority));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string description = textBoxDescription.Text;

            if (name.Length < 8)
            {
                MessageBox.Show("Task title must be at least 8 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (description.Length < 16)
            {
                MessageBox.Show("Task description must be at least 16 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxPriority.SelectedItem != null)
            {
                string priorityText = comboBoxPriority.SelectedItem.ToString();
                DateTime deadline = dateTimePickerDeadline.Value;

                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(description))
                {
                    try
                    {
                        DatabaseManager.InsertTask(name, description, priorityText, deadline);
                        MessageBox.Show("Task added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while adding the task: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a priority.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonClearFields_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxDescription.Text = "";
            comboBoxPriority.SelectedIndex = 0;
            dateTimePickerDeadline.Text = DateTime.Now.ToString();
            MessageBox.Show("Field's are empty now.", "Clear fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}