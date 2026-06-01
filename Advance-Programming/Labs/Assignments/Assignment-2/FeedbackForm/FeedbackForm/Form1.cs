using System;
using System.IO;
using System.Windows.Forms;

namespace FeedbackForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = nameBox1.Text + " , " + emailBox1.Text + " , " + cmntBox1.Text;
            saveFileDialog1.DefaultExt = ".txt";

            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.AppendAllText(saveFileDialog1.FileName, data);
                MessageBox.Show("Feedback Saved Successfully!");

                nameBox1.Clear();
                emailBox1.Clear();
                cmntBox1.Clear();
            }
        }
    }
}