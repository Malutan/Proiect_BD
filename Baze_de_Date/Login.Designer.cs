namespace Baze_de_Date
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signlabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.userlabel = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.log_user_tbox = new System.Windows.Forms.TextBox();
            this.log_pass_tbox = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.titlelabel = new System.Windows.Forms.Label();
            this.user_signup_label = new System.Windows.Forms.Label();
            this.pass_signuplabel = new System.Windows.Forms.Label();
            this.sign_user_tbox = new System.Windows.Forms.TextBox();
            this.sign_pass_tbox = new System.Windows.Forms.TextBox();
            this.sign_pass2_tbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Baze_de_Date.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // signlabel
            // 
            this.signlabel.AutoSize = true;
            this.signlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signlabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.signlabel.Location = new System.Drawing.Point(413, 110);
            this.signlabel.Name = "signlabel";
            this.signlabel.Size = new System.Drawing.Size(121, 13);
            this.signlabel.TabIndex = 3;
            this.signlabel.Text = "Not a member? Sign up:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(540, 110);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.Location = new System.Drawing.Point(74, 63);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(83, 16);
            this.userlabel.TabIndex = 5;
            this.userlabel.Text = "Username:";
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlabel.Location = new System.Drawing.Point(330, 63);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(80, 16);
            this.passlabel.TabIndex = 6;
            this.passlabel.Text = "Password:";
            this.passlabel.Click += new System.EventHandler(this.passlabel_Click);
            // 
            // log_user_tbox
            // 
            this.log_user_tbox.Location = new System.Drawing.Point(163, 62);
            this.log_user_tbox.Name = "log_user_tbox";
            this.log_user_tbox.Size = new System.Drawing.Size(147, 20);
            this.log_user_tbox.TabIndex = 7;
            // 
            // log_pass_tbox
            // 
            this.log_pass_tbox.Location = new System.Drawing.Point(416, 62);
            this.log_pass_tbox.Name = "log_pass_tbox";
            this.log_pass_tbox.Size = new System.Drawing.Size(153, 20);
            this.log_pass_tbox.TabIndex = 8;
            this.log_pass_tbox.UseSystemPasswordChar = true;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lab.Location = new System.Drawing.Point(12, 65);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(50, 13);
            this.lab.TabIndex = 9;
            this.lab.Text = "Connect:";
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.titlelabel.Location = new System.Drawing.Point(175, 9);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(236, 24);
            this.titlelabel.TabIndex = 10;
            this.titlelabel.Text = "Welcome to Socialbook!";
            // 
            // user_signup_label
            // 
            this.user_signup_label.AutoSize = true;
            this.user_signup_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_signup_label.Location = new System.Drawing.Point(93, 168);
            this.user_signup_label.Name = "user_signup_label";
            this.user_signup_label.Size = new System.Drawing.Size(123, 16);
            this.user_signup_label.TabIndex = 11;
            this.user_signup_label.Text = "Type Username:";
            // 
            // pass_signuplabel
            // 
            this.pass_signuplabel.AutoSize = true;
            this.pass_signuplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_signuplabel.Location = new System.Drawing.Point(96, 205);
            this.pass_signuplabel.Name = "pass_signuplabel";
            this.pass_signuplabel.Size = new System.Drawing.Size(120, 16);
            this.pass_signuplabel.TabIndex = 13;
            this.pass_signuplabel.Text = "Type Password:";
            // 
            // sign_user_tbox
            // 
            this.sign_user_tbox.Location = new System.Drawing.Point(233, 167);
            this.sign_user_tbox.Name = "sign_user_tbox";
            this.sign_user_tbox.Size = new System.Drawing.Size(140, 20);
            this.sign_user_tbox.TabIndex = 14;
            // 
            // sign_pass_tbox
            // 
            this.sign_pass_tbox.Location = new System.Drawing.Point(233, 204);
            this.sign_pass_tbox.Name = "sign_pass_tbox";
            this.sign_pass_tbox.Size = new System.Drawing.Size(140, 20);
            this.sign_pass_tbox.TabIndex = 15;
            this.sign_pass_tbox.UseSystemPasswordChar = true;
            // 
            // sign_pass2_tbox
            // 
            this.sign_pass2_tbox.Location = new System.Drawing.Point(233, 237);
            this.sign_pass2_tbox.Name = "sign_pass2_tbox";
            this.sign_pass2_tbox.Size = new System.Drawing.Size(140, 20);
            this.sign_pass2_tbox.TabIndex = 17;
            this.sign_pass2_tbox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Retype Password:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(430, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sign_pass2_tbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sign_pass_tbox);
            this.Controls.Add(this.sign_user_tbox);
            this.Controls.Add(this.pass_signuplabel);
            this.Controls.Add(this.user_signup_label);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.log_pass_tbox);
            this.Controls.Add(this.log_user_tbox);
            this.Controls.Add(this.userlabel);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.signlabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label signlabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.TextBox log_user_tbox;
        private System.Windows.Forms.TextBox log_pass_tbox;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label user_signup_label;
        private System.Windows.Forms.Label pass_signuplabel;
        private System.Windows.Forms.TextBox sign_user_tbox;
        private System.Windows.Forms.TextBox sign_pass_tbox;
        private System.Windows.Forms.TextBox sign_pass2_tbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}