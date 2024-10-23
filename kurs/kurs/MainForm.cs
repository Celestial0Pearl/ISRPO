using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static kurs.Utils.DictionaryService;

namespace kurs
{
    public partial class MainForm : Form
    {
        private char computerChar;
        private string symbols = rus_str;
        private List<string> dict;
        private List<string> events;
        public MainForm()
        {
            // включаем поддержку прозрачных стилей
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            // получаем список слов из словаря
            dict = GetSortedDictionary();
            events = new List<string>();
            InitializeComponent();

            // после инициализации формы проставляем прозрачные стили для компонентов
            label1.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;

            // проставляем компонентам состояние "игра не начата" и пишем сообщение в консоль игры
            SetNoGame();
            AddEvent("Приложение запущено");
        }

        // метод для показа сообщения об ошибке внутри игры
        private void ShowError(string text)
        {
            MessageBox.Show(
                text,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // метод для показа сообщения об успешном выполнении действия
        private void ShowSuccess(string text)
        {
            MessageBox.Show(
                text,
                "Успех!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // метод для написания в консоль игрового события с привязкой ко времени
        private void AddEvent(string eventText)
        {
            var str = DateTime.Now.ToString() + " - - - " + eventText + "\r\n";
            events.Add(str);

            textBox2.AppendText(str);
            ActiveControl = textBox1;
        }

        // метод для установки в компонентах состояния "игра не начата"
        // изменяем видимость кнопок и текст заголовка
        private void SetNoGame()
        {
            label1.Text = "Начните играть, и угадайте задуманную букву!";
            label2.Visible = false;
            pictureBox2.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            textBox1.Clear();
            groupBox1.Visible = false;
        }

        // метод для установки в компонентах состояния "игра началась"
        // изменяем видимость кнопок и текст заголовка
        private void SetStartGame()
        {
            label1.Text = "Компьютер загадал букву!";
            label2.Visible = true;
            pictureBox2.Visible = false;
            button3.Visible = true;
            button4.Visible = true;
            groupBox1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // при загрузке формы получаем словарь заново
            GetSortedDictionary();
            // при загрузке формы не показываем юзеру часть, содержащую консоль, до начала игры
            Size = new Size(527, 400);
        }

        // метод для обработки нажатия кнопки "инфо" (работа со словарем)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // создаем форму словаря, агрументом передаем текущую форму - 
            // - это нужно чтобы ее задизейблить при открытии формы словаря, и включить снова, при ее закрытия
            InfoForm infoForm = new InfoForm(this);
            // показываем форму словаря
            infoForm.Show();
        }

        // метод для обработки нажатия кнопки старта игры
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // показываем юзеру консоль
            Size = new Size(527, 676);
            Random rand = new Random();
            // рандомно выбираем букву русского алфавита
            computerChar = symbols[rand.Next(symbols.Length)];
            // устанавливаем состояние и пишем событие в консоль
            SetStartGame();
            AddEvent("Начата новая игра");
        }

        // метод для обработки нажатия кнопки ввода буквы (попытка угадать букву)
        private void button4_Click(object sender, EventArgs e)
        {
            // переводим текст в нижний регистр
            var text = textBox1.Text.ToLower();

            // валидация на то что введена одна буква рус. алфавита
            if (!rus_str.Contains(text) || text.Length != 1)
            {
                {
                    ShowError("Нужно ввести одну букву русского алфавита!");
                    return;
                }
            }

            // преобразуем строку из инпута в символ
            var currentChar = text[0];
            // сравниваем его с загаданным
            if (currentChar == computerChar)
            {
                // если угадали, показываем окно победы, пишем событие в консоль и проставляем состояние "игра не начата"
                ShowSuccess("Вы выиграли!");
                AddEvent($"Победа! Угадана буква {text[0]}");
                SetNoGame();
            }
            else
            {
                // если не уагадали, показываем окно ошибки и пишем в консоль событие
                ShowError("Неверно!");
                AddEvent($"Неверно названа буква {text[0]}");
            }
            // очищаем поле для ввода после каждой попытки
            textBox1.Clear();
        }

        // метод для обработки нажатия кнопки ввода слова (вводим и узнаем, есть ли в нем задуманная буква)
        private void button3_Click(object sender, EventArgs e)
        {
            // переводим в нижний регистр, так проще сравнивать
            var text = textBox1.Text.ToLower();
            // проверка что слово не пустое и есть в словаре
            if (textBox1.Text.Length > 0 && dict.Contains(text))
            {
                // проверка содержит ли слово нужную букву
                if (text.Contains(computerChar.ToString()))
                {
                    // покажем окно, что угадали
                    ShowSuccess("В слове есть нужная буква!");
                    // отправим событие в консоль
                    AddEvent($"В слове {text} есть загаданная буква!");
                }
                //если не содержит
                else
                {
                    // покажем окно что не угадали
                    ShowError("В слове нет загаданной буквы :(");
                    // событие в консоль
                    AddEvent($"В слове {text} нет загаданной буквы!");
                }
            }
            // если слово не введено или его нет в словаре
            else
            {
                // показываем окно, что его нет в словаре :)))00)00)
                ShowError("Такого слова нет в словаре!");
            }
            // очищаем поле ввода после каждой попытки
            textBox1.Clear();
        }

        // метод для обработки нажатия кнопки сохранения текста из консоли в выбранный файл
        private void button5_Click(object sender, EventArgs e)
        {
            // открываем окно сохранения
            SaveFileDialog saveFile1 = new SaveFileDialog();
            // можно сохранить в файлы любого расширения
            saveFile1.Filter = "all files(*)|*";
            // если файл существует и файл выбран, начинаем записывать в него текст из консоли
            if (saveFile1.ShowDialog() == DialogResult.OK &&
                saveFile1.FileName.Length > 0)
            {
                // пишем в выбранный файл, фалг тру для того, чтобы не стирать то что было в файле, а дописать в него новые данные
                using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                {
                    sw.WriteLine(textBox2.Text);
                    sw.Close();
                }
            }
        }
    }
}
