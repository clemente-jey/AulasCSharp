namespace HelloWorld
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

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = $"Ol�,{textBox1.Text} tenha um bom dia!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
