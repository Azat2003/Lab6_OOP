using System.Windows.Forms;
using System.Drawing;

namespace MyFigures
{
    /// <summary>
    /// 
    /// </summary>
    abstract public class Figure
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public int number;
        public string name;
        public static Bitmap bitmap;
        public static PictureBox pictureBox;
        public Pen pen;
        public Graphics g = Graphics.FromImage(bitmap);
        /// <summary>
        /// Класс фигур
        /// </summary>
        /// <param name="name">Имя фигуры</param>
        /// <param name="x">координата х</param>
        /// <param name="y">координата у</param>
        /// <param name="width">ширина</param>
        /// <param name="height">высота</param>
        /// <param name="pen">ручка</param>
        public Figure(string name, int x, int y, int width, int height,Pen pen)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.name = name;
            this.pen = pen;
        }
        /// <summary>
        /// Абстрактный метод рисования
        /// </summary>
        /// <param name="pen">ручка</param>
        abstract public void Draw(Pen pen);
        /// <summary>
        ///очистить всё
        /// </summary>
        public void ClearMap()
        {
            g.Clear(Color.WhiteSmoke);
            pictureBox.Image = bitmap;
        }
        /// <summary>
        /// Метод для преремещения фигуры
        /// </summary>
        /// <param name="figure">передает фигуры</param>
        /// <param name="flag"></param>
        public void DeleteF(Figure figure, bool flag)
        {
            g.FillRectangle(Brushes.White, x, y, width, height);
            FiguresContainer.figureList.Remove(figure);
            ClearMap();
            foreach (Figure f in FiguresContainer.figureList)
            {
                f.Draw(f.pen);
            }
            if (flag != true)
            {
                FiguresContainer.figureList.Add(figure);
            }
            pictureBox.Image = bitmap;
        }
        /// <summary>
        /// Метод для изменения цвета фигуры
        /// </summary>
        /// <param name="figure">передает фигуры</param>
        /// <param name="flag"></param>
        /// <param name="color">цвет</param>
        public void DeleteC(Figure figure, bool flag, Color color)
        {
            pen = new Pen(color, 3);
            g.FillRectangle(Brushes.White, x, y, width, height);
            FiguresContainer.figureList.Remove(figure);
            ClearMap();
            foreach (Figure f in FiguresContainer.figureList)
            {
                f.Draw(f.pen);
            }
            if (flag != true)
            {
                FiguresContainer.figureList.Add(figure);
            }
            pictureBox.Image = bitmap;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">название фигуры</param>
        public void DrawText(string name)
        {
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            g.DrawString($"{name}", new Font("Times New Roman", 10), Brushes.Gray, new RectangleF(x, y, width, height), sf);
        }
    }

}
