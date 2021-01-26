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
    public partial class FirstFloorChild : Form
    {
        public FirstFloorChild()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MainDivisoesChild child = new MainDivisoesChild();
            this.Hide();
            child.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CasaDeBanhoKidFirst wc = new CasaDeBanhoKidFirst();
            this.Hide();
            wc.Show();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CasaDeBanhoKidFirst wc = new CasaDeBanhoKidFirst();
            this.Hide();
            wc.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SalaChild sala = new SalaChild();
            this.Hide();
            sala.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SalaChild sala = new SalaChild();
            this.Hide();
            sala.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CozinhaChild cozinha = new CozinhaChild();
            this.Hide();
            cozinha.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CozinhaChild cozinha = new CozinhaChild();
            this.Hide();
            cozinha.Show();
        }
    }
}
