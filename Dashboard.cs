using System;
using System.Windows.Forms;

namespace Group
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {  
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Patient patientForm = new Patient();
            patientForm.Show();
            this.Show(patientForm);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Appointment appointmentForm = new Appointment();
            appointmentForm.Show();
        }

        private void lblappointment_Click(object sender, EventArgs e)
        {
            Appointment appointmentForm = new Appointment();
            appointmentForm.Show();
        }

        private void lblpatient_Click(object sender, EventArgs e)
        {
            Patient patientForm = new Patient();
            patientForm.Show();
        }

        private void lbldoctor_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
           Doctor doctorForm = new Doctor();
           doctorForm.Show();
           this.Hide();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            this.Hide();
        }

        private void btnAppoinment_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
