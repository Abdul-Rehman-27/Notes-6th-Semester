using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleForm_Property
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Hide();
            textBox3.PasswordChar = '@';
            textBox4.Text = "SE";
            textBox5.Text = "CUI";
            textBox5.ReadOnly = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
