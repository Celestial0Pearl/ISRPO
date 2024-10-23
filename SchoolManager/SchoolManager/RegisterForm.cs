using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager
{
    public partial class RegisterForm : Form
    {
        private SqlConnection _connection;

        public RegisterForm()
        {
            InitializeComponent();
            _connection = new SqlConnection(Config.ConnectionString);
            this.FormClosed += RegisterForm_FormClosed;
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Если нет других открытых форм, приложение завершает работу
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            string query = "INSERT INTO Users (Email, Password) VALUES (@Email, @Password)";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();

                MessageBox.Show("Регистрация успешна. Теперь вы можете войти.");
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
