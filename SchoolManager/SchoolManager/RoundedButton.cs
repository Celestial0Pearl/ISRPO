using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    public int CornerRadius { get; set; } = 30; // Радиус закругления

    public RoundedButton()
    {
        Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
        BackColor = Color.PaleTurquoise;
        FlatStyle = FlatStyle.Flat; // Убираем стандартный контур кнопки
        FlatAppearance.BorderSize = 0; // Убираем рамку кнопки
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        // Отключаем стандартную отрисовку фона и границ
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Задаем цвет фона кнопки
        using (Brush brush = new SolidBrush(this.BackColor))
        {
            // Создаем путь для закругленных углов
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
            path.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            path.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            path.CloseFigure();

            // Закрашиваем кнопку цветом
            pevent.Graphics.FillPath(brush, path);

            // Применяем форму к кнопке
            this.Region = new Region(path);
        }

        // Центрируем текст
        StringFormat sf = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };
        pevent.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle, sf);
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        this.Invalidate(); // Обновляем отрисовку при изменении размеров
    }
}