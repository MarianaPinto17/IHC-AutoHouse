﻿using System;
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
    public partial class AquecimentoGeral : Form
    {
        public AquecimentoGeral()
        {
            InitializeComponent();
        }
        //aquecimento geral
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
        //agendar
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
        //botão para trás
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Sala sala = new Sala();
            this.Hide();
            sala.Show();
        }
    }
}
