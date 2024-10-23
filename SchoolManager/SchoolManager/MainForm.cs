using System;
using System.Windows.Forms;

namespace SchoolManager
{
    public partial class MainForm : Form
    {
        public MainForm(int userId)
        {
            InitializeComponent()                      ;
            this.BackColor = System.Drawing.Color.LightBlue;
            //this.IsMdiContainer = true;
            this.FormClosed += MainForm_FormClosed;

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Если нет других открытых форм, приложение завершает работу
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void manageClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassForm classForm = new ClassForm();
            //classForm.MdiParent = this;
            classForm.Show();
        }

        private void manageStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            //studentsForm.MdiParent = this;
            studentsForm.Show();
        }

        private void maToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassroomsForm classroomsForm = new ClassroomsForm();
            //classroomsForm.MdiParent = this;
            classroomsForm.Show();
        }

        private void предметыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectsForm subjectsForm = new SubjectsForm();
            //subjectsForm.MdiParent = this;
            subjectsForm.Show();
        }

        private void учителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherForm teacherForm = new TeacherForm();
            //teacherForm.MdiParent = this;
            teacherForm.Show();
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm();
            //scheduleForm.MdiParent = this;
            scheduleForm.Show();
        }

        private void оценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradesForm gradesForm = new GradesForm();
            //gradesForm.MdiParent = this;
            gradesForm.Show();
        }

        private void выйтиИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            // Закрываем текущую форму (главную форму)
            this.Close();
        }

        private void выйтиИзПриложенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
		
    }
}



