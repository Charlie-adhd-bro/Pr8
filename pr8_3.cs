namespace Pr8
{
    public partial class pr8_3 : Form
    {
        public pr8_3()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0 
                && textBox3.Text.Length == 0 && textBox4.Text.Length == 0)
            {
                MessageBox.Show(
                        "Одно из текстовых полей пустое, введите значения во все поля",
                        "Ошибка ввода",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return;
            }

            if (!int.TryParse(textBox1.Text, out int first)
                || !int.TryParse(textBox2.Text, out int second) 
                || !int.TryParse(textBox3.Text, out int first1)
                || !int.TryParse(textBox4.Text, out int second1))
            {
                MessageBox.Show(
                        "Ввод не числа.\n Введите еще раз",
                        "Ошибка ввода",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return;
            }

            SumOfSquares number1 = new SumOfSquares(0, 8);   // сумма квадратов: 0^2 + 8^2 = 0 + 64 = 64
            SumOfSquares number2 = new SumOfSquares(9, 7);   // сумма: 9^2 + 7^2 = 81 + 49 = 130
            SumOfSquares number3 = new SumOfSquares(3, 4);   // сумма: 3^2 + 4^2 = 9 + 16 = 25
            SumOfSquares number4 = new SumOfSquares(6, 8);   // сумма: 36 + 64 = 100

            // Тесты:
            labelResult.Text = "0 + 64 > 81 + 49 " + String.Join("\n", number1 > number2); // "False"
            labelResult.Text += "\n" + $"9 + 16 > 36 + 64 " +String.Join("\n", number3 > number4); // "False"
            labelResult.Text += "\n" + $"36 + 64 > 9 + 16 " + String.Join(" ", number4 > number3); // "True"
            labelResult2.Text = "81 + 49 < 9 + 16 " + String.Join(" ", number2 < number3); // "False"
            labelResult2.Text += "\n" + "0 + 64 < 36 + 64 " + String.Join(" ", number1 < number4); // "True"

            SumOfSquares number12 = new SumOfSquares(first, second);
            SumOfSquares number22 = new SumOfSquares(first1, second1);
            labelResult2.Text += "\n" + $"{first * first} + {second * second} " +
                $"< {first1 * first1} + {second1 * second1} " 
                + String.Join(" ", number12 < number22); 
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            labelResult.Text = "";
            labelResult2.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain().Show();
        }
    }
}
