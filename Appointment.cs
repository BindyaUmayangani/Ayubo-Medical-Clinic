using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql; // Added for database connection

namespace Group
{
    public partial class Appointment : Form
    {
        private static string connectionString = "Host=ep-wispy-sun-a5j5imj0.us-east-2.aws.neon.tech;Username=ayubo_owner;Password=GFjXcvR94NPL;Database=ayubo;SslMode=Require"; 
        private DataTable appointmentTable;

        public Appointment()
        {
            InitializeComponent();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            LoadAppointments();
            cmbSortByDate.SelectedIndex = 0; // Default to "Ascending" sort
        }

        private void LoadAppointments(string searchText = "", string sortBy = "Ascending")
        {
            try
            {
                using (var connect = new NpgsqlConnection(connectionString))
                {
                    connect.Open();

                    string query = @"
                        SELECT appointment_id AS ""Appointment ID"", 
                               doctor_name AS ""Doctor Name"", 
                               patient_name AS ""Patient Name"", 
                               reason AS ""Reason"", 
                               appointment_date AS ""Appointment Date""
                        FROM appointments
                        WHERE CAST(appointment_id AS TEXT) ILIKE @SearchText 
                           OR doctor_name ILIKE @SearchText 
                           OR patient_name ILIKE @SearchText 
                           OR reason ILIKE @SearchText";

                    if (sortBy == "Ascending")
                    {
                        query += " ORDER BY appointment_date ASC";
                    }
                    else if (sortBy == "Descending")
                    {
                        query += " ORDER BY appointment_date DESC";
                    }

                    using (var cmd = new NpgsqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("SearchText", $"%{searchText}%");
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            appointmentTable = new DataTable();
                            adapter.Fill(appointmentTable);
                            dataGridView_appointment.DataSource = appointmentTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtappointment_search_TextChanged(object sender, EventArgs e)
        {
            LoadAppointments(txtappointment_search.Text, cmbSortByDate.SelectedItem.ToString());
        }

        private void btnapp_add_Click(object sender, EventArgs e)
        {
            Add_Appointment addAppointmentPage = new Add_Appointment();
            addAppointmentPage.Show();
            this.Hide(); // Hide the current form
        }

        private void dataGridView_appointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Logic for handling cell clicks, if needed
        }

        private void cmbSortByDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAppointments(txtappointment_search.Text, cmbSortByDate.SelectedItem.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: Logic for handling label clicks
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

        private void btn_patients_Click(object sender, EventArgs e)
        {
            Patient patients = new Patient();
            patients.Show();
            this.Hide();
        }

        private void btn_doctors_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Show();
            this.Hide();
        }

        private void cmbSortByDate_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadAppointments(txtappointment_search.Text, cmbSortByDate.SelectedItem.ToString());
        }
    }
}
