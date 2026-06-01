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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_3_Project_
{
    public partial class CourseForm : Form
    {
        public CourseForm()
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
                    string sqlQuery = "SELECT * FROM Course";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HEC\Documents\6th Semester\AP\Labs\Assignments\Assignment-3(Project)\SchoolContext.mdf;Integrated Security=True;Connect Timeout=30");
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Course VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course Added Successfully");
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

                    string query = "UPDATE Course SET CourseName='" + textBox2.Text + "', CreditHours='" + textBox3.Text + "' WHERE CourseCode='" + textBox1.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Course Record Updated");
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
 
                    string query = "DELETE FROM Course WHERE CourseCode='" + textBox1.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Course Record Deleted");
                        showAllRecords();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DepartmentForm dForm = new DepartmentForm();
            dForm.Show();
            this.Hide();
        }
    }
}
