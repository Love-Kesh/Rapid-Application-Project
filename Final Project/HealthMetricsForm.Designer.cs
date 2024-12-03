namespace Final_Project
{
    partial class HealthMetricsForm
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
            txtWeight = new TextBox();
            btnSave = new Button();
            btnBack = new Button();
            cmbPetNames = new ComboBox();
            txtAge = new TextBox();
            txtHeight = new TextBox();
            lblWeight = new Label();
            lblHeight = new Label();
            lblAge = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(146, 133);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(121, 23);
            txtWeight.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(54, 243);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 43);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save Metrics";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(211, 243);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(108, 43);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // cmbPetNames
            // 
            cmbPetNames.FormattingEnabled = true;
            cmbPetNames.Location = new Point(146, 27);
            cmbPetNames.Name = "cmbPetNames";
            cmbPetNames.Size = new Size(121, 23);
            cmbPetNames.TabIndex = 4;
            cmbPetNames.SelectedIndexChanged += cmbPetNames_SelectedIndexChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(146, 80);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(121, 23);
            txtAge.TabIndex = 5;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(146, 181);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(121, 23);
            txtHeight.TabIndex = 6;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(54, 136);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(45, 15);
            lblWeight.TabIndex = 8;
            lblWeight.Text = "Weight";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(54, 184);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(43, 15);
            lblHeight.TabIndex = 9;
            lblHeight.Text = "Height";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(54, 83);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 10;
            lblAge.Text = "Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 317);
            label1.Name = "label1";
            label1.Size = new Size(202, 15);
            label1.TabIndex = 11;
            label1.Text = "*Access/Modify Pet's health metrics*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 83);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 12;
            label2.Text = "years";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 136);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 13;
            label3.Text = "kgs";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 184);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 14;
            label4.Text = "inches";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 30);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 15;
            label5.Text = "Pet Name";
            // 
            // HealthMetricsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 364);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblAge);
            Controls.Add(lblHeight);
            Controls.Add(lblWeight);
            Controls.Add(txtHeight);
            Controls.Add(txtAge);
            Controls.Add(cmbPetNames);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(txtWeight);
            Name = "HealthMetricsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HealthMetricsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtWeight;
        private Button btnSave;
        private Button btnBack;
        private ComboBox cmbPetNames;
        private TextBox txtAge;
        private TextBox txtHeight;
        private Label lblWeight;
        private Label lblHeight;
        private Label lblAge;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}