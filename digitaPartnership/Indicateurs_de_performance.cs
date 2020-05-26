using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using digitaPartnership.print;
using System.Data.SqlClient;
using System.IO;
using System.Data.SQLite;

namespace digitaPartnership
{
    public partial class Indicateurs_de_performance : UserControl
    {
        //SQLiteConnection cnx = new SQLiteConnection(@"Data Source=" + Application.StartupPath + @"\mydatabase.db" + ";Verssion=3 ;New=False ;Compress=True");

        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-PCHL5NU\SQLEXPRESS;Initial Catalog=ActivitesSocialMedia ;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public Indicateurs_de_performance()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = o.FileName;
                textBox1.Text = o.FileName;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.ImageLocation = o.FileName;
                textBox2.Text = o.FileName;
            }


        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            cnx.Open();
            if(pictureBox1.Image != null && pictureBox4.Image != null)
            {
                cmd = new SqlCommand("insert into IndicateursPerformance values(@pic1,@pic2)", cnx);
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] pic1 = ms.ToArray();
                cmd.Parameters.AddWithValue("@pic1", pic1);

                MemoryStream ms2 = new MemoryStream();
                pictureBox4.Image.Save(ms2, pictureBox4.Image.RawFormat);
                byte[] pic2 = ms2.ToArray();
                cmd.Parameters.AddWithValue("@pic2", pic2);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Good");
            }else
            {
                MessageBox.Show("you should pick an image");
            }
           

            cnx.Close();
        }

        private void Indicateurs_de_performance_Load(object sender, EventArgs e)
        {

        }
    }
}
