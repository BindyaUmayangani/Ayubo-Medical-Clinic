namespace Group
{
    partial class Patient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblpt_search = new System.Windows.Forms.Label();
            this.dataGridView_patient = new System.Windows.Forms.DataGridView();
            this.btnpt_add = new System.Windows.Forms.Button();
            this.txtpt_search = new System.Windows.Forms.TextBox();
            this.lblpt = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_doctors = new System.Windows.Forms.Button();
            this.btn_patients = new System.Windows.Forms.Button();
            this.btn_appointments = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patient)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpt_search
            // 
            this.lblpt_search.AutoSize = true;
            this.lblpt_search.BackColor = System.Drawing.Color.Transparent;
            this.lblpt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblpt_search.Location = new System.Drawing.Point(261, 146);
            this.lblpt_search.Name = "lblpt_search";
            this.lblpt_search.Size = new System.Drawing.Size(55, 18);
            this.lblpt_search.TabIndex = 18;
            this.lblpt_search.Text = "Search";
            //this.lblpt_search.Click += new System.EventHandler(this.lblpt_search_Click);
            // 
            // dataGridView_patient
            // 
            this.dataGridView_patient.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_patient.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_patient.Location = new System.Drawing.Point(264, 215);
            this.dataGridView_patient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_patient.Name = "dataGridView_patient";
            this.dataGridView_patient.RowHeadersWidth = 51;
            this.dataGridView_patient.RowTemplate.Height = 24;
            this.dataGridView_patient.Size = new System.Drawing.Size(667, 432);
            this.dataGridView_patient.TabIndex = 17;
            //this.dataGridView_patient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_patient_CellContentClick);
            // 
            // btnpt_add
            // 
            this.btnpt_add.BackColor = System.Drawing.Color.Navy;
            this.btnpt_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnpt_add.ForeColor = System.Drawing.Color.White;
            this.btnpt_add.Location = new System.Drawing.Point(749, 135);
            this.btnpt_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpt_add.Name = "btnpt_add";
            this.btnpt_add.Size = new System.Drawing.Size(181, 33);
            this.btnpt_add.TabIndex = 16;
            this.btnpt_add.Text = "Add Patients";
            this.btnpt_add.UseVisualStyleBackColor = false;
            this.btnpt_add.Click += new System.EventHandler(this.btnpt_add_Click);
            // 
            // txtpt_search
            // 
            this.txtpt_search.Location = new System.Drawing.Point(323, 139);
            this.txtpt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpt_search.Multiline = true;
            this.txtpt_search.Name = "txtpt_search";
            this.txtpt_search.Size = new System.Drawing.Size(273, 30);
            this.txtpt_search.TabIndex = 15;
            this.txtpt_search.TextChanged += new System.EventHandler(this.txtpt_search_TextChanged);
            // 
            // lblpt
            // 
            this.lblpt.AutoSize = true;
            this.lblpt.BackColor = System.Drawing.Color.Transparent;
            this.lblpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpt.ForeColor = System.Drawing.Color.Navy;
            this.lblpt.Location = new System.Drawing.Point(259, 58);
            this.lblpt.Name = "lblpt";
            this.lblpt.Size = new System.Drawing.Size(107, 29);
            this.lblpt.TabIndex = 20;
            this.lblpt.Text = "Patients";
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, -1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(201, 702);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Group.Properties.Resources.resize_1721445987240395196logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 167);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 173);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 17);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.Navy;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Location = new System.Drawing.Point(3, 194);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(197, 57);
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
            this.btn_doctors.Location = new System.Drawing.Point(3, 255);
            this.btn_doctors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_doctors.Name = "btn_doctors";
            this.btn_doctors.Size = new System.Drawing.Size(197, 57);
            this.btn_doctors.TabIndex = 3;
            this.btn_doctors.Text = "Doctors";
            this.btn_doctors.UseVisualStyleBackColor = false;
            this.btn_doctors.Click += new System.EventHandler(this.btn_doctors_Click);
            // 
            // btn_patients
            // 
            this.btn_patients.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_patients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_patients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patients.ForeColor = System.Drawing.Color.Navy;
            this.btn_patients.Location = new System.Drawing.Point(3, 316);
            this.btn_patients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_patients.Name = "btn_patients";
            this.btn_patients.Size = new System.Drawing.Size(197, 57);
            this.btn_patients.TabIndex = 4;
            this.btn_patients.Text = "Patients";
            this.btn_patients.UseVisualStyleBackColor = false;
            //this.btn_patients.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_appointments
            // 
            this.btn_appointments.BackColor = System.Drawing.Color.Navy;
            this.btn_appointments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_appointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_appointments.ForeColor = System.Drawing.Color.White;
            this.btn_appointments.Location = new System.Drawing.Point(3, 377);
            this.btn_appointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_appointments.Name = "btn_appointments";
            this.btn_appointments.Size = new System.Drawing.Size(197, 57);
            this.btn_appointments.TabIndex = 5;
            this.btn_appointments.Text = "Appointments";
            this.btn_appointments.UseVisualStyleBackColor = false;
            this.btn_appointments.Click += new System.EventHandler(this.btn_appointments_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(3, 438);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(197, 177);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(3, 619);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(197, 57);
            this.btnlogout.TabIndex = 7;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group.Properties.Resources.bakground_1;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblpt);
            this.Controls.Add(this.lblpt_search);
            this.Controls.Add(this.dataGridView_patient);
            this.Controls.Add(this.btnpt_add);
            this.Controls.Add(this.txtpt_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patient)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblpt_search;
        private System.Windows.Forms.DataGridView dataGridView_patient;
        private System.Windows.Forms.Button btnpt_add;
        private System.Windows.Forms.TextBox txtpt_search;
        private System.Windows.Forms.Label lblpt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_doctors;
        private System.Windows.Forms.Button btn_patients;
        private System.Windows.Forms.Button btn_appointments;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnlogout;
    }
}