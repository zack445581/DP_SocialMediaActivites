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
using System.Data.SQLite;

namespace digitaPartnership
{
    public partial class Dépenses_publicitaires_2 : UserControl
    {
        //SQLiteConnection cnx = new SQLiteConnection(@"Data Source=" + Application.StartupPath + @"\mydatabase.db" + ";Verssion=3 ;New=False ;Compress=True");

         SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-PCHL5NU\SQLEXPRESS;Initial Catalog=ActivitesSocialMedia ;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        Dépenses_publicitaires t = new Dépenses_publicitaires();

        public Dépenses_publicitaires_2()
        {
            InitializeComponent();
        }

        void fill_DGV()
        {
            cnx.Open();

            cmd = new SqlCommand("select * from DépensesPublicitaires2", cnx);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridView1.DataSource = dt;

            cnx.Close();
        }

        public string calculateDepenses()
        {
            double calc =0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    calc = calc + double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                }
                catch
                {

                    label6.Text = "something's worng";
                }

                //label6.Text = calc.ToString();

            }
            return label6.Text = calc.ToString();
        }

        
        void toto_value()
        {
            cmd = new SqlCommand("select * from DépensesPublicitaires", cnx);

        }


        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            cnx.Open();
            if (bunifuMetroTextbox1.Text != "" && bunifuMetroTextbox2.Text != "" && bunifuMetroTextbox3.Text != "" && bunifuMetroTextbox4.Text != "" && bunifuMetroTextbox5.Text != "" && bunifuMetroTextbox6.Text != "")
            {
               
               
                cmd = new SqlCommand("insert into DépensesPublicitaires2 values(@c,@r,@p,@i,@cpr,@d,@t)", cnx);
                cmd.Parameters.AddWithValue("@c", bunifuMetroTextbox1.Text);
                cmd.Parameters.AddWithValue("@r", bunifuMetroTextbox2.Text);
                cmd.Parameters.AddWithValue("@p", bunifuMetroTextbox3.Text);
                cmd.Parameters.AddWithValue("@i", bunifuMetroTextbox4.Text);
                cmd.Parameters.AddWithValue("@cpr", bunifuMetroTextbox5.Text);
                cmd.Parameters.AddWithValue("@d", bunifuMetroTextbox6.Text);
                cmd.Parameters.AddWithValue("@t", label6.Text);

                
                cmd.ExecuteNonQuery();
                MessageBox.Show("added");
                cnx.Close();
                fill_DGV();
                calculateDepenses();
            }
            else
            {
                MessageBox.Show("fill the txtbox");
            }
        }

        private void Dépenses_publicitaires_2_Load(object sender, EventArgs e)
        {
            
            fill_DGV();
            calculateDepenses();

            dataGridView1.Columns[6].Visible = false;
           // MessageBox.Show(t.calculateDepenses1() + calculateDepenses());
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }
    }
}
