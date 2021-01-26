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
    public partial class QuartoKid : Form
    {
        public QuartoKid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LuzKidSecond luz = new LuzKidSecond();
            this.Hide();
            luz.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LuzKidSecond luz = new LuzKidSecond();
            this.Hide();
            luz.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SecondFloorChild second = new SecondFloorChild();
            this.Hide();
            second.Show();

        }
    }
}
