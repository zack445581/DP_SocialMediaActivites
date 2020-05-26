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
using System.Data.SQLite;

namespace digitaPartnership
{
    public partial class gestion : UserControl
    {
        //SQLiteConnection cnx = new SQLiteConnection(@"Data Source=" + Application.StartupPath + @"\mydatabase.db" + ";Verssion=3 ;New=False ;Compress=True");

        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-PCHL5NU\SQLEXPRESS;Initial Catalog=ActivitesSocialMedia ;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public gestion()
        {
            InitializeComponent();
        }


        void fill_combox()
        {
            cmd = new SqlCommand("select * from Client", cnx);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "raisonSociale";
            comboBox1.ValueMember = "id";
        }

        void fill_SocialMedia_combox()
        {
            cmd = new SqlCommand("select * from SocialMedia", cnx);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "id";
        }

        private void gestion_Load(object sender, EventArgs e)
        {
            fill_combox();
            fill_SocialMedia_combox();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("select * from client where raisonSociale='" + comboBox1.Text + "'", cnx);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                byte[] img = (byte[])(dr[1]);
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
            cnx.Close();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("insert into top3 values(@d ,@pa, @ia, @ra, @c, @p, @id ,@sm)", cnx);
            cmd.Parameters.AddWithValue("@d", bunifuDatepicker1.Value);
            cmd.Parameters.AddWithValue("@pa", bunifuMetroTextbox1.Text);
            cmd.Parameters.AddWithValue("@ia", bunifuMetroTextbox2.Text);
            cmd.Parameters.AddWithValue("@ra", bunifuMetroTextbox3.Text);
            cmd.Parameters.AddWithValue("@c", bunifuMetroTextbox4.Text);
            cmd.Parameters.AddWithValue("@p", bunifuMetroTextbox5.Text);
            cmd.Parameters.AddWithValue("@id", comboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@sm", comboBox2.SelectedValue);

            cmd.ExecuteNonQuery();
            MessageBox.Show("added");

            cnx.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
