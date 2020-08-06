namespace ClassManagementSystem
{
    partial class Portal
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
            this.btnp_stu = new System.Windows.Forms.Button();
            this.btnp_asn = new System.Windows.Forms.Button();
            this.btnp_exm = new System.Windows.Forms.Button();
            this.btnp_ext = new System.Windows.Forms.Button();
            this.btnp_pay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnp_stu
            // 
            this.btnp_stu.Location = new System.Drawing.Point(126, 122);
            this.btnp_stu.Name = "btnp_stu";
            this.btnp_stu.Size = new System.Drawing.Size(197, 67);
            this.btnp_stu.TabIndex = 0;
            this.btnp_stu.Text = "Student Details";
            this.btnp_stu.UseVisualStyleBackColor = true;
            this.btnp_stu.Click += new System.EventHandler(this.btnp_stu_Click);
            // 
            // btnp_asn
            // 
            this.btnp_asn.Location = new System.Drawing.Point(126, 195);
            this.btnp_asn.Name = "btnp_asn";
            this.btnp_asn.Size = new System.Drawing.Size(197, 67);
            this.btnp_asn.TabIndex = 1;
            this.btnp_asn.Text = "Assignments";
            this.btnp_asn.UseVisualStyleBackColor = true;
            this.btnp_asn.Click += new System.EventHandler(this.btnp_asn_Click);
            // 
            // btnp_exm
            // 
            this.btnp_exm.Location = new System.Drawing.Point(126, 268);
            this.btnp_exm.Name = "btnp_exm";
            this.btnp_exm.Size = new System.Drawing.Size(197, 67);
            this.btnp_exm.TabIndex = 2;
            this.btnp_exm.Text = "Exam Results";
            this.btnp_exm.UseVisualStyleBackColor = true;
            this.btnp_exm.Click += new System.EventHandler(this.btnp_exm_Click);
            // 
            // btnp_ext
            // 
            this.btnp_ext.Location = new System.Drawing.Point(126, 341);
            this.btnp_ext.Name = "btnp_ext";
            this.btnp_ext.Size = new System.Drawing.Size(197, 67);
            this.btnp_ext.TabIndex = 3;
            this.btnp_ext.Text = "Extra Facility Usage";
            this.btnp_ext.UseVisualStyleBackColor = true;
            this.btnp_ext.Click += new System.EventHandler(this.btnp_ext_Click);
            // 
            // btnp_pay
            // 
            this.btnp_pay.Location = new System.Drawing.Point(126, 414);
            this.btnp_pay.Name = "btnp_pay";
            this.btnp_pay.Size = new System.Drawing.Size(197, 67);
            this.btnp_pay.TabIndex = 4;
            this.btnp_pay.Text = "Payments";
            this.btnp_pay.UseVisualStyleBackColor = true;
            this.btnp_pay.Click += new System.EventHandler(this.btnp_pay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Management System";
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnp_pay);
            this.Controls.Add(this.btnp_ext);
            this.Controls.Add(this.btnp_exm);
            this.Controls.Add(this.btnp_asn);
            this.Controls.Add(this.btnp_stu);
            this.Name = "Portal";
            this.Text = "Student Management System 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnp_stu;
        private System.Windows.Forms.Button btnp_asn;
        private System.Windows.Forms.Button btnp_exm;
        private System.Windows.Forms.Button btnp_ext;
        private System.Windows.Forms.Button btnp_pay;
        private System.Windows.Forms.Label label1;
    }
}