using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoHouse.User.Garden
{
    public partial class GardenUser : Form
    {
        public GardenUser()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MainDivisoesUser main = new MainDivisoesUser();
            this.Hide();
            main.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegaUser rega = new RegaUser();
            this.Hide();
            rega.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CamarasUser camera = new CamarasUser();
            this.Hide();
            camera.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LuzJardimUser luzjardim = new LuzJardimUser();
            this.Hide();
            luzjardim.Show();
        }
    }
}
