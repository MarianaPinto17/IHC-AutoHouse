using AutoHouse.Child.FirstFloor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoHouse.Child.SecondFloor
{
    public partial class CasaDeBanhoKid : Form
    {
        public CasaDeBanhoKid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LuzWcKid wc = new LuzWcKid();
            this.Hide();
            wc.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LuzWcKid wc = new LuzWcKid();
            this.Hide();
            wc.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SecondFloorChild sc = new SecondFloorChild();
            this.Hide();
            sc.Show();
        }
    }
}
