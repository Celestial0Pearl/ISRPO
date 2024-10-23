namespace SchoolManager
{
    partial class GradesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewGrades;
        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.NumericUpDown numericUpDownGrade;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Label labelDate;
        private RoundedButton buttonAddGrade;
        private RoundedButton buttonUpdateGrade;
        private RoundedButton buttonDeleteGrade;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewGrades = new DataGridView();
            comboBoxStudents = new ComboBox();
            comboBoxSubjects = new ComboBox();
            numericUpDownGrade = new NumericUpDown();
            dateTimePickerDate = new DateTimePicker();
            labelStudent = new Label();
            labelSubject = new Label();
            labelGrade = new Label();
            labelDate = new Label();
            buttonAddGrade = new RoundedButton();
            buttonUpdateGrade = new RoundedButton();
            buttonDeleteGrade = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewGrades
            // 
            dataGridViewGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrades.Location = new Point(12, 12);
            dataGridViewGrades.Name = "dataGridViewGrades";
            dataGridViewGrades.Size = new Size(600, 250);
            dataGridViewGrades.TabIndex = 0;
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.FormattingEnabled = true;
            comboBoxStudents.Location = new Point(90, 270);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new Size(150, 23);
            comboBoxStudents.TabIndex = 1;
            // 
            // comboBoxSubjects
            // 
            comboBoxSubjects.FormattingEnabled = true;
            comboBoxSubjects.Location = new Point(90, 300);
            comboBoxSubjects.Name = "comboBoxSubjects";
            comboBoxSubjects.Size = new Size(150, 23);
            comboBoxSubjects.TabIndex = 2;
            // 
            // numericUpDownGrade
            // 
            numericUpDownGrade.Location = new Point(90, 330);
            numericUpDownGrade.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownGrade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownGrade.Name = "numericUpDownGrade";
            numericUpDownGrade.Size = new Size(150, 23);
            numericUpDownGrade.TabIndex = 3;
            numericUpDownGrade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(90, 360);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(150, 23);
            dateTimePickerDate.TabIndex = 4;
            // 
            // labelStudent
            // 
            labelStudent.AutoSize = true;
            labelStudent.Location = new Point(12, 273);
            labelStudent.Name = "labelStudent";
            labelStudent.Size = new Size(51, 15);
            labelStudent.TabIndex = 5;
            labelStudent.Text = "Student:";
            // 
            // labelSubject
            // 
            labelSubject.AutoSize = true;
            labelSubject.Location = new Point(12, 303);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(49, 15);
            labelSubject.TabIndex = 6;
            labelSubject.Text = "Subject:";
            // 
            // labelGrade
            // 
            labelGrade.AutoSize = true;
            labelGrade.Location = new Point(12, 333);
            labelGrade.Name = "labelGrade";
            labelGrade.Size = new Size(41, 15);
            labelGrade.TabIndex = 7;
            labelGrade.Text = "Grade:";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(12, 363);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(34, 15);
            labelDate.TabIndex = 8;
            labelDate.Text = "Date:";
            // 
            // buttonAddGrade
            // 
            buttonAddGrade.BackColor = Color.PaleTurquoise;
            buttonAddGrade.CornerRadius = 30;
            buttonAddGrade.FlatStyle = FlatStyle.Flat;
            buttonAddGrade.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonAddGrade.Location = new Point(277, 268);
            buttonAddGrade.Name = "buttonAddGrade";
            buttonAddGrade.Size = new Size(212, 39);
            buttonAddGrade.TabIndex = 9;
            buttonAddGrade.Text = "Добавить";
            buttonAddGrade.UseVisualStyleBackColor = true;
            buttonAddGrade.Click += ButtonAddGrade_Click;
            // 
            // buttonUpdateGrade
            // 
            buttonUpdateGrade.BackColor = Color.PaleTurquoise;
            buttonUpdateGrade.CornerRadius = 30;
            buttonUpdateGrade.FlatStyle = FlatStyle.Flat;
            buttonUpdateGrade.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonUpdateGrade.Location = new Point(275, 354);
            buttonUpdateGrade.Name = "buttonUpdateGrade";
            buttonUpdateGrade.Size = new Size(212, 38);
            buttonUpdateGrade.TabIndex = 10;
            buttonUpdateGrade.Text = "Обновить";
            buttonUpdateGrade.UseVisualStyleBackColor = true;
            buttonUpdateGrade.Click += ButtonUpdateGrade_Click;
            // 
            // buttonDeleteGrade
            // 
            buttonDeleteGrade.BackColor = Color.PaleTurquoise;
            buttonDeleteGrade.CornerRadius = 30;
            buttonDeleteGrade.FlatStyle = FlatStyle.Flat;
            buttonDeleteGrade.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonDeleteGrade.Location = new Point(277, 313);
            buttonDeleteGrade.Name = "buttonDeleteGrade";
            buttonDeleteGrade.Size = new Size(210, 35);
            buttonDeleteGrade.TabIndex = 11;
            buttonDeleteGrade.Text = "Удалить";
            buttonDeleteGrade.UseVisualStyleBackColor = true;
            buttonDeleteGrade.Click += ButtonDeleteGrade_Click;
            // 
            // GradesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(678, 417);
            Controls.Add(buttonDeleteGrade);
            Controls.Add(buttonUpdateGrade);
            Controls.Add(buttonAddGrade);
            Controls.Add(labelDate);
            Controls.Add(labelGrade);
            Controls.Add(labelSubject);
            Controls.Add(labelStudent);
            Controls.Add(dateTimePickerDate);
            Controls.Add(numericUpDownGrade);
            Controls.Add(comboBoxSubjects);
            Controls.Add(comboBoxStudents);
            Controls.Add(dataGridViewGrades);
            Name = "GradesForm";
            Text = "Manage Grades";
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrades).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
