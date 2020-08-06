namespace student_management_system_semester_fee
{
    partial class studentfee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SemesterFee = new System.Windows.Forms.GroupBox();
            this.notpaid = new System.Windows.Forms.RadioButton();
            this.paid = new System.Windows.Forms.RadioButton();
            this.Submit = new System.Windows.Forms.Button();
            this.feecombo = new System.Windows.Forms.ComboBox();
            this.semestercombo = new System.Windows.Forms.ComboBox();
            this.Semester = new System.Windows.Forms.Label();
            this.Degreecombo = new System.Windows.Forms.ComboBox();
            this.StudentNumber = new System.Windows.Forms.TextBox();
            this.PaymentStatus = new System.Windows.Forms.Label();
            this.Fee = new System.Windows.Forms.Label();
            this.DegreeProgram = new System.Windows.Forms.Label();
            this.studentNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.studentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SemesterFee.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SemesterFee
            // 
            this.SemesterFee.Controls.Add(this.notpaid);
            this.SemesterFee.Controls.Add(this.paid);
            this.SemesterFee.Controls.Add(this.Submit);
            this.SemesterFee.Controls.Add(this.feecombo);
            this.SemesterFee.Controls.Add(this.semestercombo);
            this.SemesterFee.Controls.Add(this.Semester);
            this.SemesterFee.Controls.Add(this.Degreecombo);
            this.SemesterFee.Controls.Add(this.StudentNumber);
            this.SemesterFee.Controls.Add(this.PaymentStatus);
            this.SemesterFee.Controls.Add(this.Fee);
            this.SemesterFee.Controls.Add(this.DegreeProgram);
            this.SemesterFee.Controls.Add(this.studentNo);
            this.SemesterFee.Location = new System.Drawing.Point(2, 6);
            this.SemesterFee.Name = "SemesterFee";
            this.SemesterFee.Size = new System.Drawing.Size(509, 369);
            this.SemesterFee.TabIndex = 0;
            this.SemesterFee.TabStop = false;
            this.SemesterFee.Text = "Semester Fee";
            // 
            // notpaid
            // 
            this.notpaid.AutoSize = true;
            this.notpaid.Location = new System.Drawing.Point(298, 214);
            this.notpaid.Name = "notpaid";
            this.notpaid.Size = new System.Drawing.Size(66, 17);
            this.notpaid.TabIndex = 20;
            this.notpaid.TabStop = true;
            this.notpaid.Text = "Not Paid";
            this.notpaid.UseVisualStyleBackColor = true;
            // 
            // paid
            // 
            this.paid.AutoSize = true;
            this.paid.Location = new System.Drawing.Point(212, 214);
            this.paid.Name = "paid";
            this.paid.Size = new System.Drawing.Size(46, 17);
            this.paid.TabIndex = 19;
            this.paid.TabStop = true;
            this.paid.Text = "Paid";
            this.paid.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(289, 258);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 18;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // feecombo
            // 
            this.feecombo.FormattingEnabled = true;
            this.feecombo.Items.AddRange(new object[] {
            "300000",
            "250000"});
            this.feecombo.Location = new System.Drawing.Point(212, 161);
            this.feecombo.Name = "feecombo";
            this.feecombo.Size = new System.Drawing.Size(152, 21);
            this.feecombo.TabIndex = 17;
            this.feecombo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // semestercombo
            // 
            this.semestercombo.FormattingEnabled = true;
            this.semestercombo.Items.AddRange(new object[] {
            "Fisrt Year-First Semester",
            "Fisrt Year-Second Semester",
            "Second Year-First Semester",
            "Second Year-Second Semester",
            "Third Year-First Semester",
            "Third Year-Second Semester"});
            this.semestercombo.Location = new System.Drawing.Point(212, 124);
            this.semestercombo.Name = "semestercombo";
            this.semestercombo.Size = new System.Drawing.Size(152, 21);
            this.semestercombo.TabIndex = 16;
            this.semestercombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Semester
            // 
            this.Semester.AutoSize = true;
            this.Semester.Location = new System.Drawing.Point(28, 124);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(51, 13);
            this.Semester.TabIndex = 15;
            this.Semester.Text = "Semester";
            // 
            // Degreecombo
            // 
            this.Degreecombo.FormattingEnabled = true;
            this.Degreecombo.Items.AddRange(new object[] {
            "BSc (hons) Software Engineering",
            "BSc (hons) Computer Networks",
            "BSc (hons) Network Security"});
            this.Degreecombo.Location = new System.Drawing.Point(212, 80);
            this.Degreecombo.Name = "Degreecombo";
            this.Degreecombo.Size = new System.Drawing.Size(152, 21);
            this.Degreecombo.TabIndex = 14;
            // 
            // StudentNumber
            // 
            this.StudentNumber.Location = new System.Drawing.Point(212, 38);
            this.StudentNumber.Name = "StudentNumber";
            this.StudentNumber.Size = new System.Drawing.Size(152, 20);
            this.StudentNumber.TabIndex = 7;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.AutoSize = true;
            this.PaymentStatus.Location = new System.Drawing.Point(28, 198);
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.Size = new System.Drawing.Size(84, 13);
            this.PaymentStatus.TabIndex = 3;
            this.PaymentStatus.Text = " Payment Status";
            // 
            // Fee
            // 
            this.Fee.AutoSize = true;
            this.Fee.Location = new System.Drawing.Point(28, 161);
            this.Fee.Name = "Fee";
            this.Fee.Size = new System.Drawing.Size(25, 13);
            this.Fee.TabIndex = 2;
            this.Fee.Text = "Fee";
            // 
            // DegreeProgram
            // 
            this.DegreeProgram.AutoSize = true;
            this.DegreeProgram.Location = new System.Drawing.Point(28, 80);
            this.DegreeProgram.Name = "DegreeProgram";
            this.DegreeProgram.Size = new System.Drawing.Size(84, 13);
            this.DegreeProgram.TabIndex = 1;
            this.DegreeProgram.Text = "Degree Program";
            this.DegreeProgram.Click += new System.EventHandler(this.label1_Click);
            // 
            // studentNo
            // 
            this.studentNo.AutoSize = true;
            this.studentNo.Location = new System.Drawing.Point(28, 38);
            this.studentNo.Name = "studentNo";
            this.studentNo.Size = new System.Drawing.Size(58, 13);
            this.studentNo.TabIndex = 0;
            this.studentNo.Text = "Student ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.studentID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(517, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 369);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check Semester Fees ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 224);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentID
            // 
            this.studentID.Location = new System.Drawing.Point(101, 32);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(205, 20);
            this.studentID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // studentfee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SemesterFee);
            this.Name = "studentfee";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SemesterFee.ResumeLayout(false);
            this.SemesterFee.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SemesterFee;
        private System.Windows.Forms.Label studentNo;
        private System.Windows.Forms.Label DegreeProgram;
        private System.Windows.Forms.Label PaymentStatus;
        private System.Windows.Forms.Label Fee;
        private System.Windows.Forms.ComboBox Degreecombo;
        private System.Windows.Forms.TextBox StudentNumber;
        private System.Windows.Forms.ComboBox semestercombo;
        private System.Windows.Forms.Label Semester;
        private System.Windows.Forms.ComboBox feecombo;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.RadioButton notpaid;
        private System.Windows.Forms.RadioButton paid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox studentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

