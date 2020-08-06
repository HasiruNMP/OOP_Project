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

namespace ClassManagementSystem
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int stid = int.Parse(textBoxStid.Text);
            string stname= textBoxStname.Text;
            string address = textBoxAddress.Text;
            int age = int.Parse(textBoxAge.Text);
            int indexno = int.Parse(textBoxIndexNo.Text);
            string gender=Convert.ToString(comboBoxGender.SelectedItem);
            string batch = textBoxBatch.Text;
            string email = textBoxEmail.Text;
            int phoneno = int.Parse(textBoxPhone.Text);


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\GitHub\OOP_Project\ClassManagementSystem\StudentMangementDB.mdf;Integrated Security=True;Connect Timeout=30");

            String query = "insert into StudentDetails(StudentId,StudentName,Address,Age,IndexNo,Gender,Batch,Email,PhoneNo) Values ('" + stid + "','" + stname + "','" + address + "', '" + age + "', '" + indexno + "', '" + gender + "', '" + batch + "', '" + email + "', '" + phoneno + "')";

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



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int stid = int.Parse(textstid.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\GitHub\OOP_Project\ClassManagementSystem\StudentMangementDB.mdf;Integrated Security=True;Connect Timeout=30");

            String query = "Select * from StudentDetails where StudentId = '" + stid + "' ";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet set = new DataSet();

            adapter.Fill(set, "StudentDetails");
            dataGridView1.DataSource = set.Tables["StudentDetails"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int stid = int.Parse(textstid.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\GitHub\OOP_Project\ClassManagementSystem\StudentMangementDB.mdf;Integrated Security=True;Connect Timeout=30");

            String query = "delete from StudentDetails where StudentId = '" + stid + "' ";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Deleted successfully");

            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int stid = int.Parse(textstid.Text);
            int newphone = int.Parse(textphoneno.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\GitHub\OOP_Project\ClassManagementSystem\StudentMangementDB.mdf;Integrated Security=True;Connect Timeout=30");

            String query = "update StudentDetails set PhoneNo = '" + newphone + "' where StudentId= '" + stid + "'";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated successfully");

            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
                con.Close();
            }
        }
    }
    
}
