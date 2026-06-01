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

namespace Assignment_3_Project_
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
            showAllRecords();
        }

        private void showAllRecords()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HEC\Documents\6th Semester\AP\Labs\Assignments\Assignment-3(Project)\SchoolContext.mdf;Integrated Security=True;Connect Timeout=30");
            {
                try
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM Teacher";
                    SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HEC\Documents\6th Semester\AP\Labs\Assignments\Assignment-3(Project)\SchoolContext.mdf;Integrated Security=True;Connect Timeout=30");
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Teacher VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Added Successfully");
                    showAllRecords();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HEC\Documents\6th Semester\AP\Labs\Assignments\Assignment-3(Project)\SchoolContext.mdf;Integrated Security=True;Connect Timeout=30");
            {
                try
                {
                    conn.Open();
      
                    string query = "UPDATE Teacher SET Name='" + textBox2.Text + "', Subject='" + textBox3.Text + "', Qualification='" + textBox4.Text + "' WHERE TeacherID='" + textBox1.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Teacher Record Updated");
                        showAllRecords();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HEC\Documents\6th Semester\AP\Labs\Assignments\Assignment-3(Project)\SchoolContext.mdf;Integrated Security=True;Connect Timeout=30");
            {
                try
                {
                    conn.Open();
                    // Deletes based on RegNo in textBox5 (Reg No to Delete)
                    string query = "DELETE FROM Teacher WHERE TeacherID='" + textBox1.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Teacher Record Deleted");
                        showAllRecords();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CourseForm cForm = new CourseForm();
            cForm.Show();
            this.Hide();
        }
    }
}
