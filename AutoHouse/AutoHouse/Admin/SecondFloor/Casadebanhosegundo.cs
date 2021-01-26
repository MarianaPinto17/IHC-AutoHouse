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
    public partial class Casadebanhosegundo : Form
    {
        public Casadebanhosegundo()
        {
            InitializeComponent();
        }

        //botao aquecimento
        private void button4_Click(object sender, EventArgs e)
        {
            AquecimentoUser aquecimento = new AquecimentoUser();
            this.Hide();
            aquecimento.Show();
            FormState.PreviousPage = this;
        }

        // botao luz
        private void button1_Click(object sender, EventArgs e)
        {
            LuzCasaDebanhoS luz = new LuzCasaDebanhoS();
            this.Hide();
            luz.Show();
            FormState.PreviousPage = this;
        }

        //back button
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SecondFloor secondfloor = new SecondFloor();
            this.Hide();
            secondfloor.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LuzCasaDebanhoS luz = new LuzCasaDebanhoS();
            this.Hide();
            luz.Show();
            FormState.PreviousPage = this;
        }
    }
}
