using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static kurs.Utils.DictionaryService;

namespace kurs
{
    public partial class InfoForm : Form
    {
        // объект для главной формы
        Form parent;

        public InfoForm(MainForm form)
        {
            // включаем прозрачные стили
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            // передали главную форму в форму словаря
            parent = form;
            InitializeComponent();

            // после инициализации формы проставим прозрачный фон заголовку
            label1.BackColor = Color.Transparent;

            // делаем неактивной главную форму
            parent.Enabled = false;
            // получаем данные из словаря
            UpdateDictText();
        }

        // метод для получения обновленных данных из словаря и вывода их в текстовое поле, если список не передан - запросим данные из файла словаря
        private void UpdateDictText(List<string> list = null)
        {
            // очищаем поле
            textBox1.Clear();

            if (list == null)
            {
                // если список не передан - запросим данные из файла словаря
                list = GetSortedDictionary();
            }

            // преобразуем массив строк в одну строку для вывода в текстовое поле
            var text = string.Join("\r\n", list);

            // выводим в поле текст
            textBox1.Text = text;
            // делаем активным другой компонент, чтобы с текста снялось некрасивое выделение
            ActiveControl = textBox2;
        }

        // обработка закрытия формы - делаем главную форму снова активной
        private void InfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Enabled = true;
        }

        // обработка закрытия формы - делаем главную форму снова активной
        private void InfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
        }

        // метод-обработчик нажатия кнопки добавления слова в словарь
        private void button1_Click(object sender, EventArgs e)
        {
            // если введено слово
            if (textBox2.Text.Length > 0)
            {
                var text = textBox2.Text;
                // вызываем метод обработки словаря, и передаем ему агрумент - слово для вставки
                // он вернет обновленный словарь в виде списка строк
                var list = GetSortedDictionary(text);
                // новый список передаем в метод обновления и вывода на экран словаря
                UpdateDictText(list);
            }
        }

        // метод-обработчик нажатия кнопки удаления слова из словаря
        private void button2_Click(object sender, EventArgs e)
        {
            // если введено слово
            if (textBox2.Text.Length > 0)
            {
                var text = textBox2.Text;
                // вызываем метод обработки словаря, и передаем ему агрумент - слово для удаления.
                // первый аргумент - слово для вставки - передаем null, тк мы удаляем слово
                // он вернет обновленный словарь в виде списка строк
                var list = GetSortedDictionary(null, text);
                // новый список передаем в метод обновления и вывода на экран словаря
                UpdateDictText(list);
            }
        }

        // метод-обработчик нажатия кнопки показа словаря
        private void button3_Click(object sender, EventArgs e)
        {
            var text = textBox2.Text;
            // вызываем метод обработки словаря, и можем передает ему агрумент из поля для ввода текста - букву или слово, для отображения словаря, начиная с него
            // если не указан - показываем весь словарь
            // первый и второй аргументы - слово для вставки и слово для удаления - передаем null, тк мы ничего не удаляем и не добавляем
            // он вернет обновленный словарь в виде списка строк
            var list = GetSortedDictionary(null, null, text);
            // новый список передаем в метод обновления и вывода на экран словаря
            UpdateDictText(list);
        }
    }
}
