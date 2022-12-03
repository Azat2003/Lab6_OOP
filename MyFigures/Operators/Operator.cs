namespace MyFigures.Operators
{
    /// <summary>
    /// Класс Operator – представляет собой объект-оператор. Данный класс будет хранить знак оператора и переменную каждого делегата, унаследованного от класса OperatorMethod
    /// </summary>
    public class Operator : OperatorMethod
    {
        public char symbolOperator;
        public EmptyOperatorMethod operatorMethod = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="operatorMethod"></param>
        /// <param name="symbolOperator">символ операции</param>
        public Operator(EmptyOperatorMethod operatorMethod, char symbolOperator)
        {
            this.operatorMethod = operatorMethod;
            this.symbolOperator = symbolOperator;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="symbolOperator">символ операции</param>
        public Operator(char symbolOperator)
        {
            this.symbolOperator = symbolOperator;
        }
    }
}
