using digitaPartnership.printTheReport;
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
using CrystalDecisions.CrystalReports.Engine;
using digitaPartnership.print.DataSet1TableAdapters;
using System.Data.SQLite;

namespace digitaPartnership.print_the_report
{
    public partial class Form1 : Form
    {
        //SQLiteConnection cnx = new SQLiteConnection(@"Data Source=" + Application.StartupPath + @"\mydatabase.db" + ";Verssion=3 ;New=False ;Compress=True");

        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-PCHL5NU\SQLEXPRESS;Initial Catalog=ActivitesSocialMedia ;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //    SqlCommand cmdc = new SqlCommand("dbo.clientproc", cnx);
            //    SqlDataAdapter dapc = new SqlDataAdapter(cmdc);
            //    DataSet1 ds2 = new DataSet1();
            //    dapc.Fill(ds2, "c");
            //    //MessageBox.Show(ds2.Tables["c"].Rows.Count.ToString());
            //    CrystalReport1 crr = new CrystalReport1();
            //    crr.SetDataSource(ds2.Tables["c"]);
            //    crystalReportViewer1.ReportSource = crr;
            //    crystalReportViewer1.Refresh();

            //SqlCommand cmddp = new SqlCommand("select * from DépensesPublicitaires", cnx);
            //SqlDataAdapter dapdp = new SqlDataAdapter(cmddp);
            //DataSet1 dsdp = new DataSet1();
            //dapdp.Fill(dsdp, "dp");
            //// MessageBox.Show(dsdp.Tables["dp"].Rows.Count.ToString());
            //CrystalReport2 crrdp = new CrystalReport2();
            //crrdp.SetDataSource(dsdp.Tables["dp"]);
            //crystalReportViewer1.ReportSource = crrdp;
            //crystalReportViewer1.Refresh();

            //SqlCommand cmdip = new SqlCommand("dbo.IndicateursPerformanceproc", cnx);
            //SqlDataAdapter dapip = new SqlDataAdapter(cmdip);
            //DataSet1 dsip = new DataSet1();
            //dapip.Fill(dsip, "ip");
            //MessageBox.Show(dsip.Tables["ip"].Rows.Count.ToString());
            //CrystalReport1 crrip = new CrystalReport1();
            //crrip.SetDataSource(dsip.Tables["ip"]);
            //crystalReportViewer1.ReportSource = crrip;
            //crystalReportViewer1.Refresh();

            //SELECT Distinct client.* , DépensesPublicitaires.* FROM client , DépensesPublicitaires

            //SqlCommand cmdsm = new SqlCommand("SELECT top3.* FROM  top3 ", cnx);
            //SqlDataAdapter dapsm = new SqlDataAdapter(cmdsm);
            //DataSet2 dssm = new DataSet2();
            //dapsm.Fill(dssm, "sm");
            ////MessageBox.Show(dssm.Tables["sm"].Rows.Count.ToString());
            //CrystalReport4 crrsm = new CrystalReport4();
            //crrsm.SetDataSource(dssm.Tables["sm"]);
            //crystalReportViewer1.ReportSource = crrsm;
            //crystalReportViewer1.Refresh();

            //SqlCommand cmdt = new SqlCommand("select * from DépensesPublicitaires2", cnx);
            //SqlDataAdapter dapt = new SqlDataAdapter(cmdt);
            //DataSet1 dst = new DataSet1();
            //dapt.Fill(dst, "t");
            //MessageBox.Show(dst.Tables["t"].Rows.Count.ToString());
            //CrystalReport1 crrt = new CrystalReport1();
            //crr.SetDataSource(dst.Tables["t"]);
            //crystalReportViewer1.ReportSource = crrt;
            //crystalReportViewer1.Refresh();

            //SqlCommand cmdtop = new SqlCommand("select * from top3", cnx);
            //SqlDataAdapter daptop = new SqlDataAdapter(cmdtop);
            //DataSet1 dstop = new DataSet1();
            //daptop.Fill(dstop, "top");
            //MessageBox.Show(dstop.Tables["top"].Rows.Count.ToString());
            //CrystalReport1 crrtop = new CrystalReport1();
            //crrtop.SetDataSource(dstop.Tables["top"]);
            //crystalReportViewer1.ReportSource = crrtop;
            //crystalReportViewer1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmdc = new SqlCommand("select * from top3", cnx);
            SqlDataAdapter dapc = new SqlDataAdapter(cmdc);
            DataSet1 ds2 = new DataSet1();
            dapc.Fill(ds2, "top3");
            //MessageBox.Show(ds2.Tables["c"].Rows.Count.ToString());
            CrystalReport1 crr = new CrystalReport1();
            crr.SetDataSource(ds2.Tables["top3"]);
            crystalReportViewer1.ReportSource = crr;
            crystalReportViewer1.Refresh();



            //SqlCommand cmdip = new SqlCommand("select * from top3", cnx);
            //SqlDataAdapter dapip = new SqlDataAdapter(cmdip);
            //DataSet1 dsip = new DataSet1();
            //dapip.Fill(dsip, "ip");
            //MessageBox.Show(dsip.Tables["ip"].Rows.Count.ToString());
            //CrystalReport1 crrip = new CrystalReport1();
            //crr.SetDataSource(dsip.Tables["ip"]);
            //crystalReportViewer1.ReportSource = crr;
            //crystalReportViewer1.Refresh();





            //SqlCommand cmddp = new SqlCommand("select * from DépensesPublicitaires", cnx);
            //SqlDataAdapter dapdp = new SqlDataAdapter(cmddp);
            //DataSet1 dsdp = new DataSet1();
            //dapdp.Fill(dsdp, "dp");
            //// MessageBox.Show(dsdp.Tables["dp"].Rows.Count.ToString());
            //CrystalReport2 crrdp = new CrystalReport2();
            //crrdp.SetDataSource(dsdp.Tables["dp"]);
            //crystalReportViewer1.ReportSource = crrdp;
            //crystalReportViewer1.Refresh();


            //SqlCommand cmdt = new SqlCommand("select * from DépensesPublicitaires2", cnx);
            //SqlDataAdapter dapt = new SqlDataAdapter(cmdt);
            //DataSet1 dst = new DataSet1();
            //dapt.Fill(dst, "t");
            //MessageBox.Show(dst.Tables["t"].Rows.Count.ToString());
            //CrystalReport1 crrt = new CrystalReport1();
            //crr.SetDataSource(dst.Tables["t"]);
            //crystalReportViewer1.ReportSource = crrt;
            //crystalReportViewer1.Refresh();

            //SqlCommand cmdtop = new SqlCommand("select * from top3", cnx);
            //SqlDataAdapter daptop = new SqlDataAdapter(cmdtop);
            //DataSet1 dstop = new DataSet1();
            //daptop.Fill(dstop, "top");
            //MessageBox.Show(dstop.Tables["top"].Rows.Count.ToString());
            //CrystalReport1 crrtop = new CrystalReport1();
            //crrtop.SetDataSource(dstop.Tables["top"]);
            //crystalReportViewer1.ReportSource = crrtop;
            //crystalReportViewer1.Refresh();


        }
    }
}
