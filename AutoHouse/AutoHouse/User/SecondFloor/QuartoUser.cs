using AutoHouse.User.SecondFloor;
using AutoHouse.User.SecondFlor;
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
    public partial class QuartoUser : Form
    {
        public QuartoUser()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SecondfloorUser SecondFloor = new SecondfloorUser();
            this.Hide();
            SecondFloor.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AquecimentoGeralQuartoUser aquecimento = new AquecimentoGeralQuartoUser();
            this.Hide();
            aquecimento.Show();
            FormState.PreviousPage = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LuzQuartoUser luz = new LuzQuartoUser();
            this.Hide();
            luz.Show();
            FormState.PreviousPage = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CamaraQuartoUser camera = new CamaraQuartoUser();
            this.Hide();
            camera.Show();
            FormState.PreviousPage = this;
        }
    }
}
