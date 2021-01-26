
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


    public partial class SecondFloor : Form
    {

        public SecondFloor()
        {
            InitializeComponent();
        }
        //back button
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MainDivisoes divisoes = new MainDivisoes();
            this.Hide();
            divisoes.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Quarto room1 = new Quarto();
            this.Hide();
            room1.Show();
            FormState.PreviousPage = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quarto room2 = new Quarto();
            this.Hide();
            room2.Show();
            FormState.PreviousPage = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quarto room3 = new Quarto();
            this.Hide();
            room3.Show();
            FormState.PreviousPage = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Casadebanhosegundo wc = new Casadebanhosegundo();
            this.Hide();
            wc.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Casadebanhosegundo wc = new Casadebanhosegundo();
            this.Hide();
            wc.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Quarto room3 = new Quarto();
            this.Hide();
            room3.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Quarto room2 = new Quarto();
            this.Hide();
            room2.Show();
            FormState.PreviousPage = this;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Quarto room1 = new Quarto();
            this.Hide();
            room1.Show();
            FormState.PreviousPage = this;
        }
    }
}


