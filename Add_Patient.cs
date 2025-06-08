using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Npgsql;

namespace Group
{
    public partial class Add_Patient : Form
    {
        private static string connectionString = "Host=ep-wispy-sun-a5j5imj0.us-east-2.aws.neon.tech;Username=ayubo_owner;Password=GFjXcvR94NPL;Database=ayubo;SslMode=Require";
        public Add_Patient()
        {
            InitializeComponent();
        }

        private void lblpt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Age label clicked!");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Blood Group label clicked!");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Address label clicked!");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gender label clicked!");
        }

        private void comboBoxpt_blood_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Blood Group: " + comboBoxpt_blood.SelectedItem.ToString());
        }

        private void btnpt_add_Click(object sender, EventArgs e)
        {
            try
            {
                string patientName = txtpt_name.Text;
                int age = int.Parse(txtpt_age.Text);
                string bloodGroup = comboBoxpt_blood.SelectedItem.ToString();
                string gender = radioButtonmale.Checked ? "Male" : "Female";
                string contactNo = txtpt_contact.Text;
                string email = txtpt_email.Text;
                string address = txtpt_address.Text;
                string reason = txtpt_reason.Text;

                AddPatientToDatabase(patientName, age, bloodGroup, gender, contactNo, email, address, reason);
                MessageBox.Show("Patient added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnpt_update_Click(object sender, EventArgs e)
        {
            try
            {
                int patientId = int.Parse(txtpt_id.Text);
                string patientName = txtpt_name.Text;
                int age = int.Parse(txtpt_age.Text);
                string bloodGroup = comboBoxpt_blood.SelectedItem.ToString();
                string gender = radioButtonmale.Checked ? "Male" : "Female";
                string contactNo = txtpt_contact.Text;
                string email = txtpt_email.Text;
                string address = txtpt_address.Text;
                string reason = txtpt_reason.Text;

                UpdatePatientInDatabase(patientId, patientName, age, bloodGroup, gender, contactNo, email, address, reason);
                MessageBox.Show("Patient updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

  
        

        private void AddPatientToDatabase(string name, int age, string bloodGroup, string gender, string contactNo, string email, string address, string reason)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO Patients (Name, Age, BloodGroup, Gender, ContactNo, Email, Address, Reason) VALUES (@name, @age, @bloodGroup, @gender, @contactNo, @Email, @address, @reason)", conn))
                {
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("age", age);
                    cmd.Parameters.AddWithValue("bloodGroup", bloodGroup);
                    cmd.Parameters.AddWithValue("gender", gender);
                    cmd.Parameters.AddWithValue("contactNo", contactNo);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("address", address);
                    cmd.Parameters.AddWithValue("reason", reason);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void UpdatePatientInDatabase(int id, string name, int age, string bloodGroup, string gender, string contactNo, string email, string address, string reason)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("UPDATE Patients SET Name = @name, Age = @age, BloodGroup = @bloodGroup, Gender = @gender, ContactNo = @contactNo, Email = @email, Address = @address, Reason = @reason WHERE PatientID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("age", age);
                    cmd.Parameters.AddWithValue("bloodGroup", bloodGroup);
                    cmd.Parameters.AddWithValue("gender", gender);
                    cmd.Parameters.AddWithValue("contactNo", contactNo);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("address", address);
                    cmd.Parameters.AddWithValue("reason", reason);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        

        private class Patient
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string BloodGroup { get; set; }
            public string Gender { get; set; }
            public string ContactNo { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public string Reason { get; set; }
        }

    }
}

