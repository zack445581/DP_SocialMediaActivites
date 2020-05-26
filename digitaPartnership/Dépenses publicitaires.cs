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
using digitaPartnership.print;
using System.Data.SQLite;

namespace digitaPartnership
{
    public partial class Dépenses_publicitaires : UserControl
    {
        //SQLiteConnection cnx = new SQLiteConnection(@"Data Source=" + Application.StartupPath + @"\mydatabase.db" + ";Verssion=3 ;New=False ;Compress=True");

       SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-PCHL5NU\SQLEXPRESS;Initial Catalog=ActivitesSocialMedia ;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        string l;
        public Dépenses_publicitaires()
        {
            InitializeComponent();
        }

        void fill_DGV()
        {
            cnx.Open();

            cmd = new SqlCommand("select * from DépensesPublicitaires", cnx);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridView1.DataSource = dt;

            cnx.Close();
        }

         public string calculateDepenses1()
        {
            double calc = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    calc = calc + double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
                catch
                {
                    toto.Text = "something's worng";
                }
               
                //label6.Text = calc.ToString();
                
            }
            return toto.Text = calc.ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            depenses_public cr = new depenses_public();
            cr.Show();
        }

        private void Dépenses_publicitaires_Load(object sender, EventArgs e)
        {
            fill_DGV();
            calculateDepenses1();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[0].Visible = false;

            //MessageBox.Show(l);

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            cnx.Open();
            if (bunifuMetroTextbox1.Text != "" && bunifuMetroTextbox2.Text != "" && bunifuMetroTextbox3.Text != "" && bunifuMetroTextbox4.Text != "")
            {
                //string i = label6.Text;
                cmd = new SqlCommand("insert into DépensesPublicitaires values(@c,@pa,@i,@d,@t)", cnx);
                cmd.Parameters.AddWithValue("@c", bunifuMetroTextbox1.Text);
                cmd.Parameters.AddWithValue("@pa", bunifuMetroTextbox2.Text);
                cmd.Parameters.AddWithValue("@i", bunifuMetroTextbox3.Text);
                cmd.Parameters.AddWithValue("@d", bunifuMetroTextbox4.Text);
                cmd.Parameters.AddWithValue("@t", toto.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("added");
                cnx.Close();
                fill_DGV();
                calculateDepenses1();
            }
            else
            {
                MessageBox.Show("fill the txtbox");
            }
            
        }
    }
}
