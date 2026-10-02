namespace NumOrText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double number))
            {
                MessageBox.Show("Значення є числовим");
            }
            else
            {
                MessageBox.Show("Значення є рядковим");
            }
        }
    }
}
