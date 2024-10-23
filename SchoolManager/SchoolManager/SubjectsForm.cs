using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolManager
{
    public partial class SubjectsForm : Form
    {
        private string connectionString = Config.ConnectionString;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public SubjectsForm()
        {
            InitializeComponent();
            LoadData();
            this.FormClosed += SubjectsForm_FormClosed;
        }

        private void SubjectsForm_FormClosed(object sender, FormClosedEventArgs e)
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
                dataAdapter = new SqlDataAdapter("SELECT * FROM subjects", connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridViewSubjects.DataSource = dataTable;
            }
        }

        private void ButtonAddSubject_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSubjectName.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO subjects (subject_name) VALUES (@SubjectName)", connection);
                    command.Parameters.AddWithValue("@SubjectName", textBoxSubjectName.Text);
                    command.ExecuteNonQuery();
                }

                LoadData();
                textBoxSubjectName.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a subject name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonUpdateSubject_Click(object sender, EventArgs e)
        {
            if (dataGridViewSubjects.SelectedRows.Count > 0)
            {
                if (!string.IsNullOrWhiteSpace(textBoxSubjectName.Text))
                {
                    DataGridViewRow selectedRow = dataGridViewSubjects.SelectedRows[0];
                    int subjectId = Convert.ToInt32(selectedRow.Cells["subject_id"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("UPDATE subjects SET subject_name = @SubjectName WHERE subject_id = @SubjectId", connection);
                        command.Parameters.AddWithValue("@SubjectName", textBoxSubjectName.Text);
                        command.Parameters.AddWithValue("@SubjectId", subjectId);
                        command.ExecuteNonQuery();
                    }

                    LoadData();
                    textBoxSubjectName.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a subject name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a subject to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonDeleteSubject_Click(object sender, EventArgs e)
        {
            if (dataGridViewSubjects.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранный предмет?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridViewSubjects.SelectedRows[0];
                    int subjectId = Convert.ToInt32(selectedRow.Cells["subject_id"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM subjects WHERE subject_id = @SubjectId", connection);
                        command.Parameters.AddWithValue("@SubjectId", subjectId);
                        command.ExecuteNonQuery();
                    }

                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a subject to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

