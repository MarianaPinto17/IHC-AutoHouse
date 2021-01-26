using AutoHouse.Child.Garden;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoHouse.Child
{
    public partial class gardenChild : Form
    {
        public gardenChild()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LuzesChildGarden luz = new LuzesChildGarden();
            this.Hide();
            luz.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MainDivisoesChild divisoes = new MainDivisoesChild();
            this.Hide();
            divisoes.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LuzesChildGarden luz = new LuzesChildGarden();
            this.Hide();
            luz.Show();
        }
    }
}
