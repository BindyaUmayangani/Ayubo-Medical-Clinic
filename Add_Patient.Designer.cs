namespace Group
{
    partial class Add_Patient
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
            this.lblpt = new System.Windows.Forms.Label();
            this.txtpt_id = new System.Windows.Forms.TextBox();
            this.lblpt_id = new System.Windows.Forms.Label();
            this.txtpt_name = new System.Windows.Forms.TextBox();
            this.lblpt_name = new System.Windows.Forms.Label();
            this.txtpt_age = new System.Windows.Forms.TextBox();
            this.lblpt_age = new System.Windows.Forms.Label();
            this.lblpt_group = new System.Windows.Forms.Label();
            this.lblpt_email = new System.Windows.Forms.Label();
            this.lblpt_contact = new System.Windows.Forms.Label();
            this.txtpt_reason = new System.Windows.Forms.TextBox();
            this.lblpt_reason = new System.Windows.Forms.Label();
            this.txtpt_address = new System.Windows.Forms.TextBox();
            this.lblpt_address = new System.Windows.Forms.Label();
            this.txtpt_contact = new System.Windows.Forms.TextBox();
            this.txtpt_email = new System.Windows.Forms.TextBox();
            this.lblpt_close = new System.Windows.Forms.Label();
            this.lblpt_gender = new System.Windows.Forms.Label();
            this.radioButtonmale = new System.Windows.Forms.RadioButton();
            this.radioButtonfemale = new System.Windows.Forms.RadioButton();
            this.btnpt_add = new System.Windows.Forms.Button();
            this.btnpt_update = new System.Windows.Forms.Button();
            this.btnpt_del = new System.Windows.Forms.Button();
            this.comboBoxpt_blood = new System.Windows.Forms.ComboBox();
            this.btnpt_view = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpt
            // 
            this.lblpt.AutoSize = true;
            this.lblpt.BackColor = System.Drawing.Color.Transparent;
            this.lblpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpt.ForeColor = System.Drawing.Color.Navy;
            this.lblpt.Location = new System.Drawing.Point(75, 100);
            this.lblpt.Name = "lblpt";
            this.lblpt.Size = new System.Drawing.Size(107, 29);
            this.lblpt.TabIndex = 0;
            this.lblpt.Text = "Patients";
            // 
            // txtpt_id
            // 
            this.txtpt_id.Location = new System.Drawing.Point(767, 98);
            this.txtpt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpt_id.Multiline = true;
            this.txtpt_id.Name = "txtpt_id";
            this.txtpt_id.Size = new System.Drawing.Size(145, 30);
            this.txtpt_id.TabIndex = 13;
            // 
            // lblpt_id
            // 
            this.lblpt_id.AutoSize = true;
            this.lblpt_id.BackColor = System.Drawing.Color.Transparent;
            this.lblpt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblpt_id.Location = new System.Drawing.Point(667, 110);
            this.lblpt_id.Name = "lblpt_id";
            this.lblpt_id.Size = new System.Drawing.Size(83, 20);
            this.lblpt_id.TabIndex = 12;
            this.lblpt_id.Text = "Patient ID";
            // 
            // txtpt_name
            // 
            this.txtpt_name.Location = new System.Drawing.Point(229, 201);
            this.txtpt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpt_name.Multiline = true;
            this.txtpt_name.Name = "txtpt_name";
            this.txtpt_name.Size = new System.Drawing.Size(225, 30);
            this.txtpt_name.TabIndex = 15;
            // 
            // lblpt_name
            // 
            this.lblpt_name.AutoSize = true;
            this.lblpt_name.BackColor = System.Drawing.Color.Transparent;
            this.lblpt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblpt_name.Location = new System.Drawing.Point(75, 210);
            this.lblpt_name.Name = "lblpt_name";
            this.lblpt_name.Size = new System.Drawing.Size(110, 20);
            this.lblpt_name.TabIndex = 14;
            this.lblpt_name.Text = "Patient Name";
            // 
            // txtpt_age
            // 
            this.txtpt_age.Location = new System.Drawing.Point(229, 262);
            this.txtpt_age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpt_age.Multiline = true;
            this.txtpt_age.Name = "txtpt_age";
            this.txtpt_age.Size = new System.Drawing.Size(225, 30);
            this.txtpt_age.TabIndex = 17;
            // 
            // lblpt_age
            // 
            this.lblpt_age.AutoSize = true;
            this.lblpt_age.BackColor = System.Drawing.Color.Transparent;
            this.lblpt_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblpt_age.Location = new System.Drawing.Point(75, 272);
            this.lblpt_age.Name = "lblpt_age";
            this.lblpt_age.Size = new System.Drawing.Size(38, 20);
            this.lblpt_age.TabIndex = 16;
            this.lblpt_age.Text = "Age";
            this.lblpt_age.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblpt_group
            // 
            this.lblpt_group.AutoSize = true;
            this.lblpt_group.BackColor = System.Drawing.Color.Transparent;
            this.lblpt_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblpt_group.Location = new System.Drawing.Point(75, 336);
            this.lblpt_group.Name = "lblpt_group";
            this.lblpt_group.Size = new System.Drawing.Size(103, 20);
            this.lblpt_group.TabIndex = 22;
            this.lblpt_group.Text = "Blood Group";
            this.lblpt_group.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblpt_email
            // 
            this.lblpt_email.AutoSize = true;
            this.lblpt_email.BackColor = System.Drawing.Color.Transparent;
            this.lblpt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblpt_email.Location = new System.Drawing.Point(551, 268);
            this.lblpt_email.Name = "lblpt_email";
            this.lblpt_email.Size = new System.Drawing.Size(51, 20);
            this.lblpt_email.TabIndex = 20;
            this.lblpt_email.Text = "Email";
            // 
            // lblpt_contact
            // 
            this.lblpt_contact.AutoSize = true;
            this.lblpt_contact.BackColor = System.Drawing.Color.Transparent;
            this.lblpt_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblpt_contact.Location = new System.Drawing.Point(551, 204);
            this.lblpt_contact.Name = "lblpt_contact";
            this.lblpt_contact.Size = new System.Drawing.Size(97, 20);
            this.lblpt_contact.TabIndex = 18;
            this.lblpt_contact.Text = "Contact No.";
            // 
            // txtpt_reason
            // 
            this.txtpt_reason.Location = new System.Drawing.Point(689, 383);
            this.txtpt_reason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpt_reason.Multiline = true;
            this.txtpt_reason.Name = "txtpt_reason";
            this.txtpt_reason.Size = new System.Drawing.Size(225, 61);
            this.txtpt_reason.TabIndex = 27;
            // 
            // lblpt_reason
            // 
            this.lblpt_reason.AutoSize = true;
            this.lblpt_reason.BackColor = System.Drawing.Color.Transparent;
            this.lblpt_reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblpt_reason.Location = new System.Drawing.Point(555, 393);
            this.lblpt_reason.Name = "lblpt_reason";
            this.lblpt_reason.Size = new System.Drawing.Size(66, 20);
            this.lblpt_reason.TabIndex = 26;
            this.lblpt_reason.Text = "Reason";
            // 
            // txtpt_address
            // 
            this.txtpt_address.Location = new System.Drawing.Point(689, 319);
            this.txtpt_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpt_address.Multiline = true;
            this.txtpt_address.Name = "txtpt_address";
            this.txtpt_address.Size = new System.Drawing.Size(225, 30);
            this.txtpt_address.TabIndex = 25;
            // 
            // lblpt_address
            // 
            this.lblpt_address.AutoSize = true;
            this.lblpt_address.BackColor = System.Drawing.Color.Transparent;
            this.lblpt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblpt_address.Location = new System.Drawing.Point(555, 329);
            this.lblpt_address.Name = "lblpt_address";
            this.lblpt_address.Size = new System.Drawing.Size(71, 20);
            this.lblpt_address.TabIndex = 24;
            this.lblpt_address.Text = "Address";
            this.lblpt_address.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtpt_contact
            // 
            this.txtpt_contact.Location = new System.Drawing.Point(689, 194);
            this.txtpt_contact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpt_contact.Multiline = true;
            this.txtpt_contact.Name = "txtpt_contact";
            this.txtpt_contact.Size = new System.Drawing.Size(225, 30);
            this.txtpt_contact.TabIndex = 19;
            // 
            // txtpt_email
            // 
            this.txtpt_email.Location = new System.Drawing.Point(689, 258);
            this.txtpt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpt_email.Multiline = true;
            this.txtpt_email.Name = "txtpt_email";
            this.txtpt_email.Size = new System.Drawing.Size(225, 30);
            this.txtpt_email.TabIndex = 21;
            // 
            // lblpt_close
            // 
            this.lblpt_close.AutoSize = true;
            this.lblpt_close.BackColor = System.Drawing.Color.Transparent;
            this.lblpt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpt_close.Location = new System.Drawing.Point(945, 33);
            this.lblpt_close.Name = "lblpt_close";
            this.lblpt_close.Size = new System.Drawing.Size(21, 20);
            this.lblpt_close.TabIndex = 28;
            this.lblpt_close.Text = "X";
            this.lblpt_close.Click += new System.EventHandler(this.lblpt_close_Click);
            // 
            // lblpt_gender
            // 
            this.lblpt_gender.AutoSize = true;
            this.lblpt_gender.BackColor = System.Drawing.Color.Transparent;
            this.lblpt_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblpt_gender.Location = new System.Drawing.Point(71, 399);
            this.lblpt_gender.Name = "lblpt_gender";
            this.lblpt_gender.Size = new System.Drawing.Size(64, 20);
            this.lblpt_gender.TabIndex = 29;
            this.lblpt_gender.Text = "Gender";
            this.lblpt_gender.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButtonmale
            // 
            this.radioButtonmale.AutoSize = true;
            this.radioButtonmale.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonmale.Location = new System.Drawing.Point(229, 395);
            this.radioButtonmale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonmale.Name = "radioButtonmale";
            this.radioButtonmale.Size = new System.Drawing.Size(66, 24);
            this.radioButtonmale.TabIndex = 31;
            this.radioButtonmale.TabStop = true;
            this.radioButtonmale.Text = "Male";
            this.radioButtonmale.UseVisualStyleBackColor = false;
            // 
            // radioButtonfemale
            // 
            this.radioButtonfemale.AutoSize = true;
            this.radioButtonfemale.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonfemale.Location = new System.Drawing.Point(336, 394);
            this.radioButtonfemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonfemale.Name = "radioButtonfemale";
            this.radioButtonfemale.Size = new System.Drawing.Size(85, 24);
            this.radioButtonfemale.TabIndex = 32;
            this.radioButtonfemale.TabStop = true;
            this.radioButtonfemale.Text = "Female";
            this.radioButtonfemale.UseVisualStyleBackColor = false;
            // 
            // btnpt_add
            // 
            this.btnpt_add.BackColor = System.Drawing.Color.Navy;
            this.btnpt_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpt_add.ForeColor = System.Drawing.Color.White;
            this.btnpt_add.Location = new System.Drawing.Point(113, 524);
            this.btnpt_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpt_add.Name = "btnpt_add";
            this.btnpt_add.Size = new System.Drawing.Size(117, 50);
            this.btnpt_add.TabIndex = 33;
            this.btnpt_add.Text = "Add";
            this.btnpt_add.UseVisualStyleBackColor = false;
            this.btnpt_add.Click += new System.EventHandler(this.btnpt_add_Click);
            // 
            // btnpt_update
            // 
            this.btnpt_update.BackColor = System.Drawing.Color.Navy;
            this.btnpt_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpt_update.ForeColor = System.Drawing.Color.White;
            this.btnpt_update.Location = new System.Drawing.Point(325, 524);
            this.btnpt_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpt_update.Name = "btnpt_update";
            this.btnpt_update.Size = new System.Drawing.Size(117, 50);
            this.btnpt_update.TabIndex = 34;
            this.btnpt_update.Text = "Update";
            this.btnpt_update.UseVisualStyleBackColor = false;
            // 
            // btnpt_del
            // 
            this.btnpt_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnpt_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpt_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpt_del.ForeColor = System.Drawing.Color.White;
            this.btnpt_del.Location = new System.Drawing.Point(533, 524);
            this.btnpt_del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpt_del.Name = "btnpt_del";
            this.btnpt_del.Size = new System.Drawing.Size(117, 50);
            this.btnpt_del.TabIndex = 35;
            this.btnpt_del.Text = "Delete";
            this.btnpt_del.UseVisualStyleBackColor = false;
            // 
            // comboBoxpt_blood
            // 
            this.comboBoxpt_blood.FormattingEnabled = true;
            this.comboBoxpt_blood.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.comboBoxpt_blood.Location = new System.Drawing.Point(229, 332);
            this.comboBoxpt_blood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxpt_blood.Name = "comboBoxpt_blood";
            this.comboBoxpt_blood.Size = new System.Drawing.Size(225, 24);
            this.comboBoxpt_blood.TabIndex = 36;
            this.comboBoxpt_blood.SelectedIndexChanged += new System.EventHandler(this.comboBoxpt_blood_SelectedIndexChanged);
            // 
            // btnpt_view
            // 
            this.btnpt_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnpt_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpt_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpt_view.ForeColor = System.Drawing.Color.White;
            this.btnpt_view.Location = new System.Drawing.Point(743, 524);
            this.btnpt_view.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpt_view.Name = "btnpt_view";
            this.btnpt_view.Size = new System.Drawing.Size(133, 50);
            this.btnpt_view.TabIndex = 37;
            this.btnpt_view.Text = "View";
            this.btnpt_view.UseVisualStyleBackColor = false;
            // 
            // Add_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group.Properties.Resources.bakground_1;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.btnpt_view);
            this.Controls.Add(this.comboBoxpt_blood);
            this.Controls.Add(this.btnpt_del);
            this.Controls.Add(this.btnpt_update);
            this.Controls.Add(this.btnpt_add);
            this.Controls.Add(this.radioButtonfemale);
            this.Controls.Add(this.radioButtonmale);
            this.Controls.Add(this.lblpt_gender);
            this.Controls.Add(this.lblpt_close);
            this.Controls.Add(this.txtpt_reason);
            this.Controls.Add(this.lblpt_reason);
            this.Controls.Add(this.txtpt_address);
            this.Controls.Add(this.lblpt_address);
            this.Controls.Add(this.lblpt_group);
            this.Controls.Add(this.txtpt_email);
            this.Controls.Add(this.lblpt_email);
            this.Controls.Add(this.txtpt_contact);
            this.Controls.Add(this.lblpt_contact);
            this.Controls.Add(this.txtpt_age);
            this.Controls.Add(this.lblpt_age);
            this.Controls.Add(this.txtpt_name);
            this.Controls.Add(this.lblpt_name);
            this.Controls.Add(this.txtpt_id);
            this.Controls.Add(this.lblpt_id);
            this.Controls.Add(this.lblpt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Add_Patient";
            this.Text = "Add_Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpt;
        private System.Windows.Forms.TextBox txtpt_id;
        private System.Windows.Forms.Label lblpt_id;
        private System.Windows.Forms.TextBox txtpt_name;
        private System.Windows.Forms.Label lblpt_name;
        private System.Windows.Forms.TextBox txtpt_age;
        private System.Windows.Forms.Label lblpt_age;
        private System.Windows.Forms.Label lblpt_group;
        private System.Windows.Forms.Label lblpt_email;
        private System.Windows.Forms.Label lblpt_contact;
        private System.Windows.Forms.TextBox txtpt_reason;
        private System.Windows.Forms.Label lblpt_reason;
        private System.Windows.Forms.TextBox txtpt_address;
        private System.Windows.Forms.Label lblpt_address;
        private System.Windows.Forms.TextBox txtpt_contact;
        private System.Windows.Forms.TextBox txtpt_email;
        private System.Windows.Forms.Label lblpt_close;
        private System.Windows.Forms.Label lblpt_gender;
        private System.Windows.Forms.RadioButton radioButtonmale;
        private System.Windows.Forms.RadioButton radioButtonfemale;
        private System.Windows.Forms.Button btnpt_add;
        private System.Windows.Forms.Button btnpt_update;
        private System.Windows.Forms.Button btnpt_del;
        private System.Windows.Forms.ComboBox comboBoxpt_blood;
        private System.Windows.Forms.Button btnpt_view;
    }
}