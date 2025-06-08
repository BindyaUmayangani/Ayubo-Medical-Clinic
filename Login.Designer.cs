namespace Group
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblwelcome = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblhaveacc = new System.Windows.Forms.Label();
            this.lblsignup = new System.Windows.Forms.Label();
            this.lblclose = new System.Windows.Forms.Label();
            this.login_showpass = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.Color.White;
            this.lblwelcome.Location = new System.Drawing.Point(631, 122);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(193, 29);
            this.lblwelcome.TabIndex = 0;
            this.lblwelcome.Text = "Welcome Back!";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.White;
            this.lblusername.Location = new System.Drawing.Point(551, 212);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(77, 18);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "Username";
            this.lblusername.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtusername
            // 
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(554, 241);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(340, 39);
            this.txtusername.TabIndex = 2;
            // 
            // txtpassword
            // 
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(554, 333);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(340, 39);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.White;
            this.lblpassword.Location = new System.Drawing.Point(551, 304);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(75, 18);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Navy;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(655, 483);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(119, 51);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblhaveacc
            // 
            this.lblhaveacc.AutoSize = true;
            this.lblhaveacc.BackColor = System.Drawing.Color.Transparent;
            this.lblhaveacc.ForeColor = System.Drawing.Color.White;
            this.lblhaveacc.Location = new System.Drawing.Point(598, 606);
            this.lblhaveacc.Name = "lblhaveacc";
            this.lblhaveacc.Size = new System.Drawing.Size(146, 16);
            this.lblhaveacc.TabIndex = 6;
            this.lblhaveacc.Text = "Don\'t have an account?";
            // 
            // lblsignup
            // 
            this.lblsignup.AutoSize = true;
            this.lblsignup.BackColor = System.Drawing.Color.Transparent;
            this.lblsignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignup.ForeColor = System.Drawing.Color.White;
            this.lblsignup.Location = new System.Drawing.Point(750, 604);
            this.lblsignup.Name = "lblsignup";
            this.lblsignup.Size = new System.Drawing.Size(100, 18);
            this.lblsignup.TabIndex = 7;
            this.lblsignup.Text = "SignUp here";
            this.lblsignup.Click += new System.EventHandler(this.lblsignup_Click);
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.BackColor = System.Drawing.Color.Transparent;
            this.lblclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclose.ForeColor = System.Drawing.Color.White;
            this.lblclose.Location = new System.Drawing.Point(951, 28);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(23, 25);
            this.lblclose.TabIndex = 20;
            this.lblclose.Text = "x";
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // login_showpass
            // 
            this.login_showpass.AutoSize = true;
            this.login_showpass.BackColor = System.Drawing.Color.Transparent;
            this.login_showpass.ForeColor = System.Drawing.Color.White;
            this.login_showpass.Location = new System.Drawing.Point(769, 390);
            this.login_showpass.Name = "login_showpass";
            this.login_showpass.Size = new System.Drawing.Size(125, 20);
            this.login_showpass.TabIndex = 21;
            this.login_showpass.Text = "Show Password";
            this.login_showpass.UseVisualStyleBackColor = false;
            this.login_showpass.CheckedChanged += new System.EventHandler(this.login_showpass_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Group.Properties.Resources._42c62d6e16c42d1ddd3506a5f44dfb341;
            this.pictureBox1.Image = global::Group.Properties.Resources.dr;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 702);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login_showpass);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.lblsignup);
            this.Controls.Add(this.lblhaveacc);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblwelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblhaveacc;
        private System.Windows.Forms.Label lblsignup;
        private System.Windows.Forms.Label lblclose;
        private System.Windows.Forms.CheckBox login_showpass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

