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
    public partial class Rega : Form
    {
        public Rega()
        {
            InitializeComponent();
        }
        //voltar botão
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Garden garden = new Garden();
            this.Hide();
            garden.Show();
        }
        //agendar
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Rega ligada. Clique para desligar")
            {
                button3.Text = "Rega desligada. Clique para ligar";
            }
            else if (button3.Text == "Rega desligada. Clique para ligar")
            {
                button3.Text = "Rega ligada. Clique para desligar";
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
