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
    public partial class Cameras : Form
    {
        public Cameras()
        {
            InitializeComponent();
        }

        private void Cameras_Load(object sender, EventArgs e)
        {

        }
        //desligar e ligar camera
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Câmara ligada. Clique para desligar")
            {
                button3.Text = "Câmara desligada. Clique para ligar";
            }
            else if (button3.Text == "Câmara desligada. Clique para ligar")
            {
                button3.Text = "Câmara ligada. Clique para desligar";
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        //voltar para garden
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Garden garden = new Garden();
            this.Hide();
            garden.Show();
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
