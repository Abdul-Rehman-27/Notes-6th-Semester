using Microsoft.VisualBasic.Logging;
using System.DirectoryServices;

namespace WF_1_LoginForm
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName;
            string password;
            userName = "Abdul Rehman";
            password = "123456";
            string userInput = tb_1.Text;
            string passInput = tb_2.Text;
            if (userInput == userName && passInput == password)
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_1.Text = "";
            tb_2.Text = "";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_3.Text = "6th";  // Pre-Filled
        }

        private void tb_3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
