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
    public partial class AquecimentoGeralUser : Form
    {
        public AquecimentoGeralUser()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SalaUser sala = new SalaUser();
            this.Hide();
            sala.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Aquecimento está ligado, clica para desligar")
            {
                button4.Text = "Aquecimento está desligado, clica para ligar";
            }
            else if (button4.Text == "Aquecimento está desligado, clica para ligar")
            {
                button4.Text = "Aquecimento luz está ligada, clica para desligar";
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
    }
}
