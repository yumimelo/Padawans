using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Padawans
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela_menu volt = new Tela_menu();
            this.Hide();
            volt.Show();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            button1.Location = new Point(0, 0);
        }
    }
}
