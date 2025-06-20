namespace Pr8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pr8_1 mainForm = new();
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            pr8_2 mainForm = new();
            mainForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            pr8_3 mainForm = new();
            mainForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            pr8_4 mainForm = new();
            mainForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            pr8_5 mainForm = new();
            mainForm.Show();
        }
    }
}
