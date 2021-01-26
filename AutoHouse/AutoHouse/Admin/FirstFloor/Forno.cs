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
    public partial class Forno : Form
    {
        public Forno()
        {
            InitializeComponent();
        }
        // botao voltar
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Cozinha cozinha = new Cozinha();
            this.Hide();
            cozinha.Show();
        }
        //forno ligado
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Forno ligado. Clique para desligar")
            {
                button3.Text = "Forno está desligado, clique para ligar";
            }
            else if (button3.Text == "Forno está desligado, clique para ligar")
            {
                button3.Text = "Forno ligado. Clique para desligar";
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
