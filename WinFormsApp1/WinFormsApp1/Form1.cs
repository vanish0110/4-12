namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            double X0 = Convert.ToDouble(textBox1.Text);
            double Xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);
            textBox5.Text = "Работу выполнил ст. Уткин И.А." +
            Environment.NewLine;
            double x = X0;
            while (x <= (Xk + dx / 2))
            {
                double y = 9 * (Math.Pow(x, 3) + Math.Pow(b, 3)) * Math.Tan(x);
                textBox5.Text += "x=" + Convert.ToString(x) +
                    "; y=" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;

            }
        }
    }
}