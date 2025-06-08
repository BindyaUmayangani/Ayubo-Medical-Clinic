using Npgsql;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Group
{
    public partial class Add_Appointment : Form
    {
        private readonly string connectionString = "Host=ep-wispy-sun-a5j5imj0.us-east-2.aws.neon.tech;Username=ayubo_owner;Password=GFjXcvR94NPL;Database=ayubo;SslMode=Require;";

        public Add_Appointment()
        {
            InitializeComponent();
            PopulateDoctorNames();
        }

        private void Add_Appointment_Load(object sender, EventArgs e)
        {
            GenerateAppointmentId();
        }

        private void GenerateAppointmentId()
        {
            try
            {
                using (var connect = new NpgsqlConnection(connectionString))
                {
                    connect.Open();

                    string query = "SELECT appointment_id FROM appointments ORDER BY appointment_id DESC LIMIT 1";
                    using (var cmd = new NpgsqlCommand(query, connect))
                    {
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int newId = int.Parse(result.ToString()) + 1;
                            txtadd_id.Text = newId.ToString("D4");
                        }
                        else
                        {
                            txtadd_id.Text = "0001";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while generating the appointment ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateDoctorNames()
        {
            string[] doctors = { "Dr. John Smith", "Dr. Alice Johnson", "Dr. Robert Brown", "Dr. Michael Williams", "Dr. Mary Jones",
                                 "Dr. Patricia Davis", "Dr. Linda Martinez", "Dr. Susan Clark", "Dr. James Miller", "Dr. Barbara Wilson" };
            cmbadd_dr.Items.AddRange(doctors);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtadd_id.Text) ||
                cmbadd_dr.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(txtadd_patient.Text) ||
                string.IsNullOrWhiteSpace(txtadd_reason.Text))
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var connect = new NpgsqlConnection(connectionString))
                {
                    connect.Open();

                    string query = "INSERT INTO appointments (appointment_id, doctor_name, patient_name, reason, appointment_date) VALUES (@id, @dr, @patient, @reason, @date)";
                    using (var cmd = new NpgsqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("id", int.Parse(txtadd_id.Text));
                        cmd.Parameters.AddWithValue("dr", cmbadd_dr.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("patient", txtadd_patient.Text);
                        cmd.Parameters.AddWithValue("reason", txtadd_reason.Text);
                        cmd.Parameters.AddWithValue("date", dateTimePicker1.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                SendEmail(txtadd_id.Text, cmbadd_dr.SelectedItem.ToString(), txtadd_patient.Text, txtadd_reason.Text, dateTimePicker1.Value);

                MessageBox.Show("Appointment added and email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenerateAppointmentId(); // Generate a new ID for the next appointment
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendEmail(string id, string doctor, string patient, string reason, DateTime appointmentDate)
        {
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUser = "ypremium.in1@gmail.com"; // Replace with your SMTP username
            string smtpPass = "vgjjpcoakjfprtip"; // Replace with your SMTP password (use an App Password for Gmail)

            string toEmail = "manidumaneeshaww@gmail.com"; // Replace with the recipient's email address
            string subject = "New Appointment Request";
            string body = $"Appointment Details:\n\n" +
                          $"Appointment ID: {id}\n" +
                          $"Doctor Name: {doctor}\n" +
                          $"Patient Name: {patient}\n" +
                          $"Reason: {reason}\n" +
                          $"Appointment Date: {appointmentDate}";

            using (SmtpClient client = new SmtpClient(smtpServer, smtpPort))
            {
                client.Credentials = new NetworkCredential(smtpUser, smtpPass);
                client.EnableSsl = true;

                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(smtpUser),
                    Subject = subject,
                    Body = body
                };

                mailMessage.To.Add(toEmail);

                try
                {
                    client.Send(mailMessage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to send email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Additional event handlers

        private void txtadd_dr_TextChanged(object sender, EventArgs e) { }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }

        private void label1_Click_2(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void btnView_Click(object sender, EventArgs e)
        {
            Appointment appointmentPage = new Appointment();
            appointmentPage.Show(); // Show the Appointment page
            this.Hide(); // Hide the current Add Appointment page
        }

        private void txtadd_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbladd_id_Click(object sender, EventArgs e)
        {

        }

        private void txtadd_reason_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbladd_reason_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txtadd_patient_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbladd_patient_Click(object sender, EventArgs e)
        {

        }

        private void lbladd_date_Click(object sender, EventArgs e)
        {

        }

        private void cmbadd_dr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbladd_dr_Click(object sender, EventArgs e)
        {

        }

        private void lbladd_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtadd_id.Text) ||
                cmbadd_dr.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(txtadd_patient.Text) ||
                string.IsNullOrWhiteSpace(txtadd_reason.Text))
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var connect = new NpgsqlConnection(connectionString))
                {
                    connect.Open();

                    string query = "INSERT INTO appointments (appointment_id, doctor_name, patient_name, reason, appointment_date) VALUES (@id, @dr, @patient, @reason, @date)";
                    using (var cmd = new NpgsqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("id", int.Parse(txtadd_id.Text));
                        cmd.Parameters.AddWithValue("dr", cmbadd_dr.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("patient", txtadd_patient.Text);
                        cmd.Parameters.AddWithValue("reason", txtadd_reason.Text);
                        cmd.Parameters.AddWithValue("date", dateTimePicker1.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                SendEmail(txtadd_id.Text, cmbadd_dr.SelectedItem.ToString(), txtadd_patient.Text, txtadd_reason.Text, dateTimePicker1.Value);

                MessageBox.Show("Appointment added and email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenerateAppointmentId(); // Generate a new ID for the next appointment
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.Show();
            this.Hide();
        }
    }
}