namespace Calculadora_3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text += "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            label4 = textBox1 + textBox2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4 = textBox1 - textBox2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4 = textBox1 * textBox2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4 = textBox1 / textBox2;
        }
    }
}
