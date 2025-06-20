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
            //if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0
            //    && textBox3.Text.Length == 0 && textBox4.Text.Length == 0)
            //{
            //    MessageBox.Show(
            //            "Одно из текстовых полей пустое, введите значения во все поля",
            //            "Ошибка ввода",
            //            MessageBoxButtons.OK,
            //            MessageBoxIcon.Error
            //        );
            //    return;
            //}

            //if (!int.TryParse(textBox1.Text, out int first)
            //    || !int.TryParse(textBox3.Text, out int second))
            //{
            //    MessageBox.Show(
            //            "Ввод не числа.\n Введите еще раз",
            //            "Ошибка ввода",
            //            MessageBoxButtons.OK,
            //            MessageBoxIcon.Error
            //        );
            //    return;
            //}

            // Тест 1: сравнение объектов с разными текстами и числами
            labelResult.Text = "Тест 1: Разные объекты\n";

            TextAndNumber obj1 = new TextAndNumber(10, "Привет");
            TextAndNumber obj2 = new TextAndNumber(20, "Мир");

            labelResult.Text += "Сравнение длины текста (>): "
                + (obj1 > obj2).ToString() + "\n"; // Ожидается false
            labelResult.Text += "Сравнение длины текста (<): "
                + (obj1 < obj2).ToString() + "\n"; // Ожидается true

            labelResult.Text += "Сравнение числовых значений (>=): "
                + (obj1 >= obj2).ToString() + "\n"; // false
            labelResult.Text += "Сравнение числовых значений (<=): "
                + (obj1 <= obj2).ToString() + "\n"; // true

            labelResult.Text += "Сравнение и текста и числа (==): "
                + (obj1 == obj2).ToString() + "\n"; // false
            labelResult.Text += "Сравнение и текста и числа (Equals): "
                + obj1.Equals(obj2).ToString() + "\n"; // false

            // Тест 2: сравнение одинаковых объектов
            TextAndNumber obj5 = new TextAndNumber(10, "Привет");
            TextAndNumber obj6 = new TextAndNumber(10, "Привет");

            labelResult2.Text = "Тест 2: Идентичные объекты\n";

            labelResult2.Text += "Сравнение длины текста (>): "
                + (obj5 > obj6).ToString() + "\n"; // false
            labelResult2.Text += "Сравнение длины текста (<): "
                + (obj5 < obj6).ToString() + "\n"; // true

            labelResult2.Text += "Сравнение числовых значений (>=): "
                + (obj5 >= obj6).ToString() + "\n"; // false
            labelResult2.Text += "Сравнение числовых значений (<=): "
                + (obj5 <= obj6).ToString() + "\n"; // true

            labelResult2.Text += "Сравнение и текста и числа (==): "
                + (obj5 == obj6).ToString() + "\n"; 
                                                   
            labelResult2.Text += "Сравнение и текста и числа (Equals): "
                + obj5.Equals(obj6).ToString() + "\n";

            // Тест 3: сравнение объектов с одинаковым текстом, разными числами
            TextAndNumber obj9 = new TextAndNumber(15, "Привет");
            TextAndNumber obj10 = new TextAndNumber(25, "Привет");

            labelResult3.Text = "Тест 3: Одинаковый текст, разные числа\n";

            labelResult3.Text += "Сравнение длины текста (>): "
                + (obj9 > obj10).ToString() + "\n"; // false
            labelResult3.Text += "Сравнение длины текста (<): "
                + (obj9 < obj10).ToString() + "\n"; // false

            labelResult3.Text += "Сравнение числовых значений (>=): "
                + (obj9 >= obj10).ToString() + "\n"; // false
            labelResult3.Text += "Сравнение числовых значений (<=): "
                + (obj9 <= obj10).ToString() + "\n"; // true

            labelResult3.Text += "Сравнение и текста и числа (==): "
                + (obj9 == obj10).ToString() + "\n"; // false или true?
            labelResult3.Text += "Сравнение и текста и числа (Equals): "
                + obj9.Equals(obj10).ToString() + "\n";

            // Тест 4: сравниваем объекты с разными текстами и одинаковыми числами
            TextAndNumber obj11 = new TextAndNumber(30, "Мир");
            TextAndNumber obj12 = new TextAndNumber(30, "Мир");

            labelResult4.Text = "Тест 4: Разный текст, одинаковые числа\n";

            labelResult4.Text += "Сравнение длины текста (>): "
                + (obj11 > obj12).ToString() + "\n"; // false
            labelResult4.Text += "Сравнение длины текста (<): "
                + (obj11 < obj12).ToString() + "\n"; // false

            labelResult4.Text += "Сравнение числовых значений (>=): "
                + (obj11 >= obj12).ToString() + "\n"; // true или false? зависит от реализации оператора ==
            labelResult4.Text += "Сравнение числовых значений (<=): "
                + (obj11 <= obj12).ToString() + "\n";

            labelResult4.Text += "Сравнение и текста и числа (==) "
                + (obj11 == obj12).ToString() + "\n";
            labelResult4.Text += "Сравнение и текста и числа (Equals): "
                + obj11.Equals(obj12).ToString() + "\n";

            labelResult.Text += "\n\n";
            labelResult2.Text += "\n\n";
            labelResult3.Text += "\n\n";
            labelResult4.Text += "\n\n";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

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
