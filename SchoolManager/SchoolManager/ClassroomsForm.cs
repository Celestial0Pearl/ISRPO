using System.Data;
using System.Data.SqlClient;

namespace SchoolManager
{
    public partial class ClassroomsForm : Form
    {
        private string connectionString = Config.ConnectionString;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public ClassroomsForm()
        {
            InitializeComponent();
            LoadData();
            this.FormClosed += ClassroomsForm_FormClosed;
        }

        private void ClassroomsForm_FormClosed(object sender, FormClosedEventArgs e)
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
                dataAdapter = new SqlDataAdapter("SELECT * FROM classrooms", connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridViewClassrooms.DataSource = dataTable;
            }
        }

        private void ButtonAddClassroom_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxRoomNumber.Text) && !string.IsNullOrWhiteSpace(textBoxCapacity.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO classrooms (room_number, capacity) VALUES (@RoomNumber, @Capacity)", connection);
                    command.Parameters.AddWithValue("@RoomNumber", textBoxRoomNumber.Text);
                    command.Parameters.AddWithValue("@Capacity", textBoxCapacity.Text);
                    command.ExecuteNonQuery();
                }

                LoadData();
                textBoxRoomNumber.Clear();
                textBoxCapacity.Clear();
            }
            else
            {
                MessageBox.Show("Please enter both room number and capacity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonUpdateClassroom_Click(object sender, EventArgs e)
        {
            if (dataGridViewClassrooms.SelectedRows.Count > 0)
            {
                if (!string.IsNullOrWhiteSpace(textBoxRoomNumber.Text) && !string.IsNullOrWhiteSpace(textBoxCapacity.Text))
                {
                    DataGridViewRow selectedRow = dataGridViewClassrooms.SelectedRows[0];
                    int classroomId = Convert.ToInt32(selectedRow.Cells["classroom_id"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("UPDATE classrooms SET room_number = @RoomNumber, capacity = @Capacity WHERE classroom_id = @ClassroomId", connection);
                        command.Parameters.AddWithValue("@RoomNumber", textBoxRoomNumber.Text);
                        command.Parameters.AddWithValue("@Capacity", textBoxCapacity.Text);
                        command.Parameters.AddWithValue("@ClassroomId", classroomId);
                        command.ExecuteNonQuery();
                    }

                    LoadData();
                    textBoxRoomNumber.Clear();
                    textBoxCapacity.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter both room number and capacity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a classroom to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonDeleteClassroom_Click(object sender, EventArgs e)
        {
            if (dataGridViewClassrooms.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранный кабинет?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridViewClassrooms.SelectedRows[0];
                    int classroomId = Convert.ToInt32(selectedRow.Cells["classroom_id"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM classrooms WHERE classroom_id = @ClassroomId", connection);
                        command.Parameters.AddWithValue("@ClassroomId", classroomId);
                        command.ExecuteNonQuery();
                    }

                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a classroom to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
