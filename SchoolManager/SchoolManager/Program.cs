using SchoolManager;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Открываем форму авторизации
        LoginForm loginForm = new LoginForm();
        Application.Run(loginForm);
    }
}