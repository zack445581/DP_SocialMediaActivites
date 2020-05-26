using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using digitaPartnership;
using System.Data.SQLite;

namespace digitaPartnership
{
    public partial class GestionActivites : UserControl
    {
        //SQLiteConnection cnx = new SQLiteConnection(@"Data Source=" + Application.StartupPath + @"\mydatabase.db" + ";Verssion=3 ;New=False ;Compress=True");

        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-PCHL5NU\SQLEXPRESS;Initial Catalog=ActivitesSocialMedia ;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        Dépenses_publicitaires t = new Dépenses_publicitaires();


        public GestionActivites()
        {
            InitializeComponent();
        }

       //void fill_combox()
       // {
       //     //comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
       //     cmd = new SqlCommand("select * from Client", cnx);
       //     SqlDataAdapter dap = new SqlDataAdapter(cmd);
       //     DataTable dt = new DataTable();
       //     dap.Fill(dt);
       //     comboBox1.DataSource = dt;
       //     comboBox1.DisplayMember = "raisonSociale";
       //     comboBox1.ValueMember = "raisonSociale";
       //     //comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
       // }

        //void fill_SocialMedia_combox()
        //{
        //    cnx.Open();
        //    cmd = new SqlCommand("select * from SocialMedia", cnx);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        comboBox2.Items.Add(dr[1].ToString());
        //    }
        //    cnx.Close();
        //}

        private void GestionActivites_Load(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            gestion g = new gestion();
            g.Parent = panel2;


            //fill_SocialMedia_combox();
            //fill_combox();
            //panel1.Visible = false;

            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx.Open();
        //    cmd = new SqlCommand("select * from client where raisonSociale='" + comboBox1.Text + "'", cnx);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                byte[] img = (byte[])(dr[1]);
                MemoryStream ms = new MemoryStream(img);
              //  pictureBox1.Image = Image.FromStream(ms);
            }


            //cmd = new SqlCommand("select from DoctorSpeciality", cnx);
            //SqlDataAdapter dap = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //dap.Fill(dt);
            //comboBox1.DataSource = dt;
            //comboBox1.DisplayMember = "NameSP";
            //comboBox1.ValueMember = "IDsp";
            cnx.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cnx.Open();
            //cmd = new SqlCommand("select * from client where id=" + bunifuMetroTextbox1.Text, cnx);
            //SqlDataReader dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    byte[] img = (byte[])(dr[1]);
            //    MemoryStream ms = new MemoryStream(img);
            //    pictureBox1.Image = Image.FromStream(ms);
            //}
            //cnx.Close();
        }

    

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            gestion g = new gestion();
            g.Parent = panel2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;

            panel2.Controls.Clear();
            Dépenses_publicitaires dp = new Dépenses_publicitaires();
            dp.Parent = panel2;

            bunifuThinButton21.ButtonText = "Dépenses publicitaires";
            bunifuThinButton21.Width = 202;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;


            bunifuThinButton21.ButtonText = "Indicateurs de performance";
            bunifuThinButton21.Width = 236;

            panel2.Controls.Clear();
            Indicateurs_de_performance idp = new Indicateurs_de_performance();
            idp.Parent = panel2;
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;



            panel2.Controls.Clear();
            Dépenses_publicitaires dp = new Dépenses_publicitaires();
            dp.Parent = panel2;

            bunifuThinButton21.ButtonText = "Dépenses publicitaires";
            bunifuThinButton21.Width = 202;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;



            panel2.Controls.Clear();
            gestion g = new gestion();
            g.Parent = panel2;

            bunifuThinButton21.ButtonText = "Gestion";
            bunifuThinButton21.Width = 202;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;//
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;//
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;


          //  MessageBox.Show(" "+t.toto.Text);
            panel2.Controls.Clear();
            Dépenses_publicitaires_2 dp2 = new Dépenses_publicitaires_2();
            dp2.Parent = panel2;

            //bunifuThinButton21.ButtonText = "Gestion";
            //bunifuThinButton21.Width = 202;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;//
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;//
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;

            panel2.Controls.Clear();
            Dépenses_publicitaires dp = new Dépenses_publicitaires();
            dp.Parent = panel2;
        }
    }
}
