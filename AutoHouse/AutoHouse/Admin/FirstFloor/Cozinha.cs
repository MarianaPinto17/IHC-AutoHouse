using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoHouse
{
    public partial class Cozinha : Form
    {
        public Cozinha()
        {
            InitializeComponent();
        }
        //botão luz cozinha
        private void button1_Click(object sender, EventArgs e)
        {
            LuzCozinha luzcozinha = new LuzCozinha();
            this.Hide();
            luzcozinha.Show();
        }
        //botao aquecimento
        private void button4_Click(object sender, EventArgs e)
        {
            AquecimentoGeralCozinha aqueccozinha = new AquecimentoGeralCozinha();
            this.Hide();
            aqueccozinha.Show();
        }
        //botao fogao
        private void button2_Click(object sender, EventArgs e)
        {
            Fogao fogao = new Fogao();
            this.Hide();
            fogao.Show();
        }
        //botao forno
        private void button3_Click(object sender, EventArgs e)
        {
            Forno forno = new Forno();
            this.Hide();
            forno.Show();
        }
        //botao frigorifico
        private void button5_Click(object sender, EventArgs e)
        {
            Frigorifico frigo = new Frigorifico();
            this.Hide();
            frigo.Show();
        }
        //botao voltar
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FirstFloor firstfloor = new FirstFloor();
            this.Hide();
            firstfloor.Show();
        }
        //camera de segurança
        private void button6_Click(object sender, EventArgs e)
        {
            CameraCozinha camera = new CameraCozinha();
            this.Hide();
            camera.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AquecimentoGeralCozinha aqueccozinha = new AquecimentoGeralCozinha();
            this.Hide();
            aqueccozinha.Show();
        }
        //luz 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LuzCozinha luzcozinha = new LuzCozinha();
            this.Hide();
            luzcozinha.Show();
        }
        //fogao
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Fogao fogao = new Fogao();
            this.Hide();
            fogao.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Forno forno = new Forno();
            this.Hide();
            forno.Show();
        }
        //forno
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Frigorifico frigo = new Frigorifico();
            this.Hide();
            frigo.Show();
        }
        //camara de segurança
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CameraCozinha camera = new CameraCozinha();
            this.Hide();
            camera.Show();
        }
    }
}
