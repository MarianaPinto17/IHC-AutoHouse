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
    public partial class LuzCasaDebanhoS : Form
    {
        public LuzCasaDebanhoS()
        {
            InitializeComponent();
        }
        //BOTAO VOLTAR
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Casadebanhosegundo casadebanho = new Casadebanhosegundo();
            this.Hide();
            casadebanho.Show();
        }
        //AGENDAR
        private void button2_Click_1(object sender, EventArgs e)
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
        //ligar e desligar luz
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
    }
}
