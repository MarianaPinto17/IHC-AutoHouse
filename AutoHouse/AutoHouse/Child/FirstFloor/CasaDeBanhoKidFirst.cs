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
    public partial class CasaDeBanhoKidFirst : Form
    {
        public CasaDeBanhoKidFirst()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LuzWcFirstKid luz = new LuzWcFirstKid();
            this.Hide();
            luz.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LuzWcFirstKid luz = new LuzWcFirstKid();
            this.Hide();
            luz.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FirstFloorChild first = new FirstFloorChild();
            this.Hide();
            first.Show();
        }
    }
}
