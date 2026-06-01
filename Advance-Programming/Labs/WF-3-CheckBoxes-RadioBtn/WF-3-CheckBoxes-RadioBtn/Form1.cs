using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_3_CheckBoxes_RadioBtn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                MessageBox.Show("You have selected: " + checkBox1.Text + " and " + checkBox2.Text);
            }
            else if (checkBox1.Checked == true) {
                MessageBox.Show("You have selected: " + checkBox1.Text);
            }
            else if (checkBox2.Checked == true)
            {
                MessageBox.Show("You have selected: " + checkBox2.Text);
            } else
            {
                MessageBox.Show("You have not selected any option.");
            }

            if (radioButton1.Checked == true)
            {
                MessageBox.Show("You are: " + radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("You are: " + radioButton2.Text);
            } else
            {
                MessageBox.Show("You have not selected any option.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
