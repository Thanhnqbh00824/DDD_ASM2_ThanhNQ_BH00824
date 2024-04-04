namespace WindowsFormsApp1
{
    partial class Attendance_Record
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtrecordID = new System.Windows.Forms.TextBox();
            this.txtstudentID = new System.Windows.Forms.TextBox();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.txtsessionID = new System.Windows.Forms.TextBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1042, 416);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(862, 52);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(145, 42);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtrecordID
            // 
            this.txtrecordID.Location = new System.Drawing.Point(175, 52);
            this.txtrecordID.Multiline = true;
            this.txtrecordID.Name = "txtrecordID";
            this.txtrecordID.Size = new System.Drawing.Size(96, 42);
            this.txtrecordID.TabIndex = 8;
            // 
            // txtstudentID
            // 
            this.txtstudentID.Location = new System.Drawing.Point(291, 52);
            this.txtstudentID.Multiline = true;
            this.txtstudentID.Name = "txtstudentID";
            this.txtstudentID.Size = new System.Drawing.Size(96, 42);
            this.txtstudentID.TabIndex = 8;
            // 
            // txtstudentname
            // 
            this.txtstudentname.Location = new System.Drawing.Point(402, 52);
            this.txtstudentname.Multiline = true;
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(203, 42);
            this.txtstudentname.TabIndex = 8;
            // 
            // txtsessionID
            // 
            this.txtsessionID.Location = new System.Drawing.Point(621, 52);
            this.txtsessionID.Multiline = true;
            this.txtsessionID.Name = "txtsessionID";
            this.txtsessionID.Size = new System.Drawing.Size(96, 42);
            this.txtsessionID.TabIndex = 8;
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(736, 52);
            this.txtstatus.Multiline = true;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(96, 42);
            this.txtstatus.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Record ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Student name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Session ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(733, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Attendance status";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Lime;
            this.btnexit.Location = new System.Drawing.Point(467, 543);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(123, 40);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Attendance_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1042, 595);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtstudentname);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtsessionID);
            this.Controls.Add(this.txtstudentID);
            this.Controls.Add(this.txtrecordID);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Attendance_Record";
            this.Text = "Attendance_Record";
            this.Load += new System.EventHandler(this.Attendance_Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtrecordID;
        private System.Windows.Forms.TextBox txtstudentID;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.TextBox txtsessionID;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnexit;
    }
}