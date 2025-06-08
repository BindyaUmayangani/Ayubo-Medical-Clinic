namespace Group
{
    partial class Doctor
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_doctors = new System.Windows.Forms.Button();
            this.btn_patients = new System.Windows.Forms.Button();
            this.btn_appointments = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.lbldr = new System.Windows.Forms.Label();
            this.lbldr_search = new System.Windows.Forms.Label();
            this.dataGridView_doctors = new System.Windows.Forms.DataGridView();
            this.btndr_add = new System.Windows.Forms.Button();
            this.txtdr_search = new System.Windows.Forms.TextBox();
            this.cmbSortByDate = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doctors)).BeginInit();
            this.SuspendLayout();
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(201, 702);
            this.flowLayoutPanel1.TabIndex = 23;
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
            this.pictureBox2.Size = new System.Drawing.Size(197, 33);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.Navy;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Location = new System.Drawing.Point(3, 210);
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
            this.btn_doctors.BackColor = System.Drawing.Color.White;
            this.btn_doctors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_doctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctors.ForeColor = System.Drawing.Color.Navy;
            this.btn_doctors.Location = new System.Drawing.Point(3, 271);
            this.btn_doctors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_doctors.Name = "btn_doctors";
            this.btn_doctors.Size = new System.Drawing.Size(197, 57);
            this.btn_doctors.TabIndex = 3;
            this.btn_doctors.Text = "Doctors";
            this.btn_doctors.UseVisualStyleBackColor = false;
            // 
            // btn_patients
            // 
            this.btn_patients.BackColor = System.Drawing.Color.Navy;
            this.btn_patients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_patients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patients.ForeColor = System.Drawing.Color.White;
            this.btn_patients.Location = new System.Drawing.Point(3, 332);
            this.btn_patients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_patients.Name = "btn_patients";
            this.btn_patients.Size = new System.Drawing.Size(197, 57);
            this.btn_patients.TabIndex = 4;
            this.btn_patients.Text = "Patients";
            this.btn_patients.UseVisualStyleBackColor = false;
            this.btn_patients.Click += new System.EventHandler(this.btn_patients_Click);
            // 
            // btn_appointments
            // 
            this.btn_appointments.BackColor = System.Drawing.Color.Navy;
            this.btn_appointments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_appointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_appointments.ForeColor = System.Drawing.Color.White;
            this.btn_appointments.Location = new System.Drawing.Point(3, 393);
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
            this.pictureBox3.Location = new System.Drawing.Point(3, 454);
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
            this.btnlogout.Location = new System.Drawing.Point(3, 635);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(197, 57);
            this.btnlogout.TabIndex = 7;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // lbldr
            // 
            this.lbldr.AutoSize = true;
            this.lbldr.BackColor = System.Drawing.Color.Transparent;
            this.lbldr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldr.ForeColor = System.Drawing.Color.Navy;
            this.lbldr.Location = new System.Drawing.Point(263, 53);
            this.lbldr.Name = "lbldr";
            this.lbldr.Size = new System.Drawing.Size(103, 29);
            this.lbldr.TabIndex = 28;
            this.lbldr.Text = "Doctors";
            // 
            // lbldr_search
            // 
            this.lbldr_search.AutoSize = true;
            this.lbldr_search.BackColor = System.Drawing.Color.Transparent;
            this.lbldr_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbldr_search.Location = new System.Drawing.Point(265, 141);
            this.lbldr_search.Name = "lbldr_search";
            this.lbldr_search.Size = new System.Drawing.Size(55, 18);
            this.lbldr_search.TabIndex = 27;
            this.lbldr_search.Text = "Search";
            // 
            // dataGridView_doctors
            // 
            this.dataGridView_doctors.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_doctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_doctors.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_doctors.Location = new System.Drawing.Point(268, 210);
            this.dataGridView_doctors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_doctors.Name = "dataGridView_doctors";
            this.dataGridView_doctors.RowHeadersWidth = 51;
            this.dataGridView_doctors.RowTemplate.Height = 24;
            this.dataGridView_doctors.Size = new System.Drawing.Size(667, 432);
            this.dataGridView_doctors.TabIndex = 26;
            this.dataGridView_doctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_doctors_CellContentClick);
            // 
            // btndr_add
            // 
            this.btndr_add.BackColor = System.Drawing.Color.Navy;
            this.btndr_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndr_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btndr_add.ForeColor = System.Drawing.Color.White;
            this.btndr_add.Location = new System.Drawing.Point(623, 134);
            this.btndr_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndr_add.Name = "btndr_add";
            this.btndr_add.Size = new System.Drawing.Size(182, 30);
            this.btndr_add.TabIndex = 25;
            this.btndr_add.Text = "Add Doctor";
            this.btndr_add.UseVisualStyleBackColor = false;
            this.btndr_add.Click += new System.EventHandler(this.btndr_add_Click);
            // 
            // txtdr_search
            // 
            this.txtdr_search.Location = new System.Drawing.Point(327, 134);
            this.txtdr_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdr_search.Multiline = true;
            this.txtdr_search.Name = "txtdr_search";
            this.txtdr_search.Size = new System.Drawing.Size(192, 30);
            this.txtdr_search.TabIndex = 24;
            // 
            // cmbSortByDate
            // 
            this.cmbSortByDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbSortByDate.FormattingEnabled = true;
            this.cmbSortByDate.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cmbSortByDate.Location = new System.Drawing.Point(811, 134);
            this.cmbSortByDate.Name = "cmbSortByDate";
            this.cmbSortByDate.Size = new System.Drawing.Size(124, 28);
            this.cmbSortByDate.TabIndex = 29;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group.Properties.Resources.bakground_1;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.cmbSortByDate);
            this.Controls.Add(this.lbldr);
            this.Controls.Add(this.lbldr_search);
            this.Controls.Add(this.dataGridView_doctors);
            this.Controls.Add(this.btndr_add);
            this.Controls.Add(this.txtdr_search);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_doctors;
        private System.Windows.Forms.Button btn_patients;
        private System.Windows.Forms.Button btn_appointments;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label lbldr;
        private System.Windows.Forms.Label lbldr_search;
        private System.Windows.Forms.DataGridView dataGridView_doctors;
        private System.Windows.Forms.Button btndr_add;
        private System.Windows.Forms.TextBox txtdr_search;
        private System.Windows.Forms.ComboBox cmbSortByDate;
    }
}