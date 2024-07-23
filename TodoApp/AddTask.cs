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
            if (comboBoxPriority.SelectedItem != null)
            {
                string priorityText = comboBoxPriority.SelectedItem.ToString();
                DateTime deadline = dateTimePickerDeadline.Value;

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
                MessageBox.Show("Please select a priority.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}