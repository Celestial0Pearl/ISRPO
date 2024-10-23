namespace SchoolManager
{
    partial class ClassForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewClasses;
        private RoundedTextBox textBoxClassName;
        private RoundedButton buttonAddClass;
        private RoundedButton buttonUpdateClass;
        private RoundedButton buttonDeleteClass;

        private void InitializeComponent()
        {
            dataGridViewClasses = new DataGridView();
            textBoxClassName = new RoundedTextBox();
            buttonAddClass = new RoundedButton();
            buttonUpdateClass = new RoundedButton();
            buttonDeleteClass = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClasses).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClasses
            // 
            dataGridViewClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClasses.Location = new Point(12, 103);
            dataGridViewClasses.Name = "dataGridViewClasses";
            dataGridViewClasses.Size = new Size(281, 250);
            dataGridViewClasses.TabIndex = 0;
            // 
            // textBoxClassName
            // 
            textBoxClassName.BackColor = Color.MediumTurquoise;
            textBoxClassName.BorderColor = Color.Gray;
            textBoxClassName.BorderThickness = 2;
            textBoxClassName.CornerRadius = 15;
            textBoxClassName.Location = new Point(12, 12);
            textBoxClassName.Name = "textBoxClassName";
            textBoxClassName.Padding = new Padding(2);
            textBoxClassName.Placeholder = null;
            textBoxClassName.Size = new Size(281, 57);
            textBoxClassName.TabIndex = 1;
            textBoxClassName.TextColor = Color.Black;
            textBoxClassName.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // buttonAddClass
            // 
            buttonAddClass.BackColor = Color.PaleTurquoise;
            buttonAddClass.CornerRadius = 30;
            buttonAddClass.FlatStyle = FlatStyle.Flat;
            buttonAddClass.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonAddClass.Location = new Point(305, 21);
            buttonAddClass.Name = "buttonAddClass";
            buttonAddClass.Size = new Size(135, 48);
            buttonAddClass.TabIndex = 2;
            buttonAddClass.Text = "Добавить";
            buttonAddClass.UseVisualStyleBackColor = true;
            buttonAddClass.Click += ButtonAddClass_Click;
            // 
            // buttonUpdateClass
            // 
            buttonUpdateClass.BackColor = Color.PaleTurquoise;
            buttonUpdateClass.CornerRadius = 30;
            buttonUpdateClass.FlatStyle = FlatStyle.Flat;
            buttonUpdateClass.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonUpdateClass.Location = new Point(305, 129);
            buttonUpdateClass.Name = "buttonUpdateClass";
            buttonUpdateClass.Size = new Size(135, 48);
            buttonUpdateClass.TabIndex = 3;
            buttonUpdateClass.Text = "Обновить";
            buttonUpdateClass.UseVisualStyleBackColor = true;
            buttonUpdateClass.Click += ButtonUpdateClass_Click;
            // 
            // buttonDeleteClass
            // 
            buttonDeleteClass.BackColor = Color.PaleTurquoise;
            buttonDeleteClass.CornerRadius = 30;
            buttonDeleteClass.FlatStyle = FlatStyle.Flat;
            buttonDeleteClass.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonDeleteClass.Location = new Point(307, 75);
            buttonDeleteClass.Name = "buttonDeleteClass";
            buttonDeleteClass.Size = new Size(133, 48);
            buttonDeleteClass.TabIndex = 4;
            buttonDeleteClass.Text = "Удалить";
            buttonDeleteClass.UseVisualStyleBackColor = true;
            buttonDeleteClass.Click += ButtonDeleteClass_Click;
            // 
            // ClassForm
            // 
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(475, 388);
            Controls.Add(buttonDeleteClass);
            Controls.Add(buttonUpdateClass);
            Controls.Add(buttonAddClass);
            Controls.Add(textBoxClassName);
            Controls.Add(dataGridViewClasses);
            Name = "ClassForm";
            Text = "Manage Classes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClasses).EndInit();
            ResumeLayout(false);
        }
    }
}