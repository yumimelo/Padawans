using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Padawans
{
    public partial class Album : Form
    {
        public Album()
        {
            InitializeComponent();
        }

        private async void Album_Load(object sender, EventArgs e)
        {
            button1.Location = new Point(0, 0);
            dataGridView1.Location = new Point(100, 100);
            dataGridView1.Size = new Size(this.Width * 70 / 100, this.Height * 70 / 100);
            dataGridView1.Rows.Add(50);
            dataGridView1.AllowUserToAddRows = false;

            var Recebe1 = RestService.For<Interface1>("https://jsonplaceholder.typicode.com/");
            int n_linha = 1;

            for (int id = 1; id < 101; id = +1)
            {
                n_linha = n_linha;
                int n_coluna = 1;

                var address = await Recebe1.MetodoA(id.ToString());
                this.dataGridView1.Rows[n_linha].Cells[n_coluna].Value = address.userId.ToString();
                n_coluna = n_coluna + 1;
                this.dataGridView1.Rows[n_linha].Cells[n_coluna].Value = address.id.ToString();
                n_coluna = n_coluna + 1;
                this.dataGridView1.Rows[n_linha].Cells[n_coluna].Value = address.title;
                n_linha = n_linha + 1;
            }
        }
    }
}
