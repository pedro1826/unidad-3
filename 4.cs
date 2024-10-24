namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d;
            a = int.Parse(maskedTextBox1.Text);
            b = int.Parse(maskedTextBox2.Text);
            c = int.Parse(maskedTextBox3.Text);
            d = int.Parse(maskedTextBox4.Text);

            maskedTextBox5.Text = d.ToString();
            maskedTextBox6.Text = c.ToString();
            maskedTextBox7.Text = b.ToString();
            maskedTextBox8.Text = a.ToString();
        }
    }
}