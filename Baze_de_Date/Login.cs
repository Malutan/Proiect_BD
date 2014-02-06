using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baze_de_Date.DMA_BusinessLayer;

namespace Baze_de_Date
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void passlabel_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button1.Visible = true;
                sign_pass_tbox.Visible = true;
                sign_pass2_tbox.Visible = true;
                sign_user_tbox.Visible = true;
                pass_signuplabel.Visible = true;
                pass2_signuplabel.Visible = true;
                user_signup_label.Visible = true;

            }
            else
            {
                
                button1.Visible = false;
                sign_pass_tbox.Visible = false;
                sign_pass2_tbox.Visible = false;
                sign_user_tbox.Visible = false;
                pass_signuplabel.Visible = false;
                pass2_signuplabel.Visible = false;
                user_signup_label.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            DMA_BusinessLayerClass b = new DMA_BusinessLayerClass();
            bool ok = b.LoginUser(log_user_tbox.Text, log_pass_tbox.Text);
            if (ok)
            {
                var main = new Form1();
                this.Hide();
                main.Show();
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DMA_BusinessLayerClass b = new DMA_BusinessLayerClass();
            b.AddNewAccount_BL(sign_user_tbox.Text, sign_pass_tbox.Text, sign_pass2_tbox.Text);
        }
    }
}
