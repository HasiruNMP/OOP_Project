namespace ClassManagementSystem
{
    partial class TermTestMarks
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
            this.label1 = new System.Windows.Forms.Label();
            this.Module1 = new System.Windows.Forms.Label();
            this.Module2 = new System.Windows.Forms.Label();
            this.Module3 = new System.Windows.Forms.Label();
            this.textBoxModule1 = new System.Windows.Forms.TextBox();
            this.textBoxModule2 = new System.Windows.Forms.TextBox();
            this.textBoxModule3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marks";
            // 
            // Module1
            // 
            this.Module1.AutoSize = true;
            this.Module1.Location = new System.Drawing.Point(111, 193);
            this.Module1.Name = "Module1";
            this.Module1.Size = new System.Drawing.Size(48, 13);
            this.Module1.TabIndex = 2;
            this.Module1.Text = "Module1";
            // 
            // Module2
            // 
            this.Module2.AutoSize = true;
            this.Module2.Location = new System.Drawing.Point(111, 235);
            this.Module2.Name = "Module2";
            this.Module2.Size = new System.Drawing.Size(48, 13);
            this.Module2.TabIndex = 3;
            this.Module2.Text = "Module2";
            // 
            // Module3
            // 
            this.Module3.AutoSize = true;
            this.Module3.Location = new System.Drawing.Point(111, 274);
            this.Module3.Name = "Module3";
            this.Module3.Size = new System.Drawing.Size(48, 13);
            this.Module3.TabIndex = 4;
            this.Module3.Text = "Module3";
            // 
            // textBoxModule1
            // 
            this.textBoxModule1.Location = new System.Drawing.Point(239, 186);
            this.textBoxModule1.Name = "textBoxModule1";
            this.textBoxModule1.Size = new System.Drawing.Size(185, 20);
            this.textBoxModule1.TabIndex = 6;
            // 
            // textBoxModule2
            // 
            this.textBoxModule2.Location = new System.Drawing.Point(239, 228);
            this.textBoxModule2.Name = "textBoxModule2";
            this.textBoxModule2.Size = new System.Drawing.Size(185, 20);
            this.textBoxModule2.TabIndex = 7;
            // 
            // textBoxModule3
            // 
            this.textBoxModule3.Location = new System.Drawing.Point(239, 274);
            this.textBoxModule3.Name = "textBoxModule3";
            this.textBoxModule3.Size = new System.Drawing.Size(185, 20);
            this.textBoxModule3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Enter Marks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // StudentextBox1
            // 
            this.StudentextBox1.Location = new System.Drawing.Point(239, 146);
            this.StudentextBox1.Name = "StudentextBox1";
            this.StudentextBox1.Size = new System.Drawing.Size(185, 20);
            this.StudentextBox1.TabIndex = 5;
            // 
            // TermTestMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxModule3);
            this.Controls.Add(this.textBoxModule2);
            this.Controls.Add(this.textBoxModule1);
            this.Controls.Add(this.Module3);
            this.Controls.Add(this.Module2);
            this.Controls.Add(this.Module1);
            this.Controls.Add(this.label1);
            this.Name = "TermTestMarks";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Module1;
        private System.Windows.Forms.Label Module2;
        private System.Windows.Forms.Label Module3;
        private System.Windows.Forms.TextBox textBoxModule1;
        private System.Windows.Forms.TextBox textBoxModule2;
        private System.Windows.Forms.TextBox textBoxModule3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudentextBox1;
    }
}

