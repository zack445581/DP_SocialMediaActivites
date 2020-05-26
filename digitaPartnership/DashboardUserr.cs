using digitaPartnership;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digitaPartnership
{
    public partial class DashboardUserr : Form
    {
        
        public DashboardUserr()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            panel3.Controls.Clear();
            Client c = new Client();
            c.Parent = panel3;
        }

        private void DashboardUserr_Load(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Client c = new Client();
            c.Parent = panel3;

            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            GestionActivites ga = new GestionActivites();
            ga.Parent = panel3;

            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Panel p = null;
            panel3.Controls.Clear();
            SocialMedia sm = new SocialMedia();
            sm.Parent = panel3;
           
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            //panel3.Controls.Clear();
            //Dépenses_publicitaires dp = new Dépenses_publicitaires();
            //dp.Parent = panel3;

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            printAll pa = new printAll();
            pa.Parent = panel3;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            propos pa = new propos();
            pa.Parent = panel3;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 550;
                mouseY = MousePosition.Y - 37;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
    }
}
