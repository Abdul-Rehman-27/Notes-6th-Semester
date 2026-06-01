using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_ListBox_CheckListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Apple"); // add apple to listbox
            listBox1.Items.Add(textBox1.Text); // add value from textbox to listbox
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Remove("Apple");
            //listBox1.Items.RemoveAt(0); // remove first item from listbox
            listBox1.Items.Remove(textBox1.Text);  
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listBox1.Items.Add("Welcome to ListBox. Add Values Here"); // we want to display default values in list
            listBox1.Items.Add("Apple");
            listBox1.Items.Add("Mangoes");
            listBox1.Items.Add("Banana");
            listBox1.Items.Add("Strawbery");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
