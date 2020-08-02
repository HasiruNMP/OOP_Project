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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxModule1 = new System.Windows.Forms.TextBox();
            this.textBoxModule2 = new System.Windows.Forms.TextBox();
            this.textBoxModule3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Module1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Module2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Module3";
            // 
            // textBoxModule1
            // 
            this.textBoxModule1.Location = new System.Drawing.Point(203, 111);
            this.textBoxModule1.Name = "textBoxModule1";
            this.textBoxModule1.Size = new System.Drawing.Size(185, 20);
            this.textBoxModule1.TabIndex = 7;
            // 
            // textBoxModule2
            // 
            this.textBoxModule2.Location = new System.Drawing.Point(203, 153);
            this.textBoxModule2.Name = "textBoxModule2";
            this.textBoxModule2.Size = new System.Drawing.Size(185, 20);
            this.textBoxModule2.TabIndex = 8;
            // 
            // textBoxModule3
            // 
            this.textBoxModule3.Location = new System.Drawing.Point(203, 199);
            this.textBoxModule3.Name = "textBoxModule3";
            this.textBoxModule3.Size = new System.Drawing.Size(185, 20);
            this.textBoxModule3.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Enter Marks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TermTestMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxModule3);
            this.Controls.Add(this.textBoxModule2);
            this.Controls.Add(this.textBoxModule1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TermTestMarks";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxModule1;
        private System.Windows.Forms.TextBox textBoxModule2;
        private System.Windows.Forms.TextBox textBoxModule3;
        private System.Windows.Forms.Button button1;
    }
}

