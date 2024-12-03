namespace Final_Project
{
    partial class AddPetForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPetName = new TextBox();
            txtPetType = new TextBox();
            txtPetBreed = new TextBox();
            btnAddPet = new Button();
            txtWeight = new TextBox();
            label4 = new Label();
            txtAge = new TextBox();
            txtHeight = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnBack = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 85);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Pet Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 138);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 210);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Breed";
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(140, 77);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(100, 23);
            txtPetName.TabIndex = 3;
            // 
            // txtPetType
            // 
            txtPetType.Location = new Point(140, 133);
            txtPetType.Name = "txtPetType";
            txtPetType.Size = new Size(100, 23);
            txtPetType.TabIndex = 4;
            // 
            // txtPetBreed
            // 
            txtPetBreed.Location = new Point(140, 202);
            txtPetBreed.Name = "txtPetBreed";
            txtPetBreed.Size = new Size(100, 23);
            txtPetBreed.TabIndex = 5;
            // 
            // btnAddPet
            // 
            btnAddPet.Location = new Point(129, 277);
            btnAddPet.Name = "btnAddPet";
            btnAddPet.Size = new Size(139, 51);
            btnAddPet.TabIndex = 6;
            btnAddPet.Text = "Add Pet";
            btnAddPet.UseVisualStyleBackColor = true;
            btnAddPet.Click += btnAddPet_Click;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(434, 82);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 23);
            txtWeight.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(309, 85);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "Weight";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(434, 138);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 11;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(434, 207);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(100, 23);
            txtHeight.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 138);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 13;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(311, 210);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 14;
            label6.Text = "Height";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(365, 277);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 51);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(222, 29);
            label7.Name = "label7";
            label7.Size = new Size(132, 15);
            label7.TabIndex = 16;
            label7.Text = "*Please fill all the fields*";
            // 
            // AddPetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 399);
            Controls.Add(label7);
            Controls.Add(btnBack);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtHeight);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(txtWeight);
            Controls.Add(btnAddPet);
            Controls.Add(txtPetBreed);
            Controls.Add(txtPetType);
            Controls.Add(txtPetName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddPetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPetForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPetName;
        private TextBox txtPetType;
        private TextBox txtPetBreed;
        private Button btnAddPet;
        private TextBox txtWeight;
        private Label label4;
        private TextBox txtAge;
        private TextBox txtHeight;
        private Label label5;
        private Label label6;
        private Button btnBack;
        private Label label7;
    }
}