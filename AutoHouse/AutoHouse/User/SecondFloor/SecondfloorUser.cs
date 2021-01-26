using AutoHouse.User.SecondFloor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoHouse.User.SecondFlor
{
    public partial class SecondfloorUser : Form
    {
        public SecondfloorUser()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MainDivisoesUser divisoes = new MainDivisoesUser();
            this.Hide();
            divisoes.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuartoUser room1 = new QuartoUser();
            this.Hide();
            room1.Show();
            FormState.PreviousPage = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuartoUser room2 = new QuartoUser();
            this.Hide();
            room2.Show();
            FormState.PreviousPage = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuartoUser room3 = new QuartoUser();
            this.Hide();
            room3.Show();
            FormState.PreviousPage = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CasadebanhosegundoUser wc = new CasadebanhosegundoUser();
            this.Hide();
            wc.Show();
            FormState.PreviousPage = this;
        }
    }
}
