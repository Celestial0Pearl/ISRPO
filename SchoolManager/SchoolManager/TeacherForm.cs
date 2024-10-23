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
    public partial class TeacherForm : Form
    {
        private string connectionString = Config.ConnectionString;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public TeacherForm()
        {
            InitializeComponent();
            LoadData();
            this.FormClosed += TeacherForm_FormClosed;
        }

        private void TeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Если нет других открытых форм, приложение завершает работу
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM teachers", connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridViewTeachers.DataSource = dataTable;
            }
        }

        private void ButtonAddTeacher_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxFirstName.Text) && !string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO teachers (first_name, last_name, email, phone) VALUES (@FirstName, @LastName, @Email, @Phone)", connection);
                    command.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                    command.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                    command.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
                    command.ExecuteNonQuery();
                }

                LoadData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please enter both first and last names.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonUpdateTeacher_Click(object sender, EventArgs e)
        {
            if (dataGridViewTeachers.SelectedRows.Count > 0)
            {
                if (!string.IsNullOrWhiteSpace(textBoxFirstName.Text) && !string.IsNullOrWhiteSpace(textBoxLastName.Text))
                {
                    DataGridViewRow selectedRow = dataGridViewTeachers.SelectedRows[0];
                    int teacherId = Convert.ToInt32(selectedRow.Cells["teacher_id"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("UPDATE teachers SET first_name = @FirstName, last_name = @LastName, email = @Email, phone = @Phone WHERE teacher_id = @TeacherId", connection);
                        command.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                        command.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                        command.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        command.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
                        command.Parameters.AddWithValue("@TeacherId", teacherId);
                        command.ExecuteNonQuery();
                    }

                    LoadData();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please enter both first and last names.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a teacher to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (dataGridViewTeachers.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранного преподавателя?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridViewTeachers.SelectedRows[0];
                    int teacherId = Convert.ToInt32(selectedRow.Cells["teacher_id"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM teachers WHERE teacher_id = @TeacherId", connection);
                        command.Parameters.AddWithValue("@TeacherId", teacherId);
                        command.ExecuteNonQuery();
                    }

                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a teacher to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearFields()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
