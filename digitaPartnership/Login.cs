using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace digitaPartnership
{
    public partial class Login : Form
    {
        //DESKTOP-PCHL5NU\SQLEXPRESS;Initial Catalog=ActivitesSocialMedia ;Integrated Security=True
        // SQLiteConnection cnx = new SQLiteConnection(@"Data Source="+Application.StartupPath+ @"\mydatabase.db" + ";Verssion=3 ;New=False ;Compress=True");

        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-PCHL5NU\SQLEXPRESS;Initial Catalog=ActivitesSocialMedia ;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();
        

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
               

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;

            bunifuThinButton25.Parent = pictureBox1;
            bunifuThinButton25.BackColor = Color.Transparent;

            //pictureBox1.Parent = pictureBox1;
            //pictureBox1.BackColor = Color.Transparent;
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click_1(object sender, EventArgs e)
        {
            cnx.Open();
            if (bunifuMetroTextbox1.Text != "" && bunifuMetroTextbox2.Text != "")
            {
                cmd = new SqlCommand("select * from Userr where email='" + bunifuMetroTextbox1.Text + "' and pass=" + bunifuMetroTextbox2.Text, cnx);

                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                //MessageBox.Show(dt.Rows[0][0].ToString());
                if (dt.Rows.Count != 0)
                {

                    DashboardUserr dbu = new DashboardUserr();
                    dbu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email or Password incorrect");
                }
            }
            else
            {
                MessageBox.Show("pls fill the txtbox");
            }

            cnx.Close();
        }
    }
}
