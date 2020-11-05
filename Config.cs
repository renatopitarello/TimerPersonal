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
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
