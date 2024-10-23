namespace SchoolManager
{
    partial class ClassroomsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewClassrooms;
        private RoundedButton buttonAddClassroom;
        private RoundedButton buttonUpdateClassroom;
        private RoundedButton buttonDeleteClassroom;
        private RoundedTextBox textBoxRoomNumber;
        private RoundedTextBox textBoxCapacity;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label labelCapacity;

        private void InitializeComponent()
        {
            dataGridViewClassrooms = new DataGridView();
            buttonAddClassroom = new RoundedButton();
            buttonUpdateClassroom = new RoundedButton();
            buttonDeleteClassroom = new RoundedButton();
            textBoxRoomNumber = new RoundedTextBox();
            textBoxCapacity = new RoundedTextBox();
            labelRoomNumber = new Label();
            labelCapacity = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClassrooms).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClassrooms
            // 
            dataGridViewClassrooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClassrooms.Location = new Point(140, 12);
            dataGridViewClassrooms.Name = "dataGridViewClassrooms";
            dataGridViewClassrooms.Size = new Size(450, 200);
            dataGridViewClassrooms.TabIndex = 0;
            // 
            // buttonAddClassroom
            // 
            buttonAddClassroom.BackColor = Color.PaleTurquoise;
            buttonAddClassroom.CornerRadius = 30;
            buttonAddClassroom.FlatStyle = FlatStyle.Flat;
            buttonAddClassroom.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonAddClassroom.Location = new Point(411, 240);
            buttonAddClassroom.Name = "buttonAddClassroom";
            buttonAddClassroom.Size = new Size(197, 40);
            buttonAddClassroom.TabIndex = 5;
            buttonAddClassroom.Text = "Добавить";
            buttonAddClassroom.UseVisualStyleBackColor = false;
            buttonAddClassroom.Click += ButtonAddClassroom_Click;
            // 
            // buttonUpdateClassroom
            // 
            buttonUpdateClassroom.BackColor = Color.PaleTurquoise;
            buttonUpdateClassroom.CornerRadius = 30;
            buttonUpdateClassroom.FlatStyle = FlatStyle.Flat;
            buttonUpdateClassroom.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonUpdateClassroom.Location = new Point(411, 299);
            buttonUpdateClassroom.Name = "buttonUpdateClassroom";
            buttonUpdateClassroom.Size = new Size(197, 40);
            buttonUpdateClassroom.TabIndex = 6;
            buttonUpdateClassroom.Text = "Обновить";
            buttonUpdateClassroom.UseVisualStyleBackColor = false;
            buttonUpdateClassroom.Click += ButtonUpdateClassroom_Click;
            // 
            // buttonDeleteClassroom
            // 
            buttonDeleteClassroom.BackColor = Color.PaleTurquoise;
            buttonDeleteClassroom.CornerRadius = 30;
            buttonDeleteClassroom.FlatStyle = FlatStyle.Flat;
            buttonDeleteClassroom.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonDeleteClassroom.Location = new Point(411, 351);
            buttonDeleteClassroom.Name = "buttonDeleteClassroom";
            buttonDeleteClassroom.Size = new Size(197, 43);
            buttonDeleteClassroom.TabIndex = 7;
            buttonDeleteClassroom.Text = "Удалить";
            buttonDeleteClassroom.UseVisualStyleBackColor = false;
            buttonDeleteClassroom.Click += ButtonDeleteClassroom_Click;
            // 
            // textBoxRoomNumber
            // 
            textBoxRoomNumber.BackColor = Color.MediumTurquoise;
            textBoxRoomNumber.BorderColor = Color.Gray;
            textBoxRoomNumber.BorderThickness = 2;
            textBoxRoomNumber.CornerRadius = 15;
            textBoxRoomNumber.Location = new Point(128, 247);
            textBoxRoomNumber.Name = "textBoxRoomNumber";
            textBoxRoomNumber.Padding = new Padding(2);
            textBoxRoomNumber.Placeholder = null;
            textBoxRoomNumber.Size = new Size(242, 53);
            textBoxRoomNumber.TabIndex = 2;
            textBoxRoomNumber.TextColor = Color.Black;
            textBoxRoomNumber.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // textBoxCapacity
            // 
            textBoxCapacity.BackColor = Color.MediumTurquoise;
            textBoxCapacity.BorderColor = Color.Gray;
            textBoxCapacity.BorderThickness = 2;
            textBoxCapacity.CornerRadius = 15;
            textBoxCapacity.Location = new Point(128, 332);
            textBoxCapacity.Name = "textBoxCapacity";
            textBoxCapacity.Padding = new Padding(2);
            textBoxCapacity.Placeholder = null;
            textBoxCapacity.Size = new Size(242, 52);
            textBoxCapacity.TabIndex = 4;
            textBoxCapacity.TextColor = Color.Black;
            textBoxCapacity.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // labelRoomNumber
            // 
            labelRoomNumber.AutoSize = true;
            labelRoomNumber.Location = new Point(24, 265);
            labelRoomNumber.Name = "labelRoomNumber";
            labelRoomNumber.Size = new Size(101, 15);
            labelRoomNumber.TabIndex = 1;
            labelRoomNumber.Text = "Номер кабинета:";
            // 
            // labelCapacity
            // 
            labelCapacity.AutoSize = true;
            labelCapacity.Location = new Point(45, 351);
            labelCapacity.Name = "labelCapacity";
            labelCapacity.Size = new Size(83, 15);
            labelCapacity.TabIndex = 3;
            labelCapacity.Text = "Вместимость:";
            // 
            // ClassroomsForm
            // 
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(754, 416);
            Controls.Add(buttonDeleteClassroom);
            Controls.Add(buttonUpdateClassroom);
            Controls.Add(buttonAddClassroom);
            Controls.Add(textBoxCapacity);
            Controls.Add(labelCapacity);
            Controls.Add(textBoxRoomNumber);
            Controls.Add(labelRoomNumber);
            Controls.Add(dataGridViewClassrooms);
            Name = "ClassroomsForm";
            Text = "Manage Classrooms";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClassrooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
