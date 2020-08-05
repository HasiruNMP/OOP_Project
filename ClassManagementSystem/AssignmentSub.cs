using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int mod = int.Parse(textBox2.Text);
            int asno = int.Parse(textBox3.Text);



            MessageBox.Show(stid.ToString());
        }
    }
}
