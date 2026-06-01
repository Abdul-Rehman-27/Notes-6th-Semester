namespace Calculator
{
    public partial class Form1 : Form

    {
        //int sum = 0;
        //int a;
        //int temp;
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == ""){
                textBox1.Text = "1";
            } else
            {
                textBox2.Text = "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox2.Text = "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox2.Text = "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox2.Text = "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox2.Text = "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "6";
            //int b = int.Parse(textBox1.Text);
            if (textBox1.Text == "")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox2.Text = "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox2.Text = "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "8";
            }else
            {
                textBox2.Text = "8";
            }
            ;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox2.Text = "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox2.Text = "0";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //int temp = int.Parse(textBox1.Text);
            //textBox1.Text = "+";
            int sum = 0;
            sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            string sumString = sum.ToString();
            textBox3.Text = sumString;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //int sum = 0;
            //sum = temp + a;  //local variable
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //int diff = temp - a;

        }
    }
}
