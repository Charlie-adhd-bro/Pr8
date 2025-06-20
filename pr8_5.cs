namespace Pr8
{
    public partial class pr8_5 : Form
    {
        public pr8_5()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show(
                        "Одно из текстовых полей пустое, введите значения во все поля",
                        "Ошибка ввода",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return;
            }

            if (!int.TryParse(textBox1.Text, out int number))
            {
                MessageBox.Show(
                        "Ввод не числа.\n Введите еще раз",
                        "Ошибка ввода",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return;
            }

            SymbolAndNumber obj = new(5, 'A');
            if (obj) 
            {
                labelResult.Text += SymbolAndNumber.Sequence(obj) + "\n\n";
            }
            else
            {
                labelResult.Text += "Разность значения целочисленного поля " +
                    "и кода символа больше 10.\n\n";
            }

            //labelResult.Text += "\n\n";
            //labelResult.Text += "\n\n";
            //labelResult3.Text += "\n\n";
            //labelResult4.Text += "\n\n";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            labelResult.Text = "";
            labelResult2.Text = "";
            labelResult3.Text = "";
            labelResult4.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain().Show();
        }
    }
}
