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
    public partial class SocialMedia : UserControl
    {
        //SQLiteConnection cnx = new SQLiteConnection(@"Data Source=" + Application.StartupPath + @"\mydatabase.db" + ";Verssion=3 ;New=False ;Compress=True");

        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-PCHL5NU\SQLEXPRESS;Initial Catalog=ActivitesSocialMedia ;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public SocialMedia()
        {
            InitializeComponent();
        }


        //void SocialMediaExist()
        //{
        //    cnx.Open();
        //    MessageBox.Show("1");
        //    cmd = new SqlCommand("select * from SocialMedia",cnx);
        //    SqlDataAdapter dap = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    dap.Fill(dt);


            //switch (twitter.Name)
            //{
            //    case "facebook":
            //        label1.Text = textBox1.Text;
            //        pictureBox1.Image = pictureBox7.Image;
            //        facebook.BackColor = Color.FromArgb(66, 103, 178);
            //        break;
            //    case "twitter":
            //        label1.Text = textBox1.Text;
            //        pictureBox2.Image = pictureBox7.Image;
            //        twitter.BackColor = Color.FromArgb(30, 161, 243);
            //        break;
            //    case "instagram":
            //        label1.Text = textBox1.Text;
            //        pictureBox3.Image = pictureBox7.Image;
            //        instagram.BackColor = Color.MediumPurple;
            //        break;
            //}


        //    cnx.Close();
        //}

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if(groupBox1.Visible == false)
            {
                groupBox1.Visible = true;
            }
        }

        private void SocialMedia_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            //  SocialMediaExist();
            cnx.Open();
            cmd = new SqlCommand("select * from SocialMedia", cnx);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);

           

            //try
            //{
                if (pictureBox1.Image == null)
                {
                    if (dt.Rows.Count == 0)
                    {
                        //MessageBox.Show("im empty");
                    }
                    else
                    {
                        switch (pictureBox1.Name)
                        {
                            case "pictureBox1":
                                byte[] image = (byte[])(dt.Rows[0][2]);
                                MemoryStream ms = new MemoryStream(image);
                                pictureBox1.Image = Image.FromStream(ms);
                                break;
                        }
                    }

                //    if (dt.Rows.Count != 0)
                //    {

                //}
                //else
                //{
                //    switch (pictureBox2.Name)
                //    {
                //        case "pictureBox2":
                //            byte[] image = (byte[])(dt.Rows[1][2]);
                //            MemoryStream ms = new MemoryStream(image);
                //            pictureBox2.Image = Image.FromStream(ms);
                //            break;
                //    }
                //}

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i != 1)
                    {
                        tst_insert();
                    }
                    else
                    {
                        switch (pictureBox2.Name)
                        {
                            case "pictureBox2":
                                byte[] image = (byte[])(dt.Rows[1][2]);
                                MemoryStream ms = new MemoryStream(image);
                                pictureBox2.Image = Image.FromStream(ms);
                                break;
                        }

                    }
                }



                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i != 2)
                    {
                        tst_insert3();
                    }
                    else
                    {
                        switch (pictureBox3.Name)
                        {
                            case "pictureBox3":
                                byte[] image = (byte[])(dt.Rows[2][2]);
                                MemoryStream ms = new MemoryStream(image);
                                pictureBox3.Image = Image.FromStream(ms);
                                break;
                        }

                    }
                }


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (i != 3)
                        {
                            tst_insert4();
                        }
                        else
                        {
                            switch (pictureBox4.Name)
                            {
                                case "pictureBox4":
                                    byte[] image = (byte[])(dt.Rows[3][2]);
                                    MemoryStream ms = new MemoryStream(image);
                                    pictureBox4.Image = Image.FromStream(ms);
                                    break;
                            }

                        }
                    }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i != 4)
                    {
                        tst_insert5();
                    }
                    else
                    {
                        switch (pictureBox5.Name)
                        {
                            case "pictureBox5":
                                byte[] image = (byte[])(dt.Rows[4][2]);
                                MemoryStream ms = new MemoryStream(image);
                                pictureBox5.Image = Image.FromStream(ms);
                                break;
                        }

                    }
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i != 5)
                    {
                        tst_insert6();
                    }
                    else
                    {
                        switch (pictureBox6.Name)
                        {
                            case "pictureBox6":
                                byte[] image = (byte[])(dt.Rows[5][2]);
                                MemoryStream ms = new MemoryStream(image);
                                pictureBox6.Image = Image.FromStream(ms);
                                break;
                        }

                    }
                }
                //    if (dt.Rows.Count != 2)
                //    {

                //    switch (pictureBox3.Name)
                //    {
                //        case "pictureBox3":
                //            byte[] image = (byte[])(dt.Rows[2][2]);
                //            MemoryStream ms = new MemoryStream(image);
                //            pictureBox3.Image = Image.FromStream(ms);
                //            break;
                //    }
                //}
                //else
                //{
                //}





                //    for(int i=0; i < dt.Rows.Count; i++)
                //{
                //    if(i != 4)
                //    {
                //        switch (pictureBox4.Name)
                //        {
                //            case "pictureBox4":
                //                byte[] image = (byte[])(dt.Rows[3][2]);
                //                MemoryStream ms = new MemoryStream(image);
                //                pictureBox4.Image = Image.FromStream(ms);
                //                break;
                //        }
                //    }
                //    else
                //    {
                //        MessageBox.Show("not workn");

                //    }
                //}
                //if ()
                //{
                //switch (pictureBox4.Name)
                //{
                //    case "pictureBox4":
                //        byte[] image = (byte[])(dt.Rows[3][2]);
                //        MemoryStream ms = new MemoryStream(image);
                //        pictureBox4.Image = Image.FromStream(ms);
                //        break;
                //}


                //}
                //else
                //{
                //    MessageBox.Show("yooo");
                //}


                //if (dt.Rows.Count >= 5)
                //{
                //    switch (pictureBox5.Name)
                //    {
                //        case "pictureBox5":
                //            byte[] image = (byte[])(dt.Rows[4][2]);
                //            MemoryStream ms = new MemoryStream(image);
                //            pictureBox5.Image = Image.FromStream(ms);
                //            break;
                //    }
                //}
                //if (dt.Rows.Count >= 6)
                //{
                //    switch (pictureBox6.Name)
                //    {
                //        case "pictureBox6":
                //            byte[] image = (byte[])(dt.Rows[5][2]);
                //            MemoryStream ms = new MemoryStream(image);
                //            pictureBox6.Image = Image.FromStream(ms);
                //            break;
                //    }
                //}
            }
            //}
            //catch
            //{
            //    MessageBox.Show("something's worng");
            //}
            
                    
            //}
            
            cnx.Close();
        }

        void tst_insert()
        {
            if (textBox1.Text == "twitter" || textBox1.Text == "Twitter" && pictureBox2.Name == "pictureBox2")
            {
                pictureBox2.Image = pictureBox7.Image;
                cnx.Open();
                cmd = new SqlCommand("insert into SocialMedia values(@n,@img)", cnx);
                cmd.Parameters.AddWithValue("@n", textBox1.Text);

                MemoryStream ms = new MemoryStream();
                pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                byte[] img = ms.ToArray();
                cmd.Parameters.AddWithValue("@img", img);

                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("good 1");
            }
        }

        void tst_insert3()
        {
            if (textBox1.Text == "instagram" || textBox1.Text == "Instagram" && pictureBox3.Name == "pictureBox3")
            {
                pictureBox3.Image = pictureBox7.Image;
                cnx.Open();
                cmd = new SqlCommand("insert into SocialMedia values(@n,@img)", cnx);
                cmd.Parameters.AddWithValue("@n", textBox1.Text);

                MemoryStream ms = new MemoryStream();
                pictureBox3.Image.Save(ms, pictureBox3.Image.RawFormat);
                byte[] img = ms.ToArray();
                cmd.Parameters.AddWithValue("@img", img);

                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("good 3");
            }
        }

        void tst_insert4()
        {
            if (textBox1.Text == "youtube" || textBox1.Text == "Youtube" && pictureBox4.Name == "pictureBox4")
            {
                pictureBox4.Image = pictureBox7.Image;
                cnx.Open();
                cmd = new SqlCommand("insert into SocialMedia values(@n,@img)", cnx);
                cmd.Parameters.AddWithValue("@n", textBox1.Text);

                MemoryStream ms = new MemoryStream();
                pictureBox4.Image.Save(ms, pictureBox4.Image.RawFormat);
                byte[] img = ms.ToArray();
                cmd.Parameters.AddWithValue("@img", img);

                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("good 4");
            }
        }


        void tst_insert5()
        {
            if (textBox1.Text == "linkedin" || textBox1.Text == "Linkedin" && pictureBox5.Name == "pictureBox5")
            {
                pictureBox5.Image = pictureBox7.Image;
                cnx.Open();
                cmd = new SqlCommand("insert into SocialMedia values(@n,@img)", cnx);
                cmd.Parameters.AddWithValue("@n", textBox1.Text);

                MemoryStream ms = new MemoryStream();
                pictureBox5.Image.Save(ms, pictureBox5.Image.RawFormat);
                byte[] img = ms.ToArray();
                cmd.Parameters.AddWithValue("@img", img);

                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("good 5");
            }
        }


        void tst_insert6()
        {
            if (textBox1.Text == "snapchat" || textBox1.Text == "Snapchat" && pictureBox6.Name == "pictureBox6")
            {
                pictureBox6.Image = pictureBox7.Image;
                cnx.Open();
                cmd = new SqlCommand("insert into SocialMedia values(@n,@img)", cnx);
                cmd.Parameters.AddWithValue("@n", textBox1.Text);

                MemoryStream ms = new MemoryStream();
                pictureBox6.Image.Save(ms, pictureBox6.Image.RawFormat);
                byte[] img = ms.ToArray();
                cmd.Parameters.AddWithValue("@img", img);

                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("good 6");
            }
        }


       



        private void bunifuMetroTextbox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void bunifuMetroTextbox1_Leave(object sender, EventArgs e)
        {
      
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if(o.ShowDialog()== DialogResult.OK)
            {
                pictureBox7.ImageLocation = o.FileName;
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "facebook" || textBox1.Text == "Facebook" && pictureBox1.Name == "pictureBox1")
                {
                    pictureBox1.Image = pictureBox7.Image;
                    cnx.Open();
                    cmd = new SqlCommand("insert into SocialMedia values(@n,@img)", cnx);
                    cmd.Parameters.AddWithValue("@n", textBox1.Text);

                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    cmd.Parameters.AddWithValue("@img", img);

                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    MessageBox.Show("good 1");
                }
                else if (textBox1.Text == "twitter" || textBox1.Text == "Twitter" && pictureBox2.Name == "pictureBox2")
                {
                    pictureBox2.Image = pictureBox7.Image;
                    cnx.Open();
                    SqlCommand cmd1 = new SqlCommand("insert into SocialMedia values(@n,@img)", cnx);
                    cmd1.Parameters.AddWithValue("@n", textBox1.Text);

                    MemoryStream ms = new MemoryStream();
                    pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    cmd1.Parameters.AddWithValue("@img", img);

                    cmd1.ExecuteNonQuery();
                    cnx.Close();
                    MessageBox.Show("good 2");
                }
                else if (textBox1.Text == "instagram" || textBox1.Text == "Instagram" && pictureBox3.Name == "pictureBox3")
                {
                    pictureBox3.Image = pictureBox7.Image;

                    cnx.Open();
                    SqlCommand cmd2 = new SqlCommand("insert into SocialMedia values(@n,@img)", cnx);
                    cmd2.Parameters.AddWithValue("@n", textBox1.Text);

                    MemoryStream ms = new MemoryStream();
                    pictureBox3.Image.Save(ms, pictureBox3.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    cmd2.Parameters.AddWithValue("@img", img);

                    cmd2.ExecuteNonQuery();
                    cnx.Close();
                    MessageBox.Show("good 3");
                }
                else if (textBox1.Text == "youtube" || textBox1.Text == "Youtube" && pictureBox4.Name == "pictureBox4")
                {
                    pictureBox4.Image = pictureBox7.Image;

                    cnx.Open();
                    SqlCommand cmd3 = new SqlCommand("insert into SocialMedia values(@n,@img)", cnx);
                    cmd3.Parameters.AddWithValue("@n", textBox1.Text);

                    MemoryStream ms = new MemoryStream();
                    pictureBox4.Image.Save(ms, pictureBox4.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    cmd3.Parameters.AddWithValue("@img", img);

                    cmd3.ExecuteNonQuery();
                    cnx.Close();
                    MessageBox.Show("good 4");
                }
                else if (textBox1.Text == "linkedin" || textBox1.Text == "Twitter" && pictureBox5.Name == "pictureBox5")
                {
                    pictureBox5.Image = pictureBox7.Image;

                    cnx.Open();
                    SqlCommand cmd4 = new SqlCommand("insert into SocialMedia values(@n,@img)", cnx);
                    cmd4.Parameters.AddWithValue("@n", textBox1.Text);

                    MemoryStream ms = new MemoryStream();
                    pictureBox5.Image.Save(ms, pictureBox5.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    cmd4.Parameters.AddWithValue("@img", img);

                    cmd4.ExecuteNonQuery();
                    cnx.Close();
                    MessageBox.Show("good 5");
                }
                else if (textBox1.Text == "snapchat" || textBox1.Text == "Snapchat" && pictureBox6.Name == "pictureBox6")
                {
                    pictureBox6.Image = pictureBox7.Image;

                    cnx.Open();
                    SqlCommand cmd5 = new SqlCommand("insert into SocialMedia values(@n,@img)", cnx);
                    cmd5.Parameters.AddWithValue("@n", textBox1.Text);

                    MemoryStream ms = new MemoryStream();
                    pictureBox6.Image.Save(ms, pictureBox6.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    cmd5.Parameters.AddWithValue("@img", img);

                    cmd5.ExecuteNonQuery();
                    cnx.Close();
                    MessageBox.Show("good 6");
                }
            }
            catch 
            {
                MessageBox.Show("gg");
            }
            


        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "nom du média social")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "nom du média social ";
            }
        }
    }
}
