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
    public partial class LoginChild : Form
    {
        public LoginChild()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
      
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainDivisoesChild child = new MainDivisoesChild();
            this.Hide();
            child.Show();
            FormState.PreviousPage = this;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainDivisoesChild child = new MainDivisoesChild();
            this.Hide();
            child.Show();
            FormState.PreviousPage = this;
        }
    }
}
