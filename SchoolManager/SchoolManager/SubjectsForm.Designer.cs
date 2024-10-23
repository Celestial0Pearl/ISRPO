namespace SchoolManager
{
    partial class SubjectsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewSubjects;
        private RoundedButton buttonAddSubject;
        private RoundedButton buttonUpdateSubject;
        private RoundedButton buttonDeleteSubject;
        private RoundedTextBox textBoxSubjectName;
        private System.Windows.Forms.Label labelSubjectName;

        private void InitializeComponent()
        {
            dataGridViewSubjects = new DataGridView();
            buttonAddSubject = new RoundedButton();
            buttonUpdateSubject = new RoundedButton();
            buttonDeleteSubject = new RoundedButton();
            textBoxSubjectName = new RoundedTextBox();
            labelSubjectName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjects).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSubjects
            // 
            dataGridViewSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSubjects.Location = new Point(12, 12);
            dataGridViewSubjects.Name = "dataGridViewSubjects";
            dataGridViewSubjects.Size = new Size(450, 200);
            dataGridViewSubjects.TabIndex = 0;
            // 
            // buttonAddSubject
            // 
            buttonAddSubject.BackColor = Color.PaleTurquoise;
            buttonAddSubject.CornerRadius = 30;
            buttonAddSubject.FlatStyle = FlatStyle.Flat;
            buttonAddSubject.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonAddSubject.Location = new Point(15, 277);
            buttonAddSubject.Name = "buttonAddSubject";
            buttonAddSubject.Size = new Size(183, 55);
            buttonAddSubject.TabIndex = 3;
            buttonAddSubject.Text = "Добавить";
            buttonAddSubject.UseVisualStyleBackColor = true;
            buttonAddSubject.Click += ButtonAddSubject_Click;
            // 
            // buttonUpdateSubject
            // 
            buttonUpdateSubject.BackColor = Color.PaleTurquoise;
            buttonUpdateSubject.CornerRadius = 30;
            buttonUpdateSubject.FlatStyle = FlatStyle.Flat;
            buttonUpdateSubject.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonUpdateSubject.Location = new Point(223, 278);
            buttonUpdateSubject.Name = "buttonUpdateSubject";
            buttonUpdateSubject.Size = new Size(191, 54);
            buttonUpdateSubject.TabIndex = 4;
            buttonUpdateSubject.Text = "Обновить";
            buttonUpdateSubject.UseVisualStyleBackColor = true;
            buttonUpdateSubject.Click += ButtonUpdateSubject_Click;
            // 
            // buttonDeleteSubject
            // 
            buttonDeleteSubject.BackColor = Color.PaleTurquoise;
            buttonDeleteSubject.CornerRadius = 30;
            buttonDeleteSubject.FlatStyle = FlatStyle.Flat;
            buttonDeleteSubject.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonDeleteSubject.Location = new Point(440, 278);
            buttonDeleteSubject.Name = "buttonDeleteSubject";
            buttonDeleteSubject.Size = new Size(183, 55);
            buttonDeleteSubject.TabIndex = 5;
            buttonDeleteSubject.Text = "Удалить";
            buttonDeleteSubject.UseVisualStyleBackColor = true;
            buttonDeleteSubject.Click += ButtonDeleteSubject_Click;
            // 
            // textBoxSubjectName
            // 
            textBoxSubjectName.BackColor = Color.MediumTurquoise;
            textBoxSubjectName.BorderColor = Color.Gray;
            textBoxSubjectName.BorderThickness = 2;
            textBoxSubjectName.CornerRadius = 15;
            textBoxSubjectName.Location = new Point(142, 218);
            textBoxSubjectName.Name = "textBoxSubjectName";
            textBoxSubjectName.Padding = new Padding(2);
            textBoxSubjectName.Placeholder = null;
            textBoxSubjectName.Size = new Size(320, 44);
            textBoxSubjectName.TabIndex = 2;
            textBoxSubjectName.TextColor = Color.Black;
            textBoxSubjectName.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // labelSubjectName
            // 
            labelSubjectName.AutoSize = true;
            labelSubjectName.Location = new Point(12, 230);
            labelSubjectName.Name = "labelSubjectName";
            labelSubjectName.Size = new Size(114, 15);
            labelSubjectName.TabIndex = 1;
            labelSubjectName.Text = "Название предмета";
            // 
            // SubjectsForm
            // 
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(647, 361);
            Controls.Add(buttonDeleteSubject);
            Controls.Add(buttonUpdateSubject);
            Controls.Add(buttonAddSubject);
            Controls.Add(textBoxSubjectName);
            Controls.Add(labelSubjectName);
            Controls.Add(dataGridViewSubjects);
            Name = "SubjectsForm";
            Text = "Manage Subjects";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
