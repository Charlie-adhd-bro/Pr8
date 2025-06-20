namespace Pr8
{
    class SymbolAndNumber
    {
        private int Number;
        private char Symbol;

        public SymbolAndNumber(int number, char text)
        {
            this.Number = number;
            this.Symbol = text;
        }
        // Сравнение по длине текста (больше)
        public static bool operator true(SymbolAndNumber obj)
        {
            return (int)obj.Symbol - obj.Number < 10;
        }

        public static bool operator false(SymbolAndNumber obj)
        {
            return (int)obj.Symbol - obj.Number > 10;
        }
        public static string Sequence(SymbolAndNumber obj)
        {
            int end = obj.Number;
            int start = obj.Symbol;

            int step = end <= start ? 1 : -1;
            int length = Math.Abs(end - start) + 1;

            string result = "Результат:\n";

            for (int i = 0; i < length; i++)
            {
                char current = (char)(obj.Symbol + i * step);

                if (i == length - 1)
                {
                    result += current;
                }
                else
                {
                    result += current + ", ";
                }
            }

            return result;
        }
    }
}
