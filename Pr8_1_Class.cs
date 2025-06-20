namespace Pr8
{

    public class CharOperator
    {
        private char Symbol;

        public CharOperator(char symbol)
        {
            Symbol = symbol;
        }

        // Оператор инкремента
        public static CharOperator operator ++(CharOperator symbol)
        {
            symbol.Symbol = (char)(symbol.Symbol + 1);
            return symbol;
        }

        // Оператор декремента
        public static CharOperator operator --(CharOperator symbol)
        {
            symbol.Symbol = (char)(symbol.Symbol - 1);
            return symbol;
        }

        // Бинарный оператор «плюс»
        public static CharOperator operator +(CharOperator symbol, int number)
        {
            return new CharOperator((char)(symbol.Symbol + number));
        }

        public static CharOperator operator +(int number, CharOperator symbol)
        {
            return new CharOperator((char)(symbol.Symbol + number));
        }

        // Бинарный оператор «минус»
        public static int operator -(CharOperator symbol1, CharOperator symbol2)
        {
            return symbol1.Symbol - symbol2.Symbol;
        }

        public override string ToString()
        {
            return $"cимвол \n{Symbol} \n";
               // Symbol.ToString();
        }
    }
}
