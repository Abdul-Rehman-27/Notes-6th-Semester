using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Required for SQL connections

namespace Assignment_3_Project_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            showAllRecords(); // Load data on startup
        }

        private void showAllRecords()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HEC\Documents\6th Semester\AP\Labs\Assignments\Assignment-3(Project)\SchoolContext.mdf;Integrated Security=True;Connect Timeout=30");
            {
                try
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM Student";
                    SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();  
                    conn.Dispose();
                }
            }

        }

        // button1: ADD STUDENT
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HEC\Documents\6th Semester\AP\Labs\Assignments\Assignment-3(Project)\SchoolContext.mdf;Integrated Security=True;Connect Timeout=30");
            {
                try
                {
                    conn.Open();
                    // Columns: RegNo(txt1), FirstName(txt2), LastName(txt3), EnrollmentDate(txt4)
                    string query = "INSERT INTO Student VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Added Successfully");
                    showAllRecords();
                }
                catch (Exception ex) { 
                    MessageBox.Show(ex.Message); 
                }
            }
        }


        // button3: DELETE STUDENT
        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HEC\Documents\6th Semester\AP\Labs\Assignments\Assignment-3(Project)\SchoolContext.mdf;Integrated Security=True;Connect Timeout=30");
            {
                try
                {
                    conn.Open();
                    // Deletes based on RegNo in textBox5 (Reg No to Delete)
                    string query = "DELETE FROM Student WHERE RegNo='" + textBox1.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Student Record Deleted");
                        showAllRecords();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        // button4: GO TO TEACHER
        private void button4_Click(object sender, EventArgs e)
        {
            TeacherForm tForm = new TeacherForm();
            tForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // button2: UPDATE STUDENT
        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HEC\Documents\6th Semester\AP\Labs\Assignments\Assignment-3(Project)\SchoolContext.mdf;Integrated Security=True;Connect Timeout=30");
            {
                try
                {
                    conn.Open();
                    // Updates based on RegNo in textBox1
                    string query = "UPDATE Student SET FirstName='" + textBox2.Text + "', LastName='" + textBox3.Text + "', EnrollmentDate='" + textBox4.Text + "' WHERE RegNo='" + textBox1.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Student Record Updated");
                        showAllRecords();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}