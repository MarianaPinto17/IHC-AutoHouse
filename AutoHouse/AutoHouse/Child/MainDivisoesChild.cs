using AutoHouse.Child;
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
    public partial class MainDivisoesChild : Form
    {
        public MainDivisoesChild()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Users inicial = new Users();
            this.Hide();
            inicial.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FirstFloorChild child = new FirstFloorChild();
            this.Hide();
            child.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SecondFloor secondFloor = new SecondFloor();
            this.Hide();
            secondFloor.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            gardenChild garden = new gardenChild();
            this.Hide();
            garden.Show();
            FormState.PreviousPage = this;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FirstFloorChild child = new FirstFloorChild();
            this.Hide();
            child.Show();
            FormState.PreviousPage = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecondFloorChild child = new SecondFloorChild();
            this.Hide();
            child.Show();
            FormState.PreviousPage = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gardenChild garden = new gardenChild();
            this.Hide();
            garden.Show();
        }
    }
}
