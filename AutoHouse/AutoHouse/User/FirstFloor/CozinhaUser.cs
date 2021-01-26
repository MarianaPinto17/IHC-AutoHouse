using AutoHouse.User.FirstFloor;
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
    public partial class CozinhaUser : Form
    {
        public CozinhaUser()
        {
            InitializeComponent();
        }
        //botão luz cozinha
        private void button1_Click(object sender, EventArgs e)
        {
            LuzCozinhaUser luzcozinha = new LuzCozinhaUser();
            this.Hide();
            luzcozinha.Show();
        }
        //botao aquecimento
        private void button4_Click(object sender, EventArgs e)
        {
            AquecimentoGeralCozinhaUser aqueccozinha = new AquecimentoGeralCozinhaUser();
            this.Hide();
            aqueccozinha.Show();
        }
        //botao fogao
        private void button2_Click(object sender, EventArgs e)
        {
            FogaoUser fogao = new FogaoUser();
            this.Hide();
            fogao.Show();
        }
        //botao forno
        private void button3_Click(object sender, EventArgs e)
        {
            FornoUser forno = new FornoUser();
            this.Hide();
            forno.Show();
        }
        //botao frigorifico
        private void button5_Click(object sender, EventArgs e)
        {
            FrigorificoUser frigo = new FrigorificoUser();
            this.Hide();
            frigo.Show();
        }
        //botao voltar
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FirstFloorUser firstfloor = new FirstFloorUser();
            this.Hide();
            firstfloor.Show();
        }
        //camera de segurança
        private void button6_Click(object sender, EventArgs e)
        {
            CamaraCozinhaUser camera = new CamaraCozinhaUser();
            this.Hide();
            camera.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AquecimentoGeralCozinhaUser aqueccozinha = new AquecimentoGeralCozinhaUser();
            this.Hide();
            aqueccozinha.Show();
        }
        //luz 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LuzCozinhaUser luzcozinha = new LuzCozinhaUser();
            this.Hide();
            luzcozinha.Show();
        }
        //fogao
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FogaoUser fogao = new FogaoUser();
            this.Hide();
            fogao.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FornoUser forno = new FornoUser();
            this.Hide();
            forno.Show();
        }
        //forno
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrigorificoUser frigo = new FrigorificoUser();
            this.Hide();
            frigo.Show();
        }
        //camara de segurança
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CamaraCozinhaUser camera = new CamaraCozinhaUser();
            this.Hide();
            camera.Show();
        }
    }
}
