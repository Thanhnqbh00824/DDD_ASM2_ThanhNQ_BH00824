using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            GetData();
        }
        private void GetData()
        {
            string connectionString = @"Data Source = ADMIN; Initial Catalog = Attendance_System; Integrated Security = True; Encrypt = False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Department";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    // Create a new instance of the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            Main Main = new Main();
            Main.Show();
        }
    }
}
