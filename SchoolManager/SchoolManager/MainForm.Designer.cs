namespace SchoolManager
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem manageClassesMenuItem;

        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            manageClassesMenuItem = new ToolStripMenuItem();
            manageClassesToolStripMenuItem = new ToolStripMenuItem();
            manageStudentsToolStripMenuItem = new ToolStripMenuItem();
            maToolStripMenuItem = new ToolStripMenuItem();
            предметыToolStripMenuItem = new ToolStripMenuItem();
            учителяToolStripMenuItem = new ToolStripMenuItem();
            расписаниеToolStripMenuItem = new ToolStripMenuItem();
            оценкиToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            выйтиИзАккаунтаToolStripMenuItem = new ToolStripMenuItem();
            выйтиИзПриложенияToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.DarkTurquoise;
            menuStrip.Items.AddRange(new ToolStripItem[] { manageClassesMenuItem, выходToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // manageClassesMenuItem
            // 
            manageClassesMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageClassesToolStripMenuItem, manageStudentsToolStripMenuItem, maToolStripMenuItem, предметыToolStripMenuItem, учителяToolStripMenuItem, расписаниеToolStripMenuItem, оценкиToolStripMenuItem });
            manageClassesMenuItem.Name = "manageClassesMenuItem";
            manageClassesMenuItem.Size = new Size(53, 20);
            manageClassesMenuItem.Text = "Меню";
            // 
            // manageClassesToolStripMenuItem
            // 
            manageClassesToolStripMenuItem.Name = "manageClassesToolStripMenuItem";
            manageClassesToolStripMenuItem.Size = new Size(139, 22);
            manageClassesToolStripMenuItem.Text = "Классы";
            manageClassesToolStripMenuItem.Click += manageClassesToolStripMenuItem_Click;
            // 
            // manageStudentsToolStripMenuItem
            // 
            manageStudentsToolStripMenuItem.Name = "manageStudentsToolStripMenuItem";
            manageStudentsToolStripMenuItem.Size = new Size(139, 22);
            manageStudentsToolStripMenuItem.Text = "Ученики";
            manageStudentsToolStripMenuItem.Click += manageStudentsToolStripMenuItem_Click;
            // 
            // maToolStripMenuItem
            // 
            maToolStripMenuItem.Name = "maToolStripMenuItem";
            maToolStripMenuItem.Size = new Size(139, 22);
            maToolStripMenuItem.Text = "Кабинеты";
            maToolStripMenuItem.Click += maToolStripMenuItem_Click;
            // 
            // предметыToolStripMenuItem
            // 
            предметыToolStripMenuItem.Name = "предметыToolStripMenuItem";
            предметыToolStripMenuItem.Size = new Size(139, 22);
            предметыToolStripMenuItem.Text = "Предметы";
            предметыToolStripMenuItem.Click += предметыToolStripMenuItem_Click;
            // 
            // учителяToolStripMenuItem
            // 
            учителяToolStripMenuItem.Name = "учителяToolStripMenuItem";
            учителяToolStripMenuItem.Size = new Size(139, 22);
            учителяToolStripMenuItem.Text = "Учителя";
            учителяToolStripMenuItem.Click += учителяToolStripMenuItem_Click;
            // 
            // расписаниеToolStripMenuItem
            // 
            расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            расписаниеToolStripMenuItem.Size = new Size(139, 22);
            расписаниеToolStripMenuItem.Text = "Расписание";
            расписаниеToolStripMenuItem.Click += расписаниеToolStripMenuItem_Click;
            // 
            // оценкиToolStripMenuItem
            // 
            оценкиToolStripMenuItem.Name = "оценкиToolStripMenuItem";
            оценкиToolStripMenuItem.Size = new Size(139, 22);
            оценкиToolStripMenuItem.Text = "Оценки";
            оценкиToolStripMenuItem.Click += оценкиToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выйтиИзАккаунтаToolStripMenuItem, выйтиИзПриложенияToolStripMenuItem });
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(54, 20);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // выйтиИзАккаунтаToolStripMenuItem
            // 
            выйтиИзАккаунтаToolStripMenuItem.Name = "выйтиИзАккаунтаToolStripMenuItem";
            выйтиИзАккаунтаToolStripMenuItem.Size = new Size(197, 22);
            выйтиИзАккаунтаToolStripMenuItem.Text = "Выйти из аккаунта";
            выйтиИзАккаунтаToolStripMenuItem.Click += выйтиИзАккаунтаToolStripMenuItem_Click;
            // 
            // выйтиИзПриложенияToolStripMenuItem
            // 
            выйтиИзПриложенияToolStripMenuItem.Name = "выйтиИзПриложенияToolStripMenuItem";
            выйтиИзПриложенияToolStripMenuItem.Size = new Size(197, 22);
            выйтиИзПриложенияToolStripMenuItem.Text = "Выйти из приложения";
            выйтиИзПриложенияToolStripMenuItem.Click += выйтиИзПриложенияToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            BackColor = Color.DarkTurquoise;
            BackgroundImage = Properties.Resources.pngwing_com__1_;
            ClientSize = new Size(800, 592);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "School Manager";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private ToolStripMenuItem manageClassesToolStripMenuItem;
        private ToolStripMenuItem manageStudentsToolStripMenuItem;
        private ToolStripMenuItem maToolStripMenuItem;
        private ToolStripMenuItem предметыToolStripMenuItem;
        private ToolStripMenuItem учителяToolStripMenuItem;
        private ToolStripMenuItem расписаниеToolStripMenuItem;
        private ToolStripMenuItem оценкиToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem выйтиИзАккаунтаToolStripMenuItem;
        private ToolStripMenuItem выйтиИзПриложенияToolStripMenuItem;
    }
}




