namespace Final_Project
{
    partial class TaskListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTaskList = new Label();
            btnMarkCompleted = new Button();
            btnBack = new Button();
            dataGridView = new DataGridView();
            cmbPetNames = new ComboBox();
            txtTaskDescription = new TextBox();
            btnAddTask = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // lblTaskList
            // 
            lblTaskList.AutoSize = true;
            lblTaskList.Location = new Point(210, 22);
            lblTaskList.Name = "lblTaskList";
            lblTaskList.Size = new Size(50, 15);
            lblTaskList.TabIndex = 0;
            lblTaskList.Text = "Task List";
            // 
            // btnMarkCompleted
            // 
            btnMarkCompleted.Location = new Point(502, 69);
            btnMarkCompleted.Name = "btnMarkCompleted";
            btnMarkCompleted.Size = new Size(173, 45);
            btnMarkCompleted.TabIndex = 2;
            btnMarkCompleted.Text = "Mark as complete";
            btnMarkCompleted.UseVisualStyleBackColor = true;
            btnMarkCompleted.Click += btnMarkComplete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(307, 347);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(95, 45);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(29, 53);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(416, 231);
            dataGridView.TabIndex = 4;
            // 
            // cmbPetNames
            // 
            cmbPetNames.FormattingEnabled = true;
            cmbPetNames.Location = new Point(480, 187);
            cmbPetNames.Name = "cmbPetNames";
            cmbPetNames.Size = new Size(121, 23);
            cmbPetNames.TabIndex = 5;
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(614, 187);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(121, 23);
            txtTaskDescription.TabIndex = 6;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(558, 248);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(95, 45);
            btnAddTask.TabIndex = 7;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(558, 152);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 8;
            label1.Text = "Add New Task";
            // 
            // TaskListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 409);
            Controls.Add(label1);
            Controls.Add(btnAddTask);
            Controls.Add(txtTaskDescription);
            Controls.Add(cmbPetNames);
            Controls.Add(dataGridView);
            Controls.Add(btnBack);
            Controls.Add(btnMarkCompleted);
            Controls.Add(lblTaskList);
            Name = "TaskListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TaskListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTaskList;
        private Button btnMarkCompleted;
        private Button btnBack;
        private DataGridView dataGridView;
        private ComboBox cmbPetNames;
        private TextBox txtTaskDescription;
        private Button btnAddTask;
        private Label label1;
    }
}