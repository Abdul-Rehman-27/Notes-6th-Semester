using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRecordManagement
{
    public partial class SignUpForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HEC\Documents\6th Semester\AP\Labs\StudentRecordManagement\StudentDB.mdf"";Integrated Security=True;Connect Timeout=30");
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black; 
            textBox2.ForeColor = Color.Black; 
            textBox3.ForeColor = Color.Black;
            textBox4.ForeColor = Color.Black;
            textBox5.ForeColor = Color.Black;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lf = new LoginForm();

            lf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text != textBox5.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                conn.Open();
                string query = "INSERT INTO Users (FullName, Username, Email, Password) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Account Created Successfully");
                LoginForm lf = new LoginForm();
                lf.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
