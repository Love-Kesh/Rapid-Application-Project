namespace Final_Project
{
    partial class MainDashboardForm
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
            btnAddPet = new Button();
            btnCareSchedule = new Button();
            btnTaskList = new Button();
            btnHealthMetrics = new Button();
            btnViewPets = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnAddPet
            // 
            btnAddPet.Location = new Point(40, 51);
            btnAddPet.Name = "btnAddPet";
            btnAddPet.Size = new Size(216, 113);
            btnAddPet.TabIndex = 0;
            btnAddPet.Text = "Add Pet";
            btnAddPet.UseVisualStyleBackColor = true;
            btnAddPet.Click += btnAddPet_Click;
            // 
            // btnCareSchedule
            // 
            btnCareSchedule.Location = new Point(309, 51);
            btnCareSchedule.Name = "btnCareSchedule";
            btnCareSchedule.Size = new Size(216, 113);
            btnCareSchedule.TabIndex = 1;
            btnCareSchedule.Text = "Care Schedule";
            btnCareSchedule.UseVisualStyleBackColor = true;
            btnCareSchedule.Click += btnCareSchedule_Click;
            // 
            // btnTaskList
            // 
            btnTaskList.Location = new Point(309, 197);
            btnTaskList.Name = "btnTaskList";
            btnTaskList.Size = new Size(216, 113);
            btnTaskList.TabIndex = 2;
            btnTaskList.Text = "Task List";
            btnTaskList.UseVisualStyleBackColor = true;
            btnTaskList.Click += btnTaskList_Click;
            // 
            // btnHealthMetrics
            // 
            btnHealthMetrics.Location = new Point(40, 197);
            btnHealthMetrics.Name = "btnHealthMetrics";
            btnHealthMetrics.Size = new Size(216, 113);
            btnHealthMetrics.TabIndex = 3;
            btnHealthMetrics.Text = "Health Metrics";
            btnHealthMetrics.UseVisualStyleBackColor = true;
            btnHealthMetrics.Click += btnHealthMetrics_Click;
            // 
            // btnViewPets
            // 
            btnViewPets.Location = new Point(40, 350);
            btnViewPets.Name = "btnViewPets";
            btnViewPets.Size = new Size(216, 113);
            btnViewPets.TabIndex = 4;
            btnViewPets.Text = "View Pets";
            btnViewPets.UseVisualStyleBackColor = true;
            btnViewPets.Click += btnViewPets_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(309, 350);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(216, 113);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // MainDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 505);
            Controls.Add(btnLogout);
            Controls.Add(btnViewPets);
            Controls.Add(btnHealthMetrics);
            Controls.Add(btnTaskList);
            Controls.Add(btnCareSchedule);
            Controls.Add(btnAddPet);
            Name = "MainDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainDashboardForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddPet;
        private Button btnCareSchedule;
        private Button btnTaskList;
        private Button btnHealthMetrics;
        private Button btnViewPets;
        private Button btnLogout;
    }
}