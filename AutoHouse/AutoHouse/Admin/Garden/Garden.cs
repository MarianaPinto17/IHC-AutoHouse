using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoHouse
{
    public partial class Garden : Form
    {
        public Garden()
        {
            InitializeComponent();
        }
        //botao para trás
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }
        //botao luzes jardim
        private void button2_Click(object sender, EventArgs e)
        {
            LuzJardim luzjardim = new LuzJardim();
            this.Hide();
            luzjardim.Show();
        }
        //botao cameras
        private void button1_Click(object sender, EventArgs e)
        {
            Cameras camera = new Cameras();
            this.Hide();
            camera.Show();
        }
        //botao rega
        private void button4_Click(object sender, EventArgs e)
        {
            Rega rega = new Rega();
            this.Hide();
            rega.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Rega rega = new Rega();
            this.Hide();
            rega.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cameras camera = new Cameras();
            this.Hide();
            camera.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LuzJardim luzjardim = new LuzJardim();
            this.Hide();
            luzjardim.Show();
        }
    }
}
