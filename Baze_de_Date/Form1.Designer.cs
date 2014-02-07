namespace Baze_de_Date
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pan_friends = new System.Windows.Forms.Panel();
            this.pan_info = new System.Windows.Forms.Panel();
            this.pan_antet = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pan_friends);
            this.panel1.Controls.Add(this.pan_info);
            this.panel1.Controls.Add(this.pan_antet);
            this.panel1.Location = new System.Drawing.Point(119, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 781);
            this.panel1.TabIndex = 0;
            // 
            // pan_friends
            // 
            this.pan_friends.Location = new System.Drawing.Point(4, 460);
            this.pan_friends.Name = "pan_friends";
            this.pan_friends.Size = new System.Drawing.Size(208, 207);
            this.pan_friends.TabIndex = 2;
            // 
            // pan_info
            // 
            this.pan_info.Location = new System.Drawing.Point(4, 247);
            this.pan_info.Name = "pan_info";
            this.pan_info.Size = new System.Drawing.Size(200, 207);
            this.pan_info.TabIndex = 1;
            // 
            // pan_antet
            // 
            this.pan_antet.Location = new System.Drawing.Point(0, 0);
            this.pan_antet.Name = "pan_antet";
            this.pan_antet.Size = new System.Drawing.Size(571, 190);
            this.pan_antet.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 750);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pan_friends;
        private System.Windows.Forms.Panel pan_info;
        private System.Windows.Forms.Panel pan_antet;

    }
}

