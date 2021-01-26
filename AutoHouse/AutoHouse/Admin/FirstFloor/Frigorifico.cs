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
    public partial class Frigorifico : Form
    {
        public Frigorifico()
        {
            InitializeComponent();
        }
        // botao voltar
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Cozinha cozinha = new Cozinha();
            this.Hide();
            cozinha.Show();
        }
        //agendar 1
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
        //botao ligar e desligar frigorifico
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Frigorífico ligado. Clique para desligar")
            {
                button4.Text = "Frigorífico desligado. Clique para ligar";
            }
            else if (button4.Text == "Frigorífico desligado. Clique para ligar")
            {
                button4.Text = "Frigorífico ligado. Clique para desligar";
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
        //agendar
        private void button3_Click(object sender, EventArgs e)
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
        // botao ligar arca
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Arca ligada. Clique para desligar")
            {
                button2.Text = "Arca desligada. Clique para ligar";
            }
            else if (button2.Text == "Arca desligada. Clique para ligar")
            {
                button2.Text = "Arca ligada. Clique para desligar";
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
    }
 }
