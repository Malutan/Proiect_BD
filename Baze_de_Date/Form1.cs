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
            antet ant = new antet(pan_antet);
            info inf= new info(pan_info);
            //init_perete();
            prieteni priet=new prieteni(pan_friends);
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
    
  

    public class post1{
        TextBox  txt;
        Label lbl;
        int top = 240;
        int left = 230;
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


    public class antet
    {
        PictureBox coperta;
        PictureBox profil;
        GroupBox butoane;
        public antet(Panel p)
        {
            //       profil;
            profil = new PictureBox();
            profil.Width = 120;
            profil.Height = 120;
            profil.BringToFront();
            profil.Top = 60;
            profil.Left = 20;
            profil.BorderStyle = BorderStyle.Fixed3D;
            profil.BackColor = System.Drawing.Color.Black;
            profil.ImageLocation = @"..\..\imagini\profil1.jpg";
            p.Controls.Add(profil);

            //coperta
            coperta = new PictureBox();
            coperta.Width = 600;
            coperta.Height = 160;
            coperta.BackColor = System.Drawing.Color.Violet;
            coperta.ImageLocation = @"..\..\imagini\cover1.jpg";
            coperta.SendToBack();
            p.Controls.Add(coperta);

            butoane = new GroupBox();
            butoane.BackColor = System.Drawing.Color.AntiqueWhite;
            butoane.Top = 150;
            butoane.Width = 600;
            butoane.Height = 50;

            Label timeline = new Label();
            timeline.Text = "Timeline";
            timeline.Top = 165;
            timeline.Width = 65;
            timeline.Left = 200;
            timeline.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            timeline.ForeColor = System.Drawing.Color.Black;
            timeline.BackColor = System.Drawing.Color.AntiqueWhite;


            Label about = new Label();
            about.Text = "Despre";
            about.Top = 165;
            about.Left = 200;
            about.Width = 60;
            about.Left = 270;
            about.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            about.ForeColor = System.Drawing.Color.Black;
            about.BackColor = System.Drawing.Color.AntiqueWhite;

            p.Controls.Add(timeline);
            p.Controls.Add(about);
            p.Controls.Add(butoane);



        }
    }
    public class info
    {
        Label studii;
        Label oras;
        Label din;
        Label nume;
        int top = 35;

        public info(Panel p)
        {
            nume = new Label();

            nume.Name = "lbl2";
            nume.Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
            nume.Text = "Despre";
      

            p.Controls.Add(nume);

            studii = new Label();
            
            studii.Name = "lbl2";
            studii.Font = new System.Drawing.Font("Arial", 9, FontStyle.Bold);
            studii.Text = "A studiat la...";
            studii.Top = top ;
         
            p.Controls.Add(studii);
            oras = new Label();
            oras.Text = "Locuieste in...";
            oras.Top=top+35;
            oras.Font = new System.Drawing.Font("Arial", 9, FontStyle.Bold);
            din = new Label();
            din.Text = "Din..";
            din.Top=top+70;
            din.Font = new System.Drawing.Font("Arial", 9, FontStyle.Bold);
            p.Controls.Add(oras);
            p.Controls.Add(din);

        }
    }

    public class prieteni
    {

        Label nume;
        PictureBox []pic= new PictureBox[6];

        public prieteni(Panel p)
        {

            for (int i = 0; i < 6; i++)
            {
                pic[i] = new PictureBox();
                pic[i].Width = 60;
                pic[i].Height = 60;
                pic[i].Left = (i%3) * 60+5;
                pic[i].Top = (i / 3) * 60+40;
                pic[i].ImageLocation = @"..\..\imagini\cover1.jpg";
                p.Controls.Add(pic[i]);

            }
            nume = new Label();
            nume.Name = "lbl2";
            nume.Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
            nume.Text = "Prieteni";

            p.Controls.Add(nume);

        }
    }

    public class post
    {
        TextBox txt;
        Label lbl;
        Label com;
        Label like;
        static int top = 300;
        int left = 230;
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
