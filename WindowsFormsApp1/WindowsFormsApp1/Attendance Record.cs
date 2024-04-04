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
    public partial class Attendance_Record : Form
    {
        DataTable dt = new DataTable();
        public Attendance_Record()
        {
            InitializeComponent();
        }

        private void Attendance_Record_Load(object sender, EventArgs e)
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

                string selectQuery = "SELECT * FROM Attendance_record";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void btnpresent_Click(object sender, EventArgs e)
        {
            DataTable filteredTable = ((DataTable)dataGridView1.DataSource).Clone();
            foreach (DataRow row in ((DataTable)dataGridView1.DataSource).Rows)
            {
                if (row["attendance_status"].ToString() == "present")
                {
                    filteredTable.ImportRow(row);
                }
            }

            dataGridView1.DataSource = filteredTable;
        }

        private void btnabsent_Click(object sender, EventArgs e)
        {
            {
                DataTable filteredTable = ((DataTable)dataGridView1.DataSource).Clone();
                foreach (DataRow row in ((DataTable)dataGridView1.DataSource).Rows)
                {
                    if (row["attendance_status"].ToString() == "absent")
                    {
                        filteredTable.ImportRow(row);
                    }
                }

                dataGridView1.DataSource = filteredTable;
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = ADMIN; Initial Catalog = Attendance_System; Integrated Security = True; Encrypt = False";
            int recordId = Convert.ToInt32(txtrecordID.Text);
            int studentId = Convert.ToInt32(txtstudentID.Text);
            string studentName = txtstudentname.Text;
            int sessionId = Convert.ToInt32(txtsessionID.Text);
            string attendanceStatus = txtstatus.Text;

            string query = "AddStudent";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@record_id", SqlDbType.Int).Value = recordId;
                    command.Parameters.Add("@student_id", SqlDbType.Int).Value = studentId;
                    command.Parameters.Add("@student_name", SqlDbType.NVarChar, 100).Value = studentName;
                    command.Parameters.Add("@session_id", SqlDbType.Int).Value = sessionId;
                    command.Parameters.Add("@attendance_status", SqlDbType.NVarChar, 50).Value = attendanceStatus;

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("The student has been added successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while adding students: " + ex.Message);
                    }
                }
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            Main Main = new Main();
            Main.Show();
        }
    }
}
