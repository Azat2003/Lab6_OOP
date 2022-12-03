using System;
using System.Drawing;
using System.Windows.Forms;

namespace PR2
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
        }
        public Square[] squares = new Square[1];
        public int squaresCnt = 0;
        public Ellipse[] ellipse = new Ellipse[1];
        public int ellipseCnt = 0;
        public Rectangle[] rectangle = new Rectangle[1];
        public int rectangleCnt = 0;
        public Ring[] ring = new Ring[1];
        public int ringCnt = 0;

        public bool[] checkedSquaresList = new bool[0];
        public bool[] checkedRectangleList = new bool[0];
        public bool[] checkedEllipseList = new bool[0];
        public bool[] checkedRingList = new bool[0];

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void squareButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;
            panel2.Visible = false;
            panel2.Enabled = false;

            helpyFirstLine.Visible = true;
            helpyFirstLine.Text = "Координаты квадрата";

            helpyFirstX.Visible = true;
            helpyFirstX.Enabled = true;
            firstInputLine.Visible = true;
            firstInputLine.Enabled = true;

            helpyFirstY.Visible = true;
            helpyFirstY.Enabled = true;
            secondInputLine.Visible = true;
            secondInputLine.Enabled = true;

            helpySecondLine.Visible = true;
            helpySecondLine.Text = "Сторона квадрата";

            helpySecondX.Text = "A:";
            helpySecondX.Visible = true;
            helpySecondX.Enabled = true;
            thirdInputLine.Visible = true;
            thirdInputLine.Enabled = true;

            helpySecondY.Visible = false;
            helpySecondY.Enabled = false;
            fourthInputLine.Visible = false;
            fourthInputLine.Enabled = false;

            rollUp.Visible = true;
            rollUp.Enabled = true;

            SquareDraw.Visible = true;
            SquareDraw.Enabled = true;

            rectangleButton.Visible = false;
            ringButton.Visible = false;
            ellipseButton.Visible = false;
        }

        private void rollUp_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Enabled = false;
            panel2.Visible = true;
            panel2.Enabled = true;


            SquareDraw.Visible = false;
            RectangleDraw.Visible = false;
            RingDraw.Visible = false;
            EllipseDraw.Visible = false;

            rollUp.Visible = false;
            rollUp.Enabled = false;

            squareButton.Visible = true;
            rectangleButton.Visible = true;
            ringButton.Visible = true;
            ellipseButton.Visible = true;
        }
        private void rectangleButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;
            panel2.Visible = false;
            panel2.Enabled = false;

            helpyFirstLine.Visible = true;
            helpyFirstLine.Text = "Кординаты левого верхнего \n угла";

            helpyFirstX.Visible = true;
            helpyFirstX.Enabled = true;
            firstInputLine.Visible = true;
            firstInputLine.Enabled = true;

            helpyFirstY.Visible = true;
            helpyFirstY.Enabled = true;
            secondInputLine.Visible = true;
            secondInputLine.Enabled = true;

            helpySecondLine.Visible = true;
            helpySecondLine.Text = "Ширина и высота";

            helpySecondX.Visible = true;
            helpySecondX.Enabled = true;
            helpySecondX.Text = "A:";
            thirdInputLine.Visible = true;
            thirdInputLine.Enabled = true;

            helpySecondY.Visible = true;
            helpySecondY.Enabled = true;
            helpySecondY.Text = "B:";
            fourthInputLine.Visible = true;
            fourthInputLine.Enabled = true;

            rollUp.Visible = true;
            rollUp.Enabled = true;

            RectangleDraw.Visible = true;
            RectangleDraw.Enabled = true;

            squareButton.Visible = false;
            ringButton.Visible = false;
            ellipseButton.Visible = false;
        }

        private void ringButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;
            panel2.Visible = false;
            panel2.Enabled = false;

            helpyFirstLine.Visible = true;
            helpyFirstLine.Text = "Кординаты левого верхнего \n угла";

            helpyFirstX.Visible = true;
            helpyFirstX.Enabled = true;
            firstInputLine.Visible = true;
            firstInputLine.Enabled = true;

            helpyFirstY.Visible = true;
            helpyFirstY.Enabled = true;
            secondInputLine.Visible = true;
            secondInputLine.Enabled = true;

            helpySecondLine.Visible = true;
            helpySecondLine.Text = "Радиус:";

            helpySecondX.Visible = true;
            helpySecondX.Enabled = true;
            helpySecondX.Text = "R:";
            thirdInputLine.Visible = true;
            thirdInputLine.Enabled = true;

            helpySecondY.Visible = false;
            helpySecondY.Enabled = false;
            fourthInputLine.Visible = false;
            fourthInputLine.Enabled = false;

            rollUp.Visible = true;
            rollUp.Enabled = true;

            RingDraw.Visible = true;
            RingDraw.Enabled = true;

            squareButton.Visible = false;
            rectangleButton.Visible = false;
            ellipseButton.Visible = false;
        }

        private void ellipseButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;
            panel2.Visible = false;
            panel2.Enabled = false;

            helpyFirstLine.Visible = true;
            helpyFirstLine.Text = "Кординаты левого верхнего \n угла";

            helpyFirstX.Visible = true;
            helpyFirstX.Enabled = true;
            firstInputLine.Visible = true;
            firstInputLine.Enabled = true;

            helpyFirstY.Visible = true;
            helpyFirstY.Enabled = true;
            secondInputLine.Visible = true;
            secondInputLine.Enabled = true;

            helpySecondLine.Visible = true;
            helpySecondLine.Text = "Ширина и высота";

            helpySecondX.Visible = true;
            helpySecondX.Enabled = true;
            helpySecondX.Text = "A:";
            thirdInputLine.Visible = true;
            thirdInputLine.Enabled = true;

            helpySecondY.Visible = true;
            helpySecondY.Enabled = true;
            helpySecondY.Text = "B:";
            fourthInputLine.Visible = true;
            fourthInputLine.Enabled = true;

            rollUp.Visible = true;
            rollUp.Enabled = true;

            EllipseDraw.Visible = true;
            EllipseDraw.Enabled = true;

            squareButton.Visible = false;
            rectangleButton.Visible = false;
            ringButton.Visible = false;
        }
        private void changeRectangleButton_Click(object sender, EventArgs e)
        {
            figuresList.Items.Clear();
            helpyFirstActionText.Visible = true;
            helpyFirstActionText.Text = "A:";
            firstActionInputPanel.Visible = true;
            firstActionInputPanel.Enabled = true;

            helpySecondActionText.Visible = true;
            helpySecondActionText.Text = "B:";
            secondActionInputPanel.Visible = true;
            secondActionInputPanel.Enabled = true;

            changeRingButton.Visible = false;
            moveButton.Visible = false;
            deleteButton.Visible = false;

            confirmActionChangeRectangleButton.Visible = true;
            confirmActionChangeRectangleButton.Enabled = true;

            cancelActionButton.Visible = true;
            cancelActionButton.Enabled = true;

            figuresList.Visible = true;
            figuresList.Enabled = true;
            fillCheckedListIn();
        }
        private void changeRingButton_Click(object sender, EventArgs e)
        {
            figuresList.Items.Clear();
            helpyFirstActionText.Visible = true;
            helpyFirstActionText.Text = "R:";
            firstActionInputPanel.Visible = true;
            firstActionInputPanel.Enabled = true;

            changeRectangleButton.Visible = false;
            moveButton.Visible = false;
            deleteButton.Visible = false;

            cancelActionButton.Visible = true;
            cancelActionButton.Enabled = true;

            confirmActionChangeRingButton.Visible = true;
            confirmActionChangeRingButton.Enabled = true;

            figuresList.Visible = true;
            figuresList.Enabled = true;
            fillCheckedListIn();
        }
        private void moveButton_Click(object sender, EventArgs e)
        {

            helpyFirstActionText.Visible = true;
            helpyFirstActionText.Text = "X:";
            firstActionInputPanel.Visible = true;
            firstActionInputPanel.Enabled = true;

            helpySecondActionText.Visible = true;
            helpySecondActionText.Text = "Y:";
            secondActionInputPanel.Visible = true;
            secondActionInputPanel.Enabled = true;

            changeRectangleButton.Visible = false;
            changeRingButton.Visible = false;
            deleteButton.Visible = false;

            confirmActionMoveButton.Visible = true;
            confirmActionMoveButton.Enabled = true;

            cancelActionButton.Visible = true;
            cancelActionButton.Enabled = true;

            figuresList.Visible = true;
            figuresList.Enabled = true;

            fillCheckedListIn();
        }
        public void fillCheckedListIn()
        {
            figuresList.Items.Clear();

            figuresList.Items.Add("Все-квадраты");
            for (int i = 0; i < squaresCnt; i++)
            {
                figuresList.Items.Add($"Квадрат{i + 1}");
            }

            figuresList.Items.Add("Все-прямоугольники");
            for (int i = 0; i < rectangleCnt; i++)
            {
                figuresList.Items.Add($"Прямоугольник{i + 1}");
            }

            figuresList.Items.Add("Все-окружности");
            for (int i = 0; i < ringCnt; i++)
            {
                figuresList.Items.Add($"Окружность{i + 1}");
            }

            figuresList.Items.Add("Все-эллипсы");
            for (int i = 0; i < ellipseCnt; i++)
            {
                figuresList.Items.Add($"эллипс{i + 1}");
            }
        }
        private void cancelActionButton_Click(object sender, EventArgs e)
        {
            helpyFirstActionText.Visible = false;
            firstActionInputPanel.Visible = false;
            firstActionInputPanel.Enabled = false;

            helpySecondActionText.Visible = false;
            secondActionInputPanel.Visible = false;
            secondActionInputPanel.Enabled = false;

            changeRingButton.Visible = true;
            changeRectangleButton.Visible = true;
            moveButton.Visible = true;
            deleteButton.Visible = true;
            cancelActionButton.Visible = false;
            cancelActionButton.Enabled = false;

            confirmActionChangeRectangleButton.Visible = false;
            confirmActionChangeRingButton.Visible = false;
            confirmActionMoveButton.Visible = false;
            confirmActionDeleteButton.Visible = false;
            confirmActionDeleteButton.Enabled = false;

            figuresList.Visible = false;
            figuresList.Enabled = false;

            firstActionInputPanel.Clear();
            secondActionInputPanel.Clear();
        }

        private void SquareDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(firstInputLine.Text);
                int y = int.Parse(secondInputLine.Text);
                int a = int.Parse(thirdInputLine.Text);
                if (!((y < 0) || (y + a > pictureBox1.Height) || (x < 0) || (x + a > pictureBox1.Width)))
                {
                    if (a >= 0) {
                        Array.Resize(ref squares, squaresCnt + 1);
                        squares[squaresCnt] = new Square(x, y, a);
                        Graphics g = pictureBox1.CreateGraphics();
                        squares[squaresCnt].show(g, Color.Green);

                        squaresCnt++;
                    }
                    else MessageBox.Show("Ошибка ввода. Введите положительное число!");
                }
                else MessageBox.Show("Вы пересекли все границы!!!");
                }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода. Повторите, пожалуйста!");
            }

            firstInputLine.Clear();
            secondInputLine.Clear();
            thirdInputLine.Clear();
            fourthInputLine.Clear();
        }
        private void RectangleDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(firstInputLine.Text);
                int y = int.Parse(secondInputLine.Text);
                int a = int.Parse(thirdInputLine.Text);
                int b = int.Parse(fourthInputLine.Text);
                if (!((y < 0) || (y + a > pictureBox1.Height) || (x < 0) || (x + b > pictureBox1.Width)))
                {
                    if (a >= 0 && b >= 0) {
                        Array.Resize(ref rectangle, rectangleCnt + 1);
                        rectangle[rectangleCnt] = new Rectangle(x, y, a, b);
                        Graphics g = pictureBox1.CreateGraphics();
                        rectangle[rectangleCnt].Show(g, Color.Green);

                        rectangleCnt++;
                    }
                    else MessageBox.Show("Ошибка ввода. Введите положительное число!");
                }
                else MessageBox.Show("Вы пересекли все границы!!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода. Повторите, пожалуйста!");
            }
            firstInputLine.Clear();
            secondInputLine.Clear();
            thirdInputLine.Clear();
            fourthInputLine.Clear();
        }

        private void RingDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(firstInputLine.Text);
                int y = int.Parse(secondInputLine.Text);
                int r = int.Parse(thirdInputLine.Text);
                if (!((y < 0) || (y + r > pictureBox1.Height) || (x < 0) || (x + r > pictureBox1.Width)))
                {
                    if (r >= 0) {
                        Array.Resize(ref ring, ringCnt + 1);
                        ring[ringCnt] = new Ring(x, y, r);
                        Graphics g = pictureBox1.CreateGraphics();
                        ring[ringCnt].show(g, Color.Green);

                        ringCnt++;
                    }
                    else MessageBox.Show("Ошибка ввода. Введите положительное число!");
                }
                else MessageBox.Show("Вы пересекли все границы!!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода. Повторите, пожалуйста!");
            }
            firstInputLine.Clear();
            secondInputLine.Clear();
            thirdInputLine.Clear();
            fourthInputLine.Clear();
        }

        private void EllipseDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(firstInputLine.Text);
                int y = int.Parse(secondInputLine.Text);
                int a = int.Parse(thirdInputLine.Text);
                int b = int.Parse(fourthInputLine.Text);
                if (!((y < 0) || (y + a > pictureBox1.Height) || (x < 0) || (x + b > pictureBox1.Width)))
                {

                    if (a >= 0 && b >= 0)
                    {
                        Array.Resize<Ellipse>(ref ellipse, ellipseCnt + 1);
                        ellipse[ellipseCnt] = new Ellipse(x, y, a, b);
                        Graphics g = pictureBox1.CreateGraphics();
                        ellipse[ellipseCnt].show(g, Color.Green);

                        ellipseCnt++;
                    }
                    else MessageBox.Show("Ошибка ввода. Введите положительное число!");
                }
                else MessageBox.Show("Вы пересекли все границы!!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода. Повторите, пожалуйста!");
            }
            firstInputLine.Clear();
            secondInputLine.Clear();
            thirdInputLine.Clear();
            fourthInputLine.Clear();
        }

        private void confirmActionChangeRingButton_Click(object sender, EventArgs e)
        {
            confirmActionChangeRingButton.Visible = false;
            cancelActionButton.Visible = false;
            figuresList.Visible = false;

            changeRectangleButton.Visible = true;
            moveButton.Visible = true;
            deleteButton.Visible = true;

            helpyFirstActionText.Visible = false;
            firstActionInputPanel.Visible = false;
            firstActionInputPanel.Enabled = false;

            figuresList.ClearSelected();
            try
            {
                int r = int.Parse(firstActionInputPanel.Text);

                for (int i = 0; i < ringCnt; i++)
                {
                    if (checkedRingList[i])
                    {
                        if (r >= 0) {
                            ring[i].changeRing(r);
                            checkedRingList[i] = false;
                        }
                        else MessageBox.Show("Ошибка ввода. Введите положительное число!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода ring. Попробуйте ещё раз!");
            }
            firstActionInputPanel.Clear();
            restorePaintments();
        }

        private void confirmActionChangeRectangleButton_Click(object sender, EventArgs e)
        {
            confirmActionChangeRectangleButton.Visible = false;
            cancelActionButton.Visible = false;
            figuresList.Visible = false;

            changeRingButton.Visible = true;
            moveButton.Visible = true;
            deleteButton.Visible = true;

            helpyFirstActionText.Visible = false;
            firstActionInputPanel.Visible = false;
            firstActionInputPanel.Enabled = false;

            helpySecondActionText.Visible = false;
            secondActionInputPanel.Visible = false;
            secondActionInputPanel.Enabled = false;

            figuresList.ClearSelected();
            try
            {
                int a = int.Parse(firstActionInputPanel.Text);
                int b = int.Parse(secondActionInputPanel.Text);

                for (int i = 0; i < rectangleCnt; i++)
                {
                    if (checkedRectangleList[i])
                    {
                        if (a >= 0 && b >= 0) {
                            rectangle[i].changeRectangle(a, b);
                            checkedRectangleList[i] = false;
                        }
                        else MessageBox.Show("Ошибка ввода. Введите положительное число!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода rec. Попробуйте ещё раз!");
            }

            firstActionInputPanel.Clear();
            secondActionInputPanel.Clear();
            restorePaintments();
        }

        private void confirmActionMoveButton_Click(object sender, EventArgs e)
        {
            figuresList.ClearSelected();

            try
            {
                int x = int.Parse(firstActionInputPanel.Text);
                int y = int.Parse(secondActionInputPanel.Text);

                for (int i = 0; i < squaresCnt; i++)
                {
                    if (checkedSquaresList[i])
                    {
                        squares[i].moveTo(x, y);
                        checkedSquaresList[i] = false;
                    }
                }

                for (int i = 0; i < rectangleCnt; i++)
                {
                    if (checkedRectangleList[i])
                    {
                        rectangle[i].moveTo(x, y);
                        checkedRectangleList[i] = false;
                    }
                }

                for (int i = 0; i < ringCnt; i++)
                {
                    if (checkedRingList[i])
                    {
                        ring[i].moveTo(x, y);
                        checkedRingList[i] = false;
                    }
                }

                for (int i = 0; i < ellipseCnt; i++)
                {
                    if (checkedEllipseList[i])
                    {
                        ellipse[i].moveTo(x, y);
                        checkedEllipseList[i] = false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода move. Попробуйте ещё раз!");
            }
            firstActionInputPanel.Clear();
            secondActionInputPanel.Clear();
            restorePaintments();
        }
        private void figuresList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Array.Resize<bool>(ref checkedSquaresList, squaresCnt + 1);
            Array.Resize<bool>(ref checkedRectangleList, rectangleCnt + 1);
            Array.Resize<bool>(ref checkedEllipseList, ellipseCnt + 1);
            Array.Resize<bool>(ref checkedRingList, ringCnt + 1);

            //Первым в списке всегда пункт "Все квадраты"
            if (e.Index == 0)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    for (int i = 1; i < squaresCnt + 1; i++)
                    {
                        figuresList.SetItemChecked(i, true);
                        checkedSquaresList[i - 1] = true;
                    }
                }
                else
                {
                    for (int i = 1; i < squaresCnt + 1; i++)
                    {
                        figuresList.SetItemChecked(i, false);
                        checkedSquaresList[i - 1] = false;
                    }
                }
            }
            //Если выбран конкретный квадрат
            else if (e.Index < squaresCnt + 1)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    Graphics g = pictureBox1.CreateGraphics();
                    int[] squareSizes = squares[e.Index - 1].get();
                    Pen pen = new Pen(Color.Red, 5);
                    g.DrawRectangle(pen, squareSizes[0], squareSizes[1], squareSizes[2], squareSizes[2]);
                    checkedSquaresList[e.Index - 1] = true;
                }
                else
                {
                    Graphics g = pictureBox1.CreateGraphics();
                    int[] squareSizes = squares[e.Index - 1].get();
                    Pen pen = new Pen(Color.Green, 5);
                    g.DrawRectangle(pen, squareSizes[0], squareSizes[1], squareSizes[2], squareSizes[2]);
                    checkedSquaresList[e.Index - 1] = false;
                }
            }
            //После квадратов всегда идут "Все прямоугольники"
            else if (e.Index == squaresCnt + 1)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    for (int i = squaresCnt + 2; i < squaresCnt + 2 + rectangleCnt; i++)
                    {
                        figuresList.SetItemChecked(i, true);
                        checkedRectangleList[i - squaresCnt - 2] = true;
                    }
                }
                else
                {
                    for (int i = squaresCnt + 2; i < squaresCnt + rectangleCnt + 2; i++)
                    {
                        figuresList.SetItemChecked(i, false);
                        checkedRectangleList[i - squaresCnt - 2] = false;
                    }
                }
            }
            //Если выбрана конкретая прямоугольник
            else if (e.Index < squaresCnt + rectangleCnt + 2)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    Graphics g = pictureBox1.CreateGraphics();
                    int[] rectangleSizes = rectangle[e.Index - squaresCnt - 2].get();
                    Pen pen = new Pen(Color.DeepPink, 5);
                    g.DrawRectangle(pen, rectangleSizes[0], rectangleSizes[1], rectangleSizes[2], rectangleSizes[3]);
                    checkedRectangleList[e.Index - squaresCnt - 2] = true;
                }
                else
                {
                    Graphics g = pictureBox1.CreateGraphics();
                    int[] rectangleSizes = rectangle[e.Index - squaresCnt - 2].get();
                    Pen pen = new Pen(Color.Green, 5);
                    g.DrawRectangle(pen, rectangleSizes[0], rectangleSizes[1], rectangleSizes[2], rectangleSizes[3]);
                    checkedRectangleList[e.Index - squaresCnt - 2] = false;
                }
            }
            //После линий всегда идут "Все окружности"
            else if (e.Index == squaresCnt + rectangleCnt + 2)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    for (int i = squaresCnt + rectangleCnt + 3; i < squaresCnt + rectangleCnt + ringCnt + 3; i++)
                    {
                        figuresList.SetItemChecked(i, true);
                        checkedRingList[i - squaresCnt - rectangleCnt - 3] = true;
                    }
                }
                else
                {
                    for (int i = squaresCnt + rectangleCnt + 3; i < squaresCnt + rectangleCnt + ringCnt + 3; i++)
                    {
                        figuresList.SetItemChecked(i, false);
                        checkedRingList[i - squaresCnt - rectangleCnt - 3] = false;
                    }
                }
            }
            //Если выбран конкретный окружность
            else if (e.Index < squaresCnt + rectangleCnt + ringCnt + 3)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    Graphics g = pictureBox1.CreateGraphics();
                    int[] ringSizes = ring[e.Index - squaresCnt - rectangleCnt - 3].get();
                    Pen pen = new Pen(Color.Violet, 5);
                    g.DrawEllipse(pen, ringSizes[0], ringSizes[1], ringSizes[2], ringSizes[2]);
                    checkedRingList[e.Index - squaresCnt - rectangleCnt - 3] = true;
                }
                else
                {
                    Graphics g = pictureBox1.CreateGraphics();
                    int[] ringSizes = ring[e.Index - squaresCnt - rectangleCnt - 3].get();
                    Pen pen = new Pen(Color.Green, 5);
                    g.DrawEllipse(pen, ringSizes[0], ringSizes[1], ringSizes[2], ringSizes[2]);
                    checkedRingList[e.Index - squaresCnt - rectangleCnt - 3] = true;
                }
            }
            //После линий всегда идут "Все эллипсы"
            else if (e.Index == squaresCnt + rectangleCnt + ringCnt + 3)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    for (int i = squaresCnt + rectangleCnt + ringCnt + 4; i < squaresCnt + rectangleCnt + ellipseCnt + ringCnt + 4; i++)
                    {
                        figuresList.SetItemChecked(i, true);
                        checkedEllipseList[i - squaresCnt - rectangleCnt - ringCnt - 4] = true;
                    }
                }
                else
                {
                    for (int i = squaresCnt + rectangleCnt + ringCnt + 4; i < squaresCnt + rectangleCnt + ellipseCnt + ringCnt + 4; i++)
                    {
                        figuresList.SetItemChecked(i, false);
                        checkedEllipseList[i - squaresCnt - rectangleCnt - ringCnt - 4] = false;
                    }
                }
            }
            //Если выбран конкретный эллипс
            else
            {
                if (e.NewValue == CheckState.Checked)
                {
                    Graphics g = pictureBox1.CreateGraphics();
                    int[] ellipseSizes = ellipse[e.Index - squaresCnt - rectangleCnt - ringCnt - 4].get();
                    Pen pen = new Pen(Color.Violet, 5);
                    g.DrawEllipse(pen, ellipseSizes[0], ellipseSizes[1], ellipseSizes[2], ellipseSizes[3]);
                    checkedEllipseList[e.Index - squaresCnt - rectangleCnt - ringCnt - 4] = true;
                }
                else
                {
                    Graphics g = pictureBox1.CreateGraphics();
                    int[] ellipseSizes = ellipse[e.Index - squaresCnt - rectangleCnt - ringCnt - 4].get();
                    Pen pen = new Pen(Color.Green, 5);
                    g.DrawEllipse(pen, ellipseSizes[0], ellipseSizes[1], ellipseSizes[2], ellipseSizes[3]);
                    checkedEllipseList[e.Index - squaresCnt - rectangleCnt - ringCnt - 4] = true;
                }
            }
        }
        public void restorePaintments()
        {
            Graphics g = pictureBox1.CreateGraphics();
            pictureBox1.Refresh();

            for (int i = 0; i < squaresCnt; i++)
            {
                squares[i].show(g, Color.Green);
            }

            for (int i = 0; i < rectangleCnt; i++)
            {
                rectangle[i].Show(g, Color.Green);
            }

            for (int i = 0; i < ellipseCnt; i++)
            {
                ellipse[i].show(g, Color.Green);
            }
            for (int i = 0; i < ringCnt; i++)
            {
                ring[i].show(g, Color.Green);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            fillCheckedListIn();
            figuresList.Visible = true;
            figuresList.Enabled = true;
            confirmActionDeleteButton.Visible = true;
            confirmActionDeleteButton.Enabled = true;
            cancelActionButton.Visible = true;
            cancelActionButton.Enabled = true;

            changeRingButton.Visible = false;
            changeRectangleButton.Visible = false;
            moveButton.Visible = false;
        }

        private void confirmActionDeleteButton_Click(object sender, EventArgs e)
        {
            confirmActionDeleteButton.Visible = false;
            cancelActionButton.Visible = false;
            figuresList.Visible = false;

            changeRingButton.Visible = true;
            changeRectangleButton.Visible = true;
            changeRingButton.Visible = true;
            moveButton.Visible = true;

            int newSquaresCnt = 0;
            int newRectangleCnt = 0;
            int newEllipseCnt = 0;
            int newRingCnt = 0;
            //Считаем оставшиеся объекты каждого класса
            for (int i = 0; i < checkedSquaresList.Length; i++)
            {
                if (!(checkedSquaresList[i])) newSquaresCnt++;
            }

            for (int i = 0; i < checkedRectangleList.Length; i++)
            {
                if (!(checkedRectangleList[i])) newRectangleCnt++;
            }

            for (int i = 0; i < checkedEllipseList.Length; i++)
            {
                if (!(checkedEllipseList[i])) newEllipseCnt++;
            }

            for (int i = 0; i < checkedRingList.Length; i++)
            {
                if (!(checkedRingList[i])) newRingCnt++;
            }
            //Создаем новые массивы под классы c оставшимся количеством объектов
            Square[] newSquare = new Square[newSquaresCnt];
            Rectangle[] newRectangle = new Rectangle[newRectangleCnt];
            Ellipse[] newEllipse = new Ellipse[newEllipseCnt];
            Ring[] newRing = new Ring[newRingCnt];

            for (int i = 0, j = 0; i < squaresCnt; i++)
            {
                if (!(checkedSquaresList[i]))
                {
                    newSquare[j] = squares[i];
                    j++;
                }
                else checkedSquaresList[i] = false;
            }
            squares = newSquare;

            for (int i = 0, j = 0; i < rectangleCnt; i++)
            {
                if (!(checkedRectangleList[i]))
                {
                    newRectangle[j] = rectangle[i];
                    j++;
                }
                else checkedRectangleList[i] = false;
            }
            rectangle = newRectangle;

            for (int i = 0, j = 0; i < ellipseCnt; i++)
            {
                if (!(checkedEllipseList[i]))
                {
                    newEllipse[j] = ellipse[i];
                    j++;
                }
                else checkedEllipseList[i] = false;
            }
            ellipse = newEllipse;

            for (int i = 0, j = 0; i < ringCnt; i++)
            {
                if (!(checkedRingList[i]))
                {
                    newRing[j] = ring[i];
                    j++;
                }
                else checkedRingList[i] = false;
            }
            ring = newRing;

            Array.Resize<bool>(ref checkedSquaresList, newSquaresCnt);
            Array.Resize<bool>(ref checkedRectangleList, newRectangleCnt);
            Array.Resize<bool>(ref checkedEllipseList, newEllipseCnt);
            Array.Resize<bool>(ref checkedRingList, newRingCnt);

            squaresCnt = newSquaresCnt - 1;
            rectangleCnt = newRectangleCnt - 1;
            ellipseCnt = newEllipseCnt - 1;
            ringCnt = newRingCnt - 1;

            firstActionInputPanel.Clear();
            secondActionInputPanel.Clear();
            restorePaintments();
            figuresList.ClearSelected();
        }
    }
}
