namespace Pr8
{
    public partial class pr8_2 : Form
    {
        public pr8_2()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int num) || num < 1)
            {
                MessageBox.Show(
                       "Ввод не числа или число меньше 1.\nВведите еще раз",
                       "Ошибка ввода",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }
            MyArray array = new(num);
            labelResult.Text = "Массив: " + ~array + "\n";

            array++;
            labelResult.Text += "Массив, размер больше на 1: " + ~array + "\n"; ;

            array--;
            labelResult.Text += "Массив, размер меньше на 1: " + ~array + "\n"; ;

            MyArray newArray = new(num);
            labelResult.Text += "Новый массив: " + ~newArray + "\n"; ;

            MyArray MyArray = array + newArray;
            labelResult2.Text = "Объединенный массив (сумма объектов): " + ~MyArray + "\n"; ;

            int num2 = 0;
            if (!String.IsNullOrWhiteSpace(textBox2.Text) && !int.TryParse(textBox2.Text, out num2))
            {
                MessageBox.Show(
                      "Ввод не числа.\n Введите еще раз",
                      "Ошибка ввода",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error
                  );
                return;
            }

            MyArray = num2 + array;
            labelResult2.Text += "Новый массив (число + объект): " + ~MyArray + "\n"; 

            MyArray = array + num2;
            labelResult2.Text += "Новый массив (объект + число): " + ~MyArray + "\n"; 
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
