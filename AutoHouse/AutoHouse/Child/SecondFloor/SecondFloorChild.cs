using AutoHouse.Child.FirstFloor;
using AutoHouse.Child.SecondFloor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoHouse.Child
{
    public partial class SecondFloorChild : Form
    {
        public SecondFloorChild()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuartoKid room1 = new QuartoKid();
            this.Hide();
            room1.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            QuartoKid room1 = new QuartoKid();
            this.Hide();
            room1.Show();
            FormState.PreviousPage = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuartoKid room2 = new QuartoKid();
            this.Hide();
            room2.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            QuartoKid room2 = new QuartoKid();
            this.Hide();
            room2.Show();
            FormState.PreviousPage = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuartoKid room3 = new QuartoKid();
            this.Hide();
            room3.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            QuartoKid room3 = new QuartoKid();
            this.Hide();
            room3.Show();
            FormState.PreviousPage = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CasaDeBanhoKid wc = new CasaDeBanhoKid();
            this.Hide();
            wc.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CasaDeBanhoKid wc = new CasaDeBanhoKid();
            this.Hide();
            wc.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MainDivisoesChild divisoes = new MainDivisoesChild();
            this.Hide();
            divisoes.Show();
        }
    }
}
