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
    public partial class Casadebanho : Form
    {
        public Casadebanho()
        {
            InitializeComponent();
        }

        //botao aquecimento
        private void button4_Click(object sender, EventArgs e)
        {
            Aquecimento aquecimento = new Aquecimento();
            this.Hide();
            aquecimento.Show();
            FormState.PreviousPage = this;
        }

        // botao luz
        private void button1_Click(object sender, EventArgs e)
        {
            LuzCasaDebanho luz = new LuzCasaDebanho();
            this.Hide();
            luz.Show();
            FormState.PreviousPage = this;
        }

        //back button
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FirstFloor firstfloor = new FirstFloor();
            this.Hide();
            firstfloor.Show();
            FormState.PreviousPage = this;
        }

        private void Casadebanho_Load(object sender, EventArgs e)
        {

        }
    }
}
