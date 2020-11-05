using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimerPersonal_v1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pausar_Click(object sender, EventArgs e)
        {
            if (user.Text == "master" && password.Text == "master")
            {
                this.Visible = false;
            }
            else
            {
                string message = "Usuário e/ou senha incorreto(s)";
                MessageBox.Show(message);
            }
        }
    }
}
