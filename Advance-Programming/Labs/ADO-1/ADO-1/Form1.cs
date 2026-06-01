using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showAllRecords();
        }

        private void showAllRecords()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HEC\Documents\6th Semester\AP\Labs\ADO-1\Database_Project.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                conn.Open();
                MessageBox.Show("Connection Established Successfully");

                // Added the table name Patient_Detail
                string sqlQuerry = "Select * from Patient_Detail";

                SqlCommand command = new SqlCommand(sqlQuerry, conn);
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Updated connection string pointing to the ADO-1 folder
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HEC\Documents\6th Semester\AP\Labs\ADO-1\Database_Project.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                conn.Open();

                string name = textBox1.Text;
                int age = int.Parse(textBox2.Text);
                string disease = textBox3.Text;

                string sqlQuerrry = "insert into Patient_Detail(Name, Age, Disease) values ('" + name + "', " + age + ", '" + disease + "')";

                SqlCommand command = new SqlCommand(sqlQuerrry, conn);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Record Inserted Successfully");
                    showAllRecords();
                }
                else
                {
                    MessageBox.Show("Error Occured");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HEC\Documents\6th Semester\AP\Labs\ADO-1\Database_Project.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                conn.Open();

                string name = textBox1.Text;
                int age = int.Parse(textBox2.Text);
                string disease = textBox3.Text;
                int id = int.Parse(textBox4.Text);
                string sqlQuerry = "UPDATE Patient_Detail SET Name= '" + name + "' ,Age = '" + age + "' ,Disease = '" + disease + "' WHERE ID = '" + id +"'";
                    
                SqlCommand command = new SqlCommand(sqlQuerry, conn);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Record Updated Successfully");
                    showAllRecords();
                }
                else
                {
                    MessageBox.Show("Error Occured");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Updated connection string pointing to the ADO-1 folder
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HEC\Documents\6th Semester\AP\Labs\ADO-1\Database_Project.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                conn.Open();

                
                int id= int.Parse(textBox4.Text);

                string sqlQuerrry = "delete from Patient_Detail  where id= '"+id+"'";

                SqlCommand command = new SqlCommand(sqlQuerrry, conn);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Record Deleted Successfully");
                    showAllRecords();
                }
                else
                {
                    MessageBox.Show("Error Occured");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}