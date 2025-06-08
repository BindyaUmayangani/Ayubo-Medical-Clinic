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
    public partial class Login : Form
    {
        NpgsqlConnection connect = new NpgsqlConnection("Host=ep-wispy-sun-a5j5imj0.us-east-2.aws.neon.tech;Username=ayubo_owner;Password=GFjXcvR94NPL;Database=ayubo;SslMode=Require;");
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Please fill all the fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        String selectData = "SELECT * FROM Admin WHERE username = @username AND password= @password";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", txtusername.Text);
                            cmd.Parameters.AddWithValue("@password", txtpassword.Text);

                            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count == 1)
                            {
                                MessageBox.Show("Logged in successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Show the Dashboard form after successful login
                                Dashboard dashboardForm = new Dashboard();
                                dashboardForm.Show();
                                this.Hide(); // Hide the login form
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void lblsignup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showpass.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }
    }
}
