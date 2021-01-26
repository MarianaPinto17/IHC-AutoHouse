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
    public partial class AquecimentoUserNovo : Form
    {
        public AquecimentoUserNovo()
        {
            InitializeComponent();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            CasadeBanhoUser casadebanho = new CasadeBanhoUser();
            this.Hide();
            casadebanho.Show();
        }

        //botão ligar e desligar
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Aquecimento ligado. Clique para desligar")
            {
                button3.Text = "Aquecimento desligado. Clique para ligar";
            }
            else if (button3.Text == "Aquecimento desligado. Clique para ligar")
            {
                button3.Text = "Aquecimento ligado. Clique para desligar";
            }
            PopUp popup = new PopUp();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                Console.WriteLine("You clicked OK");
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                Console.WriteLine("You clicked either Cancel or X button in the top right corner");
            }
            popup.Dispose();

        }
        //botao agendar
        private void button2_Click(object sender, EventArgs e)
        {
            PopUp popup = new PopUp();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                Console.WriteLine("You clicked OK");
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                Console.WriteLine("You clicked either Cancel or X button in the top right corner");
            }
            popup.Dispose();
        }
        //botao agendar
        private void button1_Click(object sender, EventArgs e)
        {
            PopUp popup = new PopUp();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                Console.WriteLine("You clicked OK");
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                Console.WriteLine("You clicked either Cancel or X button in the top right corner");
            }
            popup.Dispose();
        }
        //botao ligar
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Aquecimento ligado. Clique para desligar")
            {
                button4.Text = "Aquecimento desligado. Clique para ligar";
            }
            else if (button4.Text == "Aquecimento desligado. Clique para ligar")
            {
                button4.Text = "Aquecimento ligado. Clique para desligar";
            }
            PopUp popup = new PopUp();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                Console.WriteLine("You clicked OK");
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                Console.WriteLine("You clicked either Cancel or X button in the top right corner");
            }
            popup.Dispose();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
