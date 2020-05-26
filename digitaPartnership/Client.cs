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
    public partial class Client : UserControl
    {
        //SQLiteConnection cnx = new SQLiteConnection(@"Data Source=" + Application.StartupPath + @"\mydatabase.db" + ";Verssion=3 ;New=False ;Compress=True");

        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-PCHL5NU\SQLEXPRESS;Initial Catalog=ActivitesSocialMedia ;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();


        public Client()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)

        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = o.FileName;
            }
        }

        //Btn Enregister
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            cnx.Open();

            if (TxtRaisonSocial.Text != "" && TxtNumTele.Text != "" && TxtAdress.Text != "")
            {
                if (pictureBox1.Image == null)
                {
                    SqlCommand cmd1 = new SqlCommand(@"INSERT INTO client(picClient ,raisonSociale,numTele,dateDebut,adress) SELECT BulkColumn , @rs,@n,@d,@a FROM Openrowset( Bulk 'C:\Users\ZAKARIA\Desktop\Activities Social Media\no-image-icon-4.png', Single_Blob) as defaultimg", cnx);

                    cmd1.Parameters.AddWithValue("@rs", TxtRaisonSocial.Text);
                    cmd1.Parameters.AddWithValue("@n", TxtNumTele.Text);
                    cmd1.Parameters.AddWithValue("@d", DateDebut.Value);
                    cmd1.Parameters.AddWithValue("@a", TxtAdress.Text);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Deafult img added");
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("insert into client values(@img,@rs,@n,@a,@d)", cnx);
                    
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    cmd2.Parameters.AddWithValue("@img", img);
                    cmd2.Parameters.AddWithValue("@rs", TxtRaisonSocial.Text);
                    cmd2.Parameters.AddWithValue("@n", int.Parse(TxtNumTele.Text));
                    cmd2.Parameters.AddWithValue("@d", Convert.ToDateTime(DateDebut.Value));
                    cmd2.Parameters.AddWithValue("@a", TxtAdress.Text);

                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Added with pic");
                }
                

               
            }
            else
            {
                MessageBox.Show("Remplir tous les champs !");
            }
            
            cnx.Close();
        }
        
        //disable characters
        private void TxtNumTele_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }




    }
}
