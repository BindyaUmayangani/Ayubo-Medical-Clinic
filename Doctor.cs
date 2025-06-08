using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Group
{
    public partial class Doctor : Form
    {
        private static string connectionString = "Host=ep-wispy-sun-a5j5imj0.us-east-2.aws.neon.tech;Username=ayubo_owner;Password=GFjXcvR94NPL;Database=ayubo;SslMode=Require";
        private DataTable doctorTable;
        public Doctor()
        {
            InitializeComponent();
        }
        private void Doctor_Load(object sender, EventArgs e)
        {
            LoadDoctors();
            cmbSortByDate.SelectedIndex = 0; // Default to "Ascending" sort
        }

        private void LoadDoctors(string searchText = "", string sortBy = "Ascending")
        {
            try
            {
                using (var connect = new NpgsqlConnection(connectionString))
                {
                    connect.Open();

                    string query = @"
                        SELECT id AS ""Doctor ID"", 
                               name AS ""Doctor Name"", 
                               email AS ""Email"", 
                               phone_number AS ""Phone Number"", 
                               specialization AS ""Specialization"",
                               hourly_rate AS ""Hourly Rate""
                        FROM doctors
                        WHERE CAST(id AS TEXT) ILIKE @SearchText 
                           OR name ILIKE @SearchText 
                           OR email ILIKE @SearchText 
                           OR phone_number ILIKE @SearchText
                           OR specialization ILIKE @SearchText
                           OR hourly_rate::TEXT ILIKE @SearchText";

                    if (sortBy == "Ascending")
                    {
                        query += " ORDER BY name ASC";
                    }
                    else if (sortBy == "Descending")
                    {
                        query += " ORDER BY name DESC";
                    }

                    using (var cmd = new NpgsqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("SearchText", $"%{searchText}%");
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            doctorTable = new DataTable();
                            adapter.Fill(doctorTable);
                            dataGridView_doctors.DataSource = doctorTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btndr_add_Click(object sender, EventArgs e)
        {
            Add_doctor add_Doctor = new Add_doctor();
            add_Doctor.Show();
            this.Hide();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btn_patients_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            this.Hide();
        }

        private void btn_appointments_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.Show();
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

        private void dataGridView_doctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
