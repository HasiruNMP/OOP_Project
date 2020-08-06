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
    public partial class ExtraFacility : Form
    {
        public ExtraFacility()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int stid = int.Parse(textBox1.Text);
            string fac = comboBox1.Text;
            string date = dateTimePicker1.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\GitHub\OOP_Project\ClassManagementSystem\StudentMangementDB.mdf;Integrated Security=True;Connect Timeout=30");

            String query = "insert into ExtraFac(StudentId,Facility,Date) Values ('" + stid + "','" + comboBox1.SelectedItem + "','" + dateTimePicker1.Value.Date + "')";

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

        private void button2_Click(object sender, EventArgs e)
        {
            int stid = int.Parse(textBox2.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\GitHub\OOP_Project\ClassManagementSystem\StudentMangementDB.mdf;Integrated Security=True;Connect Timeout=30");

            String query = "Select StudentId,Facility,Date from ExtraFac where StudentId = '" + stid + "' ";
            
            
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet set = new DataSet();

            adapter.Fill(set, "ExtraFac");
            dataGridView1.DataSource = set.Tables["ExtraFac"];


        }
    }
}
