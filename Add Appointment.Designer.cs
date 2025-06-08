namespace Group
{
    partial class Add_Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Appointment));
            this.btnView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtadd_id = new System.Windows.Forms.TextBox();
            this.lbladd_id = new System.Windows.Forms.Label();
            this.txtadd_reason = new System.Windows.Forms.TextBox();
            this.lbladd_reason = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtadd_patient = new System.Windows.Forms.TextBox();
            this.lbladd_patient = new System.Windows.Forms.Label();
            this.lbladd_date = new System.Windows.Forms.Label();
            this.cmbadd_dr = new System.Windows.Forms.ComboBox();
            this.lbladd_dr = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.AccessibleName = "viewAppointments";
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(449, 532);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(234, 48);
            this.btnView.TabIndex = 28;
            this.btnView.Text = "View Appointments";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(904, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "X";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Navy;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(283, 532);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(137, 48);
            this.btnadd.TabIndex = 26;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // txtadd_id
            // 
            this.txtadd_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtadd_id.Location = new System.Drawing.Point(449, 220);
            this.txtadd_id.Multiline = true;
            this.txtadd_id.Name = "txtadd_id";
            this.txtadd_id.ReadOnly = true;
            this.txtadd_id.Size = new System.Drawing.Size(262, 30);
            this.txtadd_id.TabIndex = 25;
            // 
            // lbladd_id
            // 
            this.lbladd_id.AutoSize = true;
            this.lbladd_id.BackColor = System.Drawing.Color.Transparent;
            this.lbladd_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbladd_id.Location = new System.Drawing.Point(264, 221);
            this.lbladd_id.Name = "lbladd_id";
            this.lbladd_id.Size = new System.Drawing.Size(124, 20);
            this.lbladd_id.TabIndex = 24;
            this.lbladd_id.Text = "Appointment ID";
            // 
            // txtadd_reason
            // 
            this.txtadd_reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtadd_reason.Location = new System.Drawing.Point(449, 443);
            this.txtadd_reason.Multiline = true;
            this.txtadd_reason.Name = "txtadd_reason";
            this.txtadd_reason.Size = new System.Drawing.Size(262, 30);
            this.txtadd_reason.TabIndex = 23;
            // 
            // lbladd_reason
            // 
            this.lbladd_reason.AutoSize = true;
            this.lbladd_reason.BackColor = System.Drawing.Color.Transparent;
            this.lbladd_reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbladd_reason.Location = new System.Drawing.Point(264, 444);
            this.lbladd_reason.Name = "lbladd_reason";
            this.lbladd_reason.Size = new System.Drawing.Size(66, 20);
            this.lbladd_reason.TabIndex = 22;
            this.lbladd_reason.Text = "Reason";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dateTimePicker1.Location = new System.Drawing.Point(449, 328);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 27);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // txtadd_patient
            // 
            this.txtadd_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtadd_patient.Location = new System.Drawing.Point(449, 386);
            this.txtadd_patient.Multiline = true;
            this.txtadd_patient.Name = "txtadd_patient";
            this.txtadd_patient.Size = new System.Drawing.Size(262, 30);
            this.txtadd_patient.TabIndex = 20;
            // 
            // lbladd_patient
            // 
            this.lbladd_patient.AutoSize = true;
            this.lbladd_patient.BackColor = System.Drawing.Color.Transparent;
            this.lbladd_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbladd_patient.Location = new System.Drawing.Point(264, 387);
            this.lbladd_patient.Name = "lbladd_patient";
            this.lbladd_patient.Size = new System.Drawing.Size(110, 20);
            this.lbladd_patient.TabIndex = 19;
            this.lbladd_patient.Text = "Patient Name";
            // 
            // lbladd_date
            // 
            this.lbladd_date.AutoSize = true;
            this.lbladd_date.BackColor = System.Drawing.Color.Transparent;
            this.lbladd_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbladd_date.Location = new System.Drawing.Point(264, 332);
            this.lbladd_date.Name = "lbladd_date";
            this.lbladd_date.Size = new System.Drawing.Size(119, 20);
            this.lbladd_date.TabIndex = 18;
            this.lbladd_date.Text = "Date and Time";
            // 
            // cmbadd_dr
            // 
            this.cmbadd_dr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbadd_dr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbadd_dr.FormattingEnabled = true;
            this.cmbadd_dr.Location = new System.Drawing.Point(449, 274);
            this.cmbadd_dr.Name = "cmbadd_dr";
            this.cmbadd_dr.Size = new System.Drawing.Size(262, 28);
            this.cmbadd_dr.TabIndex = 17;
            // 
            // lbladd_dr
            // 
            this.lbladd_dr.AutoSize = true;
            this.lbladd_dr.BackColor = System.Drawing.Color.Transparent;
            this.lbladd_dr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbladd_dr.Location = new System.Drawing.Point(264, 275);
            this.lbladd_dr.Name = "lbladd_dr";
            this.lbladd_dr.Size = new System.Drawing.Size(109, 20);
            this.lbladd_dr.TabIndex = 16;
            this.lbladd_dr.Text = "Doctor Name";
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.BackColor = System.Drawing.Color.Transparent;
            this.lbladd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbladd.ForeColor = System.Drawing.Color.Navy;
            this.lbladd.Location = new System.Drawing.Point(381, 118);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(248, 32);
            this.lbladd.TabIndex = 15;
            this.lbladd.Text = "Add Appointment";
            // 
            // Add_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtadd_id);
            this.Controls.Add(this.lbladd_id);
            this.Controls.Add(this.txtadd_reason);
            this.Controls.Add(this.lbladd_reason);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtadd_patient);
            this.Controls.Add(this.lbladd_patient);
            this.Controls.Add(this.lbladd_date);
            this.Controls.Add(this.cmbadd_dr);
            this.Controls.Add(this.lbladd_dr);
            this.Controls.Add(this.lbladd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Appointment";
            this.Text = "Add_Appointment";
            this.Load += new System.EventHandler(this.Add_Appointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtadd_id;
        private System.Windows.Forms.Label lbladd_id;
        private System.Windows.Forms.TextBox txtadd_reason;
        private System.Windows.Forms.Label lbladd_reason;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtadd_patient;
        private System.Windows.Forms.Label lbladd_patient;
        private System.Windows.Forms.Label lbladd_date;
        private System.Windows.Forms.ComboBox cmbadd_dr;
        private System.Windows.Forms.Label lbladd_dr;
        private System.Windows.Forms.Label lbladd;
    }
}
