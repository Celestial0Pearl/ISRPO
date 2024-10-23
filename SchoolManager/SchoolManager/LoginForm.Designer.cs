namespace SchoolManager
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private RoundedTextBox txtEmail;
        private RoundedTextBox txtPassword;
        private RoundedButton btnLogin;
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
            btnLogin = new RoundedButton();
            btnRegister = new RoundedButton();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.MediumTurquoise;
            txtEmail.BorderColor = Color.Gray;
            txtEmail.BorderThickness = 2;
            txtEmail.CornerRadius = 15;
            txtEmail.Location = new Point(215, 25);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(2);
            txtEmail.Placeholder = "Email";
            txtEmail.Size = new Size(334, 51);
            txtEmail.TabIndex = 0;
            txtEmail.TextColor = Color.Black;
            txtEmail.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.MediumTurquoise;
            txtPassword.BorderColor = Color.Gray;
            txtPassword.BorderThickness = 2;
            txtPassword.CornerRadius = 15;
            txtPassword.Location = new Point(215, 92);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(2);
            txtPassword.Placeholder = "Пароль";
            txtPassword.Size = new Size(334, 53);
            txtPassword.TabIndex = 1;
            txtPassword.TextColor = Color.Black;
            txtPassword.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.PaleTurquoise;
            btnLogin.CornerRadius = 30;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnLogin.Location = new Point(161, 162);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(295, 51);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Вход";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.PaleTurquoise;
            btnRegister.CornerRadius = 30;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnRegister.Location = new Point(161, 219);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(295, 51);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Регистрация";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(121, 39);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(121, 106);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 5;
            label2.Text = "Пароль";
            // 
            // LoginForm
            // 
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(611, 282);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Name = "LoginForm";
            Text = "SchoolManager: Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
    }
}