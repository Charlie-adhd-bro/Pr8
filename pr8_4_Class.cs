namespace Pr8
{
    class TextAndNumber
    {
        private int Number;
        private string Text;

        public TextAndNumber(int number, string text)
        {
            this.Number = number;
            this.Text = text;
        }

        // Сравнение по длине текста (больше)
        public static bool operator >(TextAndNumber first, TextAndNumber second)
        {
            if (first is null || second is null)
                return false;
            return first.Text.Length > second.Text.Length;
        }

        // Меньше
        public static bool operator <(TextAndNumber first, TextAndNumber second)
        {
            if (first is null || second is null)
                return false;
            return first.Text.Length < second.Text.Length;
        }

        // Больше или равно — по числам
        public static bool operator >=(TextAndNumber first, TextAndNumber second)
        {
            if (first is null || second is null)
                return false;
            return first.Number >= second.Number;
        }

        // Меньше или равно — по числам
        public static bool operator <=(TextAndNumber first, TextAndNumber second)
        {
            if (first is null || second is null)
                return false;
            return first.Number <= second.Number;
        }

        // Равно — оба поля должны совпадать
        public static bool operator ==(TextAndNumber first, TextAndNumber second)
        {
            return (first.Number == second.Number && first.Text == second.Text) ? true : false;
        }

        // Не равно — хотя бы одно поле не совпадает
        public static bool operator !=(TextAndNumber first, TextAndNumber second)
        {
            return (first.Number != second.Number || first.Text != second.Text) ? true : false;
        }

        // Переопределение Equals
        public override bool Equals(object obj)
        {
            if (obj is not TextAndNumber)
                return false;

            var other = (TextAndNumber)obj;
            return this.Number == other.Number && this.Text == other.Text;
        }

        // Переопределение GetHashCode
        public override int GetHashCode()
        {
            return HashCode.Combine(Number, Text);
        }
    }
}