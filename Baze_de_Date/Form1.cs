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

        private Login var;
        string username_param;

        public Form1(Login login, string user)
        {
            var = login;
            username_param = user; // username param va fi dat mai departe ca parametru pt a accesa valorile userului din tabele

            InitializeComponent();
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

    };
    
    public class antet
    {   //adaugata de mihai pt testare commit
        int mihai = 0;
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
