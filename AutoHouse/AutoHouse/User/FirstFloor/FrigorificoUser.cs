﻿using System;
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
    public partial class FrigorificoUser : Form
    {
        public FrigorificoUser()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            CozinhaUser cozinha = new CozinhaUser();
            this.Hide();
            cozinha.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Frigorífico está ligado, clique para desligar")
            {
                button4.Text = "Frigorífico está desligado, clique para ligar";
            }
            else if (button4.Text == "Frigorífico está desligado, clique para ligar")
            {
                button4.Text = "Frigorífico está ligado, clique para desligar";
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Arca está ligada, clique para desligar")
            {
                button2.Text = "Arca está desligada, clique para ligar";
            }
            else if (button2.Text == "Arca está desligada, clique para ligar")
            {
                button2.Text = "Arca está ligada, clique para desligar";
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
