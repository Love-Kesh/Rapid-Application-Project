namespace Final_Project
{
    partial class CareScheduleForm
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
            lblSchedule = new Label();
            btnBack = new Button();
            lblScheduledTasks = new Label();
            monthCalendar = new MonthCalendar();
            cmbPetNames = new ComboBox();
            txtScheduledTask = new TextBox();
            dtpScheduledDate = new DateTimePicker();
            btnAddSchedule = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblSchedule
            // 
            lblSchedule.AutoSize = true;
            lblSchedule.Location = new Point(63, 51);
            lblSchedule.Name = "lblSchedule";
            lblSchedule.Size = new Size(117, 15);
            lblSchedule.TabIndex = 0;
            lblSchedule.Text = "Upcoming Schedule:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(493, 292);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(98, 44);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblScheduledTasks
            // 
            lblScheduledTasks.AutoSize = true;
            lblScheduledTasks.Location = new Point(63, 292);
            lblScheduledTasks.Name = "lblScheduledTasks";
            lblScheduledTasks.Size = new Size(38, 15);
            lblScheduledTasks.TabIndex = 4;
            lblScheduledTasks.Text = "label1";
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(63, 87);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 5;
            monthCalendar.DateChanged += monthCalendar_DateChanged;
            // 
            // cmbPetNames
            // 
            cmbPetNames.FormattingEnabled = true;
            cmbPetNames.Location = new Point(418, 86);
            cmbPetNames.Name = "cmbPetNames";
            cmbPetNames.Size = new Size(148, 23);
            cmbPetNames.TabIndex = 6;
            // 
            // txtScheduledTask
            // 
            txtScheduledTask.Location = new Point(418, 127);
            txtScheduledTask.Name = "txtScheduledTask";
            txtScheduledTask.Size = new Size(148, 23);
            txtScheduledTask.TabIndex = 7;
            // 
            // dtpScheduledDate
            // 
            dtpScheduledDate.Location = new Point(418, 173);
            dtpScheduledDate.Name = "dtpScheduledDate";
            dtpScheduledDate.Size = new Size(148, 23);
            dtpScheduledDate.TabIndex = 8;
            // 
            // btnAddSchedule
            // 
            btnAddSchedule.Location = new Point(396, 219);
            btnAddSchedule.Name = "btnAddSchedule";
            btnAddSchedule.Size = new Size(121, 44);
            btnAddSchedule.TabIndex = 9;
            btnAddSchedule.Text = "Add";
            btnAddSchedule.UseVisualStyleBackColor = true;
            btnAddSchedule.Click += btnAddSchedule_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(396, 50);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 10;
            label1.Text = " Add New Schedule";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 130);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 11;
            label2.Text = "Task";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 89);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 12;
            label3.Text = "Pet Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 179);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 13;
            label4.Text = "Date";
            // 
            // CareScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 358);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddSchedule);
            Controls.Add(dtpScheduledDate);
            Controls.Add(txtScheduledTask);
            Controls.Add(cmbPetNames);
            Controls.Add(monthCalendar);
            Controls.Add(lblScheduledTasks);
            Controls.Add(btnBack);
            Controls.Add(lblSchedule);
            Name = "CareScheduleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CareScheduleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSchedule;
        private Button btnBack;
        private Label lblScheduledTasks;
        private MonthCalendar monthCalendar;
        private ComboBox cmbPetNames;
        private TextBox txtScheduledTask;
        private DateTimePicker dtpScheduledDate;
        private Button btnAddSchedule;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}