using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpass.Text;

            if (txtusername.Text == "thanhnq" && txtpass.Text == "12345678")
            {
                Main main = new Main();
                main.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Please try again.");
            }
        }
    }
}
