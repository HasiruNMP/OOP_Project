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
    public partial class TermTestMarks : Form
    {

        
        public TermTestMarks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string stname = StudentextBox1.Text;
            int module1 = int.Parse(textBoxModule1.Text);
            int module2 = int.Parse(textBoxModule2.Text);
            int module3 = int.Parse(textBoxModule3.Text);
            int total = module1 + module2 + module3;
            double average = Convert.ToDouble((module1 + module2 + module3)/3);
            string m1grade, m2grade, m3grade;




           //module 1
            if (module1 >= 80)
            {
                m1grade = "A";
            }

            else if (module1 >= 60)
            {
                m1grade = "B";
            }

            else if (module1 >= 40)
            {
                m1grade = "C";
            }

            else
                m1grade = "F";

          



            //module 2
            if (module2 >= 80)
            {
                m2grade = "A";
            }

            else if (module2 >= 60)
            {
                m2grade = "B";
            }

            else if (module2 >= 40)
            {
                m2grade = "C";
            }

            else
                m2grade = "F";

          


            //moudle 3
            if (module3 >= 80)
            {
                m3grade = "A";
            }

            else if (module3 >= 60)
            {
                m3grade = "B";
            }

            else if (module3 >= 40)
            {
                m3grade = "C";
            }

            else
                m3grade = "F";


            MessageBox.Show("Student Name:" +stname+ "\n" + "Module1 " + m1grade + "\n" +"Module2 " + m2grade + "\n" + "Module3 " + m3grade  +"\n" + "Total Marks: " + total + "\n" + "Average: " + average);








            //DB connection

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\GitHub\OOP_Project\StudentMangementDB.mdf;Integrated Security=True;Connect Timeout=30");

            String query = "Insert into Module(StudentName,ModuleName,Marks,Grade) Values ('" +StudentextBox1.Text + "','" + Module1.Text + "','" + textBoxModule1.Text + "', '" + m1grade + "'),('" + StudentextBox1.Text + "','" + Module2.Text + "','" + textBoxModule2.Text + "', '" + m2grade + "'),('" + StudentextBox1.Text + "','" + Module3.Text + "','" + textBoxModule3.Text + "', '" + m3grade + "')";
            query += "Insert into MarksDetails(StudentName,TotalMarks,Average) Values('" + StudentextBox1.Text + "','" + total + "','" + average + "')";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record added successfully");


            }

            catch(SqlException ex)
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
