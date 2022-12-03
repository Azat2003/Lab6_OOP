using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MyFigures.Operators;
using MyFigures;
using MyMain;

namespace Lab4_OOP
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Figure.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Figure.pictureBox = pictureBox1;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd_KeyDown(object sender, KeyEventArgs e)
        {
            Stack<Operator> operators = Main.operators;
            Stack<Operand> operands = Main.operands;
            if (e.KeyCode == Keys.Enter) //проверка условия нажатия клавиши ENTER.
            {
                operators.Clear();
                operands.Clear();
                try
                {
                    string initial = cmd.Text.Replace(" ", "").Replace("\n", "").Replace("\r", "").Replace("\t", ""); // Убираем пробелы, перенос строк и тд
                    cmd.Text = null; //обнуляем командную строку
                    for (int i = 0; i < initial.Length; i++) 
                    {
                        if (Main.IsNotOperation(initial[i])) //проверяем текущий символ из входной строки на несоответствие знаку операции
                        {
                            if (!char.IsDigit(initial[i])) //проверка на символ-цифру (0-9)
                            {
                                operands.Push(new Operand(initial[i])); //добавление нового операнда в стек операндов operands
                                while (i < initial.Length - 1 && Main.IsNotOperation(initial[i + 1]))
                                {
                                    string temp_str = operands.Pop().value.ToString() + initial[i + 1].ToString();
                                    operands.Push(new Operand(temp_str));
                                    i++;
                                }
                            }
                            else if (char.IsDigit(initial[i]))
                            {
                                operands.Push(new Operand(initial[i].ToString()));
                                while (i < initial.Length - 1 && char.IsDigit(initial[i + 1]) && Main.IsNotOperation(initial[i + 1]))
                                {
                                    int temp_num = Convert.ToInt32(operands.Pop().value.ToString()) * 10 + (int)char.GetNumericValue(initial[i + 1]);
                                    operands.Push(new Operand(temp_num.ToString()));
                                    i++;
                                }
                            }
                        }
                        else if (initial[i] == 'R' && initial[i+1] == '[')
                        {
                            if (operators.Count == 0)
                                operators.Push(OperatorContainer.FindOperator(initial[i]));
                        }
                        else if (initial[i] == 'M')
                        {
                            if (operators.Count == 0)
                                operators.Push(OperatorContainer.FindOperator(initial[i]));
                        }
                        else if (initial[i] == 'D')
                        {
                            if (operators.Count == 0)
                                operators.Push(OperatorContainer.FindOperator(initial[i]));
                        }
                        else if (initial[i] == 'C')
                        {
                            if (operators.Count == 0)
                                operators.Push(OperatorContainer.FindOperator(initial[i]));
                        }
                        else if (initial[i] == '[')
                            operators.Push(OperatorContainer.FindOperator(initial[i]));
                        else if (initial[i] == ']')
                        {
                            do
                            {
                                if (operators.Peek().symbolOperator == '[')
                                {
                                    operators.Pop();
                                    break;
                                }
                                if (operators.Count == 0)
                                    break;
                            }
                            while (operators.Peek().symbolOperator != '[');
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Аргументы введены некорректно.");
                    log.Items.Add("Аргументы введены некорректно.");
                }
                try
                {
                    Main.SelectingPerformingOperation(Main.operators.Peek(),log); // символ оператора передаем в метод обработки функциональных выражений
                }
                catch
                {
                    MessageBox.Show($"Введенной операции /{cmd.Text} не существует.");
                    log.Items.Add($"Введенной операции /{cmd.Text} не существует.");
                }
            }
        }    
    }
}
