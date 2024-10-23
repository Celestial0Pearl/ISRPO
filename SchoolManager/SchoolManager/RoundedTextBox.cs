using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedTextBox : UserControl
{
    private TextBox innerTextBox;

    public int CornerRadius { get; set; } = 15; // Радиус закругления углов
    public Color BorderColor { get; set; } = Color.Gray; // Цвет границы
    public int BorderThickness { get; set; } = 2; // Толщина границы

    public string Placeholder { get; set; }

    public RoundedTextBox()
    {
        // Инициализация внутреннего TextBox
        innerTextBox = new TextBox
        {
            BorderStyle = BorderStyle.None, // Убираем стандартные границы
            Multiline = true,
            BackColor = Color.MediumTurquoise,
            ForeColor = Color.Black, // Цвет текста
            Location = new Point(BorderThickness + 5, BorderThickness + 5), // Устанавливаем отступы для текста
            Width = this.Width - (BorderThickness + 10), // Ширина с учетом границы
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204), // Пример шрифта
            PlaceholderText = Placeholder,
        };

        this.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
        this.Controls.Add(innerTextBox); // Добавляем TextBox внутрь кастомного контрола
        this.Padding = new Padding(BorderThickness); // Устанавливаем отступы
        this.BackColor = Color.MediumTurquoise;

        this.Resize += (s, e) =>
        {
            // Автоматическое изменение ширины и высоты при изменении размера родительского контрола
            innerTextBox.Width = this.Width - (BorderThickness + 10);
            innerTextBox.Height = this.Height - (BorderThickness + 10);
        };

        // Синхронизация фона
        this.BackColorChanged += (s, e) =>
        {
            innerTextBox.PlaceholderText = Placeholder;
            innerTextBox.BackColor = this.BackColor; // Синхронизируем цвет фона
        };
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Включаем антиалиасинг для сглаживания
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Создаем путь с закругленными углами, корректируя нижнюю границу
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90); // Верхний левый угол
            path.AddArc(this.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90); // Верхний правый угол
            path.AddArc(this.Width - CornerRadius, this.Height - CornerRadius - 1, CornerRadius, CornerRadius, 0, 90); // Нижний правый угол
            path.AddArc(0, this.Height - CornerRadius - 1, CornerRadius, CornerRadius, 90, 90); // Нижний левый угол
            path.CloseFigure();

            // Закрашиваем фон
            using (Brush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Рисуем границу
            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }

    // Прокси-свойства для внутреннего TextBox
    public string Text
    {
        get => innerTextBox.Text;
        set => innerTextBox.Text = value;
    }

    public void Clear()
    {
        innerTextBox.Clear();
    }

    public override Color BackColor
    {
        get => base.BackColor;
        set
        {
            base.BackColor = value;
            innerTextBox.BackColor = value; // Синхронизируем цвет фона
        }
    }

    public Color TextColor
    {
        get => innerTextBox.ForeColor;
        set => innerTextBox.ForeColor = value;
    }

    public Font TextFont
    {
        get => innerTextBox.Font;
        set => innerTextBox.Font = value;
    }
}