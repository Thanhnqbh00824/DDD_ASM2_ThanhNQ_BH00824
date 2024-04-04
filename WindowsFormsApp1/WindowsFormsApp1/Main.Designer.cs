namespace WindowsFormsApp1
{
    partial class Main
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
            this.btnAR = new System.Windows.Forms.Button();
            this.btnCS = new System.Windows.Forms.Button();
            this.btninstructor = new System.Windows.Forms.Button();
            this.btnstudent = new System.Windows.Forms.Button();
            this.btncourses = new System.Windows.Forms.Button();
            this.btndepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAR
            // 
            this.btnAR.BackColor = System.Drawing.Color.Lime;
            this.btnAR.Location = new System.Drawing.Point(12, 12);
            this.btnAR.Name = "btnAR";
            this.btnAR.Size = new System.Drawing.Size(178, 49);
            this.btnAR.TabIndex = 0;
            this.btnAR.Text = "Attendance Record";
            this.btnAR.UseVisualStyleBackColor = false;
            this.btnAR.Click += new System.EventHandler(this.btnAR_Click);
            // 
            // btnCS
            // 
            this.btnCS.BackColor = System.Drawing.Color.Lime;
            this.btnCS.Location = new System.Drawing.Point(196, 12);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(178, 49);
            this.btnCS.TabIndex = 0;
            this.btnCS.Text = "Class Sessions";
            this.btnCS.UseVisualStyleBackColor = false;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // btninstructor
            // 
            this.btninstructor.BackColor = System.Drawing.Color.Lime;
            this.btninstructor.Location = new System.Drawing.Point(12, 122);
            this.btninstructor.Name = "btninstructor";
            this.btninstructor.Size = new System.Drawing.Size(178, 49);
            this.btninstructor.TabIndex = 0;
            this.btninstructor.Text = "Instructor";
            this.btninstructor.UseVisualStyleBackColor = false;
            this.btninstructor.Click += new System.EventHandler(this.btninstructor_Click);
            // 
            // btnstudent
            // 
            this.btnstudent.BackColor = System.Drawing.Color.Lime;
            this.btnstudent.Location = new System.Drawing.Point(196, 122);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(178, 49);
            this.btnstudent.TabIndex = 0;
            this.btnstudent.Text = "Student";
            this.btnstudent.UseVisualStyleBackColor = false;
            this.btnstudent.Click += new System.EventHandler(this.btnstudent_Click);
            // 
            // btncourses
            // 
            this.btncourses.BackColor = System.Drawing.Color.Lime;
            this.btncourses.Location = new System.Drawing.Point(12, 67);
            this.btncourses.Name = "btncourses";
            this.btncourses.Size = new System.Drawing.Size(178, 49);
            this.btncourses.TabIndex = 0;
            this.btncourses.Text = "Courses";
            this.btncourses.UseVisualStyleBackColor = false;
            this.btncourses.Click += new System.EventHandler(this.btncourses_Click);
            // 
            // btndepartment
            // 
            this.btndepartment.BackColor = System.Drawing.Color.Lime;
            this.btndepartment.Location = new System.Drawing.Point(196, 67);
            this.btndepartment.Name = "btndepartment";
            this.btndepartment.Size = new System.Drawing.Size(178, 49);
            this.btndepartment.TabIndex = 0;
            this.btndepartment.Text = "Department";
            this.btndepartment.UseVisualStyleBackColor = false;
            this.btndepartment.Click += new System.EventHandler(this.btndepartment_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(384, 183);
            this.Controls.Add(this.btndepartment);
            this.Controls.Add(this.btnstudent);
            this.Controls.Add(this.btncourses);
            this.Controls.Add(this.btninstructor);
            this.Controls.Add(this.btnCS);
            this.Controls.Add(this.btnAR);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAR;
        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.Button btninstructor;
        private System.Windows.Forms.Button btnstudent;
        private System.Windows.Forms.Button btncourses;
        private System.Windows.Forms.Button btndepartment;
    }
}