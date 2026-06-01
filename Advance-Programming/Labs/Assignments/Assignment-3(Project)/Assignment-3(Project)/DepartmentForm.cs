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
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
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
                    string sqlQuery = "SELECT * FROM Department";
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
                    string query = "INSERT INTO Department VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department Added Successfully");
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

                    string query = "UPDATE Department SET DepartmentName='" + textBox2.Text + "', Location='" + textBox3.Text + "' WHERE DepartmentID='" + textBox1.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Department Record Updated");
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

                    string query = "DELETE FROM Department WHERE DepartmentID='" + textBox1.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Department Record Deleted");
                        showAllRecords();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
