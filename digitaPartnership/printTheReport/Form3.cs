using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace digitaPartnership.printTheReport
{
    public partial class Form3 : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-PCHL5NU\SQLEXPRESS;Initial Catalog=ActivitesSocialMedia ;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        //SQLiteConnection cnx = new SQLiteConnection(@"Data Source=" + Application.StartupPath + @"\mydatabase.db" + ";Verssion=3 ;New=False ;Compress=True");

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            SqlCommand cmdsm = new SqlCommand("SELECT * FROM IndicateursPerformance", cnx);
            SqlDataAdapter dapsm = new SqlDataAdapter(cmdsm);
            DataSet1 dssm = new DataSet1();
            dapsm.Fill(dssm, "sm");
            //MessageBox.Show(dssm.Tables["sm"].Rows.Count.ToString());
            CrystalReport3 crrsm = new CrystalReport3();
            crrsm.SetDataSource(dssm.Tables["sm"]);
            crystalReportViewer1.ReportSource = crrsm;
            crystalReportViewer1.Refresh();
        }
    }
}
