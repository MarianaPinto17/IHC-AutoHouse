using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AutoHouse
{
    public partial class Sala : Form
    {
        public Sala()
        {
            InitializeComponent();
        }
        //Botao aquecimento
        private void button4_Click(object sender, EventArgs e)
        {
            AquecimentoGeral aquec = new AquecimentoGeral();
            this.Hide();
            aquec.Show();
        }
        //Luz
        private void button1_Click(object sender, EventArgs e)
        {
            Luz luz = new Luz();
            this.Hide();
            luz.Show();
        }
        //back button
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FirstFloor firstfloor = new FirstFloor();
            this.Hide();
            firstfloor.Show();
        }
        //camara de segurança botao
        private void button2_Click(object sender, EventArgs e)
        {
            CameraSala camera = new CameraSala();
            this.Hide();
            camera.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AquecimentoGeral aquec = new AquecimentoGeral();
            this.Hide();
            aquec.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Luz luz = new Luz();
            this.Hide();
            luz.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CameraSala camera = new CameraSala();
            this.Hide();
            camera.Show();
        }
    }
}
