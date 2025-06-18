namespace Pr8
{
    public partial class pr8_1 : Form
    {
        public pr8_1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show(
                       "Одно из текстовых полей пустое, введите значения в оба поля",
                       "Ошибка ввода",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }

            if (!int.TryParse(textBox2.Text, out int num))
            {
                MessageBox.Show(
                       "Ввод не числа.\n Введите еще раз",
                       "Ошибка ввода",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }
            CharOperator charObj = new CharOperator(textBox1.Text[0]);

            labelResult.Text = "Оригинальный символ:\n" + charObj;
            labelResult.Text += "\nСимвол на 1 больше:\n" + charObj++;
            labelResult.Text += "\nСимвол на 1 меньше:\n" + charObj--;

            CharOperator newChar = charObj + num;

            labelResult.Text += $"\nНовый символ ({charObj} + {num}):\n" + newChar;
            newChar = num + charObj;
            labelResult.Text += $"\nНовый символ ({num} + {charObj}):\n" + newChar;
            num = newChar - charObj;

            labelResult.Text += $"\nРазница символов ({charObj}, {newChar}):\n" + num;


            charObj = new CharOperator('A');

            labelResult2.Text = "Оригинальный символ:\n" + charObj;
            labelResult2.Text += "\nСимвол на 1 больше:\n" + charObj++;
            labelResult2.Text += "\nСимвол на 1 меньше:\n" + charObj--;

            newChar = charObj + num;

            labelResult2.Text += $"\nНовый символ ({charObj} + {num}):\n" + newChar;
            newChar = num + charObj;
            labelResult2.Text += $"\nНовый символ ({num} + {charObj}):\n" + newChar;
            num = newChar - charObj;

            labelResult2.Text += $"\nРазница символов ({charObj}, {newChar}):\n" + num;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
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
