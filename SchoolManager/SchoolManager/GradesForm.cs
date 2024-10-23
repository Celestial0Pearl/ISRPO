using System.Data;
using System.Data.SqlClient;

namespace SchoolManager
{
    public partial class GradesForm : Form
    {
        private string connectionString = Config.ConnectionString;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public GradesForm()
        {
            InitializeComponent();
            LoadData();
            LoadStudents();
            LoadSubjects();
            this.FormClosed += GradesForm_FormClosed;
        }

        private void GradesForm_FormClosed(object sender, FormClosedEventArgs e)
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
                dataAdapter = new SqlDataAdapter(@"SELECT g.grade_id, s.first_name + ' ' + s.last_name AS student_name, 
                                                  sb.subject_name, g.grade_value, g.date 
                                                  FROM grades g
                                                  JOIN students s ON g.student_id = s.student_id
                                                  JOIN subjects sb ON g.subject_id = sb.subject_id", connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridViewGrades.DataSource = dataTable;
            }
        }

        private void LoadStudents()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter studentAdapter = new SqlDataAdapter("SELECT student_id, first_name + ' ' + last_name AS student_name FROM students", connection);
                DataTable studentTable = new DataTable();
                studentAdapter.Fill(studentTable);
                comboBoxStudents.DataSource = studentTable;
                comboBoxStudents.DisplayMember = "student_name";
                comboBoxStudents.ValueMember = "student_id";
            }
        }

        private void LoadSubjects()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter subjectAdapter = new SqlDataAdapter("SELECT subject_id, subject_name FROM subjects", connection);
                DataTable subjectTable = new DataTable();
                subjectAdapter.Fill(subjectTable);
                comboBoxSubjects.DataSource = subjectTable;
                comboBoxSubjects.DisplayMember = "subject_name";
                comboBoxSubjects.ValueMember = "subject_id";
            }
        }

        private void ButtonAddGrade_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO grades (student_id, subject_id, grade_value, date) VALUES (@StudentId, @SubjectId, @GradeValue, @Date)", connection);
                command.Parameters.AddWithValue("@StudentId", Convert.ToInt32(comboBoxStudents.SelectedValue));
                command.Parameters.AddWithValue("@SubjectId", Convert.ToInt32(comboBoxSubjects.SelectedValue));
                command.Parameters.AddWithValue("@GradeValue", numericUpDownGrade.Value);
                command.Parameters.AddWithValue("@Date", dateTimePickerDate.Value);
                command.ExecuteNonQuery();
            }

            LoadData();
        }

        private void ButtonUpdateGrade_Click(object sender, EventArgs e)
        {
            if (dataGridViewGrades.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewGrades.SelectedRows[0];
                int gradeId = Convert.ToInt32(selectedRow.Cells["grade_id"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE grades SET student_id = @StudentId, subject_id = @SubjectId, grade_value = @GradeValue, date = @Date WHERE grade_id = @GradeId", connection);
                    command.Parameters.AddWithValue("@StudentId", Convert.ToInt32(comboBoxStudents.SelectedValue));
                    command.Parameters.AddWithValue("@SubjectId", Convert.ToInt32(comboBoxSubjects.SelectedValue));
                    command.Parameters.AddWithValue("@GradeValue", numericUpDownGrade.Value);
                    command.Parameters.AddWithValue("@Date", dateTimePickerDate.Value);
                    command.Parameters.AddWithValue("@GradeId", gradeId);
                    command.ExecuteNonQuery();
                }

                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a grade to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonDeleteGrade_Click(object sender, EventArgs e)
        {
            if (dataGridViewGrades.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную оценку?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridViewGrades.SelectedRows[0];
                    int gradeId = Convert.ToInt32(selectedRow.Cells["grade_id"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM grades WHERE grade_id = @GradeId", connection);
                        command.Parameters.AddWithValue("@GradeId", gradeId);
                        command.ExecuteNonQuery();
                    }

                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a grade to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
