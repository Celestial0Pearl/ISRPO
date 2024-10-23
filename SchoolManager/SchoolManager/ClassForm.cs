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
    public partial class ClassForm : Form
    {
        private string connectionString = Config.ConnectionString;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public ClassForm()
        {
            InitializeComponent();
            LoadData();
            this.FormClosed += ClassForm_FormClosed;
        }

        private void ClassForm_FormClosed(object sender, FormClosedEventArgs e)
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
                dataAdapter = new SqlDataAdapter("SELECT * FROM classes", connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridViewClasses.DataSource = dataTable;
            }
        }

        private void ButtonAddClass_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxClassName.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO classes (class_name) VALUES (@ClassName)", connection);
                    command.Parameters.AddWithValue("@ClassName", textBoxClassName.Text);
                    command.ExecuteNonQuery();
                }

                LoadData();
                textBoxClassName.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a class name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonUpdateClass_Click(object sender, EventArgs e)
        {
            if (dataGridViewClasses.SelectedRows.Count > 0)
            {
                if (!string.IsNullOrWhiteSpace(textBoxClassName.Text))
                {
                    DataGridViewRow selectedRow = dataGridViewClasses.SelectedRows[0];
                    int classId = Convert.ToInt32(selectedRow.Cells["class_id"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("UPDATE classes SET class_name = @ClassName WHERE class_id = @ClassId", connection);
                        command.Parameters.AddWithValue("@ClassName", textBoxClassName.Text);
                        command.Parameters.AddWithValue("@ClassId", classId);
                        command.ExecuteNonQuery();
                    }

                    LoadData();
                    textBoxClassName.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a class name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a class to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonDeleteClass_Click(object sender, EventArgs e)
        {
            if (dataGridViewClasses.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранный класс?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridViewClasses.SelectedRows[0];
                    int classId = Convert.ToInt32(selectedRow.Cells["class_id"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM classes WHERE class_id = @ClassId", connection);
                        command.Parameters.AddWithValue("@ClassId", classId);
                        command.ExecuteNonQuery();
                    }

                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a class to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
