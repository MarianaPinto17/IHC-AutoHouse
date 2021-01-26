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
    public partial class SalaChild : Form
    {
        public SalaChild()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LuzKidSala luz = new LuzKidSala();
            this.Hide();
            luz.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LuzKidSala luz = new LuzKidSala();
            this.Hide();
            luz.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FirstFloorChild first = new FirstFloorChild();
            this.Hide();
            first.Show();
        }
    }
}
