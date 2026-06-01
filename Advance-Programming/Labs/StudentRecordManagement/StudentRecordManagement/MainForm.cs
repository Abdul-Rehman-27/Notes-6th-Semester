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
    public partial class MainForm : Form
    {
        // Global Connection String - Pointing to StudentDB.mdf in the project folder
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HEC\Documents\6th Semester\AP\Labs\StudentRecordManagement\StudentDB.mdf;Integrated Security=True;Connect Timeout=30";

        public MainForm()
        {
            InitializeComponent();
            showAllRecords();
        }

        private void showAllRecords()
        {
            SqlConnection conn = new SqlConnection(connString);
            {
                try
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM StudentDetails";
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

        private void label2_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label15_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        // Add Student
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO StudentDetails VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "', '" + comboBox3.Text + "', '" + textBox9.Text + "', '" + textBox10.Text + "', '" + dateTimePicker1.Value.Date + "')";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Added Successfully");
                    showAllRecords();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        // Update Student
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE StudentDetails SET FirstName='" + textBox2.Text + "', LastName='" + textBox3.Text + "', FatherName='" + textBox4.Text + "', CNIC='" + textBox5.Text + "', Department='" + comboBox1.Text + "', Program='" + comboBox2.Text + "', YearOfStudy='" + textBox6.Text + "', Semester='" + textBox7.Text + "', CGPA='" + textBox8.Text + "', Status='" + comboBox3.Text + "', Email='" + textBox9.Text + "', Contact='" + textBox10.Text + "', EnrollmentDate='" + dateTimePicker1.Value.Date + "' WHERE RegNo='" + textBox1.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Student Record Updated");
                        showAllRecords();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        // Delete Student
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM StudentDetails WHERE RegNo='" + textBox1.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Student Record Deleted");
                        showAllRecords();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        // Search Student
        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM StudentDetails WHERE RegNo='" + textBox11.Text + "' OR FirstName='" + textBox11.Text + "'";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;

                        textBox1.Text = dt.Rows[0]["RegNo"].ToString();
                        textBox2.Text = dt.Rows[0]["FirstName"].ToString();
                        textBox3.Text = dt.Rows[0]["LastName"].ToString();
                        textBox4.Text = dt.Rows[0]["FatherName"].ToString();
                        textBox5.Text = dt.Rows[0]["CNIC"].ToString();
                        comboBox1.Text = dt.Rows[0]["Department"].ToString();
                        comboBox2.Text = dt.Rows[0]["Program"].ToString();
                        textBox6.Text = dt.Rows[0]["YearOfStudy"].ToString();
                        textBox7.Text = dt.Rows[0]["Semester"].ToString();
                        textBox8.Text = dt.Rows[0]["CGPA"].ToString();
                        comboBox3.Text = dt.Rows[0]["Status"].ToString();
                        textBox9.Text = dt.Rows[0]["Email"].ToString();
                        textBox10.Text = dt.Rows[0]["Contact"].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["EnrollmentDate"]);
                    }
                    else
                    {
                        MessageBox.Show("No Student Found");
                        showAllRecords();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }
    }
}