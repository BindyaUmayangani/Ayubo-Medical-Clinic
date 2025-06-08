using System;
using System.Windows.Forms;
using Npgsql;

namespace Group
{
    public partial class Add_doctor : Form
    {
        private static string connectionString = "Host=ep-wispy-sun-a5j5imj0.us-east-2.aws.neon.tech;Username=ayubo_owner;Password=GFjXcvR94NPL;Database=ayubo;SslMode=Require";
        private NpgsqlConnection sqlConnection;

        public Add_doctor()
        {
            InitializeComponent();
            sqlConnection = new NpgsqlConnection(connectionString);
        }

        private void lblpt_Click(object sender, EventArgs e)
        {

        }

        private void txtpt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbldr_email_Click(object sender, EventArgs e)
        {

        }

        private void btnpt_add_Click(object sender, EventArgs e)
        {
            AddDoctor();
        }

        

        private void btndr_del_Click(object sender, EventArgs e)
        {
            DeleteDoctor();
        }

        private void AddDoctor()
        {
            string id = txtdr_id.Text;
            string name = txtdr_name.Text;
            string email = txtdr_email.Text;
            string phoneNumber = txtdr_contact.Text;
            string specialization = txtdr_spec.Text;
            string hourlyRate = txtdr_rate.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(specialization) || string.IsNullOrEmpty(hourlyRate))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            try
            {
                sqlConnection.Open();
                string query = "INSERT INTO doctors (id, name, email, phone_number, specialization, hourly_rate) " +
                               "VALUES (@id, @name, @mail, @phone, @specialization, @rate)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@mail", email);
                    cmd.Parameters.AddWithValue("@phone", phoneNumber);
                    cmd.Parameters.AddWithValue("@specialization", specialization);
                    cmd.Parameters.AddWithValue("@rate", hourlyRate);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        

        private void lblpt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteDoctor()
        {
            string id = txtdr_id.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please provide the ID of the doctor to delete.");
                return;
            }

            try
            {
                sqlConnection.Open();
                string query = "DELETE FROM doctors WHERE id = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Doctor deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No doctor found with the provided ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btndr_view_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Show();
            this.Hide();
        }

        private void btndr_update_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = txtdr_id.Text; 
                string name = txtdr_name.Text;
                string specialization = txtdr_spec.Text;
                string hourlyRate = txtdr_rate.Text;
                string phoneNumber = txtdr_contact.Text;
                string email = txtdr_email.Text;

                string connectionString = "Host=ep-wispy-sun-a5j5imj0.us-east-2.aws.neon.tech;Username=ayubo_owner;Password=GFjXcvR94NPL;Database=ayubo;SslMode=Require;";

                using (NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string query = "UPDATE doctors SET name = @name, specialization = @specialization, hourly_rate = @rate, phone_number = @phone, email = @mail WHERE id = @id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@specialization", specialization);
                        cmd.Parameters.AddWithValue("@rate", hourlyRate);
                        cmd.Parameters.AddWithValue("@phone", phoneNumber);
                        cmd.Parameters.AddWithValue("@mail", email);
                        cmd.Parameters.AddWithValue("@id", Id); 

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Doctor information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No doctor found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
