namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public string d;
        public string n1;
        public bool n2;

        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }






  
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button18_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double d1, d2, result;
            result = 0;
            d1 = Convert.ToDouble(n1);
            d2 = Convert.ToDouble(textBox1.Text);

            if (d == "+")
            {
                result = d1 + d2;
            }
            if (d == "-")
            {
                result = d1 - d2;
            }
            if (d == "*")
            {
                result = d1 * d2;
            }
            if (d == "/")
            {
                result = d1 / d2;
            }
            d = "=";
            n2 = true;
            textBox1.Text = result.ToString();
        }
        private void buttonMulti_Click(object sender, EventArgs e)
        {
            Button b1 = (Button)sender;
            d = b1.Text;
            n1 = textBox1.Text;
            n2 = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {

            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button b1 = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = b1.Text;
            else
                textBox1.Text = textBox1.Text + b1.Text;

        }

    }
}