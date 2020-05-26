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

namespace digitaPartnership
{
    public partial class propos : UserControl
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-PCHL5NU\SQLEXPRESS;Initial Catalog=ActivitesSocialMedia ;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public propos()
        {
            InitializeComponent();
        }

        void export_to_txt()
        {
            //string filename = null;
            using (SaveFileDialog ss = new SaveFileDialog() { Filter = "Text Doucuments | *.txt", ValidateNames = true })
            {
                //StreamWriter sw = new StreamWriter(ss.FileName);
                if (ss.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(ss.FileName))
                    {
                        //sw.Write("aaaaaaaaaaaaaaaaaa");
                        sw.WriteLine("Propositions actions social marketing");
                        sw.WriteLine("\n\t");

                        sw.WriteLineAsync(bunifuDatepicker1.Value.ToString());
                        sw.WriteLineAsync(TxtRaisonSocial.Text);
                        sw.WriteLineAsync(richTextBox1.Text);
                        
                        MessageBox.Show("Added");
                    }
                }
            }
        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            cnx.Open();
            if(TxtRaisonSocial.Text != "" && richTextBox1.Text != "")
            {
                SqlCommand cmd2 = new SqlCommand("insert into propos values(@da,@t,@de)", cnx);


                cmd2.Parameters.AddWithValue("@da", bunifuDatepicker1.Value);
                cmd2.Parameters.AddWithValue("@t", TxtRaisonSocial.Text);
                cmd2.Parameters.AddWithValue("@de", richTextBox1.Text);


                cmd2.ExecuteNonQuery();

                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("Remplir tout les champs ");
            }
            

            cnx.Close();


          //  export_to_txt();



        }
        }
    }


