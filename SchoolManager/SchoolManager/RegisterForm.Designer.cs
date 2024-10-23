namespace SchoolManager
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private RoundedTextBox txtEmail;
        private RoundedTextBox txtPassword;
        private RoundedButton btnRegister;

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
            txtEmail = new RoundedTextBox();
            txtPassword = new RoundedTextBox();
            btnRegister = new RoundedButton();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.MediumTurquoise;
            txtEmail.BorderColor = Color.Gray;
            txtEmail.BorderThickness = 2;
            txtEmail.CornerRadius = 15;
            txtEmail.Location = new Point(173, 24);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(2);
            txtEmail.Placeholder = "Email";
            txtEmail.Size = new Size(327, 47);
            txtEmail.TabIndex = 1;
            txtEmail.TextColor = Color.Black;
            txtEmail.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.MediumTurquoise;
            txtPassword.BorderColor = Color.Gray;
            txtPassword.BorderThickness = 2;
            txtPassword.CornerRadius = 15;
            txtPassword.Location = new Point(173, 105);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(2);
            txtPassword.Placeholder = "Пароль";
            txtPassword.Size = new Size(327, 50);
            txtPassword.TabIndex = 2;
            txtPassword.TextColor = Color.Black;
            txtPassword.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.PaleTurquoise;
            btnRegister.CornerRadius = 30;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnRegister.Location = new Point(98, 210);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(336, 46);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Регистрация";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(62, 33);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(52, 119);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 6;
            label3.Text = "Пароль";
            // 
            // RegisterForm
            // 
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(512, 268);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Name = "RegisterForm";
            Text = "SchoolManager: Register";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;
        private Label label3;
    }
}