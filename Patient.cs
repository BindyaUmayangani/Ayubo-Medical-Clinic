using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Group
{
    public partial class Patient : Form
    {
        private static string connectionString = "Host=ep-wispy-sun-a5j5imj0.us-east-2.aws.neon.tech;Username=ayubo_owner;Password=GFjXcvR94NPL;Database=ayubo;SslMode=Require";
        private DataTable patientTable;

        public Patient()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void LoadPatients(string searchText = "", string sortBy = "Ascending")
        {
            try
            {
                using (var connect = new NpgsqlConnection(connectionString))
                {
                    connect.Open();

                    string query = @"
                        SELECT patientid AS ""Patient ID"", 
                               name AS ""Name"", 
                               age AS ""Age"", 
                               bloodgroup AS ""Blood Group"", 
                               email AS ""Email"",
                               contactno AS ""Contact No"",
                               reason AS ""Reason"",
                               address AS ""Address"",
                               gender AS ""Gender""
                        FROM patients
                        WHERE CAST(patientid AS TEXT) ILIKE @SearchText 
                           OR name ILIKE @SearchText 
                           OR age ILIKE @SearchText 
                           OR bloodgroup ILIKE @SearchText
                           OR email ILIKE @SearchText
                           OR contactno ILIKE @SearchText
                           OR reason ILIKE @SearchText
                           OR address ILIKE @SearchText
                           OR gender ILIKE @SearchText";

                    if (sortBy == "Ascending")
                    {
                        query += " ORDER BY patientid ASC";
                    }
                    else if (sortBy == "Descending")
                    {
                        query += " ORDER BY patientid DESC";
                    }

                    using (var cmd = new NpgsqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("SearchText", $"%{searchText}%");
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            patientTable = new DataTable();
                            adapter.Fill(patientTable);
                            dataGridView_patient.DataSource = patientTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtpt_search_TextChanged(object sender, EventArgs e)
        {
            LoadPatients(txtpt_search.Text);
        }

        private void btnpt_add_Click(object sender, EventArgs e)
        {
            Add_Patient add_Patient = new Add_Patient();
            add_Patient.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btn_appointments_Click(object sender, EventArgs e)
        {
            Appointment appointments = new Appointment();
            appointments.Show();
            this.Hide();
        }

        private void btn_doctors_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Show();
            this.Hide();
        }
    }
}
