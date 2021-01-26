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
    public partial class Quarto : Form
    {
        public Quarto()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AquecimentoGeralQuarto aquecimento = new AquecimentoGeralQuarto();
            this.Hide();
            aquecimento.Show();
            FormState.PreviousPage = this;
        }

        // botao luz
        private void button1_Click(object sender, EventArgs e)
        {
            LuzQuarto luz = new LuzQuarto();
            this.Hide();
            luz.Show();
            FormState.PreviousPage = this;
        }

        //back button
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SecondFloor SecondFloor = new SecondFloor();
            this.Hide();
            SecondFloor.Show();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CameraQuarto camera = new CameraQuarto();
            this.Hide();
            camera.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            LuzQuarto luz = new LuzQuarto();
            this.Hide();
            luz.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            AquecimentoGeralQuarto aquecimento = new AquecimentoGeralQuarto();
            this.Hide();
            aquecimento.Show();
            FormState.PreviousPage = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CameraQuarto camera = new CameraQuarto();
            this.Hide();
            camera.Show();
            FormState.PreviousPage = this;
        }
    }
}
