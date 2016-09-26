using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula4.ExemploTeste
{
    public partial class Form1 : Form
    {
        public string Nome;
        public int Quantidade;

        private void btnSet_Click(object sender, EventArgs e)
        {
            this.Nome = "Teste";
            chkAtivo.Checked = true;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Nome);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.Quantidade += 1;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Quantidade.ToString());
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            if(chkAtivo.Checked)
            {
                MessageBox.Show("Ativo");
            }
            else
            {
                MessageBox.Show("Inativo");
            }
        }

        private void btnTestarSexo_Click(object sender, EventArgs e)
        {
            if(rbtMasculino.Checked)
            {
                MessageBox.Show("Masculino");
            }
            else
            {
                MessageBox.Show("Feminino");
            }
        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
