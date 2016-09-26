using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo.Aula
{
    public partial class Form1 : Form
    {
        private string Mensagem;

        private int Quantidade;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Mensagem = "Mensagem";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                this.Mensagem
            );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Quantidade++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               this.Quantidade.ToString()
           );
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(chkAtivo.Checked)
            {
                MessageBox.Show("Está marcado");
            }
            else
            {
                MessageBox.Show("Não esta marcado");
            }
        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAtivo.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void chkAtivo_CheckStateChanged(object sender, EventArgs e)
        {
           
        }

        private void chkAtivo_CheckStateChanged_1(object sender, EventArgs e)
        {
            if (chkAtivo.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void rbtOpcao2_CheckedChanged(object sender, EventArgs e)
        {            
            if(rbtOpcao1.Checked)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }

        }

        private void rbtOpcao2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("entrei 2");
        }
    }
}
