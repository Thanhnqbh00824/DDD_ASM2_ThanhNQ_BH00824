using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnAR_Click(object sender, EventArgs e)
        {
            Attendance_Record main = new Attendance_Record();
            main.Show();
            this.Hide();
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            Class_session main = new Class_session();
            main.Show();
            this.Hide();
        }

        private void btncourses_Click(object sender, EventArgs e)
        {
            Courses main = new Courses();
            main.Show();
            this.Hide();
        }

        private void btndepartment_Click(object sender, EventArgs e)
        {
            Department main = new Department();
            main.Show();
            this.Hide();
        }

        private void btninstructor_Click(object sender, EventArgs e)
        {
            Instructor main = new Instructor();
            main.Show();
            this.Hide();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            Student main = new Student();
            main.Show();
            this.Hide();
        }
    }
}
