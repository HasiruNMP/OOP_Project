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

namespace student_management_system_semester_fee
{
    public partial class studentfee : Form
    {
        public studentfee()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Paid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string paidstat = "";
            if (paid.Checked)
            {
                paidstat = "Paid";
            }
            else if (notpaid.Checked)
            {
                paidstat = "Not Paid";
            }



            //DB connection

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\GitHub\OOP_Project\StudentMangementDB.mdf;Integrated Security=True;Connect Timeout=30");

            String query = "Insert into SemesterFees(StudentNumber,DegreeProgram,Semester,Fee,PaymentStatu) Values ('" + StudentNumber.Text + "','" + Degreecombo.SelectedValue + "','" + semestercombo.SelectedValue + "', '" + feecombo.SelectedValue + "','"+paidstat+"')";
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
    }
}
