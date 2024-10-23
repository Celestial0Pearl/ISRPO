namespace SchoolManager
{
    partial class StudentsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxFirstName = new RoundedTextBox();
            textBoxLastName = new RoundedTextBox();
            dateTimePickerDateOfBirth = new DateTimePicker();
            comboBoxClass = new ComboBox();
            buttonAdd = new RoundedButton();
            buttonUpdate = new RoundedButton();
            buttonDelete = new RoundedButton();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BackColor = Color.MediumTurquoise;
            textBoxFirstName.BorderColor = Color.Gray;
            textBoxFirstName.BorderThickness = 2;
            textBoxFirstName.CornerRadius = 15;
            textBoxFirstName.Location = new Point(100, 12);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Padding = new Padding(2);
            textBoxFirstName.Placeholder = null;
            textBoxFirstName.Size = new Size(224, 49);
            textBoxFirstName.TabIndex = 0;
            textBoxFirstName.TextColor = Color.Black;
            textBoxFirstName.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // textBoxLastName
            // 
            textBoxLastName.BackColor = Color.MediumTurquoise;
            textBoxLastName.BorderColor = Color.Gray;
            textBoxLastName.BorderThickness = 2;
            textBoxLastName.CornerRadius = 15;
            textBoxLastName.Location = new Point(100, 76);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Padding = new Padding(2);
            textBoxLastName.Placeholder = null;
            textBoxLastName.Size = new Size(224, 50);
            textBoxLastName.TabIndex = 1;
            textBoxLastName.TextColor = Color.Black;
            textBoxLastName.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // dateTimePickerDateOfBirth
            // 
            dateTimePickerDateOfBirth.Location = new Point(497, 26);
            dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            dateTimePickerDateOfBirth.Size = new Size(200, 23);
            dateTimePickerDateOfBirth.TabIndex = 2;
            // 
            // comboBoxClass
            // 
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(497, 72);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(121, 23);
            comboBoxClass.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.PaleTurquoise;
            buttonAdd.CornerRadius = 30;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(47, 132);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(156, 51);
            buttonAdd.TabIndex = 4;
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
            buttonUpdate.Location = new Point(285, 132);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(155, 51);
            buttonUpdate.TabIndex = 5;
            buttonUpdate.Text = "Изменить";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += ButtonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.PaleTurquoise;
            buttonDelete.CornerRadius = 30;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonDelete.Location = new Point(529, 132);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(145, 51);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(66, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(541, 168);
            dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 26);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 8;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 89);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 9;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 26);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 10;
            label3.Text = "Дата рождения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(432, 75);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 11;
            label4.Text = "Класс";
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(722, 418);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxClass);
            Controls.Add(dateTimePickerDateOfBirth);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Name = "StudentsForm";
            Text = "StudentsForm";
            Load += StudentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedTextBox textBoxFirstName;
        private RoundedTextBox textBoxLastName;
        private DateTimePicker dateTimePickerDateOfBirth;
        private ComboBox comboBoxClass;
        private RoundedButton buttonAdd;
        private RoundedButton buttonUpdate;
        private RoundedButton buttonDelete;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
