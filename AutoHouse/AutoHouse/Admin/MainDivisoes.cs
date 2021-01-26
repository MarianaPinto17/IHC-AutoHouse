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
    public partial class MainDivisoes : Form
    {
        public MainDivisoes()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //first floor image
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FirstFloor firstfloor = new FirstFloor();
            this.Hide();
            firstfloor.Show();
            FormState.PreviousPage = this;
        }

        //log out button 
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            this.Hide();
            users.Show();
            FormState.PreviousPage = this;
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        //second floor
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SecondFloor secondfloor = new SecondFloor();
            this.Hide();
            secondfloor.Show();
            FormState.PreviousPage = this;
        }


        //jardim
        private void button2_Click(object sender, EventArgs e)
        {
            Garden garden = new Garden();
            this.Hide();
            garden.Show();

            FormState.PreviousPage = this;
        }




        //garden
        private void pictureBox3_Click(object sender, EventArgs e)

        {
            Garden garden = new Garden();
            this.Hide();
            garden.Show();

            FormState.PreviousPage = this;


           


        }
        //first floor buttom
        private void button4_Click(object sender, EventArgs e)
        {
            FirstFloor firstfloor = new FirstFloor();
            this.Hide();
            firstfloor.Show();
            FormState.PreviousPage = this;
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            NotificationAdmin notification = new NotificationAdmin();
            this.Hide();
            notification.Show();
            FormState.PreviousPage = this;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SecondFloor secondfloor = new SecondFloor();
            this.Hide();
            secondfloor.Show();
            FormState.PreviousPage = this;
        }
    }
}
