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
    public partial class EditForm : Form
    {
        public string NameText
        {
            get { return textBoxName.Text; }
            set { textBoxName.Text = value; }
        }

        public string DescriptionText
        {
            get { return textBoxDescription.Text; }
            set { textBoxDescription.Text = value; }
        }

        public string PriorityText
        {
            get { return comboBoxPriority.Text; }
            set { comboBoxPriority.Text = value; }
        }

        public string DeadlineText
        {
            get { return dateTimePickerDeadline.Text; }
            set { dateTimePickerDeadline.Text = value; }
        }

        public EditForm()
        {
            InitializeComponent();
        }

    }
}
