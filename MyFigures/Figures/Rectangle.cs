using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFigures
{
    /// <summary>
    ///Класс прямоугольник наследуемый от класса фигур
    /// </summary>
    public class Rectangle : Figure
    {
        public static int count = 0;
        /// <summary>
        /// Класс прямоугольников
        /// </summary>
        /// <param name="name">Имя фигуры</param>
        /// <param name="x">координата базовой точки фигуры по оси X</param>
        /// <param name="y">координата базовой точки фигуры по оси Y</param>
        /// <param name="width">ширина</param>
        /// <param name="height">высота</param>
        /// <param name="pen">ручка</param>
        /// <exception cref="Exception"></exception>
        public Rectangle(string name, int x, int y, int width, int height,Pen pen) : base(name, x, y, width, height,pen)
        {
            if (!(x < 0 || y < 0 || x + width > pictureBox.Width || y + height > pictureBox.Height))
            {
                FiguresContainer.RectsList.Add(this);
                FiguresContainer.figureList.Add(this);
                number = count;
                count++;
            }
            else
            {
                throw new Exception("Фигура должна помещаться на холст");
            }
        }
        /// <summary>
        /// Метод рисования прямоугольника
        /// </summary>
        /// <param name="pen">ручка</param>
        public override void Draw(Pen pen)
        {
            try
            {
                //Graphics g = Graphics.FromImage(bitmap);
                g.DrawRectangle(pen, x, y, width, height);
                pictureBox.Image = bitmap;
                DrawText(name);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }
        /// <summary>
        /// метод рисования c именем
        /// </summary>
        public void Draw_with_name()
        {
            try
            {
                foreach (Figure f in FiguresContainer.figureList)
                {
                    //Graphics g = Graphics.FromImage(bitmap);
                    g.DrawRectangle(f.pen, x, y, width, height);
                    pictureBox.Image = bitmap;
                    DrawText(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }
        /// <summary>
        /// Метод для преремещения фигуры
        /// </summary>
        /// <param name="dx">смещение фигуры по оси X</param>
        /// <param name="dy">смещение фигуры по оси Y</param>
        public void MoveTo_d(int dx, int dy)
        {
            try
            {
                if (!(x < 0 || y < 0 || x + width > pictureBox.Width || y + height > pictureBox.Height))
                {
                    x += dx; y += dy;
                    DeleteF(this, false);
                    Draw_with_name();
                }
                else
                {
                    throw new Exception("Фигура должна помещаться на холст");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }
        /// <summary>
        /// Метод для изменения цвета фигуры
        /// </summary>
        /// <param name="color">цвет</param>
        public void Change_Color(Color color)
        {
            try
            {
                DeleteC(this, false, color);
                Draw_with_name(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }
    }
}

