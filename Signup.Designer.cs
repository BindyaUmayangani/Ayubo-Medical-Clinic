namespace Group
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblhaveacc = new System.Windows.Forms.Label();
            this.btnsignup = new System.Windows.Forms.Button();
            this.txtsignup_password = new System.Windows.Forms.TextBox();
            this.lblsignup_password = new System.Windows.Forms.Label();
            this.txtsignup_username = new System.Windows.Forms.TextBox();
            this.lblsignup_username = new System.Windows.Forms.Label();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.txtsignup_email = new System.Windows.Forms.TextBox();
            this.lblsignup_email = new System.Windows.Forms.Label();
            this.lblsignup_close = new System.Windows.Forms.Label();
            this.signup_showpass = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.BackColor = System.Drawing.Color.Transparent;
            this.lbllogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.Color.White;
            this.lbllogin.Location = new System.Drawing.Point(761, 618);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(87, 18);
            this.lbllogin.TabIndex = 15;
            this.lbllogin.Text = "Login here";
            this.lbllogin.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblhaveacc
            // 
            this.lblhaveacc.AutoSize = true;
            this.lblhaveacc.BackColor = System.Drawing.Color.Transparent;
            this.lblhaveacc.ForeColor = System.Drawing.Color.White;
            this.lblhaveacc.Location = new System.Drawing.Point(593, 620);
            this.lblhaveacc.Name = "lblhaveacc";
            this.lblhaveacc.Size = new System.Drawing.Size(162, 16);
            this.lblhaveacc.TabIndex = 14;
            this.lblhaveacc.Text = "Already have an account?";
            this.lblhaveacc.Click += new System.EventHandler(this.lblhaveacc_Click);
            // 
            // btnsignup
            // 
            this.btnsignup.AutoEllipsis = true;
            this.btnsignup.BackColor = System.Drawing.Color.Navy;
            this.btnsignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsignup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.ForeColor = System.Drawing.Color.White;
            this.btnsignup.Location = new System.Drawing.Point(667, 540);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(106, 44);
            this.btnsignup.TabIndex = 13;
            this.btnsignup.Text = "Sign Up";
            this.btnsignup.UseVisualStyleBackColor = false;
            this.btnsignup.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtsignup_password
            // 
            this.txtsignup_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsignup_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsignup_password.Location = new System.Drawing.Point(554, 398);
            this.txtsignup_password.Multiline = true;
            this.txtsignup_password.Name = "txtsignup_password";
            this.txtsignup_password.PasswordChar = '*';
            this.txtsignup_password.Size = new System.Drawing.Size(323, 36);
            this.txtsignup_password.TabIndex = 12;
            this.txtsignup_password.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // lblsignup_password
            // 
            this.lblsignup_password.AutoSize = true;
            this.lblsignup_password.BackColor = System.Drawing.Color.Transparent;
            this.lblsignup_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignup_password.ForeColor = System.Drawing.Color.White;
            this.lblsignup_password.Location = new System.Drawing.Point(551, 375);
            this.lblsignup_password.Name = "lblsignup_password";
            this.lblsignup_password.Size = new System.Drawing.Size(75, 18);
            this.lblsignup_password.TabIndex = 11;
            this.lblsignup_password.Text = "Password";
            this.lblsignup_password.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtsignup_username
            // 
            this.txtsignup_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsignup_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsignup_username.Location = new System.Drawing.Point(554, 306);
            this.txtsignup_username.Multiline = true;
            this.txtsignup_username.Name = "txtsignup_username";
            this.txtsignup_username.Size = new System.Drawing.Size(323, 36);
            this.txtsignup_username.TabIndex = 10;
            this.txtsignup_username.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // lblsignup_username
            // 
            this.lblsignup_username.AutoSize = true;
            this.lblsignup_username.BackColor = System.Drawing.Color.Transparent;
            this.lblsignup_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignup_username.ForeColor = System.Drawing.Color.White;
            this.lblsignup_username.Location = new System.Drawing.Point(551, 283);
            this.lblsignup_username.Name = "lblsignup_username";
            this.lblsignup_username.Size = new System.Drawing.Size(48, 18);
            this.lblsignup_username.TabIndex = 9;
            this.lblsignup_username.Text = "Name";
            this.lblsignup_username.Click += new System.EventHandler(this.lblusername_Click);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.Color.White;
            this.lblwelcome.Location = new System.Drawing.Point(644, 88);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(129, 29);
            this.lblwelcome.TabIndex = 8;
            this.lblwelcome.Text = "Welcome!";
            this.lblwelcome.Click += new System.EventHandler(this.lblwelcome_Click);
            // 
            // txtsignup_email
            // 
            this.txtsignup_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsignup_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsignup_email.Location = new System.Drawing.Point(554, 215);
            this.txtsignup_email.Multiline = true;
            this.txtsignup_email.Name = "txtsignup_email";
            this.txtsignup_email.Size = new System.Drawing.Size(323, 36);
            this.txtsignup_email.TabIndex = 17;
            // 
            // lblsignup_email
            // 
            this.lblsignup_email.AutoSize = true;
            this.lblsignup_email.BackColor = System.Drawing.Color.Transparent;
            this.lblsignup_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignup_email.ForeColor = System.Drawing.Color.White;
            this.lblsignup_email.Location = new System.Drawing.Point(551, 192);
            this.lblsignup_email.Name = "lblsignup_email";
            this.lblsignup_email.Size = new System.Drawing.Size(103, 18);
            this.lblsignup_email.TabIndex = 16;
            this.lblsignup_email.Text = "Email Address";
            this.lblsignup_email.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblsignup_close
            // 
            this.lblsignup_close.AutoSize = true;
            this.lblsignup_close.BackColor = System.Drawing.Color.Transparent;
            this.lblsignup_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignup_close.ForeColor = System.Drawing.Color.White;
            this.lblsignup_close.Location = new System.Drawing.Point(966, 9);
            this.lblsignup_close.Name = "lblsignup_close";
            this.lblsignup_close.Size = new System.Drawing.Size(22, 25);
            this.lblsignup_close.TabIndex = 19;
            this.lblsignup_close.Text = "x";
            this.lblsignup_close.Click += new System.EventHandler(this.lblsignup_close_Click);
            // 
            // signup_showpass
            // 
            this.signup_showpass.AutoSize = true;
            this.signup_showpass.BackColor = System.Drawing.Color.Transparent;
            this.signup_showpass.ForeColor = System.Drawing.Color.White;
            this.signup_showpass.Location = new System.Drawing.Point(752, 454);
            this.signup_showpass.Name = "signup_showpass";
            this.signup_showpass.Size = new System.Drawing.Size(125, 20);
            this.signup_showpass.TabIndex = 20;
            this.signup_showpass.Text = "Show Password";
            this.signup_showpass.UseVisualStyleBackColor = false;
            this.signup_showpass.CheckedChanged += new System.EventHandler(this.signup_showpass_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Group.Properties.Resources._42c62d6e16c42d1ddd3506a5f44dfb341;
            this.pictureBox1.Image = global::Group.Properties.Resources.dr;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 702);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signup_showpass);
            this.Controls.Add(this.lblsignup_close);
            this.Controls.Add(this.txtsignup_email);
            this.Controls.Add(this.lblsignup_email);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.lblhaveacc);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.txtsignup_password);
            this.Controls.Add(this.lblsignup_password);
            this.Controls.Add(this.txtsignup_username);
            this.Controls.Add(this.lblsignup_username);
            this.Controls.Add(this.lblwelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblhaveacc;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.TextBox txtsignup_password;
        private System.Windows.Forms.Label lblsignup_password;
        private System.Windows.Forms.TextBox txtsignup_username;
        private System.Windows.Forms.Label lblsignup_username;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.TextBox txtsignup_email;
        private System.Windows.Forms.Label lblsignup_email;
        private System.Windows.Forms.Label lblsignup_close;
        private System.Windows.Forms.CheckBox signup_showpass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}