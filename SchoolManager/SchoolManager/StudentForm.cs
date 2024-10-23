using System.Data.Common;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManager
{
    public partial class StudentsForm : Form
    {
        private string connectionString = Config.ConnectionString;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public StudentsForm()
        {
            InitializeComponent();
            LoadData();
            LoadClasses();
            this.FormClosed += StudentsForm_FormClosed;

        }

        private void StudentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ≈сли нет других открытых форм, приложение завершает работу
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
                dataAdapter = new SqlDataAdapter("SELECT * FROM students", connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void LoadClasses()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter classAdapter = new SqlDataAdapter("SELECT class_id, class_name FROM classes", connection);
                DataTable classTable = new DataTable();
                classAdapter.Fill(classTable);
                comboBoxClass.DataSource = classTable;
                comboBoxClass.DisplayMember = "class_name";
                comboBoxClass.ValueMember = "class_id";
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO students (first_name, last_name, date_of_birth, class_id) VALUES (@FirstName, @LastName, @DateOfBirth, @ClassId)", connection);
                command.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                command.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                command.Parameters.AddWithValue("@DateOfBirth", dateTimePickerDateOfBirth.Value);
                command.Parameters.AddWithValue("@ClassId", Convert.ToInt32(comboBoxClass.SelectedValue));
                command.ExecuteNonQuery();
            }

            LoadData();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int studentId = Convert.ToInt32(selectedRow.Cells["student_id"].Value);

                // Open connection and create command
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Prepare the SQL command for updating the student
                    SqlCommand command = new SqlCommand("UPDATE students SET first_name = @FirstName, last_name = @LastName, date_of_birth = @DateOfBirth, class_id = @ClassId WHERE student_id = @StudentId", connection);
                    command.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                    command.Parameters.AddWithValue("@DateOfBirth", dateTimePickerDateOfBirth.Value);
                    command.Parameters.AddWithValue("@ClassId", Convert.ToInt32(comboBoxClass.SelectedValue));
                    command.Parameters.AddWithValue("@StudentId", studentId);

                    // Execute the command and check if any rows were affected
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student details updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Reload data
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Please try again.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Confirm deletion
                DialogResult result = MessageBox.Show("¬ы уверены, что хотите удалить выбранный урок?", "ѕодтверждение удалени€", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int studentId = Convert.ToInt32(selectedRow.Cells["student_id"].Value);

                    // Open connection and create command
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM students WHERE student_id = @StudentId", connection);
                        command.Parameters.AddWithValue("@StudentId", studentId);
                        command.ExecuteNonQuery();
                    }

                    // Remove the row from DataGridView
                    dataGridView1.Rows.Remove(selectedRow);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
