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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void pausar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void configuracao_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            config.Show();
        }

        private void relatorio_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio();
            relatorio.Show();
        }
    }
}
