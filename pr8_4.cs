namespace Pr8
{
    public partial class pr8_4 : Form
    {
        public pr8_4()
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
                || !int.TryParse(textBox3.Text, out int second))
            {
                MessageBox.Show(
                        "Ввод не числа.\n Введите еще раз",
                        "Ошибка ввода",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return;
            }

            TextAndNumber obj1 = new(first, textBox2.Text);
            TextAndNumber obj2 = new(second, textBox4.Text);

            labelResult2.Text = "Сравнение "+ (obj1 == obj2).ToString() +"\n";

            labelResult2.Text += obj1.Equals(obj2).ToString();

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
