using MyFigures.Operators;
using MyFigures;
using System;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = MyFigures.Rectangle;
using System.Collections.Generic;
using ComboBox = System.Windows.Forms.ComboBox;

namespace MyMain
{
    public class Main
    {
        public static Stack<Operator> operators = new Stack<Operator>();
        public static Stack<Operand> operands = new Stack<Operand>();
        /// <summary>
        /// Проверка на операцию
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool IsNotOperation(char item)
        {
            if (!(item == 'M' || item == 'R' || item == 'D' || item == 'C' || item == ',' || item == '[' || item == ']')) return true;
            else return false;
        }
        /// <summary>
        /// Проверка на границу
        /// </summary>
        /// <param name="x">координата х</param>
        /// <param name="y">координата у</param>
        /// <param name="w">ширина</param>
        /// <param name="h">высота</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool IsInBounds(int x, int y, int w, int h)
        {
            if ((y < 0) || (y + h > Figure.pictureBox.Height) || (x < 0) || (x + w > Figure.pictureBox.Width)) throw new Exception("Нарушены границы или что-то не так");
            else return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Имя фигуры</param>
        /// <param name="comboBox">Передаем элемент log "История команд"</param>
        public static void AbroadError(string name, ComboBox comboBox)
        {
            MessageBox.Show($"Фигура {name} вышла за границы.");
            comboBox.Items.Add($"Фигура {name} вышла за границы.");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num">количество параметров</param>
        /// <param name="method">метод</param>
        /// <param name="comboBox">Передаем элемент log "История команд"</param>
        public static void ParameterError(int num, string method, ComboBox comboBox)
        {
            MessageBox.Show($"Опертор {method} принимает {num} параматетров.");
            comboBox.Items.Add($"Неверное число параметров для оператора {method}.");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Имя фигуры</param>
        /// <param name="comboBox">Передаем элемент log "История команд"</param>
        public static void NoExistsError(string name,ComboBox comboBox)
        {
            MessageBox.Show($"Фигуры {name} не существует");
            comboBox.Items.Add($"Фигуры {name} не существует");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="op">объект класса Operator, извлеченный из вершины стека операторов</param>
        /// <param name="comboBox">Передаем элемент log "История команд"</param>
        public static void SelectingPerformingOperation(Operator op, ComboBox comboBox)
        {
            try
            {
                if (op.symbolOperator == 'R') //проверяем соответствие свойства symbolOperator оператора заранее определенному символу для операции прорисовки прямоугольника
                {
                    if (operands.Count == 5)
                    {
                        int w = Convert.ToInt32(operands.Pop().value.ToString());
                        int h = Convert.ToInt32(operands.Pop().value.ToString());
                        int y = Convert.ToInt32(operands.Pop().value.ToString());
                        int x = Convert.ToInt32(operands.Pop().value.ToString());
                        string name = operands.Pop().value.ToString();

                        if (IsInBounds(x, y, w, h))
                        {
                            Pen pen = new Pen(Color.Black, 3);
                            Rectangle figure = new Rectangle(name, x, y, w, h, pen);
                            op = new Operator(figure.Draw_with_name, 'R');
                            comboBox.Items.Add($"{figure.name} отрисован");
                            op.operatorMethod(); // вызывается метод прорисовки Draw через делегат operatorMethod
                        }
                        else AbroadError(name, comboBox);
                    }
                    else ParameterError(5,"R",comboBox);
                }
                
                else if (op.symbolOperator == 'M')
                {
                    if (operands.Count == 3)
                    {
                        Rectangle figure = null;
                        int dy = Convert.ToInt32(operands.Pop().value.ToString());
                        int dx = Convert.ToInt32(operands.Pop().value.ToString());
                        string name = operands.Pop().value.ToString();
                        foreach (Figure f in FiguresContainer.figureList)
                        {
                            if (f.name == name) 
                                figure = (Rectangle)f;
                        }
                        if (figure != null)
                        {
                            if (IsInBounds(figure.x + dx, figure.y + dy, figure.width, figure.height))
                            {
                                figure.MoveTo_d(dx, dy);
                                comboBox.Items.Add($"Фигура {figure.name} успешно перемещена");
                            }
                            else AbroadError(name, comboBox);
                        }
                        else NoExistsError(name, comboBox);
                    }
                    else ParameterError(3, "M", comboBox);
                }

                else if (op.symbolOperator == 'D')
                {
                    if (operands.Count == 1)
                    {
                        Rectangle figure = null;
                        string name = operands.Pop().value.ToString();
                        foreach (Figure f in FiguresContainer.figureList)
                        {
                            if (f.name == name) 
                                figure = (Rectangle)f;
                        }
                        if (figure != null)
                        {
                            figure.DeleteF(figure, true);
                            comboBox.Items.Add($"Фигура {figure.name} успешно удалена");
                        }
                        else NoExistsError(name, comboBox);
                    }
                    else ParameterError(1, "D", comboBox);
                }
                else if (op.symbolOperator == 'C')
                {
                    if (operands.Count == 4)
                    {
                        Rectangle figure = null;
                        int alpha = 255;
                        int blue = Convert.ToInt32(operands.Pop().value.ToString());
                        int green = Convert.ToInt32(operands.Pop().value.ToString());
                        int red = Convert.ToInt32(operands.Pop().value.ToString());
                        string name = operands.Pop().value.ToString();
                        if (red <= 255 && green <= 255 && blue <= 255)
                        {
                            foreach (Figure f in FiguresContainer.figureList)
                            {
                                if (f.name == name) 
                                    figure = (Rectangle)f;
                            }
                            if (figure != null)
                            {
                                Color newcolor = Color.FromArgb(alpha, red, green, blue);
                                figure.Change_Color(newcolor);
                                comboBox.Items.Add($"Фигура {figure.name} успешно поменяла цвет на {newcolor}");
                            }
                            else NoExistsError(name, comboBox);
                        }
                        else
                        {
                            MessageBox.Show($"Такого цвета нет");
                            comboBox.Items.Add($" Цвета ({red},{green},{blue}) не существует");
                        }
                    }
                    else ParameterError(4, "C", comboBox);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
