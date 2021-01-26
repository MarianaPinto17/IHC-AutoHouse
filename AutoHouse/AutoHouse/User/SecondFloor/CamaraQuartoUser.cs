using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoHouse.User.SecondFloor
{
    public partial class CamaraQuartoUser : Form
    {
        public CamaraQuartoUser()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            QuartoUser quarto = new QuartoUser();
            this.Hide();
            quarto.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Câmera está ligada, clica para desligar")
            {
                button3.Text = "Câmera está desligada, clica para ligar";
            }
            else if (button3.Text == "Câmera está desligada, clica para ligar")
            {
                button3.Text = "Câmera está ligada, clica para desligar";
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
