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

namespace AutoHouse.Child.FirstFloor
{
    public partial class LuzKidSala : Form
    {
        public LuzKidSala()
        {
            InitializeComponent();
        }

        private void LuzKid_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SalaChild sala = new SalaChild();
            this.Hide();
            sala.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Luz ligada. Clique para desligar")
            {
                button3.Text = "Luz desligada. Clique para ligar";
            }
            else if (button3.Text == "Luz desligada. Clique para ligar")
            {
                button3.Text = "Luz ligada. Clique para desligar";
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Luz ligada. Clique para desligar")
            {
                button4.Text = "Luz desligada. Clique para ligar";
            }
            else if (button4.Text == "Luz desligada. Clique para ligar")
            {
                button4.Text = "Luz ligada. Clique para desligar";
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
        // Agendar
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
        // Agendar
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
