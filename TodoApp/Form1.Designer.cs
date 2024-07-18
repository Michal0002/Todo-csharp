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
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.comboBox_priority = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button_addTask = new System.Windows.Forms.Button();
            this.tabPageCompleted = new System.Windows.Forms.TabPage();
            this.tabPageUncompleted = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPageLow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEasyTasks)).BeginInit();
            this.tabPageMedium.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMediumTasks)).BeginInit();
            this.tabPageHigh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHardTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
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
            this.tabControl.Location = new System.Drawing.Point(12, 167);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(844, 30);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabPageAllData
            // 
            this.tabPageAllData.Location = new System.Drawing.Point(4, 25);
            this.tabPageAllData.Name = "tabPageAllData";
            this.tabPageAllData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllData.Size = new System.Drawing.Size(836, 1);
            this.tabPageAllData.TabIndex = 0;
            this.tabPageAllData.Text = "All data";
            this.tabPageAllData.UseVisualStyleBackColor = true;
            // 
            // tabPageLow
            // 
            this.tabPageLow.Controls.Add(this.dataGridViewEasyTasks);
            this.tabPageLow.Location = new System.Drawing.Point(4, 25);
            this.tabPageLow.Name = "tabPageLow";
            this.tabPageLow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLow.Size = new System.Drawing.Size(836, 1);
            this.tabPageLow.TabIndex = 1;
            this.tabPageLow.Text = "Low";
            this.tabPageLow.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEasyTasks
            // 
            this.dataGridViewEasyTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEasyTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEasyTasks.Location = new System.Drawing.Point(6, 3);
            this.dataGridViewEasyTasks.Name = "dataGridViewEasyTasks";
            this.dataGridViewEasyTasks.RowHeadersWidth = 51;
            this.dataGridViewEasyTasks.RowTemplate.Height = 24;
            this.dataGridViewEasyTasks.Size = new System.Drawing.Size(824, 233);
            this.dataGridViewEasyTasks.TabIndex = 2;
            // 
            // tabPageMedium
            // 
            this.tabPageMedium.Controls.Add(this.dataGridViewMediumTasks);
            this.tabPageMedium.Location = new System.Drawing.Point(4, 25);
            this.tabPageMedium.Name = "tabPageMedium";
            this.tabPageMedium.Size = new System.Drawing.Size(836, 1);
            this.tabPageMedium.TabIndex = 2;
            this.tabPageMedium.Text = "Medium";
            this.tabPageMedium.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMediumTasks
            // 
            this.dataGridViewMediumTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMediumTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMediumTasks.Location = new System.Drawing.Point(6, 3);
            this.dataGridViewMediumTasks.Name = "dataGridViewMediumTasks";
            this.dataGridViewMediumTasks.RowHeadersWidth = 51;
            this.dataGridViewMediumTasks.RowTemplate.Height = 24;
            this.dataGridViewMediumTasks.Size = new System.Drawing.Size(824, 233);
            this.dataGridViewMediumTasks.TabIndex = 3;
            // 
            // tabPageHigh
            // 
            this.tabPageHigh.Controls.Add(this.dataGridViewHardTasks);
            this.tabPageHigh.Location = new System.Drawing.Point(4, 25);
            this.tabPageHigh.Name = "tabPageHigh";
            this.tabPageHigh.Size = new System.Drawing.Size(836, 1);
            this.tabPageHigh.TabIndex = 3;
            this.tabPageHigh.Text = "High";
            this.tabPageHigh.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHardTasks
            // 
            this.dataGridViewHardTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHardTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHardTasks.Location = new System.Drawing.Point(6, 3);
            this.dataGridViewHardTasks.Name = "dataGridViewHardTasks";
            this.dataGridViewHardTasks.RowHeadersWidth = 51;
            this.dataGridViewHardTasks.RowTemplate.Height = 24;
            this.dataGridViewHardTasks.Size = new System.Drawing.Size(824, 233);
            this.dataGridViewHardTasks.TabIndex = 4;
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
            this.dataGridViewData.Location = new System.Drawing.Point(12, 195);
            this.dataGridViewData.MultiSelect = false;
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.Size = new System.Drawing.Size(824, 233);
            this.dataGridViewData.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(171, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 119);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(12, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 119);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.Yellow;
            this.button_edit.Location = new System.Drawing.Point(330, 11);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(144, 117);
            this.button_edit.TabIndex = 1;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            // 
            // comboBox_priority
            // 
            this.comboBox_priority.FormattingEnabled = true;
            this.comboBox_priority.Location = new System.Drawing.Point(612, 103);
            this.comboBox_priority.Name = "comboBox_priority";
            this.comboBox_priority.Size = new System.Drawing.Size(100, 24);
            this.comboBox_priority.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Deadline";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Priority";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Desc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(612, 52);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(100, 22);
            this.textBox_description.TabIndex = 12;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(612, 12);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 22);
            this.textBox_name.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(745, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button_addTask
            // 
            this.button_addTask.Location = new System.Drawing.Point(745, 18);
            this.button_addTask.Name = "button_addTask";
            this.button_addTask.Size = new System.Drawing.Size(75, 23);
            this.button_addTask.TabIndex = 20;
            this.button_addTask.Text = "Add";
            this.button_addTask.UseVisualStyleBackColor = true;
            this.button_addTask.Click += new System.EventHandler(this.button_addTask_Click);
            // 
            // tabPageCompleted
            // 
            this.tabPageCompleted.Location = new System.Drawing.Point(4, 25);
            this.tabPageCompleted.Name = "tabPageCompleted";
            this.tabPageCompleted.Size = new System.Drawing.Size(836, 1);
            this.tabPageCompleted.TabIndex = 4;
            this.tabPageCompleted.Text = "Completed";
            this.tabPageCompleted.UseVisualStyleBackColor = true;
            // 
            // tabPageUncompleted
            // 
            this.tabPageUncompleted.Location = new System.Drawing.Point(4, 25);
            this.tabPageUncompleted.Name = "tabPageUncompleted";
            this.tabPageUncompleted.Size = new System.Drawing.Size(836, 1);
            this.tabPageUncompleted.TabIndex = 5;
            this.tabPageUncompleted.Text = "Uncompleted";
            this.tabPageUncompleted.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_addTask);
            this.Controls.Add(this.comboBox_priority);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.button_edit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPageLow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEasyTasks)).EndInit();
            this.tabPageMedium.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMediumTasks)).EndInit();
            this.tabPageHigh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHardTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPageMedium;
        private System.Windows.Forms.TabPage tabPageHigh;
        private System.Windows.Forms.TabPage tabPageAllData;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.TabPage tabPageLow;
        private System.Windows.Forms.DataGridView dataGridViewEasyTasks;
        private System.Windows.Forms.DataGridView dataGridViewMediumTasks;
        private System.Windows.Forms.ComboBox comboBox_priority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_addTask;
        private System.Windows.Forms.DataGridView dataGridViewHardTasks;
        private System.Windows.Forms.TabPage tabPageCompleted;
        private System.Windows.Forms.TabPage tabPageUncompleted;
    }
}

