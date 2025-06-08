namespace Group
{
    partial class Appointment
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtappointment_search = new System.Windows.Forms.TextBox();
            this.btnapp_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_appointment = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_doctors = new System.Windows.Forms.Button();
            this.btn_patients = new System.Windows.Forms.Button();
            this.btn_appointments = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSortByDate = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_appointment)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtappointment_search
            // 
            this.txtappointment_search.Location = new System.Drawing.Point(330, 145);
            this.txtappointment_search.Multiline = true;
            this.txtappointment_search.Name = "txtappointment_search";
            this.txtappointment_search.Size = new System.Drawing.Size(192, 30);
            this.txtappointment_search.TabIndex = 0;
            this.txtappointment_search.TextChanged += new System.EventHandler(this.txtappointment_search_TextChanged);
            // 
            // btnapp_add
            // 
            this.btnapp_add.BackColor = System.Drawing.Color.Navy;
            this.btnapp_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnapp_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnapp_add.ForeColor = System.Drawing.Color.White;
            this.btnapp_add.Location = new System.Drawing.Point(617, 145);
            this.btnapp_add.Name = "btnapp_add";
            this.btnapp_add.Size = new System.Drawing.Size(182, 30);
            this.btnapp_add.TabIndex = 1;
            this.btnapp_add.Text = "Add Appointment";
            this.btnapp_add.UseVisualStyleBackColor = false;
            this.btnapp_add.Click += new System.EventHandler(this.btnapp_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(269, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView_appointment
            // 
            this.dataGridView_appointment.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_appointment.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_appointment.Location = new System.Drawing.Point(273, 218);
            this.dataGridView_appointment.Name = "dataGridView_appointment";
            this.dataGridView_appointment.RowHeadersWidth = 51;
            this.dataGridView_appointment.RowTemplate.Height = 24;
            this.dataGridView_appointment.Size = new System.Drawing.Size(656, 419);
            this.dataGridView_appointment.TabIndex = 2;
            this.dataGridView_appointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_appointment_CellContentClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.btn_dashboard);
            this.flowLayoutPanel1.Controls.Add(this.btn_doctors);
            this.flowLayoutPanel1.Controls.Add(this.btn_patients);
            this.flowLayoutPanel1.Controls.Add(this.btn_appointments);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel1.Controls.Add(this.btnlogout);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(205, 701);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Group.Properties.Resources.resize_1721445987240395196logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 167);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 17);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.Navy;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Location = new System.Drawing.Point(3, 199);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(198, 57);
            this.btn_dashboard.TabIndex = 2;
            this.btn_dashboard.Text = "Dahboard";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_doctors
            // 
            this.btn_doctors.BackColor = System.Drawing.Color.Navy;
            this.btn_doctors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_doctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctors.ForeColor = System.Drawing.Color.White;
            this.btn_doctors.Location = new System.Drawing.Point(3, 262);
            this.btn_doctors.Name = "btn_doctors";
            this.btn_doctors.Size = new System.Drawing.Size(198, 57);
            this.btn_doctors.TabIndex = 3;
            this.btn_doctors.Text = "Doctors";
            this.btn_doctors.UseVisualStyleBackColor = false;
            this.btn_doctors.Click += new System.EventHandler(this.btn_doctors_Click);
            // 
            // btn_patients
            // 
            this.btn_patients.BackColor = System.Drawing.Color.Navy;
            this.btn_patients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_patients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patients.ForeColor = System.Drawing.Color.White;
            this.btn_patients.Location = new System.Drawing.Point(3, 325);
            this.btn_patients.Name = "btn_patients";
            this.btn_patients.Size = new System.Drawing.Size(198, 57);
            this.btn_patients.TabIndex = 4;
            this.btn_patients.Text = "Patients";
            this.btn_patients.UseVisualStyleBackColor = false;
            this.btn_patients.Click += new System.EventHandler(this.btn_patients_Click);
            // 
            // btn_appointments
            // 
            this.btn_appointments.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_appointments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_appointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_appointments.ForeColor = System.Drawing.Color.Navy;
            this.btn_appointments.Location = new System.Drawing.Point(3, 388);
            this.btn_appointments.Name = "btn_appointments";
            this.btn_appointments.Size = new System.Drawing.Size(198, 57);
            this.btn_appointments.TabIndex = 5;
            this.btn_appointments.Text = "Appointments";
            this.btn_appointments.UseVisualStyleBackColor = false;
            this.btn_appointments.Click += new System.EventHandler(this.btn_appointments_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(3, 451);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(198, 177);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(3, 634);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(198, 57);
            this.btnlogout.TabIndex = 7;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(268, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Appointments";
            // 
            // cmbSortByDate
            // 
            this.cmbSortByDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbSortByDate.FormattingEnabled = true;
            this.cmbSortByDate.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cmbSortByDate.Location = new System.Drawing.Point(805, 145);
            this.cmbSortByDate.Name = "cmbSortByDate";
            this.cmbSortByDate.Size = new System.Drawing.Size(124, 28);
            this.cmbSortByDate.TabIndex = 25;
            this.cmbSortByDate.SelectedIndexChanged += new System.EventHandler(this.cmbSortByDate_SelectedIndexChanged_1);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group.Properties.Resources.bakground_1;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.cmbSortByDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_appointment);
            this.Controls.Add(this.btnapp_add);
            this.Controls.Add(this.txtappointment_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_appointment)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtappointment_search;
        private System.Windows.Forms.Button btnapp_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_appointment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_doctors;
        private System.Windows.Forms.Button btn_patients;
        private System.Windows.Forms.Button btn_appointments;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSortByDate;
    }
}
