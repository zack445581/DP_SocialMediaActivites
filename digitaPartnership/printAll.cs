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
using digitaPartnership.print_the_report;
using digitaPartnership.printTheReport;
using System.Data.SQLite;

namespace digitaPartnership
{
    public partial class printAll : UserControl
    {
        //SQLiteConnection cnx = new SQLiteConnection(@"Data Source=" + Application.StartupPath + @"\mydatabase.db" + ";Verssion=3 ;New=False ;Compress=True");

        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-PCHL5NU\SQLEXPRESS;Initial Catalog=ActivitesSocialMedia ;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public printAll()
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

        void fill_DGV2()
        {
            cnx.Open();

            cmd = new SqlCommand("select * from DépensesPublicitaires2", cnx);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridView3.DataSource = dt;

            cnx.Close();
        }

        public string calculateDepenses()
        {
            double calc = 0;
           

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                
                    try
                    {
                        calc = calc + double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                        //calc2 = calc + double.Parse(dataGridView3.Rows[j].Cells[5].Value.ToString());
                    }
                    catch
                    {
                        label4.Text = "something's worng";
                    }
            }
           
            //MessageBox.Show(calc.ToString());
            //MessageBox.Show(calc2.ToString());
            return label4.Text = Convert.ToString(calc+2469);
        }

        private void printAll_Load(object sender, EventArgs e)
        {

            bunifuCards1.Visible = true;
            bunifuCards2.Visible = false;
            bunifuCards4.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox1.Visible = true;
            pictureBox4.Visible = false;
            //fill_combox();
            fill_DGV();
            fill_DGV2();
            calculateDepenses();

            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView3.Columns[6].Visible = false;

            cnx.Open();
            cmd = new SqlCommand("select c.raisonSociale, reaction ,DATENAME(month, datee) from top3 ,client c where c.id = idc and idsm=1 order by reaction desc ", cnx);

            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            dataGridView2.DataSource = dt;

            cnx.Close();
        }
        
       

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            //Form1 f = new Form1();
            //f.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cnx.Open();
            //cmd = new SqlCommand("select datepart(month , t.datee),idc,idsm,s.id,s.name,c.id from top3 t, client c,SocialMedia s where idc=c.id and idsm=s.id and c.id=" + comboBox1.SelectedValue, cnx);

            //SqlDataAdapter dap = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //dap.Fill(dt);

            //dataGridView2.DataSource = dt;


            //cnx.Close();

            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //Form1 f = new Form1();
            //f.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            //f2.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            //Form3 f3 = new Form3();
            //f3.Show();
        }

        private void Facebook_CheckedChanged(object sender, EventArgs e)
        {
            if (Facebook.Checked)
            {
                cmd = new SqlCommand("select c.raisonSociale, reaction, DATENAME(month, datee) from top3 ,client c where c.id = idc and idsm=1 order by reaction desc ", cnx);

                SqlDataAdapter dap1 = new SqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                dap1.Fill(dt1);


                dataGridView2.DataSource = dt1;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cmd = new SqlCommand("select c.raisonSociale, reaction ,DATENAME(month, datee) from top3 ,client c where c.id = idc and idsm=2 order by reaction desc ", cnx);

                SqlDataAdapter dap2 = new SqlDataAdapter(cmd);
                DataTable dt2 = new DataTable();
                dap2.Fill(dt2);

                //listView1.Items.Add(dt.ToString());
                dataGridView2.DataSource = dt2;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bunifuCards1.Visible = false;
            bunifuCards2.Visible = true;
            bunifuCards4.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox1.Visible = false;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            bunifuCards1.Visible = false;
            bunifuCards2.Visible = false;
            bunifuCards4.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bunifuCards1.Visible = false;
            bunifuCards2.Visible = true;
            bunifuCards4.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox1.Visible = false;
            pictureBox4.Visible = true;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            bunifuCards1.Visible = true;
            bunifuCards2.Visible = false;
            bunifuCards4.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox1.Visible = true;
            pictureBox4.Visible = false;

        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {

            cnx.Open();
            cmd = new SqlCommand("select * from propos where datep ='" + bunifuDatepicker2.Value + "'", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                bunifuMetroTextbox1.Text = dr[2].ToString();
                richTextBox2.Text = dr[3].ToString();
            }
            cnx.Close();
        }
    }
}




//SqlDataReader dr = cmd.ExecuteReader();
//while (dr.Read())
//{
//    dataGridView2.Rows.Add(dr[5].ToString(), dr[4].ToString(), dr[0].ToString());
//}

//  cmd = new SqlCommand("select DISTINCT c.raisonSociale , DATENAME(month, t.datee) from top3 t , client c where t.datee = " + comboBox1.SelectedValue, cnx);
// cmd.Parameters.AddWithValue("@id", comboBox1.SelectedValue);
//  cmd = new SqlCommand("select * from client where raisonSociale='" + comboBox1.Text + "'", cnx); c.raisonSociale
