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

  
    public partial class Users : Form
    {
      
        public Users()
        {
            InitializeComponent();
        }
        //botao criança
        private void button1_Click(object sender, EventArgs e)
        {
            LoginChild loginchild = new LoginChild();

            this.Hide();
            loginchild.Show();
            FormState.PreviousPage = this;
        }
        //botao user normal
        private void button2_Click(object sender, EventArgs e)
        {
            LoginUser loginuser = new LoginUser();

            this.Hide();
            loginuser.Show();
            FormState.PreviousPage = this;
        }
      
        //botao auto admin
        private void button3_Click(object sender, EventArgs e)
        {

            LoginAdmin loginadmin = new LoginAdmin();
            this.Hide();
            loginadmin.Show();

            FormState.PreviousPage = this;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewUser user = new NewUser();
            this.Hide();
            user.Show();

            FormState.PreviousPage = this;

        }
    }
}
