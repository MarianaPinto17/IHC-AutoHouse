using AutoHouse.User.Garden;
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
    public partial class MainDivisoesUser : Form
    {
        public MainDivisoesUser()
        {
            InitializeComponent();
        }
        //botao log out
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            this.Hide();
            users.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FirstFloorUser firstFloor = new FirstFloorUser();
            this.Hide();
            firstFloor.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SecondfloorUser secondFloor = new SecondfloorUser();
            this.Hide();
            secondFloor.Show();
            FormState.PreviousPage = this;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GardenUser garden = new GardenUser();
            this.Hide();
            garden.Show();
            FormState.PreviousPage = this;
        }
        //botao primeiro andar
        private void button4_Click(object sender, EventArgs e)
        {
            FirstFloorUser ff = new FirstFloorUser();
            this.Hide();
            ff.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecondfloorUser secondFloor = new SecondfloorUser();
            this.Hide();
            secondFloor.Show();
            FormState.PreviousPage = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GardenUser garden = new GardenUser();
            this.Hide();
            garden.Show();
            FormState.PreviousPage = this;
        }
    }
}
