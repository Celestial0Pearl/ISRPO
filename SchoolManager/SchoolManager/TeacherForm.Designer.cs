namespace SchoolManager
{
    partial class TeacherForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewTeachers;
        private RoundedTextBox textBoxFirstName;
        private RoundedTextBox textBoxLastName;
        private RoundedTextBox textBoxEmail;
        private RoundedTextBox textBoxPhone;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private RoundedButton buttonAddTeacher;
        private RoundedButton buttonUpdateTeacher;
        private RoundedButton buttonDeleteTeacher;

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
            dataGridViewTeachers = new DataGridView();
            textBoxFirstName = new RoundedTextBox();
            textBoxLastName = new RoundedTextBox();
            textBoxEmail = new RoundedTextBox();
            textBoxPhone = new RoundedTextBox();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelEmail = new Label();
            labelPhone = new Label();
            buttonAddTeacher = new RoundedButton();
            buttonUpdateTeacher = new RoundedButton();
            buttonDeleteTeacher = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTeachers
            // 
            dataGridViewTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeachers.Location = new Point(90, 14);
            dataGridViewTeachers.Name = "dataGridViewTeachers";
            dataGridViewTeachers.Size = new Size(600, 250);
            dataGridViewTeachers.TabIndex = 0;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BackColor = Color.MediumTurquoise;
            textBoxFirstName.BorderColor = Color.Gray;
            textBoxFirstName.BorderThickness = 2;
            textBoxFirstName.CornerRadius = 15;
            textBoxFirstName.Location = new Point(172, 273);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Padding = new Padding(2);
            textBoxFirstName.Placeholder = null;
            textBoxFirstName.Size = new Size(268, 45);
            textBoxFirstName.TabIndex = 1;
            textBoxFirstName.TextColor = Color.Black;
            textBoxFirstName.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // textBoxLastName
            // 
            textBoxLastName.BackColor = Color.MediumTurquoise;
            textBoxLastName.BorderColor = Color.Gray;
            textBoxLastName.BorderThickness = 2;
            textBoxLastName.CornerRadius = 15;
            textBoxLastName.Location = new Point(172, 325);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Padding = new Padding(2);
            textBoxLastName.Placeholder = null;
            textBoxLastName.Size = new Size(268, 41);
            textBoxLastName.TabIndex = 2;
            textBoxLastName.TextColor = Color.Black;
            textBoxLastName.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.MediumTurquoise;
            textBoxEmail.BorderColor = Color.Gray;
            textBoxEmail.BorderThickness = 2;
            textBoxEmail.CornerRadius = 15;
            textBoxEmail.Location = new Point(172, 372);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Padding = new Padding(2);
            textBoxEmail.Placeholder = null;
            textBoxEmail.Size = new Size(268, 45);
            textBoxEmail.TabIndex = 3;
            textBoxEmail.TextColor = Color.Black;
            textBoxEmail.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // textBoxPhone
            // 
            textBoxPhone.BackColor = Color.MediumTurquoise;
            textBoxPhone.BorderColor = Color.Gray;
            textBoxPhone.BorderThickness = 2;
            textBoxPhone.CornerRadius = 15;
            textBoxPhone.Location = new Point(172, 423);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Padding = new Padding(2);
            textBoxPhone.Placeholder = null;
            textBoxPhone.Size = new Size(268, 45);
            textBoxPhone.TabIndex = 4;
            textBoxPhone.TextColor = Color.Black;
            textBoxPhone.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(90, 291);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(34, 15);
            labelFirstName.TabIndex = 5;
            labelFirstName.Text = "Имя:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(90, 338);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(61, 15);
            labelLastName.TabIndex = 6;
            labelLastName.Text = "Фамилия:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(90, 388);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "Email:";
            labelEmail.Click += labelEmail_Click;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(90, 434);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(58, 15);
            labelPhone.TabIndex = 8;
            labelPhone.Text = "Телефон:";
            // 
            // buttonAddTeacher
            // 
            buttonAddTeacher.BackColor = Color.PaleTurquoise;
            buttonAddTeacher.CornerRadius = 30;
            buttonAddTeacher.FlatStyle = FlatStyle.Flat;
            buttonAddTeacher.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonAddTeacher.Location = new Point(523, 273);
            buttonAddTeacher.Name = "buttonAddTeacher";
            buttonAddTeacher.Size = new Size(167, 45);
            buttonAddTeacher.TabIndex = 9;
            buttonAddTeacher.Text = "Добавить";
            buttonAddTeacher.UseVisualStyleBackColor = true;
            buttonAddTeacher.Click += ButtonAddTeacher_Click;
            // 
            // buttonUpdateTeacher
            // 
            buttonUpdateTeacher.BackColor = Color.PaleTurquoise;
            buttonUpdateTeacher.CornerRadius = 30;
            buttonUpdateTeacher.FlatStyle = FlatStyle.Flat;
            buttonUpdateTeacher.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonUpdateTeacher.Location = new Point(523, 330);
            buttonUpdateTeacher.Name = "buttonUpdateTeacher";
            buttonUpdateTeacher.Size = new Size(167, 48);
            buttonUpdateTeacher.TabIndex = 10;
            buttonUpdateTeacher.Text = "Обновить";
            buttonUpdateTeacher.UseVisualStyleBackColor = true;
            buttonUpdateTeacher.Click += ButtonUpdateTeacher_Click;
            // 
            // buttonDeleteTeacher
            // 
            buttonDeleteTeacher.BackColor = Color.PaleTurquoise;
            buttonDeleteTeacher.CornerRadius = 30;
            buttonDeleteTeacher.FlatStyle = FlatStyle.Flat;
            buttonDeleteTeacher.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonDeleteTeacher.Location = new Point(523, 397);
            buttonDeleteTeacher.Name = "buttonDeleteTeacher";
            buttonDeleteTeacher.Size = new Size(167, 52);
            buttonDeleteTeacher.TabIndex = 11;
            buttonDeleteTeacher.Text = "Удалить";
            buttonDeleteTeacher.UseVisualStyleBackColor = true;
            buttonDeleteTeacher.Click += ButtonDeleteTeacher_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(782, 480);
            Controls.Add(buttonDeleteTeacher);
            Controls.Add(buttonUpdateTeacher);
            Controls.Add(buttonAddTeacher);
            Controls.Add(labelPhone);
            Controls.Add(labelEmail);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(dataGridViewTeachers);
            Name = "TeacherForm";
            Text = "Manage Teachers";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}