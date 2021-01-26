using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoHouse.User.FirstFloor
{
    public partial class SalaUser : Form
    {
        public SalaUser()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FirstFloorUser firstfloor = new FirstFloorUser();
            this.Hide();
            firstfloor.Show();
        }

        //Botao aquecimento
        private void button4_Click_1(object sender, EventArgs e)
        {
            AquecimentoGeralUser aquec = new AquecimentoGeralUser();
            this.Hide();
            aquec.Show();
        }
        //Luz
        private void button1_Click(object sender, EventArgs e)
        {
            LuzUser luz = new LuzUser();
            this.Hide();
            luz.Show();
        }
        //camara de segurança botao
        private void button2_Click(object sender, EventArgs e)
        {
            CamaraSalaUser camera = new CamaraSalaUser();
            this.Hide();
            camera.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AquecimentoGeralUser aquec = new AquecimentoGeralUser();
            this.Hide();
            aquec.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LuzUser luz = new LuzUser();
            this.Hide();
            luz.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CamaraSalaUser camera = new CamaraSalaUser();
            this.Hide();
            camera.Show();
        }
    }
}
