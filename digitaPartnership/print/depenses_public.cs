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

namespace digitaPartnership.print
{
    public partial class depenses_public : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-PCHL5NU\SQLEXPRESS;Initial Catalog=ActivitesSocialMedia ;Integrated Security=True");
        //SQLitConnection cnx = new SQLiteConnection(@"Data Source=" + Application.StartupPath + @"\mydatabase.db" + ";Verssion=3 ;New=False ;Compress=True");

        SqlCommand cmd = new SqlCommand();
        public depenses_public()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from DépensesPublicitaires", cnx);
            SqlDataAdapter dap2 = new SqlDataAdapter(cmd);
            DataSet1 ds2 = new DataSet1();
            dap2.Fill(ds2, "dp");
            MessageBox.Show(ds2.Tables["dp"].Rows.Count.ToString());
            CrystalReport1 crr = new CrystalReport1();
            crr.SetDataSource(ds2.Tables["dp"]);
            crystalReportViewer1.ReportSource = crr;
            crystalReportViewer1.Refresh();
        }

        private void depenses_public_Load(object sender, EventArgs e)
        {

        }
    }
}
