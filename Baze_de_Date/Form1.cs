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

   

    public partial class Form1 : Form
    {

        private Login var;
        string username_param;

        public Form1(Login login, string user)
        {
            var = login;
            username_param = user; // username param va fi dat mai departe ca parametru pt a accesa valorile userului din tabele
            

            InitializeComponent();
            label2.Text = username_param;
            post p = new post(panel1);
        //    post p1 = new post(panel1);
            post1 a = new post1(panel1);
            post b = new post(panel1);
            //init_perete();
        }


        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    if (textBox1.Text.Length > 20)
        //    {
        //        textBox1.Height += 20;
        //        btn_post.Top+= 20;
        //    }
        //}


        //public void init_perete()
        //{
        //    textBox1.Text = "scrie ceva";
        //    btn_post.Hide();
        //}

        //private void textBox1_Enter(object sender, EventArgs e)
        //{
        //    if(textBox1.Text=="scrie ceva")
        //      textBox1.Text = "";
        //    btn_post.Visible = true;
        //}

        //private void textBox1_Leave(object sender, EventArgs e)
        //{
        //    string txt = textBox1.Text;
        //    if (txt == "") 
        //        textBox1.Text="scrie ceva";
        //    btn_post.Hide();

        //}

        private void btn_post_Click(object sender, EventArgs e)
        {
            
        //    scriu statusul in baza de date
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            DMA_BusinessLayerClass b = new DMA_BusinessLayerClass();
            DataTable dt = b.About(label2.Text);
            if (dt.Rows.Count > 0)
            {
                label3.Text = dt.Rows[0][1].ToString().Trim();
                label4.Text = dt.Rows[0][2].ToString().Trim();
                label7.Text = dt.Rows[0][3].ToString().Trim();
                label8.Text = dt.Rows[0][4].ToString().Trim();
                label9.Text = dt.Rows[0][5].ToString().Trim();
                label10.Text = dt.Rows[0][6].ToString().Trim();

                panel_about.Visible = true;
            }
            else
                MessageBox.Show("Eroare deschidere About!");
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            panel_about.Visible = false;
        }

       

    };
    
    public class antet
    {   
        PictureBox coperta;
        PictureBox profil;
       public antet(){
    //       coperta;
           
       }
    }

    public class post1{
        TextBox  txt;
        Label lbl;
        int top = 150;
        int left = 200;
        Button btn;
        public post1(Panel p)
        {
            btn = new Button();
            btn.Name = "posteaza";
            btn.Text = "posteaza";
            btn.Top = top + 20;
            btn.Left = left + 200;
            p.Controls.Add(btn);
            lbl = new Label();
            lbl.Name = "lbl2";
            lbl.Text = "Scrie pe perete";
            lbl.Top = top - 25;
            lbl.Left = left;
            lbl.Font = new System.Drawing.Font("Arial", 9, FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.Blue;
            p.Controls.Add(lbl);
            txt = new TextBox();
            txt.Name = "textBox2";
            txt.Text = "Scrie ceva";
            txt.Top = top;
            txt.Width = 300;
            txt.Left = left;
            txt.TabStop = false;
            p.Controls.Add(txt);
        }

    };

    public class post
    {
        TextBox txt;
        Label lbl;
        Label com;
        Label like;
        static int top = 260;
        int left = 200;
        public post(Panel p)
        {
             lbl = new Label();
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
            com = new Label();
            com.Name = "lbl2";
            com.Text = "Comenteaza:";
            com.Top = top + 25;
            com.Left = left;
            com.Width = 90;
            com.Font =new System.Drawing.Font( "Arial", 9,FontStyle.Bold);
            com.ForeColor = System.Drawing.Color.Blue;
            p.Controls.Add(com);
            like = new Label();
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
