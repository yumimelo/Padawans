using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padawans
{
    public partial class Tela_menu : Form
    {
        public Tela_menu()
        {
            InitializeComponent();
        }

        private void TODO_Click(object sender, EventArgs e)
        {
            Todo td = new Todo();
            this.Hide();
            td.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void POSTAGENS_Click(object sender, EventArgs e)
        {
            Postag post = new Postag();
            this.Hide();
            post.Show();

        }

        private void ALBUNS_Click(object sender, EventArgs e)
        {
            Album alb = new Album();
            this.Hide();
            alb.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Help hlp = new Help();
            this.Hide();
            hlp.Show();
        }

        private void Tela_menu_Load(object sender, EventArgs e)
        {
            button1.Location = new Point(0, 695);
        }
    }
}
