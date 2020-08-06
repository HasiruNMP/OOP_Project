using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClassManagementSystem
{
    public partial class AssignmentSub : Form
    {
        public AssignmentSub()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int stid = int.Parse(textBox1.Text);
            string asn = textBox2.Text;
            string stat = textBox3.Text;
            string mrk = textBox5.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\GitHub\OOP_Project\StudentMangementDB.mdf;Integrated Security=True;Connect Timeout=30");

            String query = "Insert into ProjectSubmission(Id,AddingProjects,SubmissionStatus,ProjectMarks) Values ('" + stid + "','" + asn + "','" + stat + "', '" + mrk + "')";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record added successfully");

            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
                con.Close();
            }

            MessageBox.Show(stid.ToString());
        }

        private void btnashchk_Click(object sender, EventArgs e)
        {
            int stid = int.Parse(textBox2.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\GitHub\OOP_Project\ClassManagementSystem\StudentMangementDB.mdf;Integrated Security=True;Connect Timeout=30");

            String query = "Select Id,AddingProjects,SubmissionStatus,ProjectMarks from PrjectSubmission where ID = '" + stid + "' ";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet set = new DataSet();

            adapter.Fill(set, "Assignment Submissions");
            dataGridView1.DataSource = set.Tables["Assignment Submissions"];

 
        }
    }
}
