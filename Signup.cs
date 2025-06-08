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
    public partial class Signup : Form
    {
        NpgsqlConnection connect = new NpgsqlConnection("Host=ep-wispy-sun-a5j5imj0.us-east-2.aws.neon.tech;Username=ayubo_owner;Password=GFjXcvR94NPL;Database=ayubo;SslMode=Require;"); 
        private object date;

        public Signup()
        {
            InitializeComponent();
        }

        private void lblwelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblhaveacc_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtsignup_email.Text == "" || txtsignup_username.Text == "" || txtsignup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM Admin WHERE username = @Username";

                        using (NpgsqlCommand checkUser = new NpgsqlCommand(checkUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@Username", txtsignup_username.Text.Trim());

                            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(txtsignup_username.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Admin (email, username, password, date_created) VALUES (@Email, @Username, @Password, @Date)";

                                DateTime date = DateTime.Today;

                                using (NpgsqlCommand cmd = new NpgsqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@Email", txtsignup_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Username", txtsignup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Password", txtsignup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Date", date);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    //switch the form
                                    Login login = new Login();
                                    login.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lblsignup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_showpass.Checked)
            {
                txtsignup_password.PasswordChar = '\0';
            }
            else
            {
                txtsignup_password.PasswordChar = '*';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
