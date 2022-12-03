using System.Collections.Generic;

namespace MyFigures.Operators
{
    public static class OperatorContainer
    {
        public static List<Operator> operators = new List<Operator>();
        /// <summary>
        /// Класс OperatorContainer – представляет собой линейный список, хранящий объекты-операторы(экземпляры класса Operator)
        /// </summary>
        static OperatorContainer()
        {
            operators.Add(new Operator('R')); //R - Прорисовка прямоугольника
            operators.Add(new Operator('M')); //M - Перемещение прямоугольника
            operators.Add(new Operator('D')); //D - Удаление прямоугольника
            operators.Add(new Operator('C')); //C - Изменение цвета
            operators.Add(new Operator(',')); 
            operators.Add(new Operator('[')); 
            operators.Add(new Operator(']'));
        }
        /// <summary>
        /// метод FindOperator для поиска оператора по заданному символу s в контейнере operators
        /// </summary>
        /// <param name="s">заданный символ</param>
        /// <returns>В случае удачного поиска возвращает объект-оператор, знак которого совпал с искомым</returns>
        public static Operator FindOperator(char s)
        {
            foreach(Operator op in operators)
            {
                if(op.symbolOperator == s)
                    return op;
            }
            return null;
        }
    }
}
