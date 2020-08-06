using student_management_system_semester_fee;
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
    public partial class Portal : Form
    {
        public Portal()
        {
            InitializeComponent();
        }

        private void btnp_stu_Click(object sender, EventArgs e)
        {

        }

        private void btnp_asn_Click(object sender, EventArgs e)
        {
            var asnform = new AssignmentSub();
            asnform.Show();
        }

        private void btnp_exm_Click(object sender, EventArgs e)
        {
            var exmform = new TermTestMarks();
            exmform.Show();
        }

        private void btnp_ext_Click(object sender, EventArgs e)
        {
            var extform = new ExtraFacility();
            extform.Show();
        }

        private void btnp_pay_Click(object sender, EventArgs e)
        {
            var payform = new studentfee();
            payform.Show();
        }
    }
}
