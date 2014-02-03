using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Baze_de_Date
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            post p = new post(panel1);
            post p1 = new post(panel1);
            init_perete();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 20)
            {
                textBox1.Height += 20;
                btn_post.Top+= 20;
            }
        }


        public void init_perete()
        {
            textBox1.Text = "scrie ceva";
            btn_post.Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text=="scrie ceva")
              textBox1.Text = "";
            btn_post.Visible = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            if (txt == "") 
                textBox1.Text="scrie ceva";
            btn_post.Hide();

        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            
        //    scriu statusul in baza de date
        }

    }

    public class post
    {
        TextBox txt;
        static int top = 110;
        int left = 60;
        public post(Panel p)
        {
            Label lbl = new Label();
            lbl.Name = "lbl2";
            lbl.Text = "A scris";
            lbl.Top = top - 25;
            lbl.Left = left;
            p.Controls.Add(lbl);
            txt = new TextBox();
            txt.Name = "textBox2";
            txt.Text = "helloo";
            txt.Top = top;
            txt.Width = 300;
            txt.Left = left;
            txt.ReadOnly = true;
            txt.TabStop = false;
            p.Controls.Add(txt) ;
            Label com = new Label();
            com.Name = "lbl2";
            com.Text = "Comenteaza:";
            com.Top = top + 25;
            com.Left = left;
            com.Width = 90;
            com.Font =new System.Drawing.Font( "Arial", 9,FontStyle.Bold);
            com.ForeColor = System.Drawing.Color.Blue;
            p.Controls.Add(com);
            Label like = new Label();
            like.Name = "lbl2";
            like.Text = "Imi place:";
            like.Top = top + 25;
            like.Font = new System.Drawing.Font("Arial", 9, FontStyle.Bold);
            like.ForeColor = System.Drawing.Color.Blue;
            like.Left = left+95;
            p.Controls.Add(like);
            top += 75;
            
        }
    };

}
