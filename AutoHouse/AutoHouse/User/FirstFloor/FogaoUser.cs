using System;
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
    public partial class FogaoUser : Form
    {
        public FogaoUser()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            CozinhaUser cozinha = new CozinhaUser();
            this.Hide();
            cozinha.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Fogão está ligado, clique para desligar")
            {
                button3.Text = "Fogão está desligado, clique para ligar";
            }
            else if (button3.Text == "Fogão está desligado, clique para ligar")
            {
                button3.Text = "Fogão está ligado, clique para desligar";
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
