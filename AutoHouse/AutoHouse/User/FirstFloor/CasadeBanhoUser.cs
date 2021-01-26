using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoHouse.User.FirstFloor;

namespace AutoHouse
{
    public partial class CasadeBanhoUser : Form
    {
        public CasadeBanhoUser()
        {
            InitializeComponent();
        }

        //botao aquecimento
        private void button4_Click(object sender, EventArgs e)
        {
            AquecimentoUserNovo aquecimento = new AquecimentoUserNovo();
            this.Hide();
            aquecimento.Show();
            FormState.PreviousPage = this;
        }

        // botao luz
        private void button1_Click(object sender, EventArgs e)
        {
            LuzCasaDebanho1 luz = new LuzCasaDebanho1();
            this.Hide();
            luz.Show();
            FormState.PreviousPage = this;
        }

        //back button
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FirstFloorUser firstfloor = new FirstFloorUser();
            this.Hide();
            firstfloor.Show();
            FormState.PreviousPage = this;
        }

        private void Casadebanho_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LuzCasaDebanho1 luz = new LuzCasaDebanho1();
            this.Hide();
            luz.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AquecimentoUserNovo aquecimento = new AquecimentoUserNovo();
            this.Hide();
            aquecimento.Show();
            FormState.PreviousPage = this;
        }
    }
}
