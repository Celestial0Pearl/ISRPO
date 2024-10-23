using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager
{
    public partial class ScheduleForm : Form
    {
        private string connectionString = Config.ConnectionString;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public ScheduleForm()
        {
            InitializeComponent();
            LoadData();
            LoadDropdowns();
            this.FormClosed += ScheduleForm_FormClosed;
        }

        private void ScheduleForm_FormClosed(object sender, FormClosedEventArgs e)
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
                var command = "SELECT \r\n    s.schedule_id,\r\n    sub.subject_name AS subject,\r\n    CONCAT(t.first_name, ' ', t.last_name) AS teacher,\r\n    c.class_name AS class,\r\n    cr.room_number AS classroom,\r\n    s.start_time,\r\n    s.end_time,\r\n    s.day_of_week\r\nFROM \r\n    schedule s\r\nJOIN \r\n    subjects sub ON s.subject_id = sub.subject_id\r\nJOIN \r\n    teachers t ON s.teacher_id = t.teacher_id\r\nJOIN \r\n    classrooms cr ON s.classroom_id = cr.classroom_id\r\nJOIN \r\n    classes c ON s.class_id = c.class_id\r\nORDER BY \r\n    s.schedule_id;";
                connection.Open();
                dataAdapter = new SqlDataAdapter(command, connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridViewSchedule.DataSource = dataTable;
            }
        }

        private void LoadDropdowns()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Load Subjects
                SqlDataAdapter subjectAdapter = new SqlDataAdapter("SELECT subject_id, subject_name FROM subjects", connection);
                DataTable subjectTable = new DataTable();
                subjectAdapter.Fill(subjectTable);
                comboBoxSubject.DataSource = subjectTable;
                comboBoxSubject.DisplayMember = "subject_name";
                comboBoxSubject.ValueMember = "subject_id";

                // Load Teachers
                SqlDataAdapter teacherAdapter = new SqlDataAdapter("SELECT teacher_id, CONCAT(first_name, ' ', last_name) AS full_name FROM teachers", connection);
                DataTable teacherTable = new DataTable();
                teacherAdapter.Fill(teacherTable);
                comboBoxTeacher.DataSource = teacherTable;
                comboBoxTeacher.DisplayMember = "full_name";
                comboBoxTeacher.ValueMember = "teacher_id";

                // Load Classrooms
                SqlDataAdapter classroomAdapter = new SqlDataAdapter("SELECT classroom_id, room_number FROM classrooms", connection);
                DataTable classroomTable = new DataTable();
                classroomAdapter.Fill(classroomTable);
                comboBoxClassroom.DataSource = classroomTable;
                comboBoxClassroom.DisplayMember = "room_number";
                comboBoxClassroom.ValueMember = "classroom_id";

                // Load Classes
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
                SqlCommand command = new SqlCommand("INSERT INTO schedule (subject_id, teacher_id, classroom_id, class_id, start_time, end_time, day_of_week) VALUES (@SubjectId, @TeacherId, @ClassroomId, @ClassId, @StartTime, @EndTime, @DayOfWeek)", connection);
                command.Parameters.AddWithValue("@SubjectId", Convert.ToInt32(comboBoxSubject.SelectedValue));
                command.Parameters.AddWithValue("@TeacherId", Convert.ToInt32(comboBoxTeacher.SelectedValue));
                command.Parameters.AddWithValue("@ClassroomId", Convert.ToInt32(comboBoxClassroom.SelectedValue));
                command.Parameters.AddWithValue("@ClassId", Convert.ToInt32(comboBoxClass.SelectedValue));
                command.Parameters.AddWithValue("@StartTime", new DateTime(timePickerStartTime.Value.TimeOfDay.Ticks).ToString("HH:mm:ss"));
                command.Parameters.AddWithValue("@EndTime", new DateTime(timePickerEndTime.Value.TimeOfDay.Ticks).ToString("HH:mm:ss"));
                command.Parameters.AddWithValue("@DayOfWeek", comboBoxDayOfWeek.SelectedItem?.ToString() ?? "Понедельник");

                command.ExecuteNonQuery();
            }

            LoadData();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewSchedule.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewSchedule.SelectedRows[0];
                int scheduleId = Convert.ToInt32(selectedRow.Cells["schedule_id"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE schedule SET subject_id = @SubjectId, teacher_id = @TeacherId, classroom_id = @ClassroomId, class_id = @ClassId, start_time = @StartTime, end_time = @EndTime, day_of_week = @DayOfWeek WHERE schedule_id = @ScheduleId", connection);
                    command.Parameters.AddWithValue("@SubjectId", Convert.ToInt32(comboBoxSubject.SelectedValue));
                    command.Parameters.AddWithValue("@TeacherId", Convert.ToInt32(comboBoxTeacher.SelectedValue));
                    command.Parameters.AddWithValue("@ClassroomId", Convert.ToInt32(comboBoxClassroom.SelectedValue));
                    command.Parameters.AddWithValue("@ClassId", Convert.ToInt32(comboBoxClass.SelectedValue));
                    command.Parameters.AddWithValue("@StartTime", new DateTime(timePickerStartTime.Value.TimeOfDay.Ticks).ToString("HH:mm:ss"));
                    command.Parameters.AddWithValue("@EndTime", new DateTime(timePickerEndTime.Value.TimeOfDay.Ticks).ToString("HH:mm:ss"));
                    command.Parameters.AddWithValue("@DayOfWeek", comboBoxDayOfWeek.SelectedItem?.ToString() ?? "Понедельник");
                    command.Parameters.AddWithValue("@ScheduleId", scheduleId);

                    command.ExecuteNonQuery();
                }

                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSchedule.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранный урок?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridViewSchedule.SelectedRows[0];
                    int scheduleId = Convert.ToInt32(selectedRow.Cells["schedule_id"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM schedule WHERE schedule_id = @ScheduleId", connection);
                        command.Parameters.AddWithValue("@ScheduleId", scheduleId);
                        command.ExecuteNonQuery();
                    }

                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
