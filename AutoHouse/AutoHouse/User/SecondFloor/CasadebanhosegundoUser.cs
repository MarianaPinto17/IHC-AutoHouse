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

namespace AutoHouse.User.SecondFloor
{
    public partial class CasadebanhosegundoUser : Form
    {
        public CasadebanhosegundoUser()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SecondfloorUser secondfloor = new SecondfloorUser();
            this.Hide();
            secondfloor.Show();
            FormState.PreviousPage = this;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AquecimentoCasadeBanhoUser aquecimento = new AquecimentoCasadeBanhoUser();
            this.Hide();
            aquecimento.Show();
            FormState.PreviousPage = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LuzCasadeBanhoS luz = new LuzCasadeBanhoS();
            this.Hide();
            luz.Show();
            FormState.PreviousPage = this;
        }
    }
}
