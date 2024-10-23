namespace SchoolManager
{
    partial class ScheduleForm
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            dataGridViewSchedule = new DataGridView();
            comboBoxSubject = new ComboBox();
            comboBoxTeacher = new ComboBox();
            comboBoxClassroom = new ComboBox();
            comboBoxClass = new ComboBox();
            comboBoxDayOfWeek = new ComboBox();
            timePickerStartTime = new DateTimePicker();
            timePickerEndTime = new DateTimePicker();
            buttonAdd = new RoundedButton();
            buttonUpdate = new RoundedButton();
            buttonDelete = new RoundedButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedule).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSchedule
            // 
            dataGridViewSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSchedule.Location = new Point(12, 12);
            dataGridViewSchedule.Name = "dataGridViewSchedule";
            dataGridViewSchedule.Size = new Size(858, 300);
            dataGridViewSchedule.TabIndex = 0;
            // 
            // comboBoxSubject
            // 
            comboBoxSubject.FormattingEnabled = true;
            comboBoxSubject.Location = new Point(97, 331);
            comboBoxSubject.Name = "comboBoxSubject";
            comboBoxSubject.Size = new Size(200, 23);
            comboBoxSubject.TabIndex = 1;
            // 
            // comboBoxTeacher
            // 
            comboBoxTeacher.FormattingEnabled = true;
            comboBoxTeacher.Location = new Point(97, 376);
            comboBoxTeacher.Name = "comboBoxTeacher";
            comboBoxTeacher.Size = new Size(200, 23);
            comboBoxTeacher.TabIndex = 2;
            // 
            // comboBoxClassroom
            // 
            comboBoxClassroom.FormattingEnabled = true;
            comboBoxClassroom.Location = new Point(97, 417);
            comboBoxClassroom.Name = "comboBoxClassroom";
            comboBoxClassroom.Size = new Size(200, 23);
            comboBoxClassroom.TabIndex = 3;
            // 
            // comboBoxClass
            // 
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(400, 331);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(200, 23);
            comboBoxClass.TabIndex = 4;
            // 
            // comboBoxDayOfWeek
            // 
            comboBoxDayOfWeek.FormattingEnabled = true;
            comboBoxDayOfWeek.Items.AddRange(new object[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" });
            comboBoxDayOfWeek.Location = new Point(400, 376);
            comboBoxDayOfWeek.Name = "comboBoxDayOfWeek";
            comboBoxDayOfWeek.Size = new Size(200, 23);
            comboBoxDayOfWeek.TabIndex = 5;
            // 
            // timePickerStartTime
            // 
            timePickerStartTime.Format = DateTimePickerFormat.Time;
            timePickerStartTime.Location = new Point(97, 467);
            timePickerStartTime.Name = "timePickerStartTime";
            timePickerStartTime.ShowUpDown = true;
            timePickerStartTime.Size = new Size(100, 23);
            timePickerStartTime.TabIndex = 6;
            // 
            // timePickerEndTime
            // 
            timePickerEndTime.Format = DateTimePickerFormat.Time;
            timePickerEndTime.Location = new Point(282, 467);
            timePickerEndTime.Name = "timePickerEndTime";
            timePickerEndTime.ShowUpDown = true;
            timePickerEndTime.Size = new Size(100, 23);
            timePickerEndTime.TabIndex = 7;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.PaleTurquoise;
            buttonAdd.CornerRadius = 30;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(680, 331);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(205, 42);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.PaleTurquoise;
            buttonUpdate.CornerRadius = 30;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonUpdate.Location = new Point(680, 395);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(205, 45);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Обновить";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += ButtonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.PaleTurquoise;
            buttonDelete.CornerRadius = 30;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonDelete.Location = new Point(680, 457);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(205, 43);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 334);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 11;
            label1.Text = "Предмет";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 379);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 13;
            label2.Text = "Учитель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 417);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 15;
            label3.Text = "Кабинет";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 334);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 17;
            label4.Text = "Класс";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(318, 379);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 19;
            label5.Text = "День недели";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 470);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 20;
            label6.Text = "Начало";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(230, 470);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 21;
            label7.Text = "Конец";
            // 
            // ScheduleForm
            // 
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(897, 523);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(timePickerEndTime);
            Controls.Add(timePickerStartTime);
            Controls.Add(comboBoxDayOfWeek);
            Controls.Add(comboBoxClass);
            Controls.Add(comboBoxClassroom);
            Controls.Add(comboBoxTeacher);
            Controls.Add(comboBoxSubject);
            Controls.Add(dataGridViewSchedule);
            Name = "ScheduleForm";
            Text = "Schedule Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.ComboBox comboBoxClassroom;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.ComboBox comboBoxDayOfWeek;
        private System.Windows.Forms.DateTimePicker timePickerStartTime;
        private System.Windows.Forms.DateTimePicker timePickerEndTime;
        private RoundedButton buttonAdd;
        private RoundedButton buttonUpdate;
        private RoundedButton buttonDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}