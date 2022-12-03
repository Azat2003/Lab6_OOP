namespace MyFigures.Operators
{
    /// <summary>
    ///Класс Operand – представляет собой объект-операнд, в котором будет храниться значение для операнда из входной строки
    /// </summary>
    public class Operand
    {
        /// <summary>
        /// Свойство value хранит значение текущего операнда из командной строки
        /// </summary>
        public object value;
        public Operand(object NewValue)
        {
            this.value = NewValue;
        }
    }
}
