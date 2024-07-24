namespace TodoApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAllData = new System.Windows.Forms.TabPage();
            this.tabPageLow = new System.Windows.Forms.TabPage();
            this.dataGridViewEasyTasks = new System.Windows.Forms.DataGridView();
            this.tabPageMedium = new System.Windows.Forms.TabPage();
            this.dataGridViewMediumTasks = new System.Windows.Forms.DataGridView();
            this.tabPageHigh = new System.Windows.Forms.TabPage();
            this.dataGridViewHardTasks = new System.Windows.Forms.DataGridView();
            this.tabPageCompleted = new System.Windows.Forms.TabPage();
            this.tabPageUncompleted = new System.Windows.Forms.TabPage();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonComplete = new System.Windows.Forms.Button();
            this.buttonUncomplete = new System.Windows.Forms.Button();
            this.labelTaskID = new System.Windows.Forms.Label();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEditTask = new System.Windows.Forms.Button();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.tabPageLow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEasyTasks)).BeginInit();
            this.tabPageMedium.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMediumTasks)).BeginInit();
            this.tabPageHigh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHardTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAllData);
            this.tabControl.Controls.Add(this.tabPageLow);
            this.tabControl.Controls.Add(this.tabPageMedium);
            this.tabControl.Controls.Add(this.tabPageHigh);
            this.tabControl.Controls.Add(this.tabPageCompleted);
            this.tabControl.Controls.Add(this.tabPageUncompleted);
            this.tabControl.Location = new System.Drawing.Point(11, 197);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(824, 24);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabPageAllData
            // 
            this.tabPageAllData.Location = new System.Drawing.Point(4, 27);
            this.tabPageAllData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageAllData.Name = "tabPageAllData";
            this.tabPageAllData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageAllData.Size = new System.Drawing.Size(816, 0);
            this.tabPageAllData.TabIndex = 0;
            this.tabPageAllData.Text = "All data";
            this.tabPageAllData.UseVisualStyleBackColor = true;
            // 
            // tabPageLow
            // 
            this.tabPageLow.Controls.Add(this.dataGridViewEasyTasks);
            this.tabPageLow.Location = new System.Drawing.Point(4, 27);
            this.tabPageLow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageLow.Name = "tabPageLow";
            this.tabPageLow.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageLow.Size = new System.Drawing.Size(816, 0);
            this.tabPageLow.TabIndex = 1;
            this.tabPageLow.Text = "Low";
            this.tabPageLow.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEasyTasks
            // 
            this.dataGridViewEasyTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEasyTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEasyTasks.Location = new System.Drawing.Point(7, 4);
            this.dataGridViewEasyTasks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewEasyTasks.Name = "dataGridViewEasyTasks";
            this.dataGridViewEasyTasks.RowHeadersWidth = 51;
            this.dataGridViewEasyTasks.RowTemplate.Height = 24;
            this.dataGridViewEasyTasks.Size = new System.Drawing.Size(824, 262);
            this.dataGridViewEasyTasks.TabIndex = 2;
            // 
            // tabPageMedium
            // 
            this.tabPageMedium.Controls.Add(this.dataGridViewMediumTasks);
            this.tabPageMedium.Location = new System.Drawing.Point(4, 27);
            this.tabPageMedium.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageMedium.Name = "tabPageMedium";
            this.tabPageMedium.Size = new System.Drawing.Size(816, 0);
            this.tabPageMedium.TabIndex = 2;
            this.tabPageMedium.Text = "Medium";
            this.tabPageMedium.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMediumTasks
            // 
            this.dataGridViewMediumTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMediumTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMediumTasks.Location = new System.Drawing.Point(7, 4);
            this.dataGridViewMediumTasks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewMediumTasks.Name = "dataGridViewMediumTasks";
            this.dataGridViewMediumTasks.RowHeadersWidth = 51;
            this.dataGridViewMediumTasks.RowTemplate.Height = 24;
            this.dataGridViewMediumTasks.Size = new System.Drawing.Size(824, 262);
            this.dataGridViewMediumTasks.TabIndex = 3;
            // 
            // tabPageHigh
            // 
            this.tabPageHigh.Controls.Add(this.dataGridViewHardTasks);
            this.tabPageHigh.Location = new System.Drawing.Point(4, 27);
            this.tabPageHigh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageHigh.Name = "tabPageHigh";
            this.tabPageHigh.Size = new System.Drawing.Size(816, 0);
            this.tabPageHigh.TabIndex = 3;
            this.tabPageHigh.Text = "High";
            this.tabPageHigh.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHardTasks
            // 
            this.dataGridViewHardTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHardTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHardTasks.Location = new System.Drawing.Point(7, 4);
            this.dataGridViewHardTasks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewHardTasks.Name = "dataGridViewHardTasks";
            this.dataGridViewHardTasks.RowHeadersWidth = 51;
            this.dataGridViewHardTasks.RowTemplate.Height = 24;
            this.dataGridViewHardTasks.Size = new System.Drawing.Size(824, 262);
            this.dataGridViewHardTasks.TabIndex = 4;
            // 
            // tabPageCompleted
            // 
            this.tabPageCompleted.Location = new System.Drawing.Point(4, 27);
            this.tabPageCompleted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageCompleted.Name = "tabPageCompleted";
            this.tabPageCompleted.Size = new System.Drawing.Size(816, 0);
            this.tabPageCompleted.TabIndex = 4;
            this.tabPageCompleted.Text = "Completed";
            this.tabPageCompleted.UseVisualStyleBackColor = true;
            // 
            // tabPageUncompleted
            // 
            this.tabPageUncompleted.Location = new System.Drawing.Point(4, 27);
            this.tabPageUncompleted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageUncompleted.Name = "tabPageUncompleted";
            this.tabPageUncompleted.Size = new System.Drawing.Size(816, 0);
            this.tabPageUncompleted.TabIndex = 5;
            this.tabPageUncompleted.Text = "Uncompleted";
            this.tabPageUncompleted.UseVisualStyleBackColor = true;
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.AllowUserToOrderColumns = true;
            this.dataGridViewData.AllowUserToResizeColumns = false;
            this.dataGridViewData.AllowUserToResizeRows = false;
            this.dataGridViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewData.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewData.Location = new System.Drawing.Point(12, 220);
            this.dataGridViewData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewData.MultiSelect = false;
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.Size = new System.Drawing.Size(824, 262);
            this.dataGridViewData.TabIndex = 1;
            this.dataGridViewData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellClick);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.Location = new System.Drawing.Point(270, 82);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(230, 102);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(6, 82);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(230, 102);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(170)))));
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(6, 3);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(494, 76);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "New task";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.groupBox1.Controls.Add(this.buttonComplete);
            this.groupBox1.Controls.Add(this.buttonUncomplete);
            this.groupBox1.Controls.Add(this.labelTaskID);
            this.groupBox1.Controls.Add(this.dateTimePickerDeadline);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonEditTask);
            this.groupBox1.Controls.Add(this.comboBoxPriority);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(524, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 189);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task #";
            // 
            // buttonComplete
            // 
            this.buttonComplete.Location = new System.Drawing.Point(150, 156);
            this.buttonComplete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(103, 26);
            this.buttonComplete.TabIndex = 34;
            this.buttonComplete.Text = "Complete";
            this.buttonComplete.UseVisualStyleBackColor = true;
            this.buttonComplete.Click += new System.EventHandler(this.buttonComplete_Click);
            // 
            // buttonUncomplete
            // 
            this.buttonUncomplete.Location = new System.Drawing.Point(41, 156);
            this.buttonUncomplete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUncomplete.Name = "buttonUncomplete";
            this.buttonUncomplete.Size = new System.Drawing.Size(103, 26);
            this.buttonUncomplete.TabIndex = 33;
            this.buttonUncomplete.Text = "Uncomplete";
            this.buttonUncomplete.UseVisualStyleBackColor = true;
            this.buttonUncomplete.Click += new System.EventHandler(this.buttonUncomplete_Click);
            // 
            // labelTaskID
            // 
            this.labelTaskID.AutoSize = true;
            this.labelTaskID.Location = new System.Drawing.Point(55, 0);
            this.labelTaskID.Name = "labelTaskID";
            this.labelTaskID.Size = new System.Drawing.Size(0, 18);
            this.labelTaskID.TabIndex = 32;
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(83, 120);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(100, 26);
            this.dateTimePickerDeadline.TabIndex = 31;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(202, 120);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(103, 26);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonEditTask
            // 
            this.buttonEditTask.Location = new System.Drawing.Point(202, 26);
            this.buttonEditTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditTask.Name = "buttonEditTask";
            this.buttonEditTask.Size = new System.Drawing.Size(103, 92);
            this.buttonEditTask.TabIndex = 29;
            this.buttonEditTask.Text = "Edit";
            this.buttonEditTask.UseVisualStyleBackColor = true;
            this.buttonEditTask.Click += new System.EventHandler(this.buttonEditTask_Click);
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(83, 90);
            this.comboBoxPriority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(100, 26);
            this.comboBoxPriority.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Deadline";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Priority";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Descrip.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(83, 58);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 26);
            this.textBoxDescription.TabIndex = 23;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(83, 26);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 26);
            this.textBoxName.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonExit);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 189);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(851, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "My tasks";
            this.tabControl.ResumeLayout(false);
            this.tabPageLow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEasyTasks)).EndInit();
            this.tabPageMedium.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMediumTasks)).EndInit();
            this.tabPageHigh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHardTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TabPage tabPageMedium;
        private System.Windows.Forms.TabPage tabPageHigh;
        private System.Windows.Forms.TabPage tabPageAllData;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.TabPage tabPageLow;
        private System.Windows.Forms.DataGridView dataGridViewEasyTasks;
        private System.Windows.Forms.DataGridView dataGridViewMediumTasks;
        private System.Windows.Forms.DataGridView dataGridViewHardTasks;
        private System.Windows.Forms.TabPage tabPageCompleted;
        private System.Windows.Forms.TabPage tabPageUncompleted;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEditTask;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelTaskID;
        private System.Windows.Forms.Button buttonUncomplete;
        private System.Windows.Forms.Button buttonComplete;
    }
}

